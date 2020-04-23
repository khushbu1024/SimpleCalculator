using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calC
{
    public partial class formSimpleCalc : Form
    {
        public formSimpleCalc()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != String.Empty && txtNum2.Text != String.Empty)
            {
                if (IsNumeric(txtNum1.Text) && IsNumeric(txtNum2.Text))
                {
                    ServiceReference1.calCWebServiceSoapClient client = new ServiceReference1.calCWebServiceSoapClient();
                    txtAns.Text = client.add(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Plz, Enter Both the number First !!");
                }
            }
            else
            {
                MessageBox.Show("Plz, Enter Both the number First !!");
            }




        }

        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != String.Empty && txtNum2.Text != String.Empty)
            {
                if (IsNumeric(txtNum1.Text) && IsNumeric(txtNum2.Text))
                {
                    ServiceReference1.calCWebServiceSoapClient client = new ServiceReference1.calCWebServiceSoapClient();
                    txtAns.Text = client.sub(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Plz, Enter the number only !!");
                }
            }
            else
            {
                MessageBox.Show("Plz, Enter Both the number First !!");
            }

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != String.Empty && txtNum2.Text != String.Empty)
            {
                if (IsNumeric(txtNum1.Text) && IsNumeric(txtNum2.Text))
                {
                    ServiceReference1.calCWebServiceSoapClient client = new ServiceReference1.calCWebServiceSoapClient();
                    txtAns.Text = client.mul(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Plz, Enter the number only !!");
                }
            }
            else
            {
                MessageBox.Show("Plz, Enter Both the number First !!");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != String.Empty && txtNum2.Text != String.Empty)
            {
                if (txtNum2.Text == "0")
                {
                    MessageBox.Show("div By Zero can not be possible!!! Enter another value. ");
                }
                else
                {
                    if (IsNumeric(txtNum1.Text) && IsNumeric(txtNum2.Text))
                    {
                        ServiceReference1.calCWebServiceSoapClient client = new ServiceReference1.calCWebServiceSoapClient();
                        txtAns.Text = client.div(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Plz, Enter the number only !!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Plz, Enter Both the number First !!");
            }
        }
    }
}
