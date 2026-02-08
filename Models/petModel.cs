using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace petManagement.Models
{
    public class petModel
    {
        //Fields
        private int id;
        private string name;
        private string type;
        private string colour;

        //Propertiers - Validations
        [DisplayName("ID Pet")]
        public int Id
        { 
            get => id; set => id = value; 
        }
        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string Name 
        {
            get => name; set => name = value; 
        }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet Type is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Type must be between 3 and 50 characters")]
        public string Type 
        { 
            get => type; set => type = value; 
        }
        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Pet Colour is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet colour must be between 3 and 50 characters")]
        public string Colour 
        {
            get => colour; set => colour = value; 
        }
    }
}
