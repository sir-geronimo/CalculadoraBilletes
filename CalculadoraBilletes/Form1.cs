using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBilletes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void CalculateBills(object sender, EventArgs e)
        {
            int bills = 0;
            const int TWOTHOUSAND = 2000;
            const int ONETHOUSAND = 1000;
            const int FIVEHUNDRED = 500;
            const int TWOHUNDRED = 200;
            const int ONEHUNDRED = 100;
            int.TryParse(BillsInput.Text, out bills);

            int _twoThousandBills = 0;
            int _oneThousandBills = 0;
            int _fiveHundredBills = 0;
            int _twoHundredBills = 0;
            int _oneHundredBills = 0;

            _twoThousandBills = bills / TWOTHOUSAND;
            bills = bills - (_twoThousandBills * TWOTHOUSAND);
            Bills2000.Text = _twoThousandBills.ToString();

            _oneThousandBills = bills / ONETHOUSAND;
            bills = bills - (_oneThousandBills * ONETHOUSAND);
            Bills1000.Text = _oneThousandBills.ToString();

            _fiveHundredBills = bills / FIVEHUNDRED;
            bills = bills - (_fiveHundredBills * FIVEHUNDRED);
            Bills500.Text = _fiveHundredBills.ToString();

            _twoHundredBills = bills / TWOHUNDRED;
            bills = bills - (_twoHundredBills * TWOHUNDRED);
            Bills200.Text = _twoHundredBills.ToString();
            
            _oneHundredBills = bills / ONEHUNDRED;
            bills = bills - (_oneHundredBills * ONEHUNDRED);
            Bills100.Text = _oneHundredBills.ToString();
        }
    }
}