using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Creates a new instance of clsStaff
        clsStaff staff = new clsStaff();
        //Capture the Data
        staff.StaffID = Convert.ToInt32(txtStaffID.Text);
        staff.Name = txtName.Text;
        staff.Password = txtPassword.Text;
        staff.Role = txtRole.Text;
        staff.DateOfBirth = Convert.ToDateTime(txtDOB.Text);
        staff.Salary = Convert.ToInt32(txtSalary.Text);
        staff.Permission = Convert.ToBoolean(chkPermission.Checked);
        Session["Staff"] = staff;
        //Navigate to the Viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}