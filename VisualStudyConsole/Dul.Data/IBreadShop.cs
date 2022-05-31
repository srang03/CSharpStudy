using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dul.Data
{
    /// <summary>
    /// 제너릭 인터페이스 : 공통 CRUD 코드 => BREAD Shop Pattern
    /// </summary>
    public interface IBreadShop<T> where T : class 
    {
        /// <summary>
        /// 상세
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Browse(int id);

        /// <summary>
        /// 출력
        /// </summary>
        /// <returns></returns>
        List<T> Read();

        /// <summary>
        /// 수정
        /// </summary>
        /// <returns></returns>
        bool Edit(T model);

        /// <summary>
        /// 입력
        /// </summary>
        /// <returns></returns>
        T Add(T model);

        /// <summary>
        ///  삭제
        /// </summary>
        /// <returns></returns>
        bool Delete(int id);

        /// <summary>
        /// 검색
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        List<T> Search(string query);

        /// <summary>
        /// 건수
        /// </summary>
        /// <returns></returns>
        int Has();

        /// <summary>
        ///  정렬
        /// </summary>
        /// <param name="orderOption"></param>
        /// <returns></returns>
        List<T> Ordering(OrderOption orderOption);

        /// <summary>
        /// 페이지
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<T> Paging(int page, int pageSize);
    }
}
