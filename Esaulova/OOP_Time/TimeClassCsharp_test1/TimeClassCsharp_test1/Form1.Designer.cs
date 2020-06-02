namespace TimeClassCsharp_test1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonRes = new System.Windows.Forms.Button();
			this.textBoxRes = new System.Windows.Forms.TextBox();
			this.tBxT1_Ds = new System.Windows.Forms.TextBox();
			this.tBxT1_Hs = new System.Windows.Forms.TextBox();
			this.tBxT1_Ms = new System.Windows.Forms.TextBox();
			this.tBxT1_Ss = new System.Windows.Forms.TextBox();
			this.lblT1_title = new System.Windows.Forms.Label();
			this.lblT1_D = new System.Windows.Forms.Label();
			this.lblT1_H = new System.Windows.Forms.Label();
			this.lblT1_M = new System.Windows.Forms.Label();
			this.lblT1_S = new System.Windows.Forms.Label();
			this.lblT2_S = new System.Windows.Forms.Label();
			this.lblT2_M = new System.Windows.Forms.Label();
			this.lblT2_H = new System.Windows.Forms.Label();
			this.lblT2_D = new System.Windows.Forms.Label();
			this.lblT2_title = new System.Windows.Forms.Label();
			this.tBxT2_Ss = new System.Windows.Forms.TextBox();
			this.tBxT2_Ms = new System.Windows.Forms.TextBox();
			this.tBxT2_Hs = new System.Windows.Forms.TextBox();
			this.tBxT2_Ds = new System.Windows.Forms.TextBox();
			this.cmbBxOperator = new System.Windows.Forms.ComboBox();
			this.lblOp = new System.Windows.Forms.Label();
			this.labelPrgmTitle = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonRes
			// 
			this.buttonRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRes.Location = new System.Drawing.Point(12, 165);
			this.buttonRes.Name = "buttonRes";
			this.buttonRes.Size = new System.Drawing.Size(444, 25);
			this.buttonRes.TabIndex = 0;
			this.buttonRes.Text = "Показать результаты";
			this.buttonRes.UseVisualStyleBackColor = true;
			this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
			// 
			// textBoxRes
			// 
			this.textBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxRes.Location = new System.Drawing.Point(12, 196);
			this.textBoxRes.Multiline = true;
			this.textBoxRes.Name = "textBoxRes";
			this.textBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxRes.Size = new System.Drawing.Size(444, 177);
			this.textBoxRes.TabIndex = 1;
			// 
			// tBxT1_Ds
			// 
			this.tBxT1_Ds.Location = new System.Drawing.Point(43, 61);
			this.tBxT1_Ds.Name = "tBxT1_Ds";
			this.tBxT1_Ds.Size = new System.Drawing.Size(75, 20);
			this.tBxT1_Ds.TabIndex = 2;
			this.tBxT1_Ds.Text = "0";
			this.tBxT1_Ds.Click += new System.EventHandler(this.tBxT1_Ds_Click);
			// 
			// tBxT1_Hs
			// 
			this.tBxT1_Hs.Location = new System.Drawing.Point(43, 87);
			this.tBxT1_Hs.Name = "tBxT1_Hs";
			this.tBxT1_Hs.Size = new System.Drawing.Size(75, 20);
			this.tBxT1_Hs.TabIndex = 3;
			this.tBxT1_Hs.Text = "0";
			this.tBxT1_Hs.Click += new System.EventHandler(this.tBxT1_Hs_Click);
			// 
			// tBxT1_Ms
			// 
			this.tBxT1_Ms.Location = new System.Drawing.Point(43, 113);
			this.tBxT1_Ms.Name = "tBxT1_Ms";
			this.tBxT1_Ms.Size = new System.Drawing.Size(75, 20);
			this.tBxT1_Ms.TabIndex = 4;
			this.tBxT1_Ms.Text = "0";
			this.tBxT1_Ms.Click += new System.EventHandler(this.tBxT1_Ms_Click);
			// 
			// tBxT1_Ss
			// 
			this.tBxT1_Ss.Location = new System.Drawing.Point(43, 139);
			this.tBxT1_Ss.Name = "tBxT1_Ss";
			this.tBxT1_Ss.Size = new System.Drawing.Size(75, 20);
			this.tBxT1_Ss.TabIndex = 5;
			this.tBxT1_Ss.Text = "0";
			this.tBxT1_Ss.Click += new System.EventHandler(this.tBxT1_Ss_Click);
			// 
			// lblT1_title
			// 
			this.lblT1_title.AutoSize = true;
			this.lblT1_title.Location = new System.Drawing.Point(40, 45);
			this.lblT1_title.Name = "lblT1_title";
			this.lblT1_title.Size = new System.Drawing.Size(80, 13);
			this.lblT1_title.TabIndex = 6;
			this.lblT1_title.Text = "Первое время";
			// 
			// lblT1_D
			// 
			this.lblT1_D.AutoSize = true;
			this.lblT1_D.Location = new System.Drawing.Point(9, 67);
			this.lblT1_D.Name = "lblT1_D";
			this.lblT1_D.Size = new System.Drawing.Size(28, 13);
			this.lblT1_D.TabIndex = 7;
			this.lblT1_D.Text = "Дни";
			this.lblT1_D.Click += new System.EventHandler(this.lblT1_D_Click);
			// 
			// lblT1_H
			// 
			this.lblT1_H.AutoSize = true;
			this.lblT1_H.Location = new System.Drawing.Point(10, 93);
			this.lblT1_H.Name = "lblT1_H";
			this.lblT1_H.Size = new System.Drawing.Size(27, 13);
			this.lblT1_H.TabIndex = 8;
			this.lblT1_H.Text = "Час";
			// 
			// lblT1_M
			// 
			this.lblT1_M.AutoSize = true;
			this.lblT1_M.Location = new System.Drawing.Point(10, 116);
			this.lblT1_M.Name = "lblT1_M";
			this.lblT1_M.Size = new System.Drawing.Size(28, 13);
			this.lblT1_M.TabIndex = 9;
			this.lblT1_M.Text = "Мин";
			// 
			// lblT1_S
			// 
			this.lblT1_S.AutoSize = true;
			this.lblT1_S.Location = new System.Drawing.Point(12, 142);
			this.lblT1_S.Name = "lblT1_S";
			this.lblT1_S.Size = new System.Drawing.Size(26, 13);
			this.lblT1_S.TabIndex = 10;
			this.lblT1_S.Text = "Сек";
			// 
			// lblT2_S
			// 
			this.lblT2_S.AutoSize = true;
			this.lblT2_S.Location = new System.Drawing.Point(430, 142);
			this.lblT2_S.Name = "lblT2_S";
			this.lblT2_S.Size = new System.Drawing.Size(26, 13);
			this.lblT2_S.TabIndex = 19;
			this.lblT2_S.Text = "Сек";
			// 
			// lblT2_M
			// 
			this.lblT2_M.AutoSize = true;
			this.lblT2_M.Location = new System.Drawing.Point(430, 116);
			this.lblT2_M.Name = "lblT2_M";
			this.lblT2_M.Size = new System.Drawing.Size(28, 13);
			this.lblT2_M.TabIndex = 18;
			this.lblT2_M.Text = "Мин";
			// 
			// lblT2_H
			// 
			this.lblT2_H.AutoSize = true;
			this.lblT2_H.Location = new System.Drawing.Point(429, 90);
			this.lblT2_H.Name = "lblT2_H";
			this.lblT2_H.Size = new System.Drawing.Size(27, 13);
			this.lblT2_H.TabIndex = 17;
			this.lblT2_H.Text = "Час";
			// 
			// lblT2_D
			// 
			this.lblT2_D.AutoSize = true;
			this.lblT2_D.Location = new System.Drawing.Point(429, 64);
			this.lblT2_D.Name = "lblT2_D";
			this.lblT2_D.Size = new System.Drawing.Size(28, 13);
			this.lblT2_D.TabIndex = 16;
			this.lblT2_D.Text = "Дни";
			// 
			// lblT2_title
			// 
			this.lblT2_title.AutoSize = true;
			this.lblT2_title.Location = new System.Drawing.Point(346, 45);
			this.lblT2_title.Name = "lblT2_title";
			this.lblT2_title.Size = new System.Drawing.Size(78, 13);
			this.lblT2_title.TabIndex = 15;
			this.lblT2_title.Text = "Второе время";
			// 
			// tBxT2_Ss
			// 
			this.tBxT2_Ss.Location = new System.Drawing.Point(349, 139);
			this.tBxT2_Ss.Name = "tBxT2_Ss";
			this.tBxT2_Ss.Size = new System.Drawing.Size(75, 20);
			this.tBxT2_Ss.TabIndex = 14;
			this.tBxT2_Ss.Text = "0";
			this.tBxT2_Ss.Click += new System.EventHandler(this.tBxT2_Ss_Click);
			// 
			// tBxT2_Ms
			// 
			this.tBxT2_Ms.Location = new System.Drawing.Point(349, 113);
			this.tBxT2_Ms.Name = "tBxT2_Ms";
			this.tBxT2_Ms.Size = new System.Drawing.Size(75, 20);
			this.tBxT2_Ms.TabIndex = 13;
			this.tBxT2_Ms.Text = "0";
			this.tBxT2_Ms.Click += new System.EventHandler(this.tBxT2_Ms_Click);
			// 
			// tBxT2_Hs
			// 
			this.tBxT2_Hs.Location = new System.Drawing.Point(349, 87);
			this.tBxT2_Hs.Name = "tBxT2_Hs";
			this.tBxT2_Hs.Size = new System.Drawing.Size(75, 20);
			this.tBxT2_Hs.TabIndex = 12;
			this.tBxT2_Hs.Text = "0";
			this.tBxT2_Hs.Click += new System.EventHandler(this.tBxT2_Hs_Click);
			// 
			// tBxT2_Ds
			// 
			this.tBxT2_Ds.Location = new System.Drawing.Point(349, 61);
			this.tBxT2_Ds.Name = "tBxT2_Ds";
			this.tBxT2_Ds.Size = new System.Drawing.Size(75, 20);
			this.tBxT2_Ds.TabIndex = 11;
			this.tBxT2_Ds.Text = "0";
			this.tBxT2_Ds.Click += new System.EventHandler(this.tBxT2_Ds_Click);
			// 
			// cmbBxOperator
			// 
			this.cmbBxOperator.FormattingEnabled = true;
			this.cmbBxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            ">",
            "<",
            "="});
			this.cmbBxOperator.Location = new System.Drawing.Point(175, 93);
			this.cmbBxOperator.Name = "cmbBxOperator";
			this.cmbBxOperator.Size = new System.Drawing.Size(121, 21);
			this.cmbBxOperator.TabIndex = 20;
			// 
			// lblOp
			// 
			this.lblOp.AutoSize = true;
			this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblOp.Location = new System.Drawing.Point(183, 70);
			this.lblOp.Name = "lblOp";
			this.lblOp.Size = new System.Drawing.Size(98, 20);
			this.lblOp.TabIndex = 21;
			this.lblOp.Text = "+   -   <   >   =";
			// 
			// labelPrgmTitle
			// 
			this.labelPrgmTitle.AutoSize = true;
			this.labelPrgmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPrgmTitle.Location = new System.Drawing.Point(31, 9);
			this.labelPrgmTitle.Name = "labelPrgmTitle";
			this.labelPrgmTitle.Size = new System.Drawing.Size(360, 20);
			this.labelPrgmTitle.TabIndex = 22;
			this.labelPrgmTitle.Text = "Конвертер и калькулятор временных величин";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(175, 136);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(121, 23);
			this.buttonClear.TabIndex = 23;
			this.buttonClear.Text = "Очистить поля";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 385);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.labelPrgmTitle);
			this.Controls.Add(this.lblOp);
			this.Controls.Add(this.cmbBxOperator);
			this.Controls.Add(this.lblT2_S);
			this.Controls.Add(this.lblT2_M);
			this.Controls.Add(this.lblT2_H);
			this.Controls.Add(this.lblT2_D);
			this.Controls.Add(this.lblT2_title);
			this.Controls.Add(this.tBxT2_Ss);
			this.Controls.Add(this.tBxT2_Ms);
			this.Controls.Add(this.tBxT2_Hs);
			this.Controls.Add(this.tBxT2_Ds);
			this.Controls.Add(this.lblT1_S);
			this.Controls.Add(this.lblT1_M);
			this.Controls.Add(this.lblT1_H);
			this.Controls.Add(this.lblT1_D);
			this.Controls.Add(this.lblT1_title);
			this.Controls.Add(this.tBxT1_Ss);
			this.Controls.Add(this.tBxT1_Ms);
			this.Controls.Add(this.tBxT1_Hs);
			this.Controls.Add(this.tBxT1_Ds);
			this.Controls.Add(this.textBoxRes);
			this.Controls.Add(this.buttonRes);
			this.Name = "Form1";
			this.Text = "Конвертер и калькулятор временных величин";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.TextBox tBxT1_Ds;
        private System.Windows.Forms.TextBox tBxT1_Hs;
        private System.Windows.Forms.TextBox tBxT1_Ms;
        private System.Windows.Forms.TextBox tBxT1_Ss;
        private System.Windows.Forms.Label lblT1_title;
        private System.Windows.Forms.Label lblT1_D;
        private System.Windows.Forms.Label lblT1_H;
        private System.Windows.Forms.Label lblT1_M;
        private System.Windows.Forms.Label lblT1_S;
        private System.Windows.Forms.Label lblT2_S;
        private System.Windows.Forms.Label lblT2_M;
        private System.Windows.Forms.Label lblT2_H;
        private System.Windows.Forms.Label lblT2_D;
        private System.Windows.Forms.Label lblT2_title;
        private System.Windows.Forms.TextBox tBxT2_Ss;
        private System.Windows.Forms.TextBox tBxT2_Ms;
        private System.Windows.Forms.TextBox tBxT2_Hs;
        private System.Windows.Forms.TextBox tBxT2_Ds;
        private System.Windows.Forms.ComboBox cmbBxOperator;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label labelPrgmTitle;
        private System.Windows.Forms.Button buttonClear;
    }
}

