
namespace BrainfuckInterpreter
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
            terminalLabel.Text = "-> ";
        }

        public void PrintASCII (int cont)
        {
            char c = (char)cont;
            terminalLabel.Text += c;
        }

        public void NewLine()
        {
            terminalLabel.Text = terminalLabel.Text + "\n-> ";
        }
    }
}
