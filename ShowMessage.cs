//using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    internal class ShowMessage
    {
        public static bool CheckAndShowErr(ref string ErrMsg)
        {
            if(ErrMsg != null)
            {
                MessageBox.Show(ErrMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrMsg = null;
                return false;
            }
            return true;
        }
        public static bool ConfirmationBox(string Msg)
        {
            var result = MessageBox.Show(Msg, "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) { return true; }
            return false;
        }
    }
}
