namespace TCS
{
    partial class AppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.save_button = new DevExpress.XtraEditors.SimpleButton();
            this.email_address = new DevExpress.XtraEditors.TextEdit();
            this.contact_number = new DevExpress.XtraEditors.TextEdit();
            this.center_name = new DevExpress.XtraEditors.TextEdit();
            this.center_code = new DevExpress.XtraEditors.TextEdit();
            this.center_no = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.DBServer = new DevExpress.XtraEditors.TextEdit();
            this.Seee = new DevExpress.XtraEditors.LabelControl();
            this.dbSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.DBPassword = new DevExpress.XtraEditors.TextEdit();
            this.DBUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.DBName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.email_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_no.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(562, 318);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.save_button);
            this.xtraTabPage1.Controls.Add(this.email_address);
            this.xtraTabPage1.Controls.Add(this.contact_number);
            this.xtraTabPage1.Controls.Add(this.center_name);
            this.xtraTabPage1.Controls.Add(this.center_code);
            this.xtraTabPage1.Controls.Add(this.center_no);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Image = global::TCS.Properties.Resources.Home;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(556, 271);
            this.xtraTabPage1.Text = "Center Info";
            // 
            // save_button
            // 
            this.save_button.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Appearance.Options.UseFont = true;
            this.save_button.Image = global::TCS.Properties.Resources.Lightning;
            this.save_button.Location = new System.Drawing.Point(359, 222);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(118, 32);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // email_address
            // 
            this.email_address.Location = new System.Drawing.Point(265, 182);
            this.email_address.Name = "email_address";
            this.email_address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address.Properties.Appearance.Options.UseFont = true;
            this.email_address.Properties.Appearance.Options.UseTextOptions = true;
            this.email_address.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.email_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.email_address.Properties.Mask.BeepOnError = true;
            this.email_address.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.email_address.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.email_address.Properties.Mask.ShowPlaceHolders = false;
            this.email_address.Size = new System.Drawing.Size(212, 22);
            this.email_address.TabIndex = 9;
            // 
            // contact_number
            // 
            this.contact_number.Location = new System.Drawing.Point(265, 147);
            this.contact_number.Name = "contact_number";
            this.contact_number.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_number.Properties.Appearance.Options.UseFont = true;
            this.contact_number.Properties.Appearance.Options.UseTextOptions = true;
            this.contact_number.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.contact_number.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.contact_number.Properties.Mask.BeepOnError = true;
            this.contact_number.Properties.Mask.EditMask = "000 000 0000";
            this.contact_number.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.contact_number.Properties.Mask.SaveLiteral = false;
            this.contact_number.Size = new System.Drawing.Size(212, 22);
            this.contact_number.TabIndex = 8;
            // 
            // center_name
            // 
            this.center_name.Location = new System.Drawing.Point(265, 113);
            this.center_name.Name = "center_name";
            this.center_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_name.Properties.Appearance.Options.UseFont = true;
            this.center_name.Properties.Appearance.Options.UseTextOptions = true;
            this.center_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.center_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.center_name.Size = new System.Drawing.Size(212, 22);
            this.center_name.TabIndex = 7;
            this.center_name.Validating += new System.ComponentModel.CancelEventHandler(this.center_name_Validating);
            // 
            // center_code
            // 
            this.center_code.Location = new System.Drawing.Point(265, 79);
            this.center_code.Name = "center_code";
            this.center_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_code.Properties.Appearance.Options.UseFont = true;
            this.center_code.Properties.Appearance.Options.UseTextOptions = true;
            this.center_code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.center_code.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.center_code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.center_code.Size = new System.Drawing.Size(212, 22);
            this.center_code.TabIndex = 6;
            // 
            // center_no
            // 
            this.center_no.Location = new System.Drawing.Point(265, 47);
            this.center_no.Name = "center_no";
            this.center_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_no.Properties.Appearance.Options.UseFont = true;
            this.center_no.Properties.Appearance.Options.UseTextOptions = true;
            this.center_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.center_no.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.center_no.Properties.Mask.EditMask = "d";
            this.center_no.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.center_no.Size = new System.Drawing.Size(212, 22);
            this.center_no.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(73, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Email Address : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(73, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Contact Number:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(73, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Center Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(73, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Center Code :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(73, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Center No. :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Controls.Add(this.DBServer);
            this.xtraTabPage2.Controls.Add(this.Seee);
            this.xtraTabPage2.Controls.Add(this.dbSave);
            this.xtraTabPage2.Controls.Add(this.labelControl8);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.labelControl10);
            this.xtraTabPage2.Controls.Add(this.DBPassword);
            this.xtraTabPage2.Controls.Add(this.DBUser);
            this.xtraTabPage2.Controls.Add(this.labelControl6);
            this.xtraTabPage2.Controls.Add(this.labelControl7);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.DBName);
            this.xtraTabPage2.Image = global::TCS.Properties.Resources.database2;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(556, 271);
            this.xtraTabPage2.Text = "Database Setting";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(185, 145);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(5, 16);
            this.labelControl12.TabIndex = 37;
            this.labelControl12.Text = ":";
            // 
            // DBServer
            // 
            this.DBServer.Location = new System.Drawing.Point(243, 142);
            this.DBServer.Name = "DBServer";
            this.DBServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBServer.Properties.Appearance.Options.UseFont = true;
            this.DBServer.Properties.Appearance.Options.UseTextOptions = true;
            this.DBServer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DBServer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.DBServer.Size = new System.Drawing.Size(212, 22);
            this.DBServer.TabIndex = 35;
            // 
            // Seee
            // 
            this.Seee.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seee.Location = new System.Drawing.Point(82, 145);
            this.Seee.Name = "Seee";
            this.Seee.Size = new System.Drawing.Size(38, 16);
            this.Seee.TabIndex = 36;
            this.Seee.Text = "Server";
            // 
            // dbSave
            // 
            this.dbSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbSave.Appearance.Options.UseFont = true;
            this.dbSave.Image = global::TCS.Properties.Resources.Lightning;
            this.dbSave.Location = new System.Drawing.Point(337, 211);
            this.dbSave.Name = "dbSave";
            this.dbSave.Size = new System.Drawing.Size(118, 32);
            this.dbSave.TabIndex = 34;
            this.dbSave.Text = "Save";
            this.dbSave.Click += new System.EventHandler(this.dbSave_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(185, 112);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(5, 16);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = ":";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(185, 78);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(5, 16);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = ":";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(185, 46);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(5, 16);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = ":";
            // 
            // DBPassword
            // 
            this.DBPassword.Location = new System.Drawing.Point(243, 109);
            this.DBPassword.Name = "DBPassword";
            this.DBPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBPassword.Properties.Appearance.Options.UseFont = true;
            this.DBPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.DBPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DBPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.DBPassword.Properties.PasswordChar = '●';
            this.DBPassword.Size = new System.Drawing.Size(212, 22);
            this.DBPassword.TabIndex = 27;
            // 
            // DBUser
            // 
            this.DBUser.Location = new System.Drawing.Point(243, 75);
            this.DBUser.Name = "DBUser";
            this.DBUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBUser.Properties.Appearance.Options.UseFont = true;
            this.DBUser.Properties.Appearance.Options.UseTextOptions = true;
            this.DBUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DBUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.DBUser.Size = new System.Drawing.Size(212, 22);
            this.DBUser.TabIndex = 26;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(82, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 16);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Password";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(82, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 16);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "User Name";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(82, 46);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(90, 16);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "Database Name";
            // 
            // DBName
            // 
            this.DBName.Location = new System.Drawing.Point(243, 43);
            this.DBName.Name = "DBName";
            this.DBName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBName.Properties.Appearance.Options.UseFont = true;
            this.DBName.Properties.Appearance.Options.UseTextOptions = true;
            this.DBName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DBName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.DBName.Size = new System.Drawing.Size(212, 22);
            this.DBName.TabIndex = 25;
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 341);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.email_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_no.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit email_address;
        private DevExpress.XtraEditors.TextEdit contact_number;
        private DevExpress.XtraEditors.TextEdit center_name;
        private DevExpress.XtraEditors.TextEdit center_code;
        private DevExpress.XtraEditors.TextEdit center_no;
        private DevExpress.XtraEditors.SimpleButton save_button;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit DBPassword;
        private DevExpress.XtraEditors.TextEdit DBUser;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit DBName;
        private DevExpress.XtraEditors.SimpleButton dbSave;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit DBServer;
        private DevExpress.XtraEditors.LabelControl Seee;
    }
}