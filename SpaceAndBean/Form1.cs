using System;
using System.Windows.Forms;

namespace SpaceAndBean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void PX_START_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void PY_START_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void PZ_START_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
        
        private void PX_END_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void PY_END_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void PZ_END_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.material_cards_basic.Count; i++)
            {
                String[] data = (String[]) Program.material_cards_basic[i];
                MATERIAL_VIEW.Rows.Add(data);
            }

            for (int i = 100; i < 600; i++)
            {
                String[] data = {"m"+i.ToString(), "", "", "", ""};
                MATERIAL_VIEW.Rows.Add(data);
            }
            //throw new System.NotImplementedException();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void CELL_ADD_Click(object sender, EventArgs e)
        {

            //throw new System.NotImplementedException();
        }

        private void CELL_DEL_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void SURFACE_ADD_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void SURFACE_DEL_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void MATERIAL_ADD_Click(object sender, EventArgs e)
        {
            int index = MATERIAL_VIEW.CurrentRow.Index;
            String header = MATERIAL_VIEW.Rows[index].Cells[0].Value.ToString();
            String[] data = {header, "", "", "", ""};
            MATERIAL_VIEW.Rows.Insert(index+1, data);
            //throw new System.NotImplementedException();
        }

        private void MATERIAL_DEL_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void TALLY_ADD_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void TALLY_DEL_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}