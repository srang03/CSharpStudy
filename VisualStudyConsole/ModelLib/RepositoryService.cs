using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ModelLib
{
    internal class RepositoryService : IRepository
    {
        private string _path;
        private static List<Model> _models = new List<Model>();
        public RepositoryService()
        {
            _path = @"C:\Users\Ian\Desktop\ian\C#\CSharpStudy\Todos.json";
            var json = File.ReadAllText(_path);
            _models = JsonConvert.DeserializeObject<List<Model>>(json); // JSON > C#
        }

        public bool AddMemo(Model m)
        {
            try
            {
                m.Id = _models.Max(x => x.Id) + 1;
                m.created = DateTime.Now;
                _models.Add(m);

                string json = JsonConvert.SerializeObject(_models, Formatting.Indented); // C# > JSON
                File.WriteAllText(_path, json);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
          
        }

        public bool DeleteMemo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Model> ListModel()
        {
            throw new NotImplementedException();
        }

        public bool ModifyMemo(Model m)
        {
            throw new NotImplementedException();
        }

        public Model ViewModel(int id)
        {
            var models = File.ReadAllText(_path);
            throw new NotImplementedException();
        }
    }
}
