namespace GraphOfFunction
{
    partial class FormMy
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGraphFunction = new System.Windows.Forms.Panel();
            this.labelMinX = new System.Windows.Forms.Label();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.labelMinY = new System.Windows.Forms.Label();
            this.labelMaxY = new System.Windows.Forms.Label();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.textBoxMinY = new System.Windows.Forms.TextBox();
            this.groupBoxDiapason = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxFunctions = new System.Windows.Forms.ListBox();
            this.groupBoxDiapason.SuspendLayout();
            this.groupBoxFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGraphFunction
            // 
            this.panelGraphFunction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGraphFunction.Location = new System.Drawing.Point(15, 15);
            this.panelGraphFunction.Margin = new System.Windows.Forms.Padding(4);
            this.panelGraphFunction.Name = "panelGraphFunction";
            this.panelGraphFunction.Size = new System.Drawing.Size(586, 501);
            this.panelGraphFunction.TabIndex = 1;
            this.panelGraphFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraphFunction_Paint);
            // 
            // labelMinX
            // 
            this.labelMinX.AutoSize = true;
            this.labelMinX.Location = new System.Drawing.Point(112, 80);
            this.labelMinX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinX.Name = "labelMinX";
            this.labelMinX.Size = new System.Drawing.Size(39, 16);
            this.labelMinX.TabIndex = 3;
            this.labelMinX.Text = "Min X";
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Location = new System.Drawing.Point(323, 80);
            this.labelMaxX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(43, 16);
            this.labelMaxX.TabIndex = 4;
            this.labelMaxX.Text = "Max X";
            // 
            // labelMinY
            // 
            this.labelMinY.AutoSize = true;
            this.labelMinY.Location = new System.Drawing.Point(112, 112);
            this.labelMinY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinY.Name = "labelMinY";
            this.labelMinY.Size = new System.Drawing.Size(40, 16);
            this.labelMinY.TabIndex = 5;
            this.labelMinY.Text = "Min Y";
            // 
            // labelMaxY
            // 
            this.labelMaxY.AutoSize = true;
            this.labelMaxY.Location = new System.Drawing.Point(323, 112);
            this.labelMaxY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxY.Name = "labelMaxY";
            this.labelMaxY.Size = new System.Drawing.Size(44, 16);
            this.labelMaxY.TabIndex = 6;
            this.labelMaxY.Text = "Max Y";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(175, 76);
            this.textBoxMinX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(111, 22);
            this.textBoxMinX.TabIndex = 7;
            this.textBoxMinX.Text = "-5";
            this.textBoxMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(386, 76);
            this.textBoxMaxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(111, 22);
            this.textBoxMaxX.TabIndex = 8;
            this.textBoxMaxX.Text = "5";
            this.textBoxMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(386, 108);
            this.textBoxMaxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(111, 22);
            this.textBoxMaxY.TabIndex = 9;
            this.textBoxMaxY.Text = "5";
            this.textBoxMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Location = new System.Drawing.Point(175, 108);
            this.textBoxMinY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.Size = new System.Drawing.Size(111, 22);
            this.textBoxMinY.TabIndex = 10;
            this.textBoxMinY.Text = "-5";
            this.textBoxMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxDiapason
            // 
            this.groupBoxDiapason.Controls.Add(this.buttonRefresh);
            this.groupBoxDiapason.Controls.Add(this.textBoxMinX);
            this.groupBoxDiapason.Controls.Add(this.labelMinX);
            this.groupBoxDiapason.Controls.Add(this.labelMaxY);
            this.groupBoxDiapason.Controls.Add(this.textBoxMinY);
            this.groupBoxDiapason.Controls.Add(this.textBoxMaxX);
            this.groupBoxDiapason.Controls.Add(this.labelMaxX);
            this.groupBoxDiapason.Controls.Add(this.labelMinY);
            this.groupBoxDiapason.Controls.Add(this.textBoxMaxY);
            this.groupBoxDiapason.Location = new System.Drawing.Point(633, 272);
            this.groupBoxDiapason.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDiapason.Name = "groupBoxDiapason";
            this.groupBoxDiapason.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDiapason.Size = new System.Drawing.Size(610, 244);
            this.groupBoxDiapason.TabIndex = 13;
            this.groupBoxDiapason.TabStop = false;
            this.groupBoxDiapason.Text = "Диапазоны значений";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(266, 165);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 28);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Controls.Add(this.buttonDelete);
            this.groupBoxFunctions.Controls.Add(this.buttonEdit);
            this.groupBoxFunctions.Controls.Add(this.buttonAdd);
            this.groupBoxFunctions.Controls.Add(this.listBoxFunctions);
            this.groupBoxFunctions.Location = new System.Drawing.Point(633, 15);
            this.groupBoxFunctions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFunctions.Size = new System.Drawing.Size(610, 249);
            this.groupBoxFunctions.TabIndex = 14;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Список функций";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(376, 203);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(266, 204);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(158, 204);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxFunctions
            // 
            this.listBoxFunctions.FormattingEnabled = true;
            this.listBoxFunctions.ItemHeight = 16;
            this.listBoxFunctions.Location = new System.Drawing.Point(8, 32);
            this.listBoxFunctions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFunctions.MultiColumn = true;
            this.listBoxFunctions.Name = "listBoxFunctions";
            this.listBoxFunctions.Size = new System.Drawing.Size(594, 164);
            this.listBoxFunctions.TabIndex = 0;
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 539);
            this.Controls.Add(this.groupBoxFunctions);
            this.Controls.Add(this.groupBoxDiapason);
            this.Controls.Add(this.panelGraphFunction);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMy";
            this.Text = "FormHome";
            this.groupBoxDiapason.ResumeLayout(false);
            this.groupBoxDiapason.PerformLayout();
            this.groupBoxFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGraphFunction;
        private System.Windows.Forms.Label labelMinX;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.Label labelMinY;
        private System.Windows.Forms.Label labelMaxY;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.TextBox textBoxMinY;
        private System.Windows.Forms.GroupBox groupBoxDiapason;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxFunctions;
        private System.Windows.Forms.Button buttonRefresh;

    }
}

