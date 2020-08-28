using System.Windows.Forms;

namespace SmallCalc
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void SetClickEvents()
        {
            this.equalsButton.Click += new System.EventHandler(ButtonEvents.onEqualsButtonClick);
            this.divideButton.Click += new System.EventHandler(ButtonEvents.onDivideButtonClick);
            this.subtactButton.Click += new System.EventHandler(ButtonEvents.onSubtractButtonClick);
            this.addButton.Click += new System.EventHandler(ButtonEvents.onAddButtonClick);
            this.multiplyButton.Click += new System.EventHandler(ButtonEvents.onMultiplyButtonClick);
            this.button1.Click += new System.EventHandler(ButtonEvents.onButton1Click);
            this.button2.Click += new System.EventHandler(ButtonEvents.onButton2Click);
            this.button3.Click += new System.EventHandler(ButtonEvents.onButton3Click);
            this.button4.Click += new System.EventHandler(ButtonEvents.onButton4Click);
            this.button5.Click += new System.EventHandler(ButtonEvents.onButton5Click);
            this.button6.Click += new System.EventHandler(ButtonEvents.onButton6Click);
            this.button7.Click += new System.EventHandler(ButtonEvents.onButton7Click);
            this.button8.Click += new System.EventHandler(ButtonEvents.onButton8Click);
            this.button9.Click += new System.EventHandler(ButtonEvents.onButton9Click);
            this.button0.Click += new System.EventHandler(ButtonEvents.onButton0Click);
            this.backButton.Click += new System.EventHandler(ButtonEvents.onBackButtonClick);
            this.openBracketButton.Click += new System.EventHandler(ButtonEvents.onOpenBracketButton);
            this.closeBracketButton.Click += new System.EventHandler(ButtonEvents.onCloseBracketButton);
            this.updateTextBox();
            this.KeyDown += new KeyEventHandler(ButtonEvents.onKeyPress);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {            
            this.equalsButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.subtactButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.openBracketButton = new System.Windows.Forms.Button();
            this.closeBracketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equalsButton
            // 
            this.equalsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(615, 315);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(126, 80);
            this.equalsButton.TabIndex = 0;
            this.equalsButton.TabStop = false;
            this.equalsButton.Text = "=";
            // 
            // divideButton
            // 
            this.divideButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(681, 229);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(60, 80);
            this.divideButton.TabIndex = 1;
            this.divideButton.TabStop = false;
            this.divideButton.Text = "/";
            // 
            // subtactButton
            // 
            this.subtactButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.subtactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtactButton.Location = new System.Drawing.Point(681, 143);
            this.subtactButton.Name = "subtactButton";
            this.subtactButton.Size = new System.Drawing.Size(60, 80);
            this.subtactButton.TabIndex = 2;
            this.subtactButton.TabStop = false;
            this.subtactButton.Text = "-";
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(615, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 80);
            this.addButton.TabIndex = 3;
            this.addButton.TabStop = false;
            this.addButton.Text = "+";
            // 
            // multiplyButton
            // 
            this.multiplyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(615, 229);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(60, 80);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.TabStop = false;
            this.multiplyButton.Text = "*";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(54, 12);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(687, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 33);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(89, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 33);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(124, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 33);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(159, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 33);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(194, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 33);
            this.button5.TabIndex = 9;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(54, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 33);
            this.button6.TabIndex = 10;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(89, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 33);
            this.button7.TabIndex = 11;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            // 
            // button8
            // 
            this.button8.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(124, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 33);
            this.button8.TabIndex = 12;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            // 
            // button9
            // 
            this.button9.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(159, 192);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 33);
            this.button9.TabIndex = 13;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            // 
            // button0
            // 
            this.button0.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(194, 192);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(29, 33);
            this.button0.TabIndex = 14;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(483, 153);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 33);
            this.backButton.TabIndex = 15;
            this.backButton.TabStop = false;
            this.backButton.Text = "<--";
            // 
            // solutionBox
            // 
            this.solutionBox.Location = new System.Drawing.Point(54, 50);
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.ReadOnly = true;
            this.solutionBox.Size = new System.Drawing.Size(687, 20);
            this.solutionBox.TabIndex = 16;
            this.solutionBox.TabStop = false;
            // 
            // openBracketButton
            // 
            this.openBracketButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.openBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBracketButton.Location = new System.Drawing.Point(229, 153);
            this.openBracketButton.Name = "openBracketButton";
            this.openBracketButton.Size = new System.Drawing.Size(29, 33);
            this.openBracketButton.TabIndex = 17;
            this.openBracketButton.TabStop = false;
            this.openBracketButton.Text = "(";
            // 
            // closeBracketButton
            // 
            this.closeBracketButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBracketButton.Location = new System.Drawing.Point(229, 192);
            this.closeBracketButton.Name = "closeBracketButton";
            this.closeBracketButton.Size = new System.Drawing.Size(29, 33);
            this.closeBracketButton.TabIndex = 18;
            this.closeBracketButton.TabStop = false;
            this.closeBracketButton.Text = ")";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeBracketButton);
            this.Controls.Add(this.openBracketButton);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtactButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.textBox);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SmallCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void updateTextBox()
        {
            this.textBox.Text = InputHandle.getInputHandleInstance().getInputText();
            this.solutionBox.Text = "Solution: "+InputHandle.getInputHandleInstance().getSolution();
        }

        #endregion

        private Button equalsButton;
        private Button divideButton;
        private Button subtactButton;
        private Button addButton;
        private Button multiplyButton;
        private TextBox textBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button backButton;
        private TextBox solutionBox;
        private Button openBracketButton;
        private Button closeBracketButton;
    }
}

