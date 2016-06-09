using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clane.DAL;
using System.Data.SQLite;

namespace Clane.BL
{
    class News
    {
        public struct strc_news
        {
            public string Href { get; set; }
            public int Page { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public bool Classified { get; set; }
        }

        public strc_news GetNewRow()
        {
            return new strc_news { Href = "", Page = 0, Title = "", Date = DateTime.Now, Classified = false };
        }

        public bool Insert(strc_news newRow)
        {
            try
            {
                DataAccessLayer DAL = new DataAccessLayer();
                SQLiteCommand scom = new SQLiteCommand("Insert into News values (@Href,@Page,@Title,@Date,@Classified)");
                scom.Parameters.AddWithValue("Href", newRow.Href);
                scom.Parameters.AddWithValue("Page", newRow.Page);
                scom.Parameters.AddWithValue("Title", newRow.Title);
                scom.Parameters.AddWithValue("Date", newRow.Date);
                scom.Parameters.AddWithValue("Classified", newRow.Classified);

                return DAL.GeneralCommand(scom);
            }
            catch
            {
                return false;
            }

        }


        public DataTable GetDataTable()
        {
            try
            {
                DataAccessLayer DAL = new DataAccessLayer();
                SQLiteCommand scom = new SQLiteCommand("select * from News");
                return DAL.GeneralSelect(scom);
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDataTable(strc_news newRow)
        {
            try
            {
                DataAccessLayer DAL = new DataAccessLayer();
                SQLiteCommand scom = new SQLiteCommand("select * from News where Href=@Href");
                scom.Parameters.AddWithValue("Href", newRow.Href);
                return DAL.GeneralSelect(scom);
            }
            catch
            {
                return null;
            }
        }
    }
}
