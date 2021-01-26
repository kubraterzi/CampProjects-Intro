using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikDogrulama
{
    public partial class IdentityVerification : Form
    {
        public IdentityVerification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long identityNumber = long.Parse(tbxIdentityNumber.Text);
            int yearOfBirth = int.Parse(tbxBirthYear.Text);

            bool? state;
            try
            {
                using (Idendity.KPSPublicSoapClient servis = new Idendity.KPSPublicSoapClient())
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
