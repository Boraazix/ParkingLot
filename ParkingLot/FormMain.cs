namespace ParkingLot
{
    public partial class FormMain : Form
    {
        public static User UserLogged { get; set; }
        private static FormMain _instance;
        public FormMain()
        {
            InitializeComponent();
        }
        public static FormMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormMain();
            }
            _instance.WindowState = FormWindowState.Maximized;
            return _instance;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.GetInstance().Show();
            UserLogged = null;
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuFileLogoff_Click(object sender, EventArgs e)
        {
            FormLogin.GetInstance().Show();
            this.Close();
            UserLogged = null;
        }
    }
}
