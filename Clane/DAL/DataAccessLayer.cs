using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Clane.DAL
{
    public class DataAccessLayer
    {
        private SQLiteConnection sc;
        private SQLiteCommand scom;
        public DataAccessLayer(string connection= "Data Source=Clane.sqlite;Version=3;")
        {
            sc = new SQLiteConnection(connection);
        }
        public DataTable  GeneralSelect(SQLiteCommand scom)
        {
            SQLiteDataAdapter sda = new SQLiteDataAdapter(scom.CommandText,sc);
            DataTable dat = new DataTable();
            sda.Fill(dat);
            return dat;
        }

        public bool GeneralCommand(SQLiteCommand _scom)
        {
            try
            {
                scom.Connection = sc;
                scom.CommandText = _scom.CommandText;
                sc.Open();
                scom.ExecuteNonQuery();
                sc.Close();
                return true;
            }
            catch
            { return false; }
        }


    }
}
