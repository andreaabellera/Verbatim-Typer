using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verbatim_Typer
{
    public partial class Form2 : Form
    {
        public String defHead = "";
        public String defContent = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            defHead = defHead_tbx.Text;
            defContent = defContent_tbx.Text;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
