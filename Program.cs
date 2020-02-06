using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ConsoleApplication8
{
    class Program
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader Reader = new OleDbDataReader();
        Program()
        {
            con = new OleDbConnection();
            con.Open();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            //Insert 
            cmd.CommandText = " SELECT * FROM student";
            cmd.ExecuteReader();
            while (Reader.Read())
            {
                Console.WriteLine(Reader("sname"));
            }

            //display all the books
            cmd.CommandText = "SELECT * FROM book WHERE count > 0";
            cmd.ExecuteReader();
            while (Reader.Read())
            {
                txt = Reader();
            }

            //search
            string string_search = Console.ReadLine();
            cmd.CommandText = "SELECT * FROM book WHERE title like 'string_search' ";
            cmd.ExecuteReader();
            while (Reader.Read())
            {
                txt = Reader();
            }
            //Update
            
            cmd.CommandText = "	Insert into issued_record values(s_id, b_id) select s_id, b_id from issued_record join book where book.count > 0; ";
            cmd.ExecuteReader();
            cmd.CommandText = " Update book set count = count - 1 where b_id =” ”";
            cmd.ExecuteReader();
            while (Reader.Read())
            {
                txt = Reader();
            }
            con.Close();

        }
        static void Main(string[] args)
        {
        }
    }
}
