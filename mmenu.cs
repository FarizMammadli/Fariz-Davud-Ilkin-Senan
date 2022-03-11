using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shebeke
{
    public partial class mmenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public mmenu()
        {
            InitializeComponent();
        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rule r =new rule();
            r.Show();
        }
    }
}
