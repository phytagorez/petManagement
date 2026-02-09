using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petManagement.Views
{
    public interface IPetView
    {
        //Properties - Fields
        string PetId { get; set; }
        string PetName { get; set; }
        string PetType { get; set; }
        string PetColour { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        bool Delete { get; set; }

        //Event
        event EventHandler SearchEvent;
        event EventHandler AddNewItem;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPetListBindingSource(BindingSource petList);
        void Show();
    }
}
