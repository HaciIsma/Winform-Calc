using org.mariuszgromada.math.mxparser;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string statement = default;
        public Form1()
        {
            InitializeComponent();
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            //numbers and "."
            switch (label.Text)
            {
                case "0":
                    statement += "0";
                    break;
                case "1":
                    statement += "1";
                    break;
                case "2":
                    statement += "2";
                    break;
                case "3":
                    statement += "3";
                    break;
                case "4":
                    statement += "4";
                    break;
                case "5":
                    statement += "5";
                    break;
                case "6":
                    statement += "6";
                    break;
                case "7":
                    statement += "7";
                    break;
                case "8":
                    statement += "8";
                    break;
                case "9":
                    statement += "9";
                    break;
                case ".":
                    statement += ".";
                    break;
            }
            //arithmetic operators
            switch (label.Text)
            {
                case "÷":
                    statement += "/";
                    break;
                case "x":
                    statement += "x";
                    break;
                case "+":
                    statement += "+";
                    break;
                case "-":
                    statement += "-";
                    break;
                case "(":
                    statement += "(";
                    break;
                case ")":
                    statement += ")";
                    break;
                case "=":
                    statement = new Expression(statement).calculate().ToString();
                    break;
            }
            //Calc operation
            switch (label.Text)
            {
                case "C":
                    statement = default;
                    break;
                case "<":
                    statement = statement.Substring(0, statement.Length - 1);
                    break;
            }
            label21.Text = statement;
            if (label21.Text == "NaN")
            {
                statement = default;
            }
        }
    }
}
