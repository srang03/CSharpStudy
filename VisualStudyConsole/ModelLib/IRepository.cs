using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    internal interface IRepository
    {
        // 추가
        bool AddMemo(Model m);

        // 삭제
        bool DeleteMemo(int id);

        // 수정
        bool ModifyMemo(Model m);

        // 브라우징
        Model ViewModel(int id);

        // 리스트
        List<Model> ListModel();
    }
}
