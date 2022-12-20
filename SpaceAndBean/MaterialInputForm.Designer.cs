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
            this.inputPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputFileSelector = new System.Windows.Forms.Button();
            this.outputFileSelector = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tally4Text = new System.Windows.Forms.TextBox();
            this.tally14Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // MATERIAL_VIEW
            // 
            this.MATERIAL_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MATERIAL_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.M_MAT_NUM, this.MAT_ATOM_INDEX, this.MAT_ATOM_QTY, this.M_MAT_DEN, this.M_ANNO });
            this.MATERIAL_VIEW.Location = new System.Drawing.Point(41, 366);
            this.MATERIAL_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_VIEW.Name = "MATERIAL_VIEW";
            this.MATERIAL_VIEW.RowTemplate.Height = 23;
            this.MATERIAL_VIEW.Size = new System.Drawing.Size(795, 402);
            this.MATERIAL_VIEW.TabIndex = 0;
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
            this.M_MAT_DEN.HeaderText = "M_MAT_DEN";
            this.M_MAT_DEN.Name = "M_MAT_DEN";
            this.M_MAT_DEN.Width = 130;
            // 
            // M_ANNO
            // 
            this.M_ANNO.HeaderText = "M_ANNO";
            this.M_ANNO.Name = "M_ANNO";
            this.M_ANNO.Width = 130;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material_Card";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(713, 795);
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
            this.MATERIAL_ADD.Location = new System.Drawing.Point(493, 796);
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
            this.MATERIAL_DEL.Location = new System.Drawing.Point(603, 796);
            this.MATERIAL_DEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_DEL.Name = "MATERIAL_DEL";
            this.MATERIAL_DEL.Size = new System.Drawing.Size(90, 31);
            this.MATERIAL_DEL.TabIndex = 4;
            this.MATERIAL_DEL.Text = "DEL";
            this.MATERIAL_DEL.UseVisualStyleBackColor = true;
            this.MATERIAL_DEL.Click += new System.EventHandler(this.MATERIAL_DEL_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(611, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "PZ_END";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(326, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "PY_END";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "PX_END";
            // 
            // PZ_END
            // 
            this.PZ_END.Location = new System.Drawing.Point(713, 274);
            this.PZ_END.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PZ_END.Name = "PZ_END";
            this.PZ_END.Size = new System.Drawing.Size(140, 25);
            this.PZ_END.TabIndex = 20;
            // 
            // PY_END
            // 
            this.PY_END.Location = new System.Drawing.Point(428, 274);
            this.PY_END.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PY_END.Name = "PY_END";
            this.PY_END.Size = new System.Drawing.Size(134, 25);
            this.PY_END.TabIndex = 19;
            // 
            // PX_END
            // 
            this.PX_END.Location = new System.Drawing.Point(134, 274);
            this.PX_END.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PX_END.Name = "PX_END";
            this.PX_END.Size = new System.Drawing.Size(131, 25);
            this.PX_END.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(611, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "PZ_START";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(326, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "PY_START";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "PX_START";
            // 
            // PZ_START
            // 
            this.PZ_START.Location = new System.Drawing.Point(713, 224);
            this.PZ_START.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PZ_START.Name = "PZ_START";
            this.PZ_START.Size = new System.Drawing.Size(140, 25);
            this.PZ_START.TabIndex = 14;
            // 
            // PY_START
            // 
            this.PY_START.Location = new System.Drawing.Point(427, 224);
            this.PY_START.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PY_START.Name = "PY_START";
            this.PY_START.Size = new System.Drawing.Size(137, 25);
            this.PY_START.TabIndex = 13;
            // 
            // PX_START
            // 
            this.PX_START.Location = new System.Drawing.Point(134, 224);
            this.PX_START.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PX_START.Name = "PX_START";
            this.PX_START.Size = new System.Drawing.Size(131, 25);
            this.PX_START.TabIndex = 12;
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(144, 29);
            this.inputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(644, 25);
            this.inputPath.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(41, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Basic File";
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(144, 81);
            this.outputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(644, 25);
            this.outputPath.TabIndex = 26;
            this.outputPath.Text = "C:\\output_File";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(41, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Output Path";
            // 
            // inputFileSelector
            // 
            this.inputFileSelector.Location = new System.Drawing.Point(809, 29);
            this.inputFileSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputFileSelector.Name = "inputFileSelector";
            this.inputFileSelector.Size = new System.Drawing.Size(38, 26);
            this.inputFileSelector.TabIndex = 28;
            this.inputFileSelector.Text = "...";
            this.inputFileSelector.UseVisualStyleBackColor = true;
            this.inputFileSelector.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputFileSelector
            // 
            this.outputFileSelector.Location = new System.Drawing.Point(809, 81);
            this.outputFileSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputFileSelector.Name = "outputFileSelector";
            this.outputFileSelector.Size = new System.Drawing.Size(38, 26);
            this.outputFileSelector.TabIndex = 29;
            this.outputFileSelector.Text = "...";
            this.outputFileSelector.UseVisualStyleBackColor = true;
            this.outputFileSelector.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // label10
            // 
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(31, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "TALLY_4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tally4Text
            // 
            this.tally4Text.Location = new System.Drawing.Point(134, 162);
            this.tally4Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tally4Text.Name = "tally4Text";
            this.tally4Text.Size = new System.Drawing.Size(131, 25);
            this.tally4Text.TabIndex = 31;
            // 
            // tally14Text
            // 
            this.tally14Text.Location = new System.Drawing.Point(429, 162);
            this.tally14Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tally14Text.Name = "tally14Text";
            this.tally14Text.Size = new System.Drawing.Size(131, 25);
            this.tally14Text.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(326, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "TALLY_14";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaterialInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(974, 711);
            this.Controls.Add(this.tally14Text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tally4Text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.outputFileSelector);
            this.Controls.Add(this.inputFileSelector);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputPath);
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

        private System.Windows.Forms.TextBox tally14Text;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tally4Text;

        private System.Windows.Forms.Button outputFileSelector;
        private System.Windows.Forms.Button inputFileSelector;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outputPath;
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