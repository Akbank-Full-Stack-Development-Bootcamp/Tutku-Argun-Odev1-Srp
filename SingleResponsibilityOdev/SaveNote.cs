using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityOdev
{
    class SaveNote
    {
        public int Save(int not1, int not2, double ortalama, string durum)
        {
            var connectionText = "Data Source=.\\SQLEXPRESS05;Initial Catalog=School;Integrated Security=True";
            var commandText = "INSERT into Notlar(vize, final, ortalama,durum) values (@not1 , @not2, @ortalama , @durum)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@not1", not1);
            parameters.Add("@not2", not2);
            parameters.Add("@ortalama", ortalama);
            parameters.Add("@durum", durum);


            DBBusiness dBBusiness = new DBBusiness(connectionText);
            int efectedrowcount = dBBusiness.Execute(commandText, parameters);
            return efectedrowcount;


        }
    }
}
