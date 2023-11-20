using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _14112023_WebForm
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string metin = TextBox1.Text;
            if (string.IsNullOrEmpty(metin))
            {
                Label1.Text = "Metin Alanı Boş Bırakılamaz";
                Label1.ForeColor = Color.Red;
            }
            else
            {
                Label1.Text = metin;
                TextBox1.Text = string.Empty;
                Label1.ForeColor= Color.Green;
            }
        }

        protected void btnCheckbox_Click(object sender, EventArgs e)
        {
            List<string> list=new List<string>();
            if(CheckBox1.Checked) { list.Add(CheckBox1.Text); }
            if (CheckBox2.Checked) { list.Add(CheckBox2.Text); }
            if (CheckBox3.Checked) { list.Add (CheckBox3.Text); }
            if(CheckBox4.Checked) { list.Add(CheckBox4.Text);}
            string secilenler = string.Empty;
            if (list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    secilenler += (i == 0 ? "" : ",") + list[i];
                }
                lblCheckbox.Text = "Seçilen Değer : "+secilenler;
                lblCheckbox.ForeColor = Color.Green;

            }
            else
            {
                lblCheckbox.Text = "Hiçbir Değer Seçmediniz";
                lblCheckbox.ForeColor = Color.Red;
            }
        }
    }
}