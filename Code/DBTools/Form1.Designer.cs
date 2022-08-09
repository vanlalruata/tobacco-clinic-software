namespace DBTools
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EX_Button = new System.Windows.Forms.Button();
            this.test_button = new System.Windows.Forms.Button();
            this.passtext = new System.Windows.Forms.TextBox();
            this.usertext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EX_Button);
            this.groupBox1.Controls.Add(this.test_button);
            this.groupBox1.Controls.Add(this.passtext);
            this.groupBox1.Controls.Add(this.usertext);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dabase Connection";
            // 
            // EX_Button
            // 
            this.EX_Button.Location = new System.Drawing.Point(246, 50);
            this.EX_Button.Name = "EX_Button";
            this.EX_Button.Size = new System.Drawing.Size(111, 23);
            this.EX_Button.TabIndex = 7;
            this.EX_Button.Text = "Execute DB";
            this.EX_Button.UseVisualStyleBackColor = true;
            this.EX_Button.Visible = false;
            this.EX_Button.Click += new System.EventHandler(this.EX_Button_Click);
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(246, 23);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(111, 23);
            this.test_button.TabIndex = 6;
            this.test_button.Text = "Test Connection";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // passtext
            // 
            this.passtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtext.Location = new System.Drawing.Point(98, 49);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '●';
            this.passtext.Size = new System.Drawing.Size(135, 23);
            this.passtext.TabIndex = 5;
            this.passtext.Text = "root";
            this.passtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usertext
            // 
            this.usertext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usertext.Location = new System.Drawing.Point(98, 23);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(135, 23);
            this.usertext.TabIndex = 4;
            this.usertext.Text = "root";
            this.usertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 118);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Tools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EX_Button;
        private System.Windows.Forms.Button test_button;
    }
}

