
namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrescribedMedication = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerPrescriptionDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxInsertDescription = new System.Windows.Forms.ListBox();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrescriptionPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lek";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(336, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPrescribedMedication
            // 
            this.textBoxPrescribedMedication.Location = new System.Drawing.Point(336, 79);
            this.textBoxPrescribedMedication.Name = "textBoxPrescribedMedication";
            this.textBoxPrescribedMedication.Size = new System.Drawing.Size(211, 22);
            this.textBoxPrescribedMedication.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum";
            // 
            // dateTimePickerPrescriptionDate
            // 
            this.dateTimePickerPrescriptionDate.Location = new System.Drawing.Point(336, 130);
            this.dateTimePickerPrescriptionDate.Name = "dateTimePickerPrescriptionDate";
            this.dateTimePickerPrescriptionDate.Size = new System.Drawing.Size(211, 22);
            this.dateTimePickerPrescriptionDate.TabIndex = 5;
            // 
            // listBoxInsertDescription
            // 
            this.listBoxInsertDescription.FormattingEnabled = true;
            this.listBoxInsertDescription.ItemHeight = 16;
            this.listBoxInsertDescription.Location = new System.Drawing.Point(29, 262);
            this.listBoxInsertDescription.Name = "listBoxInsertDescription";
            this.listBoxInsertDescription.Size = new System.Drawing.Size(752, 148);
            this.listBoxInsertDescription.TabIndex = 6;
            
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(622, 196);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(109, 41);
            this.ButtonInsert.TabIndex = 7;
            this.ButtonInsert.Text = "Unesi";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena";
            // 
            // textBoxPrescriptionPrice
            // 
            this.textBoxPrescriptionPrice.Location = new System.Drawing.Point(336, 177);
            this.textBoxPrescriptionPrice.Name = "textBoxPrescriptionPrice";
            this.textBoxPrescriptionPrice.Size = new System.Drawing.Size(211, 22);
            this.textBoxPrescriptionPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrescriptionPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.listBoxInsertDescription);
            this.Controls.Add(this.dateTimePickerPrescriptionDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrescribedMedication);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Recepti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrescribedMedication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxInsertDescription;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrescriptionPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerPrescriptionDate;
    }
}

