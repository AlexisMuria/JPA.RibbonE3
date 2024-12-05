using JPA.Ribbon_E3_xml;
using System;
using System.Windows.Forms;

namespace JPA.RibbonE3
{
    public partial class TaskPaneControl : UserControl
    {

        public TaskPaneControl()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Btn_configuración_Click(object sender, EventArgs e)
        {
            ConfigImpresoras config = new ConfigImpresoras();
            config.ShowDialog();
        }
    }
}
