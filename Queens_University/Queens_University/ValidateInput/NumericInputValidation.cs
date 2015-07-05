using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queens_University.ValidateInput
{
    class NumericInputValidation
    {
        /// <summary>
        /// Make sure that Average Field can only add numeric vales   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void IsValidNmericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show(Constants.VALIDATION_FAIL);
                e.Handled = true;
            }
        }
    }
}
