namespace TCS
{
    partial class PharIssueDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharIssueDetail));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.client_no = new DevExpress.XtraEditors.ComboBoxEdit();
            this.client_name = new DevExpress.XtraEditors.TextEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(33, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Client No";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(33, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Name";
            // 
            // client_no
            // 
            this.client_no.Location = new System.Drawing.Point(118, 28);
            this.client_no.Name = "client_no";
            this.client_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_no.Properties.Appearance.Options.UseFont = true;
            this.client_no.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.client_no.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.client_no.Size = new System.Drawing.Size(208, 22);
            this.client_no.TabIndex = 2;
            this.client_no.SelectedIndexChanged += new System.EventHandler(this.client_no_SelectedIndexChanged);
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(118, 56);
            this.client_name.Name = "client_name";
            this.client_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_name.Properties.Appearance.Options.UseFont = true;
            this.client_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.client_name.Properties.ReadOnly = true;
            this.client_name.Size = new System.Drawing.Size(208, 22);
            this.client_name.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Appearance.Options.UseFont = true;
            this.searchButton.Location = new System.Drawing.Point(362, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 48);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(33, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 184);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PharIssueDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 311);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.client_name);
            this.Controls.Add(this.client_no);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PharIssueDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Detail";
            this.Load += new System.EventHandler(this.PharIssueDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_name.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit client_no;
        private DevExpress.XtraEditors.TextEdit client_name;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private System.Windows.Forms.ListView listView1;
    }
}