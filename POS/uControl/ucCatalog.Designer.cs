namespace POS.uControl
{
    partial class ucCatalog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.picAddCat = new System.Windows.Forms.PictureBox();
            this.gbAddCat = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.lblAddNewCatalog = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.dgCatalog = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCat)).BeginInit();
            this.gbAddCat.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1023, 70);
            this.panelHeader.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(674, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 70);
            this.panel1.TabIndex = 5;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateTime.Location = new System.Drawing.Point(24, 28);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(58, 14);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(311, 29);
            this.lblX.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.picAddCat);
            this.panel.Controls.Add(this.gbAddCat);
            this.panel.Controls.Add(this.lblAddNewCatalog);
            this.panel.Controls.Add(this.gbEdit);
            this.panel.Controls.Add(this.dgCatalog);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1023, 449);
            this.panel.TabIndex = 6;
            // 
            // picAddCat
            // 
            this.picAddCat.Image = global::POS.Properties.Resources.add_cat;
            this.picAddCat.Location = new System.Drawing.Point(21, 13);
            this.picAddCat.Name = "picAddCat";
            this.picAddCat.Size = new System.Drawing.Size(32, 32);
            this.picAddCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAddCat.TabIndex = 11;
            this.picAddCat.TabStop = false;
            this.picAddCat.Click += new System.EventHandler(this.picAddCat_Click);
            // 
            // gbAddCat
            // 
            this.gbAddCat.Controls.Add(this.btnInsert);
            this.gbAddCat.Controls.Add(this.label2);
            this.gbAddCat.Controls.Add(this.txtCatalog);
            this.gbAddCat.Location = new System.Drawing.Point(484, 51);
            this.gbAddCat.Name = "gbAddCat";
            this.gbAddCat.Size = new System.Drawing.Size(344, 121);
            this.gbAddCat.TabIndex = 10;
            this.gbAddCat.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(114, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(214, 44);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Catalog Name :";
            // 
            // txtCatalog
            // 
            this.txtCatalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatalog.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatalog.Location = new System.Drawing.Point(114, 19);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(214, 29);
            this.txtCatalog.TabIndex = 4;
            this.txtCatalog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatalog_KeyDown);
            // 
            // lblAddNewCatalog
            // 
            this.lblAddNewCatalog.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblAddNewCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAddNewCatalog.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewCatalog.ForeColor = System.Drawing.Color.White;
            this.lblAddNewCatalog.Location = new System.Drawing.Point(49, 13);
            this.lblAddNewCatalog.Name = "lblAddNewCatalog";
            this.lblAddNewCatalog.Size = new System.Drawing.Size(138, 32);
            this.lblAddNewCatalog.TabIndex = 9;
            this.lblAddNewCatalog.Text = "  New Catalog";
            this.lblAddNewCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNewCatalog.UseCompatibleTextRendering = true;
            this.lblAddNewCatalog.Click += new System.EventHandler(this.lblAddNewCatalog_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.label5);
            this.gbEdit.Controls.Add(this.txtCatId);
            this.gbEdit.Controls.Add(this.btnUpdate);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.txtCatName);
            this.gbEdit.Location = new System.Drawing.Point(484, 51);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(344, 184);
            this.gbEdit.TabIndex = 8;
            this.gbEdit.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Catalog Id :";
            // 
            // txtCatId
            // 
            this.txtCatId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatId.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatId.Location = new System.Drawing.Point(106, 47);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.ReadOnly = true;
            this.txtCatId.Size = new System.Drawing.Size(226, 29);
            this.txtCatId.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(106, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Catalog Name :";
            // 
            // txtCatName
            // 
            this.txtCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatName.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(106, 87);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(226, 29);
            this.txtCatName.TabIndex = 4;
            // 
            // dgCatalog
            // 
            this.dgCatalog.AllowUserToAddRows = false;
            this.dgCatalog.AllowUserToDeleteRows = false;
            this.dgCatalog.AllowUserToOrderColumns = true;
            this.dgCatalog.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCatalog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCatalog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgCatalog.ColumnHeadersHeight = 40;
            this.dgCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CatName,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCatalog.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgCatalog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCatalog.EnableHeadersVisualStyles = false;
            this.dgCatalog.GridColor = System.Drawing.SystemColors.Control;
            this.dgCatalog.Location = new System.Drawing.Point(21, 51);
            this.dgCatalog.Name = "dgCatalog";
            this.dgCatalog.ReadOnly = true;
            this.dgCatalog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCatalog.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgCatalog.RowHeadersVisible = false;
            this.dgCatalog.RowHeadersWidth = 40;
            this.dgCatalog.RowTemplate.Height = 30;
            this.dgCatalog.Size = new System.Drawing.Size(457, 397);
            this.dgCatalog.TabIndex = 0;
            this.dgCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCatalog_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "#Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // CatName
            // 
            this.CatName.HeaderText = "CatName";
            this.CatName.Name = "CatName";
            this.CatName.ReadOnly = true;
            this.CatName.Width = 200;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "EDIT";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "DELETE";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelHeader);
            this.Name = "ucCatalog";
            this.Size = new System.Drawing.Size(1023, 519);
            this.Load += new System.EventHandler(this.ucCatalog_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCat)).EndInit();
            this.gbAddCat.ResumeLayout(false);
            this.gbAddCat.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox gbAddCat;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.Label lblAddNewCatalog;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.PictureBox picAddCat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblX;

    }
}
