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
            cmbType.Items.Add("FixedDialog");
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
            FormTest.frmCreate testDialog = new FormTest.frmCreate();

            // 속성 설정
            if (cmbType.SelectedIndex == 0)
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            else if (cmbType.SelectedIndex == 1)
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            else if (cmbType.SelectedIndex == 2)
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            else if (cmbType.SelectedIndex == 3)
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            else if (cmbType.SelectedIndex == 4)
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            else if (cmbType.SelectedIndex == 5)
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            else
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;

            if (cmbPos.SelectedIndex == 0)
                testDialog.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            else if (cmbPos.SelectedIndex == 1)
                testDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            else if (cmbPos.SelectedIndex == 2)
                testDialog.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            else if (cmbPos.SelectedIndex == 3)
                testDialog.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            else
                testDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // 속성에 맞는 문자열 출력
            testDialog.lblType.Text = cmbType.SelectedItem.ToString();
            testDialog.lblPos.Text = cmbType.SelectedItem.ToString();

            if (cmbMode.SelectedIndex == 0)
            {
                testDialog.ShowDialog(this);
                testDialog.Dispose();
            }
            else
            {
                testDialog.Show();
            }
        }
    }
}
