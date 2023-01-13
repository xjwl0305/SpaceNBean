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
            /*
            for (int i = 0; i < Program.material_cards_basic.Count; i++)
            {
                String[] data = (String[]) Program.material_cards_basic[i];
                MATERIAL_VIEW.Rows.Add(data);
            }
            */
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.material_cards_basic.Clear();
            Program.MaterialCardArrayList.Clear();
            Program.basicFilePath = basicFileTextBox.Text;
            Program.inputPathDir = inputPathTextBox.Text;
            Program.resultPathDir = resultPathTextBox.Text;
            Program.excelPathDir = excelPathTextBox.Text;
            Program.ReadBasic(@Program.basicFilePath);

            // 테이블 요소들을 다음 Form에 전달해야 함.
            for (int i = 0; i < MATERIAL_VIEW.Rows.Count-1; i++)
            {
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
            Program.tally4 = tally4Text.Text;
            Program.tally14 = tally14Text.Text;
            Program.m1Density = m1DensityText.Text;
            Program.executeNum = executeNumberTextBox.Text;
            
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

        private void inputButton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    basicFileTextBox.Text = openFileDialog.FileName;
                }
                
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                inputPathTextBox.Text = fbd.SelectedPath;
            }
        }
        
        private void resultPathSelectorButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                resultPathTextBox.Text = fbd.SelectedPath;
            }
        }
        
        private void excelPathSelectorButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                excelPathTextBox.Text = fbd.SelectedPath;
            }
        }
        
    }
}