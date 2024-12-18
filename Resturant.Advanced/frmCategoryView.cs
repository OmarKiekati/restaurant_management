using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Advanced
{
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }
        //public int id = 0 ;
        //public override void btn_click(object sender, EventArgs e)
        //{
        //} 

        public void GetData()
        {
            string qry = "select * from category where catName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            MainClass.loadData(qry , frmCategoryView , lb);
        }
        private void frmCategoryView_load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void btnAdd_Click(object sender, EventArgs e) 
        {
            frmCategoryAdd frm = new frmCategoryAdd();
            frm.ShowDialog();
            GetData();
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e) 
        {
            
        }
        GetData();
    }
}
