using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoRental
{
    public partial class AutoSelection : System.Web.UI.Page
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ben\\Desktop\\Hoefs_Assignment3\\AutoRental\\App_Data\\AutoRental.mdf;Integrated Security=True;Connect Timeout=30";
        protected void Page_Load(object sender, EventArgs e)
        {
            ModelsDataContext db = new ModelsDataContext(conn);
            var listItemsRecord = (from x in db.Models select new { ModelName = x.ModelName, CargoSpace = x.CargoSpace }).ToList();
            modelView.DataSource = listItemsRecord;
            modelView.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int autoTypeID = int.Parse(autoTypeList.SelectedValue);

            ModelsDataContext db = new ModelsDataContext(conn);
            var models = (from x in db.Models where(x.AutoTypeID == autoTypeID) select
                                   new { ModelName = x.ModelName, CargoSpace = x.CargoSpace }).ToList();
            modelView.DataSource = models;
            modelView.DataBind();
        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            int autoTypeID = int.Parse(autoTypeList.SelectedValue);
            AutoTypesDataContext db = new AutoTypesDataContext(conn);
            var autoType = (from x in db.AutoTypes where (x.AutoTypeID == autoTypeID) select x).First();

            decimal dailyRate = autoType.DailyRate;

            if(chkInsurance.Checked)
            {
                dailyRate += 10;
            }

            double discount;
            if(rdoDiscount.SelectedValue == "Best Rate")
            {
                discount = 1;
            }
            else if (rdoDiscount.SelectedValue == "Govt. Employee")
            {
                discount = 0.85;
            }
            else if (rdoDiscount.SelectedValue == "Business")
            {
                discount = 0.9;
            }
            else if (rdoDiscount.SelectedValue == "Favorite")
            {
                discount = 0.8;
            }
            else
            {
                throw new Exception();
            }

            dailyRate *= (decimal)discount;
            decimal totalCost = dailyRate * int.Parse(txtDays.Text);

            // Display the results of the calculation
            lblRate.Text = "Standard rate: " + autoType.DailyRate.ToString("c");
            lblDiscount.Text = "Discount: " + (dailyRate - dailyRate * (decimal)discount).ToString("c");
            lblInsurance.Text = "Insurance: " + (chkInsurance.Checked ? "$10.00" : "$0.00");
            lblDailyCost.Text = "Cost per day: " + dailyRate.ToString("c");
            lblTotalCost.Text = "Total cost: " + totalCost.ToString("c");

        }
    }
}