﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierQueue
{
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e) 
        { 
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private void btnRefresh_Click(object sender, EventArgs e) 
        { 
            DisplayCashierQueue(CashierClass.CashierQueue); 
        }
        public void DisplayCashierQueue(IEnumerable CashierList) 
        { 
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            { 
                listCashierQueue.Items.Add(obj.ToString()); 
            } 
        }
        public delegate void PassControl(object sender);
        public PassControl passControl;
    }
}
