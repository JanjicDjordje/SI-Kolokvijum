using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Prescription
    {
        public int Id { get; set; }
       
        public string PatientName { get; set; }
        
        public string PrescribedMedication { get; set; }
       
        public DateTime PrescriptionDate { get; set; }

        public decimal PrescriptionPrice { get; set; }
    }
}
