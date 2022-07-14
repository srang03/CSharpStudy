using Microsoft.AspNetCore.Mvc;
using ModelMemo;

namespace ModelMemoNetworksWebApi
{
    
    [Route("api/[Controller]")]
    // Route Attribute (ModelMemo 접두사 사용하고 Controller 이름 접미사 제거)
    public class ModelMemoController: ControllerBase
    {

        private IRepositoryService _repository;
        public ModelMemoController()
        {
             _repository = new RepositoryServiceJson();

        }
        // Http 서비스를 통해서 데이터를 출력해서 전달하고 싶다.
        [HttpGet]
        public IActionResult GetAll()
        {
            // return Content("안녕하세요")
            return Ok(_repository.ListModel());
        }

        // Http 서비스를 통해서 전달되는 것을 받고 싶다.
        // Body에 담아서 보내기 위한 Post 방식
        [HttpPost]
        public IActionResult Add([FromBody]Model model)
        {
            _repository.AddMemo(model);
            return Ok(model);
        }
    }
}
