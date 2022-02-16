using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class accountdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //DataSet ds = new DataSet();

        //SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        //conn.Open();
        ////SqlDataAdapter da = new SqlDataAdapter("Select * From Test",conn);
        //SqlCommand cmd = new SqlCommand("Select * From Test", conn);
        //SqlDataReader dr = cmd.ExecuteReader();

        //DataTable dt = new DataTable(); //使用DataTable來儲存資料
        //dt.Load(dr);
        //GridView2.DataSource = dt;
        ////GridView2.Columns.Add();
        //GridView2.DataBind();
        //conn.Close();
        //conn.Dispose();
        //cmd.Dispose();

        SqlConnection conn = new SqlConnection("Data Source=10.8.28.239;Initial Catalog=SnManage;Persist Security Info=True;User ID=VRMA;Password=vrma2016");
        conn.Open();
        SqlCommand cmd = new SqlCommand("Select * From SnManage.dbo.CheckingCategory", conn);
        SqlDataReader dr = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(dr);
        GridView2.DataSource = dt;
        GridView2.DataBind();
        conn.Close();
        conn.Dispose();
        cmd.Dispose();
    }

    protected void Button1_Click(object sender, EventArgs e)//新增BUTTON
    {
        修改Panel1.Visible = false;
        新增Panel1.Visible = true;
        刪除Panel1.Visible = false;
        查詢Panel1.Visible = false;
        DropDownList1.Items.Clear();
        DropDownList1.Items.Add("男");
        DropDownList1.Items.Add("女");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";

        Label16.Visible = false;
        Label33.Text = "";
        Label26.Visible = false;
    }

    protected void 修改按鈕_Click(object sender, EventArgs e)//修改BUTTON
    {
        修改Panel1.Visible = true;
        新增Panel1.Visible = false;
        刪除Panel1.Visible = false;
        查詢Panel1.Visible = false;
        //TextBox4.Text = "";
        DropDownList5.Items.Clear();
        DropDownList5.Items.Add("男");
        DropDownList5.Items.Add("女");
        Label26.Visible = false;
        Label33.Text = "";
        //TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
    }

    protected void 刪除按鈕_Click(object sender, EventArgs e)
    {
        修改Panel1.Visible = false;
        新增Panel1.Visible = false;
        刪除Panel1.Visible = true;
        查詢Panel1.Visible = false;
        TextBox8.Text = "";
        Label29.Visible = false;
        Label32.Text = "";
    }

    protected void 查詢按鈕_Click(object sender, EventArgs e)
    {
        修改Panel1.Visible = false;
        新增Panel1.Visible = false;
        刪除Panel1.Visible = false;
        查詢Panel1.Visible = true;
        TextBox9.Text = "";
        Label30.Visible = false;
        Label31.Text = "";
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void Button2_Click(object sender, EventArgs e)//新增資料Panel清空Button
    {
        DropDownList1.Items.Clear();
        DropDownList1.Items.Add("男");
        DropDownList1.Items.Add("女");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";

        Label16.Visible = false;
        Label33.Text = "";
        Label26.Visible = false;
        Label34.Text = "";
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void Button1_Click1(object sender, EventArgs e)//新增資料Panel送出Button
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
        {
            Label16.Visible = true;
            Label34.Text = "";
        }
        else
        {
            string gender2 = DropDownList1.SelectedItem.ToString();
            string name2 = TextBox1.Text;
            string address2 = TextBox2.Text;
            string phone2 = TextBox3.Text;
            string birthday2 = TextBox10.Text;
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            conn.Open();
            string sql = "INSERT INTO Test(gender, name, address, phone, birthday)" + "Values(@genders,@names,@addresss,@phones,@birthdays)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@genders", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@names", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@addresss", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@phones", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@birthdays", SqlDbType.NVarChar, 10);
            cmd.Parameters["@genders"].Value = gender2;
            cmd.Parameters["@names"].Value = name2;
            cmd.Parameters["@addresss"].Value = address2;
            cmd.Parameters["@phones"].Value = phone2;
            cmd.Parameters["@birthdays"].Value = birthday2;
            cmd.ExecuteNonQuery();
            Label34.Text = "新增完成!";
        }
    }

    protected void 匯出按鈕_Click(object sender, EventArgs e)
    {
        /*Response.Clear();
        Response.AddHeader("content-disposition", "attachment;filename=outputexcel.xls");
        Response.Charset = "BIG5";
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("BIG5");
        Response.ContentType = "application/vnd.xls";
        StringWriter StringWriter = new System.IO.StringWriter();
        HtmlTextWriter HtmlTextWriter = new HtmlTextWriter(StringWriter);
        GridView2.RenderControl(HtmlTextWriter);
        Response.Write(StringWriter.ToString());
        Response.End();*/

        IWorkbook wb = new XSSFWorkbook();
        ISheet ws;

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        conn.Open();
        //SqlDataAdapter da = new SqlDataAdapter("Select * From Test",conn);
        SqlCommand cmd = new SqlCommand("Select * From Test", conn);
        SqlDataReader dr = cmd.ExecuteReader();

        DataTable dt = new DataTable(); //使用DataTable來儲存資料
        dt.Load(dr);

        if (dt.TableName != string.Empty)
        {
            ws = wb.CreateSheet(dt.TableName);
        }
        else
        {
            ws = wb.CreateSheet("Sheet1");
        }

        ws.CreateRow(0);//第一行為欄位名稱
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            ws.GetRow(0).CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
        }

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ws.CreateRow(i + 1);
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                ws.GetRow(i + 1).CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
            }
        }

        FileStream file = new FileStream(@"C:\Users\Antony.Tsai\Desktop\test.xls", FileMode.Create);//產生檔案
        wb.Write(file);
        file.Close();
    }

    protected void Button9_Click(object sender, EventArgs e)//修改panel清空button
    {
        //TextBox4.Text = "";
        DropDownList5.Items.Clear();
        DropDownList5.Items.Add("男");
        DropDownList5.Items.Add("女");
        Label26.Visible = false;
        Label33.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        string id2 = Label37.Text;
        string gender2 = DropDownList5.SelectedItem.ToString();
        string name2 = TextBox5.Text;
        string address2 = TextBox6.Text;
        string phone2 = TextBox7.Text;
        string birthday2 = TextBox11.Text;
        if (Label37.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "")
        {
            Label26.Visible = true;
            Label33.Text = "";
        }
        else
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Test Set gender = @genders,name = @names,address = @addresss,phone = @phones,birthday = @birthdays Where id = @ids", conn);
            cmd.Parameters.Add("@genders", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@names", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@addresss", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@phones", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@birthdays", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@ids", SqlDbType.NVarChar, 10).Value = id2;
            cmd.Parameters["@genders"].Value = gender2;
            cmd.Parameters["@names"].Value = name2;
            cmd.Parameters["@addresss"].Value = address2;
            cmd.Parameters["@phones"].Value = phone2;
            cmd.Parameters["@birthdays"].Value = birthday2;
            int correct = cmd.ExecuteNonQuery();
            if (correct != 0)
            {
                Label33.Text = "已完成更新";
            }
            else
            {
                Label33.Text = "查無此人，無法更新資料!";
            }
        }
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        TextBox8.Text = "";
        Label29.Visible = false;
        Label32.Text = "";
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        TextBox9.Text = "";
        Label30.Visible = false;
        Label31.Text = "";
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Label29.Visible = false;
        string id2 = TextBox8.Text;
        if (TextBox8.Text == "")
        {
            Label29.Visible = true;
            Label32.Text = "";
        }
        else
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete From Test Where  id=@ids", conn);
            cmd.Parameters.Add("@ids", SqlDbType.NVarChar, 10).Value = id2;
            int correct = cmd.ExecuteNonQuery();
            if (correct!=0)
            {
                Label32.Text = "已完成刪除";
            }
            else
            {
                Label32.Text = "無此ID，無法刪除";
            }
        }
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        Label30.Visible = false;
        string id2 = TextBox9.Text;
        if (TextBox9.Text == "")
        {
            Label30.Visible = true;
            Label31.Text = "";
        }
        else
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Test Where id ="+id2, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label31.Text = "性別:"+ dr["gender"].ToString() + "\n姓名:" + dr["name"].ToString()+"\n地址:"+dr["address"].ToString() + "\n手機:"+ dr["phone"].ToString()+"\n生日:"+dr["birthday"].ToString();
            }
            else
            {
                Label31.Text = "查無此人!";
            }
        }
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void GridView2_PageIndexChanged(object sender, EventArgs e)
    {
    }

    protected void GridView2_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        /*GridViewRow row = GridView2.Rows[e.];
        SqlCommand cmd = new SqlCommand("Delete From Test (userName,age,birthPLace)");
        GridView2.DataBind();*/
    }

    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridView2.DataKeys[e.RowIndex].Value.ToString();//取得點擊這列的id

        //string get = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionStrings的name"].ConnectionString;
        SqlConnection Connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

        SqlCommand command = new SqlCommand($"DELETE  FROM Test WHERE   (id = {id}) ", Connection);
        Connection.Open();
        command.ExecuteNonQuery();
        Connection.Close();
        GridView2.DataBind();
    }

    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int a = Convert.ToInt32(e.CommandArgument);
            string id = GridView2.DataKeys[a].Value.ToString();
            Label37.Text = id;
            string name = GridView2.Rows[a].Cells[4].Text;
            TextBox5.Text = name;
            string address = GridView2.Rows[a].Cells[5].Text;
            TextBox6.Text = address;
            string phone = GridView2.Rows[a].Cells[6].Text;
            TextBox7.Text = phone;
            string birthday = GridView2.Rows[a].Cells[7].Text;
            TextBox8.Text = birthday;
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
    }

    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView2.EditIndex = -1;
        GridView2.DataBind();
    }

    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView2.EditIndex = e.NewEditIndex;
        GridView2.DataBind();
    }

    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id2 = GridView2.DataKeys[e.RowIndex].Values[2].ToString();
        string gender2 = ((TextBox)GridView2.Rows[e.RowIndex].FindControl("out1")).Text;
        string name2 = ((TextBox)GridView2.Rows[e.RowIndex].FindControl("out2")).Text;
        string address2 = ((TextBox)GridView2.Rows[e.RowIndex].FindControl("out3")).Text;
        string phone2 = ((TextBox)GridView2.Rows[e.RowIndex].FindControl("out4")).Text;
        string birthday2 = ((TextBox)GridView2.Rows[e.RowIndex].FindControl("out5")).Text;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("Update Test Set gender = @genders,name = @names,address = @addresss,phone = @phones,birthday = @birthdays Where id = @ids", conn);
        cmd.Parameters.Add("@genders", SqlDbType.NVarChar, 10);
        cmd.Parameters.Add("@names", SqlDbType.NVarChar, 10);
        cmd.Parameters.Add("@addresss", SqlDbType.NVarChar, 10);
        cmd.Parameters.Add("@phones", SqlDbType.NVarChar, 10);
        cmd.Parameters.Add("@birthdays", SqlDbType.NVarChar, 10);
        cmd.Parameters.Add("@ids", SqlDbType.NVarChar, 10).Value = id2;
        cmd.Parameters["@genders"].Value = gender2;
        cmd.Parameters["@names"].Value = name2;
        cmd.Parameters["@addresss"].Value = address2;
        cmd.Parameters["@phones"].Value = phone2;
        cmd.Parameters["@birthdays"].Value = birthday2;
        cmd.ExecuteNonQuery();
        GridView2.EditIndex = -1;
        GridView2.DataBind();
    }

    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {
        //string id = GridView2.DataKeys[e.RowIndex].Value.ToString();//取得點擊這列的id
    }

    protected void Button16_Click1(object sender, EventArgs e)
    {
    }

    protected void Button16_Click2(object sender, EventArgs e)
    {
        //Dim TemplateField As TemplateField = new TemplateField()
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        GridView2.Rows[2].Cells.Clear();
    }
}