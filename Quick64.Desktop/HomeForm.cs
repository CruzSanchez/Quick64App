using System.Text;

namespace Quick64.Desktop
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            var textToEncode = InputTextBox.Text;

            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(textToEncode));

            OutputTextBox.Text = encoded;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            var textToDecode = InputTextBox.Text;

            var decoded = Encoding.UTF8.GetString(Convert.FromBase64String(textToDecode));

            OutputTextBox.Text = decoded;
        }
    }
}
