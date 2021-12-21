using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BusinessLayer
{
    public class PrescriptionBusiness
    {
        public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();

        public List<Prescription> GetPrescriptions()
        {
            return prescriptionRepository.GetAllPrescriptions().Where(prescription => DateTime.Now < prescription.PrescriptionDate).ToList();
        }

        public bool InsertPrescription (Prescription prescription)
        {
            return prescriptionRepository.InsertPrescription(prescription) != 0;
        }
    }
}
