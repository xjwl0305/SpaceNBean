using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpaceAndBean
{
    public partial class MaterialInputForm : Form
    {
        public MaterialInputForm()
        {
            InitializeComponent();
            MaterialInputForm_Load();
        }

        private void MaterialInputForm_Load()
        {
            //TODO 이거 나중에 빼야함. 지금은 테스트용
            for (int i = 0; i < Program.material_cards_basic.Count; i++)
            {
                String[] data = (String[]) Program.material_cards_basic[i];
                MATERIAL_VIEW.Rows.Add(data);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.material_cards_basic.Clear();
            
            // 테이블 요소들을 다음 Form에 전달해야 함.
            for (int i = 0; i < MATERIAL_VIEW.Rows.Count; i++)
            {
                if (MATERIAL_VIEW.Rows[i].Cells[0].Value == null)
                {
                    break;
                }
                String[] data = new string[5];
                for (int j = 0; j < MATERIAL_VIEW.Rows[i].Cells.Count; j++)
                {
                    if (MATERIAL_VIEW.Rows[i].Cells[j].Value == null)
                    {
                        data[j] = "";
                    }
                    else
                    {
                        data[j] = MATERIAL_VIEW.Rows[i].Cells[j].Value.ToString();
                    }
                    
                }
                Program.MaterialCardArrayList.Add(data);
            }
            
            // VAR_INPUT 전달
            Program.var_inputs[0] = PX_START.Text;
            Program.var_inputs[1] = PX_END.Text;
            Program.var_inputs[2] = PY_START.Text;
            Program.var_inputs[3] = PY_END.Text;
            Program.var_inputs[4] = PZ_START.Text;
            Program.var_inputs[5] = PZ_END.Text;
            Form1 form1 = new Form1();
            form1.ShowDialog();

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
    }
}