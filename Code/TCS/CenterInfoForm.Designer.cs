namespace TCS
{
    partial class CenterInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CenterInfoForm));
            this.email_address = new DevExpress.XtraEditors.TextEdit();
            this.contact_number = new DevExpress.XtraEditors.TextEdit();
            this.center_name = new DevExpress.XtraEditors.TextEdit();
            this.center_code = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.save_button = new DevExpress.XtraEditors.SimpleButton();
            this.clear_button = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_button = new DevExpress.XtraEditors.SimpleButton();
            this.modify_button = new DevExpress.XtraEditors.SimpleButton();
            this.default_button = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.center_no = new DevExpress.XtraEditors.ComboBoxEdit();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.email_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_code.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.default_button.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_no.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // email_address
            // 
            this.email_address.Location = new System.Drawing.Point(182, 166);
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
            this.email_address.TabIndex = 4;
            // 
            // contact_number
            // 
            this.contact_number.Location = new System.Drawing.Point(182, 131);
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
            this.contact_number.TabIndex = 3;
            // 
            // center_name
            // 
            this.center_name.Location = new System.Drawing.Point(182, 97);
            this.center_name.Name = "center_name";
            this.center_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_name.Properties.Appearance.Options.UseFont = true;
            this.center_name.Properties.Appearance.Options.UseTextOptions = true;
            this.center_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.center_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.center_name.Size = new System.Drawing.Size(212, 22);
            this.center_name.TabIndex = 2;
            // 
            // center_code
            // 
            this.center_code.Location = new System.Drawing.Point(182, 63);
            this.center_code.Name = "center_code";
            this.center_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_code.Properties.Appearance.Options.UseFont = true;
            this.center_code.Properties.Appearance.Options.UseTextOptions = true;
            this.center_code.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.center_code.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.center_code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.center_code.Size = new System.Drawing.Size(212, 22);
            this.center_code.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(21, 169);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Email Address ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(21, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 16);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Contact Number";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(21, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 16);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Center Name ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(21, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Center Code ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(21, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Center No. ";
            // 
            // save_button
            // 
            this.save_button.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Appearance.Options.UseFont = true;
            this.save_button.Image = global::TCS.Properties.Resources.Success;
            this.save_button.Location = new System.Drawing.Point(446, 66);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(118, 32);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Appearance.Options.UseFont = true;
            this.clear_button.Image = global::TCS.Properties.Resources.Clock;
            this.clear_button.Location = new System.Drawing.Point(446, 26);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(118, 32);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "Clear";
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_button);
            this.groupBox1.Controls.Add(this.modify_button);
            this.groupBox1.Controls.Add(this.default_button);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.clear_button);
            this.groupBox1.Controls.Add(this.save_button);
            this.groupBox1.Controls.Add(this.email_address);
            this.groupBox1.Controls.Add(this.contact_number);
            this.groupBox1.Controls.Add(this.center_name);
            this.groupBox1.Controls.Add(this.center_code);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.center_no);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 222);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // delete_button
            // 
            this.delete_button.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Appearance.Options.UseFont = true;
            this.delete_button.Image = global::TCS.Properties.Resources.Remove;
            this.delete_button.Location = new System.Drawing.Point(446, 104);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(118, 32);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Delete";
            // 
            // modify_button
            // 
            this.modify_button.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_button.Appearance.Options.UseFont = true;
            this.modify_button.Image = global::TCS.Properties.Resources.Pen;
            this.modify_button.Location = new System.Drawing.Point(446, 104);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(118, 32);
            this.modify_button.TabIndex = 8;
            this.modify_button.Text = "Modify";
            this.modify_button.Visible = false;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // default_button
            // 
            this.default_button.Location = new System.Drawing.Point(124, 197);
            this.default_button.Name = "default_button";
            this.default_button.Properties.Caption = "Is Default";
            this.default_button.Size = new System.Drawing.Size(212, 19);
            this.default_button.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(124, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(5, 16);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = ":";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(124, 134);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(5, 16);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = ":";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(124, 100);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(5, 16);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = ":";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(124, 66);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(5, 16);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = ":";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(124, 34);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(5, 16);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = ":";
            // 
            // center_no
            // 
            this.center_no.Location = new System.Drawing.Point(182, 31);
            this.center_no.Name = "center_no";
            this.center_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_no.Properties.Appearance.Options.UseFont = true;
            this.center_no.Properties.Appearance.Options.UseTextOptions = true;
            this.center_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.center_no.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.center_no.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.center_no.Size = new System.Drawing.Size(212, 22);
            this.center_no.TabIndex = 0;
            this.center_no.SelectedIndexChanged += new System.EventHandler(this.center_no_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 240);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 145);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CenterInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 397);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CenterInfoForm";
            this.Text = "Center Information Details";
            this.Load += new System.EventHandler(this.CenterInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.email_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_code.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.default_button.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_no.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit email_address;
        private DevExpress.XtraEditors.TextEdit contact_number;
        private DevExpress.XtraEditors.TextEdit center_name;
        private DevExpress.XtraEditors.TextEdit center_code;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton save_button;
        private DevExpress.XtraEditors.SimpleButton clear_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit center_no;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit default_button;
        private DevExpress.XtraEditors.SimpleButton delete_button;
        private DevExpress.XtraEditors.SimpleButton modify_button;
    }
}