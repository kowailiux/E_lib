namespace POS.uControl
{
    partial class ucDashboard
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.picAddItem = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(628, 70);
            this.panelHeader.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picAddItem);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(256, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 70);
            this.panel1.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateTime.Location = new System.Drawing.Point(47, 28);
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
            this.lblX.Location = new System.Drawing.Point(334, 29);
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
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gentium Basic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = global::POS.Properties.Resources.system_task_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 40);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // picAddItem
            // 
            this.picAddItem.Image = global::POS.Properties.Resources.calendar_48;
            this.picAddItem.Location = new System.Drawing.Point(6, 15);
            this.picAddItem.Name = "picAddItem";
            this.picAddItem.Size = new System.Drawing.Size(40, 40);
            this.picAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddItem.TabIndex = 13;
            this.picAddItem.TabStop = false;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(628, 369);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picAddItem;
        private System.Windows.Forms.Label label2;
    }
}
