using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibilityOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int not1 = Convert.ToInt32(textBoxNot1.Text);
            int not2 = Convert.ToInt32(textBoxNot2.Text);
            NotCalculater notCalculater = new NotCalculater();
            double result = notCalculater.Calculate(not1, not2);
            string message;
            if (not2 < 50 || result < 50)
            {
                message = "final notu 50'den küçük, kaldınız";
            }
            else
            {
                message = "Geçtiniz!";
            }

            MessageBox.Show(message);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NotCalculater notCalculater = new NotCalculater();
            int not1 = Convert.ToInt32(textBoxNot1.Text);
            int not2 = Convert.ToInt32(textBoxNot2.Text);

            double ortalama = notCalculater.Calculate(not1, not2);
            string durum = ortalama > 50 ? "Geçti" : "Kaldı";
            SaveNote saveNote = new SaveNote();
            int efectedRowCount = saveNote.Save(not1, not2, ortalama, durum);

            string message = efectedRowCount > 0 ? "Kayıt eklendi." : "Ekleme Başarısız!";
            MessageBox.Show(message);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormNotlar notlarForm = new FormNotlar();
            notlarForm.Show();
        }
    }
}
