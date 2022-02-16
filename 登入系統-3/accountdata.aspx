<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="accountdata.aspx.cs" Inherits="accountdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="White" HorizontalAlign="Center" Height="539px">
                <asp:Button ID="新增按鈕" runat="server" Font-Size="Medium" OnClick="Button1_Click" Text="新增" />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="修改按鈕" runat="server" Font-Size="Medium" OnClick="修改按鈕_Click" Text="修改" />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="刪除按鈕" runat="server" Font-Size="Medium" OnClick="刪除按鈕_Click" Text="刪除" />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="查詢按鈕" runat="server" Font-Size="Medium" OnClick="查詢按鈕_Click" Text="查詢" />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="匯出按鈕" runat="server" Font-Size="Medium" OnClick="匯出按鈕_Click" Text="匯出" style="height: 26px" />
                &nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <asp:GridView ID="GridView2" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" HorizontalAlign="Center" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"  ItemStyle-HorizontalAlign="Center" Height="101px" OnPageIndexChanged="GridView2_PageIndexChanged" AllowPaging="True" EmptyDataText="0" Width="293px" OnRowDeleted="GridView2_RowDeleted" OnRowDeleting="GridView2_RowDeleting" DataKeyNames ="id" OnRowCommand="GridView2_RowCommand" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" EnableEventValidation="false" OnRowUpdating="GridView2_RowUpdating" AutoGenerateColumns="False">
                    <Columns>
                        
                        <asp:ButtonField CommandName="Select" Text="選取" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:ButtonField>
                        <asp:TemplateField HeaderText="刪除" ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除"></asp:LinkButton>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                </asp:RadioButtonList>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ProductId" HeaderText="項目" InsertVisible="False" ReadOnly="True" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" HorizontalAlign="Right" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" HorizontalAlign="Right" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" HorizontalAlign="Right" />
                    <PagerSettings Mode="Numeric" PageButtonCount="4" />
                </asp:GridView>
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="新增Panel1" runat="server" BackColor="#FFCC99" Height="280px" HorizontalAlign="Center" Visible="False">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="新增資料"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="性別:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label6" runat="server" Text="姓名:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Text="地址:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" runat="server" Text="手機:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label35" runat="server" Text="生日:"></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server" type="date"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label34" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label16" runat="server" ForeColor="Red" Text="資料尚未輸入完成，請重新輸入!" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="確定" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Height="21px" OnClick="Button2_Click" Text="清空" />
            </asp:Panel>
            <asp:Panel ID="修改Panel1" runat="server" BackColor="#FFCC99" Height="314px" HorizontalAlign="Center" Visible="False">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large" Text="修改資料"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label17" runat="server" Text="欲修改ID:"></asp:Label>
                &nbsp;<asp:Label ID="Label37" runat="server"></asp:Label>
                <br />&nbsp;&nbsp;<asp:Label ID="Label18" runat="server" Text="性別:"></asp:Label>
                <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label19" runat="server" Text="姓名:"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label20" runat="server" Text="地址:"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label21" runat="server" Text="手機:"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label36" runat="server" Text="生日:"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server" type="date"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label33" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label26" runat="server" ForeColor="Red" Text="資料尚未輸入完成，請重新輸入!" Visible="False"></asp:Label>
                <br />
                <br />
                <br />
                &nbsp;<asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="確定" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="清空" />
            </asp:Panel>
            <asp:Panel ID="刪除Panel1" runat="server" BackColor="#FFCC99" Height="188px" HorizontalAlign="Center" Visible="False">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="刪除資料"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label27" runat="server" Text="欲刪除ID:"></asp:Label>
                &nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label32" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label29" runat="server" ForeColor="Red" Text="資料尚未輸入完成，請重新輸入!" Visible="False"></asp:Label>
                <br />
                <br />
                &nbsp;<asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="確定" style="height: 21px" />
                &nbsp;&nbsp;
                <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="清空" />
            </asp:Panel>
            <asp:Panel ID="查詢Panel1" runat="server" BackColor="#FFCC99" Height="188px" HorizontalAlign="Center" Visible="False">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="查詢資料"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label28" runat="server" Text="欲查詢ID:"></asp:Label>
                &nbsp;<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label31" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label30" runat="server" ForeColor="Red" Text="資料尚未輸入完成，請重新輸入!" Visible="False"></asp:Label>
                <br />
                <br />
                &nbsp;
                <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="確定" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" style="height: 21px" Text="清空" />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
