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
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUF_NUM_PX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUF_NUM_PY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUF_NUM_PY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUF_NUM_PZ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUF_NUM_PZ2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZ2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL_CARD = new System.Windows.Forms.Label();
            this.MATERIAL_VIEW = new System.Windows.Forms.DataGridView();
            this.M_MAT_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ATOM_INDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_ATOM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_MAT_DEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_ANNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLY_CARD = new System.Windows.Forms.Label();
            this.TALLY_VIEW = new System.Windows.Forms.DataGridView();
            this.TALLY_INDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLY_PAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLY_IMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.Button();
            this.CELL_ADD = new System.Windows.Forms.Button();
            this.CELL_DEL = new System.Windows.Forms.Button();
            this.SURFACE_ADD = new System.Windows.Forms.Button();
            this.SURFACE_DEL = new System.Windows.Forms.Button();
            this.TALLY_ADD = new System.Windows.Forms.Button();
            this.TALLY_DEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CELL_CARD_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SURFACE_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TALLY_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // CELL_CARD
            // 
            this.CELL_CARD.Location = new System.Drawing.Point(22, 30);
            this.CELL_CARD.Name = "CELL_CARD";
            this.CELL_CARD.Size = new System.Drawing.Size(106, 21);
            this.CELL_CARD.TabIndex = 12;
            this.CELL_CARD.Text = "CELL_CARD";
            // 
            // CELL_CARD_VIEW
            // 
            this.CELL_CARD_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CELL_CARD_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.CELL_NUM, this.MAT_NUM, this.MAT_DEN, this.SUF_COM, this.IMP_P, this.IMP_N, this.IMP_E, this.ANNO });
            this.CELL_CARD_VIEW.Location = new System.Drawing.Point(30, 64);
            this.CELL_CARD_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CELL_CARD_VIEW.Name = "CELL_CARD_VIEW";
            this.CELL_CARD_VIEW.RowTemplate.Height = 23;
            this.CELL_CARD_VIEW.Size = new System.Drawing.Size(805, 328);
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
            this.SURFACE_CARD.Location = new System.Drawing.Point(23, 461);
            this.SURFACE_CARD.Name = "SURFACE_CARD";
            this.SURFACE_CARD.Size = new System.Drawing.Size(121, 28);
            this.SURFACE_CARD.TabIndex = 14;
            this.SURFACE_CARD.Text = "SURFACE_CARD";
            // 
            // SURFACE_VIEW
            // 
            this.SURFACE_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SURFACE_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.index, this.category, this.SUF_NUM_PX2, this.value, this.SUF_NUM_PY1, this.PY1, this.SUF_NUM_PY2, this.PY2, this.SUF_NUM_PZ1, this.PZ1, this.SUF_NUM_PZ2, this.PZ2 });
            this.SURFACE_VIEW.Location = new System.Drawing.Point(30, 506);
            this.SURFACE_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SURFACE_VIEW.Name = "SURFACE_VIEW";
            this.SURFACE_VIEW.RowTemplate.Height = 23;
            this.SURFACE_VIEW.Size = new System.Drawing.Size(806, 364);
            this.SURFACE_VIEW.TabIndex = 15;
            // 
            // index
            // 
            this.index.HeaderText = "SUF_NUM_PX1";
            this.index.Name = "index";
            // 
            // category
            // 
            this.category.HeaderText = "PX1";
            this.category.Name = "category";
            // 
            // SUF_NUM_PX2
            // 
            this.SUF_NUM_PX2.HeaderText = "SUF_NUM_PX2";
            this.SUF_NUM_PX2.Name = "SUF_NUM_PX2";
            // 
            // value
            // 
            this.value.HeaderText = "PX2";
            this.value.Name = "value";
            // 
            // SUF_NUM_PY1
            // 
            this.SUF_NUM_PY1.HeaderText = "SUF_NUM_PY1";
            this.SUF_NUM_PY1.Name = "SUF_NUM_PY1";
            // 
            // PY1
            // 
            this.PY1.HeaderText = "PY1";
            this.PY1.Name = "PY1";
            // 
            // SUF_NUM_PY2
            // 
            this.SUF_NUM_PY2.HeaderText = "SUF_NUM_PY2";
            this.SUF_NUM_PY2.Name = "SUF_NUM_PY2";
            // 
            // PY2
            // 
            this.PY2.HeaderText = "PY2";
            this.PY2.Name = "PY2";
            // 
            // SUF_NUM_PZ1
            // 
            this.SUF_NUM_PZ1.HeaderText = "SUF_NUM_PZ1";
            this.SUF_NUM_PZ1.Name = "SUF_NUM_PZ1";
            // 
            // PZ1
            // 
            this.PZ1.HeaderText = "PZ1";
            this.PZ1.Name = "PZ1";
            // 
            // SUF_NUM_PZ2
            // 
            this.SUF_NUM_PZ2.HeaderText = "SUF_NUM_PZ2";
            this.SUF_NUM_PZ2.Name = "SUF_NUM_PZ2";
            // 
            // PZ2
            // 
            this.PZ2.HeaderText = "PZ2";
            this.PZ2.Name = "PZ2";
            // 
            // MATERIAL_CARD
            // 
            this.MATERIAL_CARD.Location = new System.Drawing.Point(18, 924);
            this.MATERIAL_CARD.Name = "MATERIAL_CARD";
            this.MATERIAL_CARD.Size = new System.Drawing.Size(134, 34);
            this.MATERIAL_CARD.TabIndex = 16;
            this.MATERIAL_CARD.Text = "MATERIAL_CARD";
            // 
            // MATERIAL_VIEW
            // 
            this.MATERIAL_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MATERIAL_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.M_MAT_NUM, this.MAT_ATOM_INDEX, this.MAT_ATOM_QTY, this.M_MAT_DEN, this.M_ANNO });
            this.MATERIAL_VIEW.Location = new System.Drawing.Point(30, 973);
            this.MATERIAL_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_VIEW.Name = "MATERIAL_VIEW";
            this.MATERIAL_VIEW.RowTemplate.Height = 23;
            this.MATERIAL_VIEW.Size = new System.Drawing.Size(798, 392);
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
            this.TALLY_CARD.Location = new System.Drawing.Point(18, 1418);
            this.TALLY_CARD.Name = "TALLY_CARD";
            this.TALLY_CARD.Size = new System.Drawing.Size(99, 32);
            this.TALLY_CARD.TabIndex = 18;
            this.TALLY_CARD.Text = "TALLY_CARD";
            // 
            // TALLY_VIEW
            // 
            this.TALLY_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TALLY_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.TALLY_INDEX, this.TALLY_PAR, this.TALLY_IMP });
            this.TALLY_VIEW.Location = new System.Drawing.Point(30, 1455);
            this.TALLY_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TALLY_VIEW.Name = "TALLY_VIEW";
            this.TALLY_VIEW.RowTemplate.Height = 23;
            this.TALLY_VIEW.Size = new System.Drawing.Size(798, 210);
            this.TALLY_VIEW.TabIndex = 19;
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
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(679, 1785);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 48);
            this.Save.TabIndex = 20;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CELL_ADD
            // 
            this.CELL_ADD.Location = new System.Drawing.Point(586, 399);
            this.CELL_ADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CELL_ADD.Name = "CELL_ADD";
            this.CELL_ADD.Size = new System.Drawing.Size(109, 42);
            this.CELL_ADD.TabIndex = 21;
            this.CELL_ADD.Text = "ADD";
            this.CELL_ADD.UseVisualStyleBackColor = true;
            this.CELL_ADD.Click += new System.EventHandler(this.CELL_ADD_Click);
            // 
            // CELL_DEL
            // 
            this.CELL_DEL.Location = new System.Drawing.Point(710, 399);
            this.CELL_DEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CELL_DEL.Name = "CELL_DEL";
            this.CELL_DEL.Size = new System.Drawing.Size(104, 42);
            this.CELL_DEL.TabIndex = 22;
            this.CELL_DEL.Text = "DEL";
            this.CELL_DEL.UseVisualStyleBackColor = true;
            this.CELL_DEL.Click += new System.EventHandler(this.CELL_DEL_Click);
            // 
            // SURFACE_ADD
            // 
            this.SURFACE_ADD.Location = new System.Drawing.Point(585, 878);
            this.SURFACE_ADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SURFACE_ADD.Name = "SURFACE_ADD";
            this.SURFACE_ADD.Size = new System.Drawing.Size(109, 44);
            this.SURFACE_ADD.TabIndex = 23;
            this.SURFACE_ADD.Text = "ADD";
            this.SURFACE_ADD.UseVisualStyleBackColor = true;
            this.SURFACE_ADD.Click += new System.EventHandler(this.SURFACE_ADD_Click);
            // 
            // SURFACE_DEL
            // 
            this.SURFACE_DEL.Location = new System.Drawing.Point(712, 878);
            this.SURFACE_DEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SURFACE_DEL.Name = "SURFACE_DEL";
            this.SURFACE_DEL.Size = new System.Drawing.Size(104, 44);
            this.SURFACE_DEL.TabIndex = 24;
            this.SURFACE_DEL.Text = "DEL";
            this.SURFACE_DEL.UseVisualStyleBackColor = true;
            this.SURFACE_DEL.Click += new System.EventHandler(this.SURFACE_DEL_Click);
            // 
            // TALLY_ADD
            // 
            this.TALLY_ADD.Location = new System.Drawing.Point(582, 1672);
            this.TALLY_ADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TALLY_ADD.Name = "TALLY_ADD";
            this.TALLY_ADD.Size = new System.Drawing.Size(107, 49);
            this.TALLY_ADD.TabIndex = 27;
            this.TALLY_ADD.Text = "ADD";
            this.TALLY_ADD.UseVisualStyleBackColor = true;
            this.TALLY_ADD.Click += new System.EventHandler(this.TALLY_ADD_Click);
            // 
            // TALLY_DEL
            // 
            this.TALLY_DEL.Location = new System.Drawing.Point(706, 1674);
            this.TALLY_DEL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TALLY_DEL.Name = "TALLY_DEL";
            this.TALLY_DEL.Size = new System.Drawing.Size(104, 48);
            this.TALLY_DEL.TabIndex = 28;
            this.TALLY_DEL.Text = "DEL";
            this.TALLY_DEL.UseVisualStyleBackColor = true;
            this.TALLY_DEL.Click += new System.EventHandler(this.TALLY_DEL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.ClientSize = new System.Drawing.Size(941, 669);
            this.Controls.Add(this.TALLY_DEL);
            this.Controls.Add(this.TALLY_ADD);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "NoriSpace";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CELL_CARD_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SURFACE_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIAL_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TALLY_VIEW)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn SUF_NUM_PX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUF_NUM_PY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUF_NUM_PY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUF_NUM_PZ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUF_NUM_PZ2;

        private System.Windows.Forms.DataGridViewTextBoxColumn PY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZ2;

        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;

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

        #endregion
    }
}