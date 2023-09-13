using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierQueue
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }
        public string getters { get; set; }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            lblNowServing.Text = getters;
        }
    }
}
