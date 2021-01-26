using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdendityVerification
{
    public partial class IdentityVerification : Form
    {
        public IdentityVerification()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            long identityNumber = long.Parse(tbxIdentityNumber.Text);
            int yearOfBirth = int.Parse(tbxYearOfBirth.Text);

            bool? state;
            try
            {
                using (Identity.KPSPublicSoapClient servis = new Identity.KPSPublicSoapClient())
                {
                    state = servis.TCKimlikNoDogrula(identityNumber, tbxName.Text,
                        tbxLastName.Text, yearOfBirth);
                }
            }
            catch (Exception)
            {

                state = null;
            }
            MessageBox.Show(state.ToString());
        }

      
    }
}
