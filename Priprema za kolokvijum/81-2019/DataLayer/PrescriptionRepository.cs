using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PrescriptionRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PharmacyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Prescription> GetAllPrescriptions()
        {
            List<Prescription> prescriptionList = new List<Prescription>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Prescriptions";

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Prescription prescription = new Prescription();
                    prescription.Id = dataReader.GetInt32(0);
                    prescription.PatientName = dataReader.GetString(1);
                    prescription.PrescribedMedication = dataReader.GetString(2);
                    prescription.PrescriptionDate = dataReader.GetDateTime(3);
                    prescription.PrescriptionPrice = dataReader.GetDecimal (4);

                    prescriptionList.Add(prescription);
                }
            }

            return prescriptionList;
        }

        public int InsertPrescription(Prescription prescription)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Prescriptions VALUES('{0}','{1}','{2}','{3}')",
                    prescription.PatientName, prescription.PrescribedMedication, prescription.PrescriptionDate, prescription.PrescriptionPrice);

                sqlConnection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
