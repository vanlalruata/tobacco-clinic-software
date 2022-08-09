namespace TCS
{
    partial class TobaccoUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TobaccoUse));
            this.listView1 = new System.Windows.Forms.ListView();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tobacconame = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.client_no = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tobacco_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ageonset = new DevExpress.XtraEditors.SpinEdit();
            this.avg_day = new DevExpress.XtraEditors.SpinEdit();
            this.no_year = new DevExpress.XtraEditors.SpinEdit();
            this.total_chew = new DevExpress.XtraEditors.SpinEdit();
            this.total_year = new DevExpress.XtraEditors.SpinEdit();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tobacconame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tobacco_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageonset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg_day.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_chew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_year.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(17, 406);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(630, 212);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // save_btn
            // 
            this.save_btn.Image = global::TCS.Properties.Resources.Success;
            this.save_btn.Location = new System.Drawing.Point(543, 71);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(99, 40);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save Now";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Image = global::TCS.Properties.Resources.Clock;
            this.clear_btn.Location = new System.Drawing.Point(543, 25);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(99, 40);
            this.clear_btn.TabIndex = 12;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.tobacconame);
            this.groupBox1.Controls.Add(this.labelControl41);
            this.groupBox1.Controls.Add(this.client_no);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.tobacco_type);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.ageonset);
            this.groupBox1.Controls.Add(this.avg_day);
            this.groupBox1.Controls.Add(this.no_year);
            this.groupBox1.Controls.Add(this.total_chew);
            this.groupBox1.Controls.Add(this.total_year);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tobacco Used Register";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(24, 342);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(372, 16);
            this.labelControl10.TabIndex = 128;
            this.labelControl10.Text = "*  You can add multiple products as much you get about the use.";
            // 
            // tobacconame
            // 
            this.tobacconame.Location = new System.Drawing.Point(294, 86);
            this.tobacconame.Name = "tobacconame";
            this.tobacconame.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tobacconame.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tobacconame.Properties.Items.AddRange(new object[] {
            "Zozial",
            "Cigarette",
            "Hooka",
            "Sahdah",
            "Khaini",
            "Tuibur",
            "Gutkha"});
            this.tobacconame.Size = new System.Drawing.Size(193, 20);
            this.tobacconame.TabIndex = 2;
            this.tobacconame.SelectedIndexChanged += new System.EventHandler(this.tobacconame_SelectedIndexChanged);
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl41.Location = new System.Drawing.Point(24, 306);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(125, 16);
            this.labelControl41.TabIndex = 124;
            this.labelControl41.Text = "Source of Information";
            // 
            // client_no
            // 
            this.client_no.Location = new System.Drawing.Point(295, 23);
            this.client_no.Name = "client_no";
            this.client_no.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.client_no.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.client_no.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.client_no.Size = new System.Drawing.Size(193, 20);
            this.client_no.TabIndex = 9;
            this.client_no.SelectedIndexChanged += new System.EventHandler(this.client_no_SelectedIndexChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(24, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 16);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Client Code";
            // 
            // tobacco_type
            // 
            this.tobacco_type.Location = new System.Drawing.Point(295, 55);
            this.tobacco_type.Name = "tobacco_type";
            this.tobacco_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tobacco_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tobacco_type.Properties.Items.AddRange(new object[] {
            "Smoking",
            "Smokeless"});
            this.tobacco_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tobacco_type.Size = new System.Drawing.Size(193, 20);
            this.tobacco_type.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(23, 277);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(218, 48);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Average number of cigarettes/sachets \r\namount of tobacco chewed per day \r\nin the " +
    "last one month";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(23, 215);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(222, 48);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Sachet/cigarette years\r\n(No. of cigs/bidis/sachets used per day\r\nX No. of years o" +
    "f regular tobacco use)";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(23, 184);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(201, 16);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "No. of years of regular tobacco use";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(23, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(268, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Average No. of cigs/bidis/sachets used per day";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(23, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Age Of OnSet";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(147, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Name of Tobacco Product";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Type (Tobacco Use)";
            // 
            // ageonset
            // 
            this.ageonset.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ageonset.Location = new System.Drawing.Point(295, 118);
            this.ageonset.Name = "ageonset";
            this.ageonset.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ageonset.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ageonset.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.ageonset.Properties.IsFloatValue = false;
            this.ageonset.Properties.Mask.EditMask = "N00";
            this.ageonset.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.ageonset.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ageonset.Size = new System.Drawing.Size(193, 20);
            this.ageonset.TabIndex = 3;
            // 
            // avg_day
            // 
            this.avg_day.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.avg_day.Location = new System.Drawing.Point(294, 149);
            this.avg_day.Name = "avg_day";
            this.avg_day.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.avg_day.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.avg_day.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.avg_day.Properties.IsFloatValue = false;
            this.avg_day.Properties.Mask.EditMask = "N00";
            this.avg_day.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.avg_day.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.avg_day.Size = new System.Drawing.Size(193, 20);
            this.avg_day.TabIndex = 4;
            // 
            // no_year
            // 
            this.no_year.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.no_year.Location = new System.Drawing.Point(294, 183);
            this.no_year.Name = "no_year";
            this.no_year.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.no_year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.no_year.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.no_year.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.no_year.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.no_year.Size = new System.Drawing.Size(193, 20);
            this.no_year.TabIndex = 5;
            // 
            // total_chew
            // 
            this.total_chew.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total_chew.Location = new System.Drawing.Point(293, 276);
            this.total_chew.Name = "total_chew";
            this.total_chew.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.total_chew.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.total_chew.Properties.DisplayFormat.FormatString = "d";
            this.total_chew.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.total_chew.Properties.EditFormat.FormatString = "d";
            this.total_chew.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.total_chew.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.total_chew.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.total_chew.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.total_chew.Size = new System.Drawing.Size(194, 20);
            this.total_chew.TabIndex = 7;
            // 
            // total_year
            // 
            this.total_year.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total_year.Location = new System.Drawing.Point(295, 214);
            this.total_year.Name = "total_year";
            this.total_year.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.total_year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.total_year.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.total_year.Properties.Mask.BeepOnError = true;
            this.total_year.Properties.Mask.EditMask = "d";
            this.total_year.Size = new System.Drawing.Size(193, 20);
            this.total_year.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(543, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 40);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add / Modify";
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // TobaccoUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 633);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TobaccoUse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tobacco Uses Record";
            this.Load += new System.EventHandler(this.TobaccoUse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tobacconame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tobacco_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageonset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg_day.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_chew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_year.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        public DevExpress.XtraEditors.SimpleButton save_btn;
        public DevExpress.XtraEditors.SimpleButton clear_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit tobacconame;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        public DevExpress.XtraEditors.ComboBoxEdit client_no;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.ComboBoxEdit tobacco_type;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit ageonset;
        private DevExpress.XtraEditors.SpinEdit avg_day;
        private DevExpress.XtraEditors.SpinEdit no_year;
        private DevExpress.XtraEditors.SpinEdit total_chew;
        private DevExpress.XtraEditors.SpinEdit total_year;
        public DevExpress.XtraEditors.SimpleButton addButton;
    }
}