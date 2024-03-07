namespace Examination.PresentationLayer.Forms
{
    public partial class Splashfrm : Form
    {
        private const int TargetPanelWidth = 522;
        private const int PanelWidthIncrement = 2;

        public Splashfrm()
        {
            InitializeComponent();
            timer_1.Interval = 28;
            timer_1.Start();
        }

        private void Splashfrm_Load(object sender, EventArgs e)
        {

        }

        private void timer_1_Tick(object sender, EventArgs e)
        {
            panel_1.Width += PanelWidthIncrement;

            if (panel_1.Width >= TargetPanelWidth)
            {
                timer_1.Stop();
                ShowLoginForm();
            }
        }

        private void ShowLoginForm()
        {
            try
            {
                Login login = new Login();
                login.FormClosed += Login_FormClosed;
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while showing login form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_FormClosed;
            this.Close();
        }
    }
}
