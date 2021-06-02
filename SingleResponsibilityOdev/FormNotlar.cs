using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibilityOdev
{
    public partial class FormNotlar : Form
    {
        public FormNotlar()
        {
            InitializeComponent();
        }

        private void FormNotlar_Load(object sender, EventArgs e)
        {
            ShowNotes();
        }

        private void ShowNotes()
        {
            var connectionText = "Data Source=.\\SQLEXPRESS05;Initial Catalog=School;Integrated Security=True";
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Notlar", connectionText);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void buttonCreateTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog(); //Dosya kaydetme komutu
            sf.Filter = "txt dosyası|0.txt";
            sf.FileName = "Notlar Text Dosyası"; //dosya adı belirlendi
            FileStream fs = new FileStream(sf.FileName, FileMode.OpenOrCreate, FileAccess.Write);

            if (sf.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int vize = int.Parse(dataGridView1.Rows[i].Cells["vize"].Value.ToString());
                    int final = int.Parse(dataGridView1.Rows[i].Cells["final"].Value.ToString());
                    double ortalama = double.Parse(dataGridView1.Rows[i].Cells["ortalama"].Value.ToString());
                    string durum = dataGridView1.Rows[i].Cells["durum"].Value.ToString();
                    string icerik = "vize notu : " + vize + " final notu : " + final + " ortalaması : " + ortalama + " durumu : " + durum;

                    File.AppendAllText(sf.FileName, icerik + "\n"); //oluşturulan dosyanın içerisine içerikle birlikte yazdırıldı

                }
            }
        }
    }
}
