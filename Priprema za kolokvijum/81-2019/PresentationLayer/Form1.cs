using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private PrescriptionBusiness prescriptionBusiness = new PrescriptionBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            listBoxInsertDescription.Items.Clear();
            List<Prescription> prescriptionList = this.prescriptionBusiness.GetPrescriptions();

            foreach(Prescription p in prescriptionList)
            {
                listBoxInsertDescription.Items.Add(p.PatientName + " - " + p.PrescribedMedication + " - " + p.PrescriptionPrice);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription p = new Prescription();
            p.PatientName = textBoxName.Text;
            p.PrescribedMedication = textBoxPrescribedMedication.Text;
            p.PrescriptionDate = dateTimePickerPrescriptionDate.Value;
            p.PrescriptionPrice = Convert.ToDecimal(textBoxPrescriptionPrice.Text);


            this.prescriptionBusiness.InsertPrescription(p);
            RefreshData();
        }

       
    }
}
