using System.ComponentModel;

namespace SpaceAndBean
{
    partial class Form1
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
            this.PX_START = new System.Windows.Forms.TextBox();
            this.PY_START = new System.Windows.Forms.TextBox();
            this.PZ_START = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PX_END = new System.Windows.Forms.TextBox();
            this.PY_END = new System.Windows.Forms.TextBox();
            this.PZ_END = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CELL_CARD = new System.Windows.Forms.Label();
            this.CELL_CARD_VIEW = new System.Windows.Forms.DataGridView();
            this.CELL_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_DEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUF_COM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURFACE_CARD = new System.Windows.Forms.Label();
            this.SURFACE_VIEW = new System.Windows.Forms.DataGridView();
            this.MATERIAL_CARD = new System.Windows.Forms.Label();
            this.MATERIAL_VIEW = new System.Windows.Forms.DataGridView();
            this.M_MAT_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ATOM_INDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ATOM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_MAT_DEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_ANNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLY_CARD = new System.Windows.Forms.Label();
            this.TALLY_VIEW = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.CELL_ADD = new System.Windows.Forms.Button();
            this.CELL_DEL = new System.Windows.Forms.Button();
            this.SURFACE_ADD = new System.Windows.Forms.Button();
            this.SURFACE_DEL = new System.Windows.Forms.Button();
            this.MATERIAL_ADD = new System.Windows.Forms.Button();
            this.MATERIAL_DEL = new System.Windows.Forms.Button();
            this.TALLY_ADD = new System.Windows.Forms.Button();
            this.TALLY_DEL = new System.Windows.Forms.Button();
            this.TALLY_INDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLY_PAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLY_IMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CELL_CARD_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SURFACE_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TALLY_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // PX_START
            // 
            this.PX_START.Location = new System.Drawing.Point(102, 30);
            this.PX_START.Name = "PX_START";
            this.PX_START.Size = new System.Drawing.Size(115, 21);
            this.PX_START.TabIndex = 0;
            this.PX_START.TextChanged += new System.EventHandler(this.PX_START_TextChanged);
            // 
            // PY_START
            // 
            this.PY_START.Location = new System.Drawing.Point(358, 30);
            this.PY_START.Name = "PY_START";
            this.PY_START.Size = new System.Drawing.Size(120, 21);
            this.PY_START.TabIndex = 1;
            this.PY_START.TextChanged += new System.EventHandler(this.PY_START_TextChanged);
            // 
            // PZ_START
            // 
            this.PZ_START.Location = new System.Drawing.Point(609, 30);
            this.PZ_START.Name = "PZ_START";
            this.PZ_START.Size = new System.Drawing.Size(123, 21);
            this.PZ_START.TabIndex = 2;
            this.PZ_START.TextChanged += new System.EventHandler(this.PZ_START_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "PX_START";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(270, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "PY_START";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(520, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "PZ_START";
            // 
            // PX_END
            // 
            this.PX_END.Location = new System.Drawing.Point(102, 71);
            this.PX_END.Name = "PX_END";
            this.PX_END.Size = new System.Drawing.Size(115, 21);
            this.PX_END.TabIndex = 6;
            this.PX_END.TextChanged += new System.EventHandler(this.PX_END_TextChanged);
            // 
            // PY_END
            // 
            this.PY_END.Location = new System.Drawing.Point(360, 71);
            this.PY_END.Name = "PY_END";
            this.PY_END.Size = new System.Drawing.Size(118, 21);
            this.PY_END.TabIndex = 7;
            this.PY_END.TextChanged += new System.EventHandler(this.PY_END_TextChanged);
            // 
            // PZ_END
            // 
            this.PZ_END.Location = new System.Drawing.Point(609, 71);
            this.PZ_END.Name = "PZ_END";
            this.PZ_END.Size = new System.Drawing.Size(123, 21);
            this.PZ_END.TabIndex = 8;
            this.PZ_END.TextChanged += new System.EventHandler(this.PZ_END_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "PX_END";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(270, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "PY_END";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(520, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "PZ_END";
            // 
            // CELL_CARD
            // 
            this.CELL_CARD.Location = new System.Drawing.Point(20, 121);
            this.CELL_CARD.Name = "CELL_CARD";
            this.CELL_CARD.Size = new System.Drawing.Size(93, 17);
            this.CELL_CARD.TabIndex = 12;
            this.CELL_CARD.Text = "CELL_CARD";
            // 
            // CELL_CARD_VIEW
            // 
            this.CELL_CARD_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CELL_CARD_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.CELL_NUM, this.MAT_NUM, this.MAT_DEN, this.SUF_COM, this.IMP_P, this.IMP_N, this.IMP_E, this.ANNO });
            this.CELL_CARD_VIEW.Location = new System.Drawing.Point(27, 148);
            this.CELL_CARD_VIEW.Name = "CELL_CARD_VIEW";
            this.CELL_CARD_VIEW.RowTemplate.Height = 23;
            this.CELL_CARD_VIEW.Size = new System.Drawing.Size(704, 262);
            this.CELL_CARD_VIEW.TabIndex = 13;
            // 
            // CELL_NUM
            // 
            this.CELL_NUM.HeaderText = "CELL_NUM";
            this.CELL_NUM.Name = "CELL_NUM";
            // 
            // MAT_NUM
            // 
            this.MAT_NUM.HeaderText = "MAT_NUM";
            this.MAT_NUM.Name = "MAT_NUM";
            // 
            // MAT_DEN
            // 
            this.MAT_DEN.HeaderText = "MAT_DEN";
            this.MAT_DEN.Name = "MAT_DEN";
            // 
            // SUF_COM
            // 
            this.SUF_COM.HeaderText = "SUF_COM";
            this.SUF_COM.Name = "SUF_COM";
            // 
            // IMP_P
            // 
            this.IMP_P.HeaderText = "IMP_P";
            this.IMP_P.Name = "IMP_P";
            // 
            // IMP_N
            // 
            this.IMP_N.HeaderText = "IMP_N";
            this.IMP_N.Name = "IMP_N";
            // 
            // IMP_E
            // 
            this.IMP_E.HeaderText = "IMP_E";
            this.IMP_E.Name = "IMP_E";
            // 
            // ANNO
            // 
            this.ANNO.HeaderText = "ANNO";
            this.ANNO.Name = "ANNO";
            // 
            // SURFACE_CARD
            // 
            this.SURFACE_CARD.Location = new System.Drawing.Point(20, 465);
            this.SURFACE_CARD.Name = "SURFACE_CARD";
            this.SURFACE_CARD.Size = new System.Drawing.Size(106, 22);
            this.SURFACE_CARD.TabIndex = 14;
            this.SURFACE_CARD.Text = "SURFACE_CARD";
            // 
            // SURFACE_VIEW
            // 
            this.SURFACE_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SURFACE_VIEW.Location = new System.Drawing.Point(26, 501);
            this.SURFACE_VIEW.Name = "SURFACE_VIEW";
            this.SURFACE_VIEW.RowTemplate.Height = 23;
            this.SURFACE_VIEW.Size = new System.Drawing.Size(705, 291);
            this.SURFACE_VIEW.TabIndex = 15;
            // 
            // MATERIAL_CARD
            // 
            this.MATERIAL_CARD.Location = new System.Drawing.Point(20, 852);
            this.MATERIAL_CARD.Name = "MATERIAL_CARD";
            this.MATERIAL_CARD.Size = new System.Drawing.Size(117, 27);
            this.MATERIAL_CARD.TabIndex = 16;
            this.MATERIAL_CARD.Text = "MATERIAL_CARD";
            // 
            // MATERIAL_VIEW
            // 
            this.MATERIAL_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MATERIAL_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.M_MAT_NUM, this.MAT_ATOM_INDEX, this.MAT_ATOM_QTY, this.M_MAT_DEN, this.M_ANNO });
            this.MATERIAL_VIEW.Location = new System.Drawing.Point(31, 891);
            this.MATERIAL_VIEW.Name = "MATERIAL_VIEW";
            this.MATERIAL_VIEW.RowTemplate.Height = 23;
            this.MATERIAL_VIEW.Size = new System.Drawing.Size(698, 314);
            this.MATERIAL_VIEW.TabIndex = 17;
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
            // TALLY_CARD
            // 
            this.TALLY_CARD.Location = new System.Drawing.Point(20, 1266);
            this.TALLY_CARD.Name = "TALLY_CARD";
            this.TALLY_CARD.Size = new System.Drawing.Size(87, 26);
            this.TALLY_CARD.TabIndex = 18;
            this.TALLY_CARD.Text = "TALLY_CARD";
            // 
            // TALLY_VIEW
            // 
            this.TALLY_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TALLY_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.TALLY_INDEX, this.TALLY_PAR, this.TALLY_IMP });
            this.TALLY_VIEW.Location = new System.Drawing.Point(31, 1295);
            this.TALLY_VIEW.Name = "TALLY_VIEW";
            this.TALLY_VIEW.RowTemplate.Height = 23;
            this.TALLY_VIEW.Size = new System.Drawing.Size(698, 168);
            this.TALLY_VIEW.TabIndex = 19;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(633, 1558);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(115, 38);
            this.Save.TabIndex = 20;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CELL_ADD
            // 
            this.CELL_ADD.Location = new System.Drawing.Point(514, 416);
            this.CELL_ADD.Name = "CELL_ADD";
            this.CELL_ADD.Size = new System.Drawing.Size(95, 34);
            this.CELL_ADD.TabIndex = 21;
            this.CELL_ADD.Text = "ADD";
            this.CELL_ADD.UseVisualStyleBackColor = true;
            this.CELL_ADD.Click += new System.EventHandler(this.CELL_ADD_Click);
            // 
            // CELL_DEL
            // 
            this.CELL_DEL.Location = new System.Drawing.Point(622, 416);
            this.CELL_DEL.Name = "CELL_DEL";
            this.CELL_DEL.Size = new System.Drawing.Size(91, 34);
            this.CELL_DEL.TabIndex = 22;
            this.CELL_DEL.Text = "DEL";
            this.CELL_DEL.UseVisualStyleBackColor = true;
            this.CELL_DEL.Click += new System.EventHandler(this.CELL_DEL_Click);
            // 
            // SURFACE_ADD
            // 
            this.SURFACE_ADD.Location = new System.Drawing.Point(512, 798);
            this.SURFACE_ADD.Name = "SURFACE_ADD";
            this.SURFACE_ADD.Size = new System.Drawing.Size(95, 35);
            this.SURFACE_ADD.TabIndex = 23;
            this.SURFACE_ADD.Text = "ADD";
            this.SURFACE_ADD.UseVisualStyleBackColor = true;
            this.SURFACE_ADD.Click += new System.EventHandler(this.SURFACE_ADD_Click);
            // 
            // SURFACE_DEL
            // 
            this.SURFACE_DEL.Location = new System.Drawing.Point(623, 798);
            this.SURFACE_DEL.Name = "SURFACE_DEL";
            this.SURFACE_DEL.Size = new System.Drawing.Size(91, 35);
            this.SURFACE_DEL.TabIndex = 24;
            this.SURFACE_DEL.Text = "DEL";
            this.SURFACE_DEL.UseVisualStyleBackColor = true;
            this.SURFACE_DEL.Click += new System.EventHandler(this.SURFACE_DEL_Click);
            // 
            // MATERIAL_ADD
            // 
            this.MATERIAL_ADD.Location = new System.Drawing.Point(514, 1211);
            this.MATERIAL_ADD.Name = "MATERIAL_ADD";
            this.MATERIAL_ADD.Size = new System.Drawing.Size(94, 34);
            this.MATERIAL_ADD.TabIndex = 25;
            this.MATERIAL_ADD.Text = "ADD";
            this.MATERIAL_ADD.UseVisualStyleBackColor = true;
            this.MATERIAL_ADD.Click += new System.EventHandler(this.MATERIAL_ADD_Click);
            // 
            // MATERIAL_DEL
            // 
            this.MATERIAL_DEL.Location = new System.Drawing.Point(622, 1211);
            this.MATERIAL_DEL.Name = "MATERIAL_DEL";
            this.MATERIAL_DEL.Size = new System.Drawing.Size(91, 34);
            this.MATERIAL_DEL.TabIndex = 26;
            this.MATERIAL_DEL.Text = "DEL";
            this.MATERIAL_DEL.UseVisualStyleBackColor = true;
            this.MATERIAL_DEL.Click += new System.EventHandler(this.MATERIAL_DEL_Click);
            // 
            // TALLY_ADD
            // 
            this.TALLY_ADD.Location = new System.Drawing.Point(514, 1469);
            this.TALLY_ADD.Name = "TALLY_ADD";
            this.TALLY_ADD.Size = new System.Drawing.Size(94, 39);
            this.TALLY_ADD.TabIndex = 27;
            this.TALLY_ADD.Text = "ADD";
            this.TALLY_ADD.UseVisualStyleBackColor = true;
            this.TALLY_ADD.Click += new System.EventHandler(this.TALLY_ADD_Click);
            // 
            // TALLY_DEL
            // 
            this.TALLY_DEL.Location = new System.Drawing.Point(622, 1470);
            this.TALLY_DEL.Name = "TALLY_DEL";
            this.TALLY_DEL.Size = new System.Drawing.Size(91, 38);
            this.TALLY_DEL.TabIndex = 28;
            this.TALLY_DEL.Text = "DEL";
            this.TALLY_DEL.UseVisualStyleBackColor = true;
            this.TALLY_DEL.Click += new System.EventHandler(this.TALLY_DEL_Click);
            // 
            // TALLY_INDEX
            // 
            this.TALLY_INDEX.HeaderText = "TALLY_INDEX";
            this.TALLY_INDEX.Name = "TALLY_INDEX";
            this.TALLY_INDEX.Width = 200;
            // 
            // TALLY_PAR
            // 
            this.TALLY_PAR.HeaderText = "TALLY_PAR";
            this.TALLY_PAR.Name = "TALLY_PAR";
            this.TALLY_PAR.Width = 200;
            // 
            // TALLY_IMP
            // 
            this.TALLY_IMP.HeaderText = "TALLY_IMP";
            this.TALLY_IMP.Name = "TALLY_IMP";
            this.TALLY_IMP.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.ClientSize = new System.Drawing.Size(806, 518);
            this.Controls.Add(this.TALLY_DEL);
            this.Controls.Add(this.TALLY_ADD);
            this.Controls.Add(this.MATERIAL_DEL);
            this.Controls.Add(this.MATERIAL_ADD);
            this.Controls.Add(this.SURFACE_DEL);
            this.Controls.Add(this.SURFACE_ADD);
            this.Controls.Add(this.CELL_DEL);
            this.Controls.Add(this.CELL_ADD);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TALLY_VIEW);
            this.Controls.Add(this.TALLY_CARD);
            this.Controls.Add(this.MATERIAL_VIEW);
            this.Controls.Add(this.MATERIAL_CARD);
            this.Controls.Add(this.SURFACE_VIEW);
            this.Controls.Add(this.SURFACE_CARD);
            this.Controls.Add(this.CELL_CARD_VIEW);
            this.Controls.Add(this.CELL_CARD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PZ_END);
            this.Controls.Add(this.PY_END);
            this.Controls.Add(this.PX_END);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PZ_START);
            this.Controls.Add(this.PY_START);
            this.Controls.Add(this.PX_START);
            this.Name = "Form1";
            this.Text = "SpaceNBean";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CELL_CARD_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SURFACE_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TALLY_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn TALLY_INDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TALLY_PAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TALLY_IMP;

        private System.Windows.Forms.DataGridViewTextBoxColumn M_ANNO;

        private System.Windows.Forms.DataGridViewTextBoxColumn M_MAT_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ATOM_INDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_ATOM_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_MAT_DEN;

        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_DEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUF_COM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNO;

        private System.Windows.Forms.DataGridViewTextBoxColumn CELL_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NUM;

        private System.Windows.Forms.Button CELL_ADD;
        private System.Windows.Forms.Button CELL_DEL;
        private System.Windows.Forms.Button SURFACE_ADD;
        private System.Windows.Forms.Button SURFACE_DEL;
        private System.Windows.Forms.Button MATERIAL_ADD;
        private System.Windows.Forms.Button MATERIAL_DEL;
        private System.Windows.Forms.Button TALLY_ADD;
        private System.Windows.Forms.Button TALLY_DEL;

        private System.Windows.Forms.Button Save;

        private System.Windows.Forms.Label TALLY_CARD;
        private System.Windows.Forms.DataGridView TALLY_VIEW;

        private System.Windows.Forms.Label MATERIAL_CARD;
        private System.Windows.Forms.DataGridView MATERIAL_VIEW;

        private System.Windows.Forms.Label SURFACE_CARD;
        private System.Windows.Forms.DataGridView SURFACE_VIEW;

        private System.Windows.Forms.DataGridView CELL_CARD_VIEW;

        private System.Windows.Forms.Label CELL_CARD;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox PX_END;
        private System.Windows.Forms.TextBox PY_END;
        private System.Windows.Forms.TextBox PZ_END;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox PX_START;
        private System.Windows.Forms.TextBox PY_START;
        private System.Windows.Forms.TextBox PZ_START;

        #endregion
    }
}