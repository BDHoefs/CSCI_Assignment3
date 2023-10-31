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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CleaningBusiness
{
    public partial class Form2 : Form
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ben\\Desktop\\Hoefs_Assignment3\\CleaningBusiness.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            try {
                conn = new SqlConnection(connString);
                refreshResults();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            string specialization = txtSpecialization.Text;
            string companyAddress = txtAddress.Text;
            string city = txtCity.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            decimal hourlyRate = decimal.Parse(txtRate.Text);

            conn.Open();
            string command = "INSERT INTO Business(CompanyName, Specialization, CompanyAddress, City, Email, Phone, HourlyRate)"
                + " VALUES('" + companyName + "','" + specialization + "','" + companyAddress + "','" + city + "','" + email + "','" + phone + "','" + hourlyRate +"')";

            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshResults();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            string specialization = txtSpecialization.Text;
            string companyAddress = txtAddress.Text;
            string city = txtCity.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            decimal hourlyRate = decimal.Parse(txtRate.Text);

            int companyId = int.Parse(txtId.Text);

            conn.Open();
            string command = "UPDATE Business SET " +
                "CompanyName='" + companyName + "'," +
                "Specialization='" + specialization + "'," +
                "CompanyAddress='" + companyAddress + "'," +
                "City='" + city + "'," +
                "Email='" + email + "'," +
                "Phone='" + phone + "'," +
                "HourlyRate='" + hourlyRate +
                "' WHERE CompanyID='" + companyId + "'";

            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshResults();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int companyId = int.Parse(txtId.Text);

            conn.Open();
            string command = "DELETE FROM Business WHERE CompanyId='" + companyId + "'";

            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshResults();
        }
    }
}
