using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SpaceAndBean
{
    public partial class NorisProgress : Form
    {
        public NorisProgress(int min, int max, String label)
        {
            InitializeComponent();
            init(min, max, label);
        }

        public void init(int min, int max, String label)
        {
            progreddssBar1.Value = 0;
            progreddssBar1.Maximum = max;
            progreddssBar1.Minimum = min;
            label1.Text = label;
            
        }
        public void update(String label, int increasment)
        {
            if (progreddssBar1.Value + increasment > progreddssBar1.Maximum)
            {
                return;
            }
            label1.Text = label;
            progreddssBar1.Value += increasment;
        }
    }
}