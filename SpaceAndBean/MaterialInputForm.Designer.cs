using System.ComponentModel;

namespace SpaceAndBean
{
    partial class MaterialInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MATERIAL_VIEW = new System.Windows.Forms.DataGridView();
            this.M_MAT_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ATOM_INDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ATOM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_MAT_DEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_ANNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.MATERIAL_ADD = new System.Windows.Forms.Button();
            this.MATERIAL_DEL = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tally4Text = new System.Windows.Forms.TextBox();
            this.tally14Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.m1DensityText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.executeNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PZ_END = new System.Windows.Forms.TextBox();
            this.PY_END = new System.Windows.Forms.TextBox();
            this.PX_END = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PZ_START = new System.Windows.Forms.TextBox();
            this.PY_START = new System.Windows.Forms.TextBox();
            this.PX_START = new System.Windows.Forms.TextBox();
            this.basicFileTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputPathTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.basicFileSelectorButton = new System.Windows.Forms.Button();
            this.inputPathSelectorButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.resultPathTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.excelPathTextBox = new System.Windows.Forms.TextBox();
            this.resultPathSelectorButton = new System.Windows.Forms.Button();
            this.excelPathSelectorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // MATERIAL_VIEW
            // 
            this.MATERIAL_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MATERIAL_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.M_MAT_NUM, this.MAT_ATOM_INDEX, this.MAT_ATOM_QTY, this.M_MAT_DEN, this.M_ANNO });
            this.MATERIAL_VIEW.Location = new System.Drawing.Point(35, 473);
            this.MATERIAL_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_VIEW.Name = "MATERIAL_VIEW";
            this.MATERIAL_VIEW.RowTemplate.Height = 23;
            this.MATERIAL_VIEW.Size = new System.Drawing.Size(812, 322);
            this.MATERIAL_VIEW.TabIndex = 19;
            // 
            // M_MAT_NUM
            // 
            this.M_MAT_NUM.HeaderText = "M_MAT_NUM";
            this.M_MAT_NUM.Name = "M_MAT_NUM";
            this.M_MAT_NUM.Width = 130;
            // 
            // MAT_ATOM_INDEX
            // 
            this.MAT_ATOM_INDEX.HeaderText = "MAT_ATOM_INDEX";
            this.MAT_ATOM_INDEX.Name = "MAT_ATOM_INDEX";
            this.MAT_ATOM_INDEX.Width = 130;
            // 
            // MAT_ATOM_QTY
            // 
            this.MAT_ATOM_QTY.HeaderText = "MAT_ATOM_QTY";
            this.MAT_ATOM_QTY.Name = "MAT_ATOM_QTY";
            this.MAT_ATOM_QTY.Width = 130;
            // 
            // M_MAT_DEN
            // 
            this.M_MAT_DEN.HeaderText = "M_MAT_Density";
            this.M_MAT_DEN.Name = "M_MAT_DEN";
            this.M_MAT_DEN.Width = 130;
            // 
            // M_ANNO
            // 
            this.M_ANNO.HeaderText = "M_MAT_SHIELD";
            this.M_ANNO.Name = "M_ANNO";
            this.M_ANNO.Width = 130;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material_Card";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(707, 820);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(95, 32);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MATERIAL_ADD
            // 
            this.MATERIAL_ADD.Location = new System.Drawing.Point(487, 821);
            this.MATERIAL_ADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_ADD.Name = "MATERIAL_ADD";
            this.MATERIAL_ADD.Size = new System.Drawing.Size(90, 31);
            this.MATERIAL_ADD.TabIndex = 3;
            this.MATERIAL_ADD.Text = "ADD";
            this.MATERIAL_ADD.UseVisualStyleBackColor = true;
            this.MATERIAL_ADD.Click += new System.EventHandler(this.MATERIAL_ADD_Click);
            // 
            // MATERIAL_DEL
            // 
            this.MATERIAL_DEL.Location = new System.Drawing.Point(597, 821);
            this.MATERIAL_DEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_DEL.Name = "MATERIAL_DEL";
            this.MATERIAL_DEL.Size = new System.Drawing.Size(90, 31);
            this.MATERIAL_DEL.TabIndex = 4;
            this.MATERIAL_DEL.Text = "DEL";
            this.MATERIAL_DEL.UseVisualStyleBackColor = true;
            this.MATERIAL_DEL.Click += new System.EventHandler(this.MATERIAL_DEL_Click);
            // 
            // label10
            // 
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(41, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "TALLY_4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tally4Text
            // 
            this.tally4Text.Location = new System.Drawing.Point(144, 230);
            this.tally4Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tally4Text.Name = "tally4Text";
            this.tally4Text.Size = new System.Drawing.Size(131, 25);
            this.tally4Text.TabIndex = 9;
            // 
            // tally14Text
            // 
            this.tally14Text.Location = new System.Drawing.Point(423, 230);
            this.tally14Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tally14Text.Name = "tally14Text";
            this.tally14Text.Size = new System.Drawing.Size(135, 25);
            this.tally14Text.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(322, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "TALLY_14";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label12.Location = new System.Drawing.Point(605, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 26);
            this.label12.TabIndex = 34;
            this.label12.Text = "M1_Density";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m1DensityText
            // 
            this.m1DensityText.Location = new System.Drawing.Point(707, 231);
            this.m1DensityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m1DensityText.Name = "m1DensityText";
            this.m1DensityText.Size = new System.Drawing.Size(140, 25);
            this.m1DensityText.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(41, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 26);
            this.label13.TabIndex = 37;
            this.label13.Text = "실행 횟수";
            // 
            // executeNumberTextBox
            // 
            this.executeNumberTextBox.Location = new System.Drawing.Point(144, 384);
            this.executeNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.executeNumberTextBox.Name = "executeNumberTextBox";
            this.executeNumberTextBox.Size = new System.Drawing.Size(131, 25);
            this.executeNumberTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(605, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "PZ_END";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(322, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "PY_END";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(41, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "PX_END";
            // 
            // PZ_END
            // 
            this.PZ_END.Location = new System.Drawing.Point(707, 340);
            this.PZ_END.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PZ_END.Name = "PZ_END";
            this.PZ_END.Size = new System.Drawing.Size(140, 25);
            this.PZ_END.TabIndex = 17;
            // 
            // PY_END
            // 
            this.PY_END.Location = new System.Drawing.Point(424, 339);
            this.PY_END.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PY_END.Name = "PY_END";
            this.PY_END.Size = new System.Drawing.Size(136, 25);
            this.PY_END.TabIndex = 16;
            // 
            // PX_END
            // 
            this.PX_END.Location = new System.Drawing.Point(144, 339);
            this.PX_END.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PX_END.Name = "PX_END";
            this.PX_END.Size = new System.Drawing.Size(131, 25);
            this.PX_END.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(605, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "PZ_START";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(322, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "PY_START";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(41, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "PX_START";
            // 
            // PZ_START
            // 
            this.PZ_START.Location = new System.Drawing.Point(707, 290);
            this.PZ_START.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PZ_START.Name = "PZ_START";
            this.PZ_START.Size = new System.Drawing.Size(140, 25);
            this.PZ_START.TabIndex = 14;
            // 
            // PY_START
            // 
            this.PY_START.Location = new System.Drawing.Point(423, 289);
            this.PY_START.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PY_START.Name = "PY_START";
            this.PY_START.Size = new System.Drawing.Size(137, 25);
            this.PY_START.TabIndex = 13;
            // 
            // PX_START
            // 
            this.PX_START.Location = new System.Drawing.Point(144, 289);
            this.PX_START.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PX_START.Name = "PX_START";
            this.PX_START.Size = new System.Drawing.Size(131, 25);
            this.PX_START.TabIndex = 12;
            // 
            // basicFileTextBox
            // 
            this.basicFileTextBox.Location = new System.Drawing.Point(144, 35);
            this.basicFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basicFileTextBox.Name = "basicFileTextBox";
            this.basicFileTextBox.Size = new System.Drawing.Size(644, 25);
            this.basicFileTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(41, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Basic File";
            // 
            // inputPathTextBox
            // 
            this.inputPathTextBox.Location = new System.Drawing.Point(144, 87);
            this.inputPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPathTextBox.Name = "inputPathTextBox";
            this.inputPathTextBox.Size = new System.Drawing.Size(644, 25);
            this.inputPathTextBox.TabIndex = 3;
            this.inputPathTextBox.Text = "C:\\mcnp6_auto\\input_File";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(41, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Input Path";
            // 
            // basicFileSelectorButton
            // 
            this.basicFileSelectorButton.Location = new System.Drawing.Point(809, 35);
            this.basicFileSelectorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basicFileSelectorButton.Name = "basicFileSelectorButton";
            this.basicFileSelectorButton.Size = new System.Drawing.Size(38, 26);
            this.basicFileSelectorButton.TabIndex = 2;
            this.basicFileSelectorButton.Text = "...";
            this.basicFileSelectorButton.UseVisualStyleBackColor = true;
            this.basicFileSelectorButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // inputPathSelectorButton
            // 
            this.inputPathSelectorButton.Location = new System.Drawing.Point(809, 87);
            this.inputPathSelectorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPathSelectorButton.Name = "inputPathSelectorButton";
            this.inputPathSelectorButton.Size = new System.Drawing.Size(38, 26);
            this.inputPathSelectorButton.TabIndex = 4;
            this.inputPathSelectorButton.Text = "...";
            this.inputPathSelectorButton.UseVisualStyleBackColor = true;
            this.inputPathSelectorButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(41, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 26);
            this.label14.TabIndex = 39;
            this.label14.Text = "Result Path";
            // 
            // resultPathTextBox
            // 
            this.resultPathTextBox.Location = new System.Drawing.Point(144, 137);
            this.resultPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultPathTextBox.Name = "resultPathTextBox";
            this.resultPathTextBox.Size = new System.Drawing.Size(644, 25);
            this.resultPathTextBox.TabIndex = 5;
            this.resultPathTextBox.Text = "C:\\mcnp6_auto\\result_File";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(41, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 26);
            this.label15.TabIndex = 41;
            this.label15.Text = "Excel Path";
            // 
            // excelPathTextBox
            // 
            this.excelPathTextBox.Location = new System.Drawing.Point(144, 185);
            this.excelPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excelPathTextBox.Name = "excelPathTextBox";
            this.excelPathTextBox.Size = new System.Drawing.Size(644, 25);
            this.excelPathTextBox.TabIndex = 7;
            this.excelPathTextBox.Text = "C:\\mcnp6_auto\\excel_File";
            // 
            // resultPathSelectorButton
            // 
            this.resultPathSelectorButton.Location = new System.Drawing.Point(809, 133);
            this.resultPathSelectorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultPathSelectorButton.Name = "resultPathSelectorButton";
            this.resultPathSelectorButton.Size = new System.Drawing.Size(38, 26);
            this.resultPathSelectorButton.TabIndex = 6;
            this.resultPathSelectorButton.Text = "...";
            this.resultPathSelectorButton.UseVisualStyleBackColor = true;
            this.resultPathSelectorButton.Click += new System.EventHandler(this.resultPathSelectorButton_Click);
            // 
            // excelPathSelectorButton
            // 
            this.excelPathSelectorButton.Location = new System.Drawing.Point(809, 185);
            this.excelPathSelectorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excelPathSelectorButton.Name = "excelPathSelectorButton";
            this.excelPathSelectorButton.Size = new System.Drawing.Size(38, 26);
            this.excelPathSelectorButton.TabIndex = 8;
            this.excelPathSelectorButton.Text = "...";
            this.excelPathSelectorButton.UseVisualStyleBackColor = true;
            this.excelPathSelectorButton.Click += new System.EventHandler(this.excelPathSelectorButton_Click);
            // 
            // MaterialInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 859);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PZ_END);
            this.Controls.Add(this.PY_END);
            this.Controls.Add(this.PX_END);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PZ_START);
            this.Controls.Add(this.PY_START);
            this.Controls.Add(this.PX_START);
            this.Controls.Add(this.m1DensityText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tally14Text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tally4Text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.excelPathTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.resultPathTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.executeNumberTextBox);
            this.Controls.Add(this.excelPathSelectorButton);
            this.Controls.Add(this.resultPathSelectorButton);
            this.Controls.Add(this.inputPathSelectorButton);
            this.Controls.Add(this.basicFileSelectorButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputPathTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.basicFileTextBox);
            this.Controls.Add(this.MATERIAL_DEL);
            this.Controls.Add(this.MATERIAL_ADD);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MATERIAL_VIEW);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaterialInputForm";
            this.Text = "NoriSpace";
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox resultPathTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox excelPathTextBox;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox executeNumberTextBox;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m1DensityText;

        private System.Windows.Forms.TextBox tally14Text;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tally4Text;

        private System.Windows.Forms.Button inputPathSelectorButton;
        private System.Windows.Forms.Button basicFileSelectorButton;

        private System.Windows.Forms.Button excelPathSelectorButton;

        private System.Windows.Forms.Button resultPathSelectorButton;

        private System.Windows.Forms.TextBox basicFileTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputPathTextBox;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PZ_END;
        private System.Windows.Forms.TextBox PY_END;
        private System.Windows.Forms.TextBox PX_END;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PZ_START;
        private System.Windows.Forms.TextBox PY_START;
        private System.Windows.Forms.TextBox PX_START;

        private System.Windows.Forms.Button MATERIAL_DEL;

        private System.Windows.Forms.Button MATERIAL_ADD;

        private System.Windows.Forms.Button NextButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ATOM_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_MAT_DEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_ANNO;

        private System.Windows.Forms.DataGridViewTextBoxColumn M_MAT_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ATOM_INDEX;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView MATERIAL_VIEW;

        #endregion
    }
}