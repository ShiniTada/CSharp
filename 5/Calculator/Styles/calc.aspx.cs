using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calcolatrice.Styles
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void setTextValue(string number)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = number;
            }
            else
            {
                TextBox1.Text += number;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            setTextValue("1");
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            setTextValue("2");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            setTextValue("3");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            setTextValue("4");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            setTextValue("5");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            setTextValue("6");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            setTextValue("7");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            setTextValue("8");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            setTextValue("9");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            setTextValue("0");
        }
        //+
        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["session"] = Session["session"] == null ? TextBox1.Text : calculate();
            Session["operation"] = "+";
            TextBox1.Text = "";
        }
        //-
        protected void Button8_Click(object sender, EventArgs e)
        {
            Session["session"] = Session["session"] == null ? TextBox1.Text : calculate();
            Session["operation"] = "-";
            TextBox1.Text = "";
        }
        //X
        protected void Button12_Click(object sender, EventArgs e)
        {
            Session["session"] = Session["session"] == null ? TextBox1.Text : calculate();
            Session["operation"] = "x";
            TextBox1.Text = "";
        }
        //:
        protected void Button16_Click(object sender, EventArgs e)
        {
            Session["session"] = Session["session"] == null ? TextBox1.Text : calculate();
            Session["operation"] = ":";
            TextBox1.Text = "";
        }
        //=
        protected void Button15_Click(object sender, EventArgs e)
        {
            TextBox1.Text = calculate();
            Session["session"] = TextBox1.Text;
        }

        private string calculate()
        {
            switch (Session["operation"].ToString())
            {
                case "+":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["session"].ToString();
                        return (Convert.ToInt32(a) + Convert.ToInt32(b)).ToString();
                    }
                case "-":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["session"].ToString();
                        return (Convert.ToInt32(b) - Convert.ToInt32(a)).ToString();
                    }
                case "x":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["session"].ToString();
                        return (Convert.ToInt32(a) * Convert.ToInt32(b)).ToString();
                    }
                case ":":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["session"].ToString();
                        return (Convert.ToInt32(b) / Convert.ToInt32(a)).ToString();
                    }
            }
            return "0";
        }
        //ce
        protected void Button13_Click(object sender, EventArgs e)
        {
            Session.Clear();
            TextBox1.Text = "0";
        }
    }
}