namespace GraphOfFunction
{
    partial class FormFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.colorDialogFunction = new System.Windows.Forms.ColorDialog();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelFunction = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonBrackets = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonBrachetClosing = new System.Windows.Forms.Button();
            this.buttonBracketOpening = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonCtg = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAbs = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Location = new System.Drawing.Point(17, 42);
            this.textBoxFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFunction.Multiline = true;
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(529, 63);
            this.textBoxFunction.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 341);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(120, 28);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Сохранить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(140, 341);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColor.Location = new System.Drawing.Point(17, 288);
            this.panelColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(531, 28);
            this.panelColor.TabIndex = 3;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Location = new System.Drawing.Point(17, 18);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(67, 17);
            this.labelFunction.TabIndex = 4;
            this.labelFunction.Text = "Функции";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(13, 268);
            this.labelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(41, 17);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Цвет";
            // 
            // buttonBrackets
            // 
            this.buttonBrackets.Location = new System.Drawing.Point(17, 114);
            this.buttonBrackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrackets.Name = "buttonBrackets";
            this.buttonBrackets.Size = new System.Drawing.Size(100, 28);
            this.buttonBrackets.TabIndex = 6;
            this.buttonBrackets.Text = "()";
            this.buttonBrackets.UseVisualStyleBackColor = true;
            this.buttonBrackets.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(448, 114);
            this.buttonE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(100, 28);
            this.buttonE.TabIndex = 7;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Location = new System.Drawing.Point(341, 114);
            this.buttonPi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(100, 28);
            this.buttonPi.TabIndex = 8;
            this.buttonPi.Text = "pi";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonBrachetClosing
            // 
            this.buttonBrachetClosing.Location = new System.Drawing.Point(233, 114);
            this.buttonBrachetClosing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrachetClosing.Name = "buttonBrachetClosing";
            this.buttonBrachetClosing.Size = new System.Drawing.Size(100, 28);
            this.buttonBrachetClosing.TabIndex = 9;
            this.buttonBrachetClosing.Text = ")";
            this.buttonBrachetClosing.UseVisualStyleBackColor = true;
            this.buttonBrachetClosing.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonBracketOpening
            // 
            this.buttonBracketOpening.Location = new System.Drawing.Point(125, 114);
            this.buttonBracketOpening.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBracketOpening.Name = "buttonBracketOpening";
            this.buttonBracketOpening.Size = new System.Drawing.Size(100, 28);
            this.buttonBracketOpening.TabIndex = 10;
            this.buttonBracketOpening.Text = "(";
            this.buttonBracketOpening.UseVisualStyleBackColor = true;
            this.buttonBracketOpening.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.Location = new System.Drawing.Point(125, 150);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(100, 28);
            this.buttonCos.TabIndex = 15;
            this.buttonCos.Text = "cos()";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.Location = new System.Drawing.Point(233, 150);
            this.buttonTan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(100, 28);
            this.buttonTan.TabIndex = 14;
            this.buttonTan.Text = "tan()";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonCtg
            // 
            this.buttonCtg.Location = new System.Drawing.Point(341, 150);
            this.buttonCtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new System.Drawing.Size(100, 28);
            this.buttonCtg.TabIndex = 13;
            this.buttonCtg.Text = "ctg()";
            this.buttonCtg.UseVisualStyleBackColor = true;
            this.buttonCtg.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(448, 150);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(100, 28);
            this.buttonLog.TabIndex = 12;
            this.buttonLog.Text = "log()";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.Location = new System.Drawing.Point(17, 150);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(100, 28);
            this.buttonSin.TabIndex = 11;
            this.buttonSin.Text = "sin()";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(125, 186);
            this.buttonSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(100, 28);
            this.buttonSub.TabIndex = 20;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(233, 186);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(100, 28);
            this.buttonMul.TabIndex = 19;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(341, 186);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(100, 28);
            this.buttonDiv.TabIndex = 18;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.Location = new System.Drawing.Point(448, 186);
            this.buttonPow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(100, 28);
            this.buttonPow.TabIndex = 17;
            this.buttonPow.Text = "^";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(17, 186);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonAbs
            // 
            this.buttonAbs.Location = new System.Drawing.Point(17, 222);
            this.buttonAbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbs.Name = "buttonAbs";
            this.buttonAbs.Size = new System.Drawing.Size(100, 28);
            this.buttonAbs.TabIndex = 21;
            this.buttonAbs.Text = "abs()";
            this.buttonAbs.UseVisualStyleBackColor = true;
            this.buttonAbs.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(125, 222);
            this.buttonX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(100, 28);
            this.buttonX.TabIndex = 22;
            this.buttonX.Text = "x";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 382);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonAbs);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCtg);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonBracketOpening);
            this.Controls.Add(this.buttonBrachetClosing);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonBrackets);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelFunction);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxFunction);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFunction";
            this.Text = "FormFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ColorDialog colorDialogFunction;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonBrackets;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonBrachetClosing;
        private System.Windows.Forms.Button buttonBracketOpening;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonCtg;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAbs;
        private System.Windows.Forms.Button buttonX;
    }
}