using Dul.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepositoryPattern
{
    public interface ICategoryRepository: IBreadShop<Category>
    {
        void Log(string message);
    }
}
