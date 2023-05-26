namespace Курсач_опбд_версия_2
{
    partial class StaffAdd
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Имя = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.SurNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(451, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "👁";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Фамилия";
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Location = new System.Drawing.Point(321, 119);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(39, 20);
            this.Имя.TabIndex = 17;
            this.Имя.Text = "Имя";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(320, 301);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(125, 27);
            this.PassTextBox.TabIndex = 16;
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.Location = new System.Drawing.Point(321, 195);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.SurNameTextBox.TabIndex = 14;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(320, 248);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(125, 27);
            this.PhoneTextBox.TabIndex = 15;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(320, 142);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(125, 27);
            this.NameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавление сотрудника";
            // 
            // StaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.SurNameTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StaffAdd";
            this.Text = "StaffAdd";
            this.Load += new System.EventHandler(this.StaffAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Имя;
        private TextBox PassTextBox;
        private TextBox SurNameTextBox;
        private TextBox PhoneTextBox;
        private TextBox NameTextBox;
        private Label label1;
    }
}