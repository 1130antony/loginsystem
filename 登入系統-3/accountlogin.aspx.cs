using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class accountlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void 送出ID_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "a" && TextBox2.Text == "b")
        {
            Server.Transfer("accountdata.aspx");
        }
        else
        {
            Label1.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }

    protected void 清空按鈕_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        Label1.Visible = false;
    }
}