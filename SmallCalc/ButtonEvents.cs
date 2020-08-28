using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmallCalc
{
    class ButtonEvents
    {
        private ButtonEvents()
        { }

        public static void onButton1Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("1");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton2Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("2");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton3Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("3");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton4Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("4");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton5Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("5");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton6Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("6");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton7Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("7");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton8Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("8");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton9Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("9");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onButton0Click(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("0");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onBackButtonClick(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().removeInput();
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onEqualsButtonClick(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().
                setSolution(StringParser.parseStringToSolution(InputHandle.getInputHandleInstance().getInputText()));
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onAddButtonClick(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("+");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onSubtractButtonClick(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("-");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onMultiplyButtonClick(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("*");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onDivideButtonClick(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("/");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onOpenBracketButton(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput("(");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onCloseBracketButton(object sender, System.EventArgs e)
        {
            InputHandle.getInputHandleInstance().appendInput(")");
            ((Form1)((Button)sender).Parent).updateTextBox();
        }

        public static void onKeyPress(object sender, KeyEventArgs e)
        {
            if(Control.ModifierKeys==Keys.Shift)
            {
                switch(e.KeyCode)
                {
                    case Keys.Enter:
                        InputHandle.getInputHandleInstance().
                            setSolution(StringParser.parseStringToSolution(InputHandle.getInputHandleInstance().getInputText()));
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.Back:
                        InputHandle.getInputHandleInstance().removeInput();
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.Oemplus:
                        InputHandle.getInputHandleInstance().appendInput("*");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.D7:
                        InputHandle.getInputHandleInstance().appendInput("/");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.D8:
                        InputHandle.getInputHandleInstance().appendInput("(");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.D9:
                        InputHandle.getInputHandleInstance().appendInput(")");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad1:
                        InputHandle.getInputHandleInstance().appendInput("1");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad2:
                        InputHandle.getInputHandleInstance().appendInput("2");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad3:
                        InputHandle.getInputHandleInstance().appendInput("3");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad4:
                        InputHandle.getInputHandleInstance().appendInput("4");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad5:
                        InputHandle.getInputHandleInstance().appendInput("5");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad6:
                        InputHandle.getInputHandleInstance().appendInput("6");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad7:
                        InputHandle.getInputHandleInstance().appendInput("7");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad8:
                        InputHandle.getInputHandleInstance().appendInput("8");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad9:
                        InputHandle.getInputHandleInstance().appendInput("9");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.NumPad0:
                        InputHandle.getInputHandleInstance().appendInput("0");
                        ((Form1)sender).updateTextBox();
                        break;
                    case Keys.Space:
                        InputHandle.getInputHandleInstance().appendInput(" ");
                        ((Form1)sender).updateTextBox();
                        break;
                }
                return;
            }
            switch(e.KeyCode)
            {
                case Keys.Space:
                    InputHandle.getInputHandleInstance().appendInput(" ");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Oemplus:
                    InputHandle.getInputHandleInstance().appendInput("+");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.OemMinus:
                    InputHandle.getInputHandleInstance().appendInput("-");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Enter:
                    InputHandle.getInputHandleInstance().
                        setSolution(StringParser.parseStringToSolution(InputHandle.getInputHandleInstance().getInputText()));
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Back:
                    InputHandle.getInputHandleInstance().removeInput();
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D1:
                    InputHandle.getInputHandleInstance().appendInput("1");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D2:
                    InputHandle.getInputHandleInstance().appendInput("2");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D3:
                    InputHandle.getInputHandleInstance().appendInput("3");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D4:
                    InputHandle.getInputHandleInstance().appendInput("4");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D5:
                    InputHandle.getInputHandleInstance().appendInput("5");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D6:
                    InputHandle.getInputHandleInstance().appendInput("6");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D7:
                    InputHandle.getInputHandleInstance().appendInput("7");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D8:
                    InputHandle.getInputHandleInstance().appendInput("8");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D9:
                    InputHandle.getInputHandleInstance().appendInput("9");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.D0:
                    InputHandle.getInputHandleInstance().appendInput("0");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Subtract:
                    InputHandle.getInputHandleInstance().appendInput("-");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Add:
                    InputHandle.getInputHandleInstance().appendInput("+");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Divide:
                    InputHandle.getInputHandleInstance().appendInput("/");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.Multiply:
                    InputHandle.getInputHandleInstance().appendInput("*");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad1:
                    InputHandle.getInputHandleInstance().appendInput("1");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad2:
                    InputHandle.getInputHandleInstance().appendInput("2");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad3:
                    InputHandle.getInputHandleInstance().appendInput("3");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad4:
                    InputHandle.getInputHandleInstance().appendInput("4");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad5:
                    InputHandle.getInputHandleInstance().appendInput("5");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad6:
                    InputHandle.getInputHandleInstance().appendInput("6");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad7:
                    InputHandle.getInputHandleInstance().appendInput("7");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad8:
                    InputHandle.getInputHandleInstance().appendInput("8");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad9:
                    InputHandle.getInputHandleInstance().appendInput("9");
                    ((Form1)sender).updateTextBox();
                    break;
                case Keys.NumPad0:
                    InputHandle.getInputHandleInstance().appendInput("0");
                    ((Form1)sender).updateTextBox();
                    break;
            }
        }
    }

}
