using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petManagement.Models
{
    public interface IPetRepository
    {
        void Add(petModel petmodel);
        void Edit(petModel petModel);
        void Delete(int id);
        IEnumerable<petModel> GetAll();
        IEnumerable<petModel> GetByValue();
    }
}
