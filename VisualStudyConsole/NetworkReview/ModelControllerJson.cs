using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace NetworkReview
{
    public class ModelControllerJson
    {
        public List<Model> _repository = new List<Model>();
        string path = @"C:\Users\Ian\Desktop\ian\C#\CSharpStudy\VisualStudyConsole\NetworkReview\todo.json";
        public ModelControllerJson()
        {
            var json = File.ReadAllText(path);
            _repository = JsonConvert.DeserializeObject<List<Model>>(json);
        }

        public List<Model> GetAllList()
        {
            var json = File.ReadAllText(path);
            _repository = JsonConvert.DeserializeObject<List<Model>>(json);
            return _repository;
        }
        public bool Add(Model model)
        {
            try
            {
                _repository.Add(model);
                var json = JsonConvert.SerializeObject(_repository, Formatting.Indented);
                File.WriteAllText(path, json);
                return true;
            }
            catch
            {
                return false;
            }
     
        }
    }
}
