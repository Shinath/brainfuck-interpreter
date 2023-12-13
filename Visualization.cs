using System.Text.RegularExpressions;


namespace BrainfuckInterpreter
{
    public partial class Visualization : Form
    {
        bool flag = true;
        Control ctr = new Control();
        string userInput;
        Terminal terminal;
        Interpreter interpreter;

        public Visualization(string userInput, Terminal terminal, Interpreter interpreter)
        {
            InitializeComponent();
            this.userInput = userInput;
            this.terminal = terminal;
            this.interpreter = interpreter;
        }

        public async Task Brain(string userInput, Terminal terminal)
        {
            int i = 0;
            ctr = this.SetBytePosition(i);
            int unmatchedBracketCounter = 0;
            for (int n = 0; n < userInput.Length; n++)
            {   
                ctr = this.SetBytePosition(i);
                await Task.Delay(250);
                int cont = Int32.Parse(ctr.Text);
                labelSingleChar.Text = userInput[n].ToString();

                switch (userInput[n])
                {
                    case '>':
                        i++;
                        break;

                    case '<':
                        i--;
                        break;

                    case '+':
                        cont++;
                        ctr.Text = cont.ToString();
                        break;

                    case '-':
                        cont--;
                        ctr.Text = cont.ToString();
                        break;

                    case '.':
                        terminal.PrintASCII(cont);
                        break;

                    case ',':
                        visualInput.Visible = true;
                        while (flag)
                        {
                            await Task.Delay(100);
                        }
                        flag = true;
                        break;

                    case '[':
                        if (cont == 0)
                        {
                            unmatchedBracketCounter++;
                            while (userInput[n] != ']' || unmatchedBracketCounter != 0)
                            {
                                n++;

                                if (userInput[n] == '[')
                                {
                                    unmatchedBracketCounter++;
                                }
                                else if (userInput[n] == ']')
                                {
                                    unmatchedBracketCounter--;
                                }
                            }
                        }
                        break;

                    case ']':
                        if (cont != 0)
                        {
                            unmatchedBracketCounter++;
                            while (userInput[n] != '[' || unmatchedBracketCounter != 0)
                            {
                                n--;

                                if (userInput[n] == ']')
                                {
                                    unmatchedBracketCounter++;
                                }
                                else if (userInput[n] == '[')
                                {
                                    unmatchedBracketCounter--;
                                }
                            }
                        }
                        break;
                }
            }
            
            visualReset.Enabled = true;
            terminal.NewLine();
        }

        public Control SetBytePosition(int i)
        {
            foreach (Control x in groupByte.Controls)
            {
                x.BackColor = Color.White;
            }
            int len = groupByte.Controls.Count - 1;
            Control control = groupByte.Controls[len-i];
            control.BackColor = Color.Red;
            return control;
        }

        private void EnterInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                if (EnterInput_Validation(visualInput.Text))
                {
                    visualInput.Text = null;
                }
                else
                {
                    ctr.Text = visualInput.Text;
                    visualInput.Visible = false;
                    visualInput.Text = null;
                    flag = false;
                }    
            }
        }

        private bool EnterInput_Validation(string input)
        {
            Regex rg = new Regex(@"[0-9]*");
            int matches = rg.Matches(input).Count;
            if (matches != input.Length)
            {
                MessageBox.Show("Proszę podać wartość liczbową");
                return true;
            }
            return false;
        }

        private void StartVisualization(object sender, EventArgs e)
        {

            Brain(userInput, terminal);
            visualStart.Enabled = false;
            visualReset.Enabled = false;
        }

        private void visualReset_Click(object sender, EventArgs e)
        {
            foreach (Control x in groupByte.Controls)
            {
                x.BackColor = Color.White;
                x.Text = "0"; 
            }
            visualStart.Enabled = true;
            visualReset.Enabled = false;
            labelSingleChar.Text = null; 
            interpreter.buttonSend.Enabled = true; 
        }
    }
}
