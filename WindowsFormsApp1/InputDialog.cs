using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputDialog : Form
    {
        public string InputText => textBoxInput.Text;

        public InputDialog(string title, string prompt)
        {
            InitializeComponent();
            Text = title;
            lbPrompt.Text = prompt;
        }
    }
}
