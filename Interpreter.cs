using System.Text.RegularExpressions;

namespace BrainfuckInterpreter
{
    public partial class Interpreter : Form
    {
        Terminal terminal = null;
        Visualization visualization = null;

        public Interpreter()
        {
            InitializeComponent();
        }

        public void OnClick(object sender, EventArgs e)
        {
            

            string userInput = mainTextBox.Text.Trim();
            if (InputValidation(userInput))
            {
                Interpreter interpreter = new Interpreter();
                this.Hide();
                interpreter.Show();
            }
            else
            {

                if (terminal == null)
                {
                    terminal = new Terminal();
                }
                if (visualization != null)
                {
                    visualization.Hide();
                }
                visualization = new Visualization(userInput, terminal, this);
                buttonSend.Enabled = false;
                visualization.Show();
                terminal.Show();
            }
        }

        public bool InputValidation(string input)
        {
            Regex rg = new Regex(@"[<>+-\.,\[\]]");
            MatchCollection matches = rg.Matches(input);
            int numberOfMatches = matches.Count;
            if (numberOfMatches != input.Length)
            {
                MessageBox.Show("Kod zawiera niedozwolone znaki");
                return true;
            }

            rg = new Regex(@">");
            int numberOfMatches1 = rg.Matches(input).Count;

            rg = new Regex(@"<");
            int numberOfMatches2 = rg.Matches(input).Count; 

            if (numberOfMatches1 - numberOfMatches2 > 30)
            {
                MessageBox.Show("Podany kod wyjdzie poza skale dostêpnych bajtów (30)");
                return true;
            }

            return false;
        }
    }
}