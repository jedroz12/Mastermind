using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form2 : Form
    {
        Color Grey = Color.FromArgb(96, 96, 96);
        Color Black = Color.FromArgb(0, 0, 0);
        Color Red = Color.FromArgb(255, 0, 0);

        public Form2()
        {
            InitializeComponent();
            square1.BackColor = Grey;
            square2.BackColor = Grey;
            square3.BackColor = Grey;
            square4.BackColor = Grey;
            square5.BackColor = Black;
            square6.BackColor = Red;
        }
    }
}
