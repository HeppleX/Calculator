using System;
using System.Threading;

public partial class calculator : System.Web.UI.Page
{
    static string num1 = "0", num2 = "0", total = "", sign = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        if (sign.Length == 1)
        {
            Count();
            num1 = TextBox1.Text;
            sign = "-";
        }
        else
        {
            num1 = TextBox1.Text;
            TextBox1.Text = "";
            total = "";
            sign = "-";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        total += "1";
        TextBox1.Text = total;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        total += "2";
        TextBox1.Text = total;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        total += "3";
        TextBox1.Text = total;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        total += "4";
        TextBox1.Text = total;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        total += "5";
        TextBox1.Text = total;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        total += "6";
        TextBox1.Text = total;
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        total += "7";
        TextBox1.Text = total;
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        total += "8";
        TextBox1.Text = total;
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        total += "9";
        TextBox1.Text = total;
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        total += "0";
        TextBox1.Text = total;
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        if(sign.Length==1)
        {
            Count();
            num1 = TextBox1.Text;
            sign = "+";
        }
        else
        {
            num1 = TextBox1.Text;
            TextBox1.Text = "";
            total = "";
            sign = "+";
        }
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        if (sign.Length == 1)
        {
            Count();
            num1 = TextBox1.Text;
            sign = "*";
        }
        else
        {
            num1 = TextBox1.Text;
            TextBox1.Text = "";
            total = "";
            sign = "*";
        }
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        if (sign.Length == 1)
        {
            Count();
            num1 = TextBox1.Text;
            sign = "/";
        }
        else
        {
            num1 = TextBox1.Text;
            TextBox1.Text = "";
            total = "";
            sign = "/";
        }
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        Count();
    }

    protected void Count()
    {
        num2 = TextBox1.Text;
        if(num2=="")
        {
            num2 = "0";
        }
        switch(sign)
        {
            case "+":
                TextBox1.Text = (double.Parse(num1) + double.Parse(num2)).ToString();
                num1 = "0";
                num2 = "0";
                total = "";
                sign = "";
                break;
            case "-":
                TextBox1.Text = (double.Parse(num1) - double.Parse(num2)).ToString();
                num1 = "0";
                num2 = "0";
                total = "";
                sign = "";
                break;
            case "*":
                TextBox1.Text = (double.Parse(num1) * double.Parse(num2)).ToString();
                num1 = "0";
                num2 = "0";
                total = "";
                sign = "";
                break;
            case "/":
                TextBox1.Text = (double.Parse(num1) / double.Parse(num2)).ToString();
                num1 = "0";
                num2 = "0";
                total = "";
                sign = "";
                break;
        }
    }
}