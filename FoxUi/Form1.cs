using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxUi
{
    public partial class FoxUI : Form
    {
        public FoxUI()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Click on export");
            
            DateTime starDate = startDatePicker.Value;
            DateTime stopDate = stopDatePicker.Value;

            System.Diagnostics.Debug.WriteLine(starDate);
            System.Diagnostics.Debug.WriteLine(stopDate);
            
            FoxDBConector foxDbConector = new FoxDBConector();
            
            foxDbConector.connect();

            DataTable testData = foxDbConector.GetYourData();

            int count = testData.Rows.Count;

            System.Diagnostics.Debug.WriteLine("Found " + count);



        }
    }
}
