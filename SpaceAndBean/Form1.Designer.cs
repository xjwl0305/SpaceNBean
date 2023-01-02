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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CELL_CARD_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CELL_CARD_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CELL_CARD_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.CELL_NUM, this.MAT_NUM, this.MAT_DEN, this.SUF_COM, this.IMP_P, this.IMP_N, this.IMP_E, this.ANNO });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CELL_CARD_VIEW.DefaultCellStyle = dataGridViewCellStyle2;
            this.CELL_CARD_VIEW.Location = new System.Drawing.Point(30, 64);
            this.CELL_CARD_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CELL_CARD_VIEW.Name = "CELL_CARD_VIEW";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CELL_CARD_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SURFACE_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SURFACE_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SURFACE_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.index, this.category, this.SUF_NUM_PX2, this.value, this.SUF_NUM_PY1, this.PY1, this.SUF_NUM_PY2, this.PY2, this.SUF_NUM_PZ1, this.PZ1, this.SUF_NUM_PZ2, this.PZ2, this.MATERIAL });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SURFACE_VIEW.DefaultCellStyle = dataGridViewCellStyle5;
            this.SURFACE_VIEW.Location = new System.Drawing.Point(30, 506);
            this.SURFACE_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SURFACE_VIEW.Name = "SURFACE_VIEW";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SURFACE_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // MATERIAL
            // 
            this.MATERIAL.HeaderText = "MATERIAL";
            this.MATERIAL.Name = "MATERIAL";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MATERIAL_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MATERIAL_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MATERIAL_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.M_MAT_NUM, this.MAT_ATOM_INDEX, this.MAT_ATOM_QTY, this.M_MAT_DEN, this.M_ANNO });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MATERIAL_VIEW.DefaultCellStyle = dataGridViewCellStyle8;
            this.MATERIAL_VIEW.Location = new System.Drawing.Point(30, 973);
            this.MATERIAL_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MATERIAL_VIEW.Name = "MATERIAL_VIEW";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MATERIAL_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TALLY_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.TALLY_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TALLY_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.TALLY_INDEX, this.TALLY_PAR, this.TALLY_IMP });
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TALLY_VIEW.DefaultCellStyle = dataGridViewCellStyle11;
            this.TALLY_VIEW.Location = new System.Drawing.Point(30, 1455);
            this.TALLY_VIEW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TALLY_VIEW.Name = "TALLY_VIEW";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TALLY_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            this.ClientSize = new System.Drawing.Size(991, 708);
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

        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAL;

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