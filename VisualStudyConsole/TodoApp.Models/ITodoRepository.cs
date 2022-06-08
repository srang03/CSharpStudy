using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        /// <summary>
        /// todo 객체를 매개변수로 받아서 할일을 입력합니다.
        /// </summary>
        /// <param name="todo"></param>
        void Add(Todo todo);

        /// <summary>
        /// todo 객체를 매개변수로 받아서 할일을 수정합니다.
        /// </summary>
        /// <param name="todo"></param>
        bool Update(Todo todo);

        /// <summary>
        /// todo 데이터의 모든 내용을 출력합니다.
        /// </summary>
        /// <returns></returns>
        List<Todo> GetAll();
        
        /// <summary>
        /// ID 값을 매개변수로 받아서 해당 할일을 삭제 후 결과값을 논리형으로 반환합니다.
        /// </summary>
        /// <param name="id"></param>
        bool Delete(int id);

        /// <summary>
        /// ID 값을 매개 변수로 받아서 해당 할일을 출력합니다.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Todo GetTodo(int id);

    }
}
