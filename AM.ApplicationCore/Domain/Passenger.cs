using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        [EmailAddress(ErrorMessage = "L'adresse e-mail n'est pas valide.")]
        public string EmailAddress { get; set; }
        [Required]
        public FullName FullName { get; set; }
        [Required(ErrorMessage = "Le nom de famille est obligatoire.")]
        
        [Key]
        public string PassportNumber { get; set; }
        [RegularExpression("^[0-9]{8}$")]
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get; set; }
        public virtual string PassengerType { get { return "Unknown passenger type"; } }
        
        public override string ToString()
        {
            return $"PassportNumber : {PassportNumber}, FirstName : {FullName.FirstName}, LastName : {FullName.LastName}";
        }
    }
}

