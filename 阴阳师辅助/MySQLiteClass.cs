using System.Data;
using System.Data.SQLite;

namespace 阴阳师辅助
{
    class MySQLiteClass
    {
        public static SQLiteConnection sqlitecon;

        static string str1 = System.Windows.Forms.Application.StartupPath+"\\YYS_db";
        public static SQLiteConnection Getsqlitecon()
        {
            string str_sqlitecon = @"Data Source = "+str1; //根据自己的设置
            SQLiteConnection sqlitecon = new SQLiteConnection(str_sqlitecon);
            sqlitecon.Open();
            return sqlitecon;
        }

        public static void Getmysqlcom(string M_str_sqlstr)
        {
            sqlitecon = Getsqlitecon();
            SQLiteCommand sqlitecom = new SQLiteCommand(M_str_sqlstr, sqlitecon);
            sqlitecom.ExecuteNonQuery();
            sqlitecom.Dispose();
            sqlitecon.Close();
            sqlitecon.Dispose();
        }

        public static SQLiteDataReader Getmysqlread(string sqlstr)
        {
            sqlitecon = Getsqlitecon();
            SQLiteCommand sqlitecom = new SQLiteCommand(sqlstr,sqlitecon);
            SQLiteDataReader sqliteread = sqlitecom.ExecuteReader();
            //sqliteread.Read();
            //sqlitecon.Close();
            //sqlitecon.Dispose();
            return sqliteread;
        }

        public static DataSet Getsqliteset(string sqlstr, string tableName)
        {
            sqlitecon = Getsqlitecon();
            SQLiteDataAdapter sqlitedata = new SQLiteDataAdapter(sqlstr, sqlitecon);
            DataSet sqlitedataset = new DataSet();
            sqlitedata.Fill(sqlitedataset, tableName);
            sqlitecon.Close();
            sqlitecon.Dispose();
            return sqlitedataset;
        }
    }
}
