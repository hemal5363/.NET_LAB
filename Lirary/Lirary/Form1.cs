using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lirary
{
    public partial class Form1 : Form
    {
        int id;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader Reader;

        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paras vasoya\Desktop\library_management.mdb");
            con.Open();
            cmd = new OleDbCommand();
            cmd.Connection = con;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void issued_books_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox1.Text);
            cmd.CommandText = "Select * from issued_record where s_id="+id;
            Reader=cmd.ExecuteReader();
            issued_books.Text = null;
            while (Reader.Read())
            {
                issued_books.Text += Reader[1].ToString()+"\n";
                
            }
            Reader.Close();
            cmd.CommandText = "SELECT * FROM book WHERE count > 0";
            Reader=cmd.ExecuteReader();
            book_name.Text = null;
            publisher.Text = null;
            book_id.Text = null;
            
            while (Reader.Read())
            {
                book_id.Text += Reader[0].ToString()+"\n";
                book_name.Text += Reader[1].ToString() + "\n";
                publisher.Text += Reader[2].ToString() + "\n";
            }
            Reader.Close();
          //  con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_id_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox1.Text);
            int bid = Convert.ToInt32(textBox2.Text);
            cmd.CommandText = "Insert into issued_record values(id,bid) select s_id,b_id from issued_record join book where book.count>0 ";
            //Reader=cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
        }
    }
}
