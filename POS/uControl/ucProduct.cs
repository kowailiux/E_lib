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
using System.Windows; //***
using System.IO;


namespace POS.uControl
{

    public partial class ucProduct : UserControl
    {
        DbClass db = new DbClass();
        OpenFileDialog dlg = new OpenFileDialog();
          //for foto add
         Byte[] Foto;
        public ucProduct()
        {
            InitializeComponent();
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime iDateTime = DateTime.Now;
            lblDateTime.Text = iDateTime.ToLongDateString() + " at " + iDateTime.ToLongTimeString();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //ucProduct ucProduct = new ucProduct();
            this.Hide();
            uControl.ucDashboard ucDashboard = new uControl.ucDashboard();
            ucDashboard.Dock = DockStyle.Fill;
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
        }

        public void LoadDgItem()
        {
            dgItem.Rows.Clear();
            String sql = "SELECT tbl_item.id, tbl_item.barcode AS 'ဘားကုတ္နံပါတ္', tbl_item.name, tbl_item.cost_price, tbl_item.sale_price, tbl_item.quantity, tbl_catalog.name AS Catalog, tbl_item.photo, tbl_item.date FROM tbl_item INNER JOIN  tbl_catalog ON tbl_item.cat_id = tbl_catalog.id";

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn = new SqlConnection(DbClass.strConn);
            if ( DbClass.cn.State == ConnectionState.Closed)
            {
                DbClass.cn.Open();
            }
 
            cmd = new SqlCommand(sql, cn);
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "tbl_item");         
            dt = ds.Tables["tbl_item"];
            if (dt != null)
            {
                dgItem.DataSource = ds.Tables["tbl_item"];
                dgItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else {
                MessageBox.Show("NO");
            }
 

            //datagridview design
            //dgItem.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            //dgItem.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
            //dgItem.DefaultCellStyle.SelectionBackColor = Color.Red;
            //dgItem.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            //dgItem.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dgItem.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ////dgCatalog.RowTemplate.Height = 100;
            //dgItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgItem.AllowUserToResizeColumns = false;


        }

        public void LoadCbCatalog()
        {
            cbCatalog.Items.Clear();
            string[] ColumnList = { "id", "name" };
            DataTable dt = db.LoadAndReturnMultiRow(ColumnList, "tbl_catalog", "", "id");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbCatalog.Items.Add( dt.Rows[i]["name"].ToString());                     
                }
            }

        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            LoadDgItem();

            panelItem.Dock = DockStyle.Fill;
            panelItemAdd.Dock = DockStyle.Fill;

            panelItemAdd.Visible = false;

           

        }

        private void picAddItem_Click(object sender, EventArgs e)
        {
            panelItemAdd.Visible = true;
            panelItem.Visible = false;

            LoadCbCatalog();




            //MessageBox.Show("OK");
            //ucAddItem ucAddItem = new ucAddItem();
            //this.Controls.Add(ucAddItem);
            //frmItem frmAddItem = new frmItem();
            //frmAddItem.Show();     

 
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() ){
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    //pbItem.Image = new Bitmap(dlg.FileName);
                    pbItem.Image = Bitmap.FromFile(dlg.FileName);
                }
                dlg.Dispose();
            }
            

        }
        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }

            return stream.ToArray();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (File.Exists(dlg.FileName))
            {
                Foto = ImageToStream(dlg.FileName);
            }

            string[] ColumnList = {"id","cat_id","barcode","name","cost_price","sale_price","quantity","photo","date" };
            string[] DataList = { };

        }



    }
}
