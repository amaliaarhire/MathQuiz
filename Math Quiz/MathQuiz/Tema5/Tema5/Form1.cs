using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rezultat;
            bool enumar = Int32.TryParse(Numarul.Text, out rezultat)
                if (enumar)
            { int d = 1;
                for (int i = 1; i <= rezultat / 2; i++) { if (rezultat % i == 0) { d++; } }
                if (d == 2) { this.BackColor = Color.Green; }
                else { this.BackColor = Color.Red; }
            }
            else { this.BackColor = Color.Yellow; }
        }
    }
}

            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
