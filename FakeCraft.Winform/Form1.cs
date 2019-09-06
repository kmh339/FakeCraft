using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakeCraft;

namespace FakeCraft.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Marine m = new Marine();
            m.OnDead = Unit_Dead;
            m.TakeDamage(70);

            MessageBox.Show($"HP is {m.HP}");
        }
          
        void Unit_Dead(int remainingDamage)
        {
            MessageBox.Show($"I am dead with {remainingDamage} damage(s)");
        }
    }
}
