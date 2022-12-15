using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using SpaceAndBean.IO;
using SpaceAndBean.MCNP6;
using SpaceAndBean.RandomCreate;

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
            Program.CreateBasic();
            
            
            for (int i = 0; i < Program.MaterialCardArrayList.Count; i++)
            {
                String[] data = (String[]) Program.MaterialCardArrayList[i];
                MATERIAL_VIEW.Rows.Add(data);
            }
            /*
            for (int i = 0; i < Program.tally_cards_basic.Count; i++)
            {
                String[] data = (String[]) Program.tally_cards_basic[i];
                TALLY_VIEW.Rows.Add(data);
            }
            
            
            for (int i = 100; i < 600; i++)
            {
                String[] data = {"m"+i.ToString(), "", "", "", ""};
                MATERIAL_VIEW.Rows.Add(data);
            }
            */
            //throw new System.NotImplementedException();
            
            int index = 0;
            for (int i = 0; i < Program.SurfaceCardArrayList.Count; i++)
            {
                String[] data1 = (String[])Program.SurfaceCardArrayList[i];
                SURFACE_VIEW.Rows.Add(data1);

            }
            
            //Program.cell_cards_basic.AddRange();
            for (int i = 0; i < Program.CellCardArrayList.Count; i++)
            {
                String[] data = (String[]) Program.CellCardArrayList[i];
                CELL_CARD_VIEW.Rows.Add(data);
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {

            Program.CellCardArrayList = SaveInput.CollectionToArrayList(CELL_CARD_VIEW.Rows);
            Program.SurfaceCardArrayList = SaveInput.CollectionToArrayList(SURFACE_VIEW.Rows);
            Program.MaterialCardArrayList = SaveInput.CollectionToArrayList(MATERIAL_VIEW.Rows);
            Program.TallyCardArrayList = SaveInput.CollectionToArrayList(TALLY_VIEW.Rows);
            
            SaveInput.Save(Program.CellCardArrayList, Program.SurfaceCardArrayList, Program.MaterialCardArrayList, Program.TallyCardArrayList);
            AutoExec.Exec_MCNP();
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
            int index = MATERIAL_VIEW.CurrentRow.Index;
            MATERIAL_VIEW.Rows.Remove(MATERIAL_VIEW.Rows[index]);
            //throw new System.NotImplementedException();
        }

        private void TALLY_ADD_Click(object sender, EventArgs e)
        {
            int index = TALLY_VIEW.CurrentRow.Index;
            String[] data = {"", "", "", "", ""};
            TALLY_VIEW.Rows.Insert(index+1, data);
            //throw new System.NotImplementedException();
        }

        private void TALLY_DEL_Click(object sender, EventArgs e)
        {
            int index = TALLY_VIEW.CurrentRow.Index;
            TALLY_VIEW.Rows.Remove(TALLY_VIEW.Rows[index]);
            //throw new System.NotImplementedException();
        }
    }
}