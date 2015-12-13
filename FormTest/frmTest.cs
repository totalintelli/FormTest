using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            // 콤보 상자 초기값 설정
            cmbType.Items.Add("None");
            cmbType.Items.Add("FixedSingle");
            cmbType.Items.Add("Fixed3D");
            cmbType.Items.Add("FoxedDialog");
            cmbType.Items.Add("Sizable");
            cmbType.Items.Add("FixedToolWindow");
            cmbType.Items.Add("SizableToolWindow");

            cmbPos.Items.Add("Manual");
            cmbPos.Items.Add("CenterScreen");
            cmbPos.Items.Add("WindowsDafaultLocation");
            cmbPos.Items.Add("WindowsDefaultBounds");
            cmbPos.Items.Add("CenterParent");

            cmbMode.Items.Add("모달");
            cmbMode.Items.Add("모달리스");

            // 초기 선택값 설정
            cmbType.SelectedIndex = 0;
            cmbPos.SelectedIndex = 0;
            cmbMode.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
