using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Lecture_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iU_VP_Script_DBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.iU_VP_Script_DBDataSet.Students);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string conectionstring = "Data Source=.;Initial Catalog=IU_VP_Script_DB;Integrated Security=True";
            // Let's Creat a conection to the database
            SqlConnection connection = new SqlConnection(conectionstring);

            string commandstirng = $"Insert into Students(StudentName) Values('{txtName.Text}')";

            SqlCommand coomand = new SqlCommand(commandstirng, connection);

            // To Run the Command on sql server from your application
            connection.Open();
            coomand.ExecuteNonQuery();
            connection.Close();
            refreshDataGridView();
            txtName.Text = "";
            MessageBox.Show("تمت العملية بنجاح");


        }
        private void refreshDataGridView()
        {
            string conectionstring = "Data Source=.;Initial Catalog=IU_VP_Script_DB;Integrated Security=True";
            // Let's Creat a conection to the database
            SqlConnection connection = new SqlConnection(conectionstring);

            string commandstirng = $"Select *from Students";

            SqlCommand coomand = new SqlCommand(commandstirng, connection);

            SqlDataAdapter da = new SqlDataAdapter(coomand);

            DataTable dt=new DataTable();
            da.Fill(dt);
            dgtStudents.DataSource = dt;    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conectionstring = "Data Source=.;Initial Catalog=IU_VP_Script_DB;Integrated Security=True";
            // Let's Creat a conection to the database
            SqlConnection connection = new SqlConnection(conectionstring);

            string commandstirng = $"Update Students Set StudentName ='{txtName.Text}' where StudentID ='{txtID.Text}')";

            SqlCommand coomand = new SqlCommand(commandstirng, connection);

            // To Run the Command on sql server from your application
            connection.Open();
            coomand.ExecuteNonQuery();
            connection.Close();
            refreshDataGridView();
            txtName.Text = "";
            MessageBox.Show("تمت التعديل بنجاح");
        }

        private void dgtStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgtStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgtStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
