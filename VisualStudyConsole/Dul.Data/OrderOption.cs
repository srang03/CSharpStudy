using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dul.Data
{
    /// <summary>
    /// SortOrder 열거형 : 행의 데이터 정렬 방법을 지정
    /// </summary>
    public enum OrderOption
    {
        /// <summary>
        /// 오름차순
        /// </summary>
        Ascending,

        /// <summary>
        /// 내림차순
        /// </summary>
        Descending,

        /// <summary>
        /// 기본값
        /// </summary>
        None

    }
}
