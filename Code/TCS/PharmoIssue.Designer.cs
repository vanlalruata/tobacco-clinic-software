namespace TCS
{
    partial class PharmoIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmoIssue));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_Btn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.modify_btn = new DevExpress.XtraEditors.SimpleButton();
            this.remove_btn = new DevExpress.XtraEditors.SimpleButton();
            this.clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.remark_detail = new DevExpress.XtraEditors.MemoEdit();
            this.exp_date = new DevExpress.XtraEditors.DateEdit();
            this.issue_date = new DevExpress.XtraEditors.DateEdit();
            this.quantity = new DevExpress.XtraEditors.SpinEdit();
            this.med_detail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.batch_detail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.client_no = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remark_detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 323);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 212);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_Btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.modify_btn);
            this.groupBox1.Controls.Add(this.remove_btn);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.remark_detail);
            this.groupBox1.Controls.Add(this.exp_date);
            this.groupBox1.Controls.Add(this.issue_date);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.med_detail);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.batch_detail);
            this.groupBox1.Controls.Add(this.client_no);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 295);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pharmocological Issue Detail";
            // 
            // Search_Btn
            // 
            this.Search_Btn.Image = global::TCS.Properties.Resources.Magnifier;
            this.Search_Btn.Location = new System.Drawing.Point(31, 179);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(40, 40);
            this.Search_Btn.TabIndex = 20;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(169, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modify_btn
            // 
            this.modify_btn.Image = global::TCS.Properties.Resources.Pen;
            this.modify_btn.Location = new System.Drawing.Point(493, 239);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(113, 40);
            this.modify_btn.TabIndex = 17;
            this.modify_btn.Text = "Modify";
            this.modify_btn.Visible = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Image = global::TCS.Properties.Resources.Remove;
            this.remove_btn.Location = new System.Drawing.Point(493, 239);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(113, 40);
            this.remove_btn.TabIndex = 18;
            this.remove_btn.Text = "Remove";
            this.remove_btn.Visible = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Image = global::TCS.Properties.Resources.Clock;
            this.clear_btn.Location = new System.Drawing.Point(31, 239);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(113, 40);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = global::TCS.Properties.Resources.Success;
            this.save_btn.Location = new System.Drawing.Point(493, 239);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(113, 40);
            this.save_btn.TabIndex = 15;
            this.save_btn.Text = "Save Now";
            this.save_btn.Visible = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // remark_detail
            // 
            this.remark_detail.Location = new System.Drawing.Point(157, 140);
            this.remark_detail.Name = "remark_detail";
            this.remark_detail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.remark_detail.Size = new System.Drawing.Size(449, 79);
            this.remark_detail.TabIndex = 6;
            // 
            // exp_date
            // 
            this.exp_date.EditValue = null;
            this.exp_date.Location = new System.Drawing.Point(459, 70);
            this.exp_date.Name = "exp_date";
            this.exp_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.exp_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exp_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exp_date.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.exp_date.Properties.Mask.BeepOnError = true;
            this.exp_date.Properties.Mask.EditMask = "y";
            this.exp_date.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.exp_date.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.exp_date.Size = new System.Drawing.Size(147, 20);
            this.exp_date.TabIndex = 4;
            this.exp_date.ToolTip = "Choose the Expiring Date";
            this.exp_date.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.exp_date.ToolTipTitle = "Info";
            // 
            // issue_date
            // 
            this.issue_date.EditValue = null;
            this.issue_date.Location = new System.Drawing.Point(459, 38);
            this.issue_date.Name = "issue_date";
            this.issue_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.issue_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.issue_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.issue_date.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.issue_date.Properties.Mask.BeepOnError = true;
            this.issue_date.Size = new System.Drawing.Size(147, 20);
            this.issue_date.TabIndex = 3;
            this.issue_date.ToolTip = "Choose the Manufaturing Date";
            this.issue_date.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.issue_date.ToolTipTitle = "Info";
            // 
            // quantity
            // 
            this.quantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantity.Location = new System.Drawing.Point(157, 102);
            this.quantity.Name = "quantity";
            this.quantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.quantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantity.Properties.MaxLength = 9;
            this.quantity.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.quantity.Size = new System.Drawing.Size(147, 20);
            this.quantity.TabIndex = 2;
            this.quantity.ToolTip = "Enter the quantity instock without adding the previous stocks.";
            this.quantity.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.quantity.ToolTipTitle = "Info";
            // 
            // med_detail
            // 
            this.med_detail.Location = new System.Drawing.Point(157, 70);
            this.med_detail.Name = "med_detail";
            this.med_detail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.med_detail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.med_detail.Properties.Items.AddRange(new object[] {
            "Nicogum 2Mg",
            "Nicogum 4Mg"});
            this.med_detail.Properties.Sorted = true;
            this.med_detail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.med_detail.Size = new System.Drawing.Size(147, 20);
            this.med_detail.TabIndex = 1;
            this.med_detail.ToolTip = "Choose the Medicine Detail or Enter it Yourself.";
            this.med_detail.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.med_detail.ToolTipTitle = "Info";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(31, 140);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 16);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Remark";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(336, 71);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 16);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Expiry Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(336, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Issue Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(336, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Batch Detail";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(31, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Quantity";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(31, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Medicine Issue";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(31, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Client No.";
            // 
            // batch_detail
            // 
            this.batch_detail.Location = new System.Drawing.Point(459, 102);
            this.batch_detail.Name = "batch_detail";
            this.batch_detail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.batch_detail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.batch_detail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.batch_detail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.batch_detail.Size = new System.Drawing.Size(147, 20);
            this.batch_detail.TabIndex = 5;
            this.batch_detail.ToolTip = "Enter the Batch Number Details as it appears in the medicine box.";
            this.batch_detail.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.batch_detail.ToolTipTitle = "Info";
            // 
            // client_no
            // 
            this.client_no.Location = new System.Drawing.Point(157, 38);
            this.client_no.Name = "client_no";
            this.client_no.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.client_no.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.client_no.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.client_no.Properties.DisplayFormat.FormatString = "d";
            this.client_no.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.client_no.Properties.EditFormat.FormatString = "d";
            this.client_no.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.client_no.Size = new System.Drawing.Size(147, 20);
            this.client_no.TabIndex = 0;
            this.client_no.ToolTip = "Choose the Stock Entry Date";
            this.client_no.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.client_no.ToolTipTitle = "Info";
            this.client_no.SelectedIndexChanged += new System.EventHandler(this.client_no_SelectedIndexChanged);
            // 
            // PharmoIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 556);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PharmoIssue";
            this.Text = "Pharmacology Issue Register";
            this.Load += new System.EventHandler(this.PharmoIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remark_detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit remark_detail;
        private DevExpress.XtraEditors.DateEdit exp_date;
        private DevExpress.XtraEditors.DateEdit issue_date;
        private DevExpress.XtraEditors.SpinEdit quantity;
        private DevExpress.XtraEditors.ComboBoxEdit med_detail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit batch_detail;
        private DevExpress.XtraEditors.ComboBoxEdit client_no;
        public DevExpress.XtraEditors.SimpleButton modify_btn;
        public DevExpress.XtraEditors.SimpleButton remove_btn;
        private DevExpress.XtraEditors.SimpleButton clear_btn;
        public DevExpress.XtraEditors.SimpleButton save_btn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Search_Btn;
    }
}