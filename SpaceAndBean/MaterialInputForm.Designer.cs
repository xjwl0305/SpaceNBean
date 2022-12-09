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
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // MATERIAL_VIEW
            // 
            this.MATERIAL_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MATERIAL_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.M_MAT_NUM, this.MAT_ATOM_INDEX, this.MAT_ATOM_QTY, this.M_MAT_DEN, this.M_ANNO });
            this.MATERIAL_VIEW.Location = new System.Drawing.Point(45, 248);
            this.MATERIAL_VIEW.Name = "MATERIAL_VIEW";
            this.MATERIAL_VIEW.RowTemplate.Height = 23;
            this.MATERIAL_VIEW.Size = new System.Drawing.Size(696, 322);
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
            this.label1.Location = new System.Drawing.Point(45, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material_Card";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(633, 591);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(83, 26);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MATERIAL_ADD
            // 
            this.MATERIAL_ADD.Location = new System.Drawing.Point(440, 592);
            this.MATERIAL_ADD.Name = "MATERIAL_ADD";
            this.MATERIAL_ADD.Size = new System.Drawing.Size(79, 25);
            this.MATERIAL_ADD.TabIndex = 3;
            this.MATERIAL_ADD.Text = "ADD";
            this.MATERIAL_ADD.UseVisualStyleBackColor = true;
            this.MATERIAL_ADD.Click += new System.EventHandler(this.MATERIAL_ADD_Click);
            // 
            // MATERIAL_DEL
            // 
            this.MATERIAL_DEL.Location = new System.Drawing.Point(536, 592);
            this.MATERIAL_DEL.Name = "MATERIAL_DEL";
            this.MATERIAL_DEL.Size = new System.Drawing.Size(79, 25);
            this.MATERIAL_DEL.TabIndex = 4;
            this.MATERIAL_DEL.Text = "DEL";
            this.MATERIAL_DEL.UseVisualStyleBackColor = true;
            this.MATERIAL_DEL.Click += new System.EventHandler(this.MATERIAL_DEL_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(543, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "PZ_END";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(294, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "PY_END";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "PX_END";
            // 
            // PZ_END
            // 
            this.PZ_END.Location = new System.Drawing.Point(633, 174);
            this.PZ_END.Name = "PZ_END";
            this.PZ_END.Size = new System.Drawing.Size(123, 21);
            this.PZ_END.TabIndex = 20;
            // 
            // PY_END
            // 
            this.PY_END.Location = new System.Drawing.Point(383, 174);
            this.PY_END.Name = "PY_END";
            this.PY_END.Size = new System.Drawing.Size(118, 21);
            this.PY_END.TabIndex = 19;
            // 
            // PX_END
            // 
            this.PX_END.Location = new System.Drawing.Point(126, 174);
            this.PX_END.Name = "PX_END";
            this.PX_END.Size = new System.Drawing.Size(115, 21);
            this.PX_END.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(543, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "PZ_START";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(294, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "PY_START";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(36, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "PX_START";
            // 
            // PZ_START
            // 
            this.PZ_START.Location = new System.Drawing.Point(633, 134);
            this.PZ_START.Name = "PZ_START";
            this.PZ_START.Size = new System.Drawing.Size(123, 21);
            this.PZ_START.TabIndex = 14;
            // 
            // PY_START
            // 
            this.PY_START.Location = new System.Drawing.Point(382, 134);
            this.PY_START.Name = "PY_START";
            this.PY_START.Size = new System.Drawing.Size(120, 21);
            this.PY_START.TabIndex = 13;
            // 
            // PX_START
            // 
            this.PX_START.Location = new System.Drawing.Point(126, 134);
            this.PX_START.Name = "PX_START";
            this.PX_START.Size = new System.Drawing.Size(115, 21);
            this.PX_START.TabIndex = 12;
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(126, 23);
            this.inputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(564, 21);
            this.inputPath.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(36, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Input File";
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(126, 65);
            this.outputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(564, 21);
            this.outputPath.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(36, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Output File";
            // 
            // inputFileSelector
            // 
            this.inputFileSelector.Location = new System.Drawing.Point(708, 23);
            this.inputFileSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputFileSelector.Name = "inputFileSelector";
            this.inputFileSelector.Size = new System.Drawing.Size(33, 21);
            this.inputFileSelector.TabIndex = 28;
            this.inputFileSelector.Text = "...";
            this.inputFileSelector.UseVisualStyleBackColor = true;
            this.inputFileSelector.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputFileSelector
            // 
            this.outputFileSelector.Location = new System.Drawing.Point(708, 65);
            this.outputFileSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputFileSelector.Name = "outputFileSelector";
            this.outputFileSelector.Size = new System.Drawing.Size(33, 21);
            this.outputFileSelector.TabIndex = 29;
            this.outputFileSelector.Text = "...";
            this.outputFileSelector.UseVisualStyleBackColor = true;
            this.outputFileSelector.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // MaterialInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 569);
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
            this.Name = "MaterialInputForm";
            this.Text = "NoriSpace";
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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