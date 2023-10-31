using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleaningBusiness
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ben\\Desktop\\Hoefs_Assignment3\\CleaningBusiness.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshResults()
        {
            string query = "SELECT * FROM Business";
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, conn);


            //set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);

            //set DataGridView control to read-only
            resultGridView.ReadOnly = true;

            //set the DataGridView control's data source/data table
            resultGridView.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                refreshResults();
            } 
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompanySearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * From Business WHERE CompanyName LIKE '%" + txtCompanyName.Text + "%'";
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, conn);


            //set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);

            //set DataGridView control to read-only
            resultGridView.ReadOnly = true;

            //set the DataGridView control's data source/data table
            resultGridView.DataSource = ds.Tables[0];
        }

        private void btnSpecializationSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * From Business WHERE CompanyName LIKE '%" + txtSpecialization.Text + "%'";
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, conn);


            //set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);

            //set DataGridView control to read-only
            resultGridView.ReadOnly = true;

            //set the DataGridView control's data source/data table
            resultGridView.DataSource = ds.Tables[0];

        }

        private void btnHighestRate_Click(object sender, EventArgs e)
        {
            string query = "SELECT HourlyRate FROM Business ORDER BY HourlyRate DESC";
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, conn);


            //set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);

            MessageBox.Show(ds.Tables[0].Rows[0]["HourlyRate"].ToString());
        }

        private void btnLowestRate_Click(object sender, EventArgs e)
        {
            string query = "SELECT HourlyRate FROM Business ORDER BY HourlyRate ASC";
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, conn);


            //set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);

            MessageBox.Show(ds.Tables[0].Rows[0]["HourlyRate"].ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form2 editForm = new Form2();
            editForm.ShowDialog();
            refreshResults();
        }
    }
}
