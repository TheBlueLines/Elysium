namespace Elysium
{
    public partial class NewServer : Form
    {
        public string selected = string.Empty;
        public NewServer()
        {
            InitializeComponent();
        }
        private void Create_Click(object sender, EventArgs e)
        {
            Submit(name.Text);
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Submit(name.Text);
            }
        }
        private void Submit(string? text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                selected = text;
                Close();
            }
        }
    }
}
