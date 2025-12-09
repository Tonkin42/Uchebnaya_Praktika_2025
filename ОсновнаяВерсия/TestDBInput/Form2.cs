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

namespace TestDBInput
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BookName, BookAuthor;
            BookName = textBox1.Text;
            BookAuthor = textBox2.Text;
            int ID = Convert.ToInt32(textBox3.Text);

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\KINGSTON\\АнализИМоделированиеПО\\ОсновнаяВерсия\\TestDBInput\\TestDataBase.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO Table1 VALUES (" + ID + ", '" + BookName + "','" + BookAuthor + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса", "Внимание!");
            else
                MessageBox.Show("Данные добавлены", "Внимание!");
            dbConnection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

