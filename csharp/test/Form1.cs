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
            Request req = new Request();
            QosResponse resp = req.GET_Qos("O56b5cc79-5669-4457-bce2-0aeaf3b7242f") as QosResponse;
        }
    }
}
