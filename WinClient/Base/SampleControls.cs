using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinClient.Base
{
    /// <summary>
    /// Repozytorium podstawowych kontrolek. Bez znaczenia dla aplikacji.
    /// </summary>
    public partial class SampleControls : Form
    {
        public SampleControls()
        {
            IList<GuiSample> colection = new List<GuiSample>();
            colection.Add(new GuiSample() { lp = "1", Nazwa = "Nazwa 1", Wartość = "Wartość 1"});
            colection.Add(new GuiSample() { lp = "2", Nazwa = "Nazwa 2", Wartość = "Wartość 2"});
            colection.Add(new GuiSample() { lp = "3", Nazwa = "Nazwa 3", Wartość = "Wartość 3"});

            InitializeComponent();
            dataGridView1.DataSource = colection;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class GuiSample
    {
        public string lp { set; get; }
        public string Nazwa { set; get; }
        public string Wartość { set; get; }
    }
}
