using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            this.listBox1.Items.AddRange(System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.AllCultures));
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem is CultureInfo culture)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = culture;
                System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

                var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

                foreach (Control ctl in this.Controls)
                {
                    resources.ApplyResources(ctl, ctl.Name);
                }

            }
        }
    }
}
