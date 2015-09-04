using commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestRequest req = new TestRequest();
            TestResponse resp = req.GET_OneTest("O211ec703-71db-4c32-b61a-77fc1bbf1705", "m7n8o9p10q11") as TestResponse;
        }
    }
}
