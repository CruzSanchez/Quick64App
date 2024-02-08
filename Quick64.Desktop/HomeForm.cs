using System.Buffers.Text;
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

            if (textToEncode is null)
            {
                return;
            }

            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(textToEncode));

            OutputTextBox.Text = encoded;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            var textToDecode = InputTextBox.Text;

            if (!Base64.IsValid(textToDecode))
            {
                MessageBox.Show("Text to decode contains no valid Base64 characters", "Invalid text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var decoded = Encoding.UTF8.GetString(Convert.FromBase64String(textToDecode));

            OutputTextBox.Text = decoded;
        }
    }
}
