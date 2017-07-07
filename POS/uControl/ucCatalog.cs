using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS.uControl
{
    public partial class ucCatalog : UserControl
    {

        DbClass db = new DbClass();
        public ucCatalog()
        {
            InitializeComponent();
             
        }

        private void lblX_Click(object sender, EventArgs e)
        {

            //((Form)this.TopLevelControl).Close();
            ucCatalog ucCatalog = new ucCatalog();
            this.Hide();
            uControl.ucDashboard ucDashboard = new uControl.ucDashboard();
            ucDashboard.Dock = DockStyle.Fill;
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
  
        }

        private void ucCatalog_Load(object sender, EventArgs e)
        {
            gbAddCat.Visible = false;
            gbEdit.Visible = false;

            LoadDgCatalog();
 
        }

        private void txtCatalog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertCatalog();
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertCatalog();
        }
        private void InsertCatalog() {
            String strMessage = null;
            String sql_check = String.Format("SELECT id FROM tbl_catalog WHERE name=@name");

            int intCount = 0;
            intCount = Convert.ToInt32(db.GetCheck(sql_check, new SqlParameter("@name", txtCatalog.Text)));

            if ((intCount < 1) && (txtCatalog.Text != " "))
            {
                String sql = String.Format("INSERT INTO tbl_catalog(name) VALUES (@CatName)");
                db.CreateDelete(sql, new SqlParameter("@CatName", txtCatalog.Text));
                strMessage = "Inserted!";
                LoadDgCatalog();
            }
            else
            {
                strMessage = "Can't Inserte!";
                
            }
            MessageBox.Show(strMessage);
        }

        public void LoadDgCatalog()
        {
            dgCatalog.Rows.Clear();
            string[] ColumnList = {"id", "name"};
            DataTable dt = db.LoadAndReturnMultiRow(ColumnList, "tbl_catalog", "", "id");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgCatalog.Rows.Add();
                    dgCatalog.Rows[i].Cells["id"].Value = dt.Rows[i]["id"].ToString();
                    dgCatalog.Rows[i].Cells["CatName"].Value = dt.Rows[i]["name"].ToString();                    
                }
            }

            //datagridview design
            dgCatalog.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgCatalog.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
            dgCatalog.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgCatalog.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgCatalog.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            dgCatalog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgCatalog.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgCatalog.RowTemplate.Height = 100;


            dgCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCatalog.AllowUserToResizeColumns = false;
            
            //Add button to dgview
            // DataGridViewButtonColumn dgBtn = new DataGridViewButtonColumn();
            
            //dgCatalog.Columns.Add(dgBtn);
            //dgBtn.HeaderText = "Edit Data";
            //dgBtn.Text = "Edit";
            //dgBtn.UseColumnTextForButtonValue = true;  
            
        }
   
 

 
        private void dgCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) {
                gbEdit.Visible = true;
                gbAddCat.Visible = false;
                string name = Convert.ToString(dgCatalog.Rows[e.RowIndex].Cells[0].Value + "- " + dgCatalog.Rows[e.RowIndex].Cells[1].Value);
                String CatId = Convert.ToString(dgCatalog.Rows[e.RowIndex].Cells[0].Value);
                string CatName = Convert.ToString(dgCatalog.Rows[e.RowIndex].Cells[1].Value);
                txtCatId.Text = CatId;
                txtCatName.Text = CatName;
 
                //MessageBox.Show( name);
                //MessageBox.Show((e.RowIndex + 1).ToString());
            }else if ( e.ColumnIndex == 3 ){
               if( MessageBox.Show("Are you sure to Delete this Row?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes) {
                   db.DELETE("tbl_catalog", "id='" + dgCatalog.CurrentRow.Cells["id"].Value.ToString() + "'");
                   LoadDgCatalog();
               }


                 //if (MessageBox.Show(UClass.Cls_Global.msg_DeleteComfirm, "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] ColumnList = { "name" };
            string[] DataList = { txtCatName.Text};

 
            db.UPDATE(ColumnList, DataList, "tbl_catalog", "id=' " + txtCatId.Text + " ' ");

            this.LoadDgCatalog();
            
        }

        private void lblAddNewCatalog_Click(object sender, EventArgs e)
        {      
            gbAddCat.Visible = true;
            gbEdit.Visible = false;

        }

        private void picAddCat_Click(object sender, EventArgs e)
        {
            gbAddCat.Visible = true;
            gbEdit.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime iDateTime = DateTime.Now;
            lblDateTime.Text = iDateTime.ToLongDateString() + " at " + iDateTime.ToLongTimeString();
        }

        

  

   
 

 
 
 
 

 

 
    }
}
