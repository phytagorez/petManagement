using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using petManagement.Models;

namespace petManagement._Repository
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        public void Add(petModel petmodel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(petModel petModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<petModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<petModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
