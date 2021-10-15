using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*
 * @author Kareem Sherif
 * @version 1.0
 * @since 2021-10-01
 */

namespace ScientificCalculator
{
    public partial class MainForm : Form
    {
        // ========================== Rounding Edges ==========================//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );
        // =====================================================================//

        public MainForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }


        #region MOVABLE_BORDERLESS_FORM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void titlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region TITLEBAR_BUTTONS_CLICK_EVENTS
        // =========================== TITLEBAR BUTTONS CLICK EVENTS =========================== //
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // ===================================================================================== //
        #endregion

        #region HANDLE_USER_INPUT
        private void numericalInput_Click(object sender, EventArgs e)
        {
            manageCharacter(char.Parse((sender as Button).Text));
            toBeFocused.Focus();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            int digit = e.KeyValue - 96;
            if (digit > -1 && digit < 10)
                manageCharacter(char.Parse(digit.ToString()));
            else 
                switch (e.KeyCode)
                {
                    case Keys.Add:
                        manageCharacter('+');
                        break;
                    case Keys.Subtract:
                        manageCharacter('-');
                        break;
                    case Keys.Multiply:
                        manageCharacter('×');
                        break;
                    case Keys.Divide:
                        manageCharacter('÷');
                        break;
                    case Keys.Escape:
                        clear();
                        break;
                    case Keys.Enter:
                        evaluate();
                        break;
                }
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "0";
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void eqButton_Click(object sender, EventArgs e)
        {
            evaluate();
        }

        private bool lastCharIsDigit = true;
        private bool enterIsPressed = false;

        private void manageCharacter(char c)
        {
            if (char.IsDigit(c))
            {
                string currentPlaceHolder = answerLabel.Text;
                if (enterIsPressed)
                {
                    currentPlaceHolder = "0";
                    operationsLabel.Text = "";
                    enterIsPressed = false;
                }

                else if (!lastCharIsDigit)
                {
                    operationsLabel.Text = operationsLabel.Text + answerLabel.Text + " ";
                    currentPlaceHolder = "0";
                }

                int number = int.Parse(currentPlaceHolder);
                number = number * 10 + (c - '0');
                answerLabel.Text = number.ToString();
                lastCharIsDigit = true;
            }
            else
            {
                if (enterIsPressed)
                {
                    operationsLabel.Text = answerLabel.Text + " ";
                    enterIsPressed = false;
                }

                else if (lastCharIsDigit)
                    operationsLabel.Text = operationsLabel.Text + answerLabel.Text + " ";

                answerLabel.Text = c.ToString();
                lastCharIsDigit = false;
            }
        }

        private void clear()
        {
            answerLabel.Text = "0";
            operationsLabel.Text = "";
            lastCharIsDigit = true;
            enterIsPressed = false;
        }

        private void evaluate()
        {
            operationsLabel.Text = operationsLabel.Text + answerLabel.Text;
            string operation = "";

            for (int i = 0; i < operationsLabel.Text.Length; ++i)
                if (operationsLabel.Text[i] == '×')
                    operation += '*';
                else if (operationsLabel.Text[i] == '÷')
                    operation += '/';
                else
                    operation += operationsLabel.Text[i];

            answerLabel.Text = (new DataTable().Compute(operation, null)).ToString();
            operationsLabel.Text += " =";
            enterIsPressed = true;
        }
        #endregion
        
    }
}
