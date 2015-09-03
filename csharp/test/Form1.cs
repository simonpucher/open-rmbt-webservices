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
            SearchRequest req = new SearchRequest();
            SearchResponse forecast = req.GET_OneTest(1764 , "a1b2c3d4e5f6") as SearchResponse;
        }
    }
}
