namespace POS.uControl
{
    partial class ucProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTitle = new System.Windows.Forms.Panel();
            this.picAddItem = new System.Windows.Forms.PictureBox();
            this.panelItem = new System.Windows.Forms.Panel();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelItemAdd = new System.Windows.Forms.Panel();
            this.panelAddHeader = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbCatalog = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddItem)).BeginInit();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.panelItemAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1180, 70);
            this.panelHeader.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(831, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 70);
            this.panel1.TabIndex = 4;
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
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
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
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.picAddItem);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 70);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1180, 63);
            this.panelTitle.TabIndex = 8;
            // 
            // picAddItem
            // 
            this.picAddItem.Image = global::POS.Properties.Resources.add_cat;
            this.picAddItem.Location = new System.Drawing.Point(21, 16);
            this.picAddItem.Name = "picAddItem";
            this.picAddItem.Size = new System.Drawing.Size(32, 32);
            this.picAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAddItem.TabIndex = 12;
            this.picAddItem.TabStop = false;
            this.picAddItem.Click += new System.EventHandler(this.picAddItem_Click);
            // 
            // panelItem
            // 
            this.panelItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItem.Controls.Add(this.dgItem);
            this.panelItem.Location = new System.Drawing.Point(0, 133);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(248, 335);
            this.panelItem.TabIndex = 9;
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToOrderColumns = true;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItem.BackgroundColor = System.Drawing.Color.White;
            this.dgItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgItem.ColumnHeadersHeight = 40;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgItem.EnableHeadersVisualStyles = false;
            this.dgItem.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgItem.Location = new System.Drawing.Point(0, 0);
            this.dgItem.MultiSelect = false;
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgItem.RowHeadersWidth = 30;
            this.dgItem.RowTemplate.Height = 30;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(246, 333);
            this.dgItem.TabIndex = 1;
            // 
            // Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "EDIT";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 80;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "DELETE";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 80;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::POS.Properties.Resources.del;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // panelItemAdd
            // 
            this.panelItemAdd.Controls.Add(this.panelAddHeader);
            this.panelItemAdd.Controls.Add(this.btnInsert);
            this.panelItemAdd.Controls.Add(this.cbCatalog);
            this.panelItemAdd.Controls.Add(this.dtpDate);
            this.panelItemAdd.Controls.Add(this.btnLoadImage);
            this.panelItemAdd.Controls.Add(this.pbItem);
            this.panelItemAdd.Controls.Add(this.label9);
            this.panelItemAdd.Controls.Add(this.label8);
            this.panelItemAdd.Controls.Add(this.label6);
            this.panelItemAdd.Controls.Add(this.label7);
            this.panelItemAdd.Controls.Add(this.txtAmount);
            this.panelItemAdd.Controls.Add(this.label4);
            this.panelItemAdd.Controls.Add(this.txtSalePrice);
            this.panelItemAdd.Controls.Add(this.label5);
            this.panelItemAdd.Controls.Add(this.txtCostPrice);
            this.panelItemAdd.Controls.Add(this.label3);
            this.panelItemAdd.Controls.Add(this.txtName);
            this.panelItemAdd.Controls.Add(this.label2);
            this.panelItemAdd.Controls.Add(this.txtBarcode);
            this.panelItemAdd.Location = new System.Drawing.Point(271, 151);
            this.panelItemAdd.Name = "panelItemAdd";
            this.panelItemAdd.Size = new System.Drawing.Size(859, 466);
            this.panelItemAdd.TabIndex = 10;
            // 
            // panelAddHeader
            // 
            this.panelAddHeader.BackColor = System.Drawing.Color.Coral;
            this.panelAddHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAddHeader.Name = "panelAddHeader";
            this.panelAddHeader.Size = new System.Drawing.Size(859, 40);
            this.panelAddHeader.TabIndex = 42;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(625, 379);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(214, 38);
            this.btnInsert.TabIndex = 41;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbCatalog
            // 
            this.cbCatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCatalog.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCatalog.FormattingEnabled = true;
            this.cbCatalog.Location = new System.Drawing.Point(625, 155);
            this.cbCatalog.Name = "cbCatalog";
            this.cbCatalog.Size = new System.Drawing.Size(201, 28);
            this.cbCatalog.TabIndex = 40;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(626, 196);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 27);
            this.dtpDate.TabIndex = 39;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(625, 239);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(214, 32);
            this.btnLoadImage.TabIndex = 32;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(625, 274);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(214, 99);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItem.TabIndex = 38;
            this.pbItem.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "ဓါတ္ပံု :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "ရက္စြဲ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "ကတ္တေလာက္ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "အေရအတြက္ :";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(227, 364);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(214, 29);
            this.txtAmount.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "ေရာင္းေစ်းႏႈန္း :";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalePrice.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(227, 310);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(214, 29);
            this.txtSalePrice.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "ဝယ္ယူေစ်းႏႈန္း :";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostPrice.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.Location = new System.Drawing.Point(227, 257);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(214, 29);
            this.txtCostPrice.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "ပစၥည္းအမည္ :";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(227, 208);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 29);
            this.txtName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Barcode No :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(227, 157);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(214, 29);
            this.txtBarcode.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelItemAdd);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelHeader);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(1180, 642);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddItem)).EndInit();
            this.panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.panelItemAdd.ResumeLayout(false);
            this.panelItemAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.PictureBox picAddItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.Panel panelItemAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbCatalog;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel panelAddHeader;
    }
}
