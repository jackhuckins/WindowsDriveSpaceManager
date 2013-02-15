using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_Drive_Space_Manager_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DiskSpaceResources.Resources.PrepareComboTable();
            cmbDisplaySize.DataSource = DiskSpaceResources.Resources.ComboTable;
            cmbDisplaySize.DisplayMember = "DisplayLong";
            cmbDisplaySize.ValueMember = "DisplayShort";
            cmbDisplaySize.SelectedIndex = 2;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DiskSpaceResources.Resources.PrepareDiskTable(cmbDisplaySize.SelectedValue.ToString());
            dgvResults.DataSource = DiskSpaceResources.Resources.DiskTable;
        }
    }
}
