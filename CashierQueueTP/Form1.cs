using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierQueue
{
    public partial class Form1 : Form
    {
        CashierClass cashier = new CashierClass();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lb_Queue.Text = cashier.CashierGeneratedNumber("P - "); 
            CashierClass.getNumberInQueue = lb_Queue.Text; 
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            CashierWindowQueue cashierWindow = new CashierWindowQueue(); 
            cashierWindow.ShowDialog(); 
        }
    }
}
