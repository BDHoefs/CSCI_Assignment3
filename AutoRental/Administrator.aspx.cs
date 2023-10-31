using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoRental
{
    public partial class Administrator : System.Web.UI.Page
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ben\\Desktop\\Hoefs_Assignment3\\AutoRental\\App_Data\\AutoRental.mdf;Integrated Security=True;Connect Timeout=30";
        protected void Page_Load(object sender, EventArgs e)
        {
            ModelsDataContext db = new ModelsDataContext(conn);
            var listItemsRecord = (from x in db.Models select x).ToList();
            modelView.DataSource = listItemsRecord;
            modelView.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string modelName = txtName.Text;
            int autoTypeId = int.Parse(txtAutoType.Text);
            int cargoSpace = int.Parse(txtCargoSpace.Text);

            ModelsDataContext db = new ModelsDataContext(conn);
            Model model = new Model();
            model.ModelName = modelName;
            model.AutoTypeID = autoTypeId;
            model.CargoSpace = cargoSpace;
            db.Models.InsertOnSubmit(model);
            db.SubmitChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (modelView.SelectedRow.DataItem == null)
            {
                return;
            }
            Model model = (Model)modelView.SelectedRow.DataItem;
            ModelsDataContext db = new ModelsDataContext(conn);

            db.Models.DeleteOnSubmit(model);
            db.SubmitChanges();
        }
    }
}