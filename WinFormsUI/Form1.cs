using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadPerson();
        }

        private void LoadPerson()
        {
            try
            {
                if (tbLoad.Text != null && tbLoad.Text.Length > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    int temp;
                    Int32.TryParse(tbLoad.Text, out temp);
                    this.personEditBindingSource.DataSource = Library.Net.PersonEdit.GetPerson(temp);
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
