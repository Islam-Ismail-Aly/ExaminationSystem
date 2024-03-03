using Examination.PresentationLayer.CustomMaterialDesign;
using System.Runtime.CompilerServices;

namespace Examination.PresentationLayer.Helpers
{
    public class CustomHelperManager
    {
        private static Button currentBtn;
        private static Form activeFrm;

        public static void ExitHelper()
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("The application will not exit.");
            }
        }

        public static void ActiveBtnHelper(object sender, Control panelControl)
        {
            if (sender != null)
            {
                if (currentBtn != (Button)sender)
                {
                    DisableBtnHelper(panelControl);
                    Color color = Color.DeepSkyBlue;
                    currentBtn = (Button)sender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        private static void DisableBtnHelper(Control panelControl)
        {
            foreach (Control prevBtn in panelControl.Controls)
            {
                if (prevBtn.GetType() == typeof(RButton))
                {
                    prevBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        public static void ChildForm(Form childfrm, object btnSender, Control panelControl, Control panelContent, Control labelTitle)
        {
            if (activeFrm != null)
            {
                activeFrm.Close();
            }

            ActiveBtnHelper(btnSender, panelControl);
            activeFrm = childfrm;
            childfrm.TopLevel = false;
            childfrm.FormBorderStyle = FormBorderStyle.None;
            childfrm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childfrm);
            panelContent.Tag = childfrm;
            childfrm.BringToFront();
            childfrm.Show();
            labelTitle.Text = childfrm.Text.Trim();
        }
    }
}
