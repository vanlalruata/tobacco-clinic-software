namespace TCS
{
    partial class PharmoStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmoStock));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exp_date = new DevExpress.XtraEditors.DateEdit();
            this.mfg_date = new DevExpress.XtraEditors.DateEdit();
            this.modify_btn = new DevExpress.XtraEditors.SimpleButton();
            this.remove_btn = new DevExpress.XtraEditors.SimpleButton();
            this.med_rating = new DevExpress.XtraEditors.RatingControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.remark_detail = new DevExpress.XtraEditors.MemoEdit();
            this.price_detail = new DevExpress.XtraEditors.SpinEdit();
            this.quantity = new DevExpress.XtraEditors.SpinEdit();
            this.med_detail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.stockdate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.batch_detail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfg_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfg_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_rating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark_detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_detail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_detail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 348);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 194);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exp_date);
            this.groupBox1.Controls.Add(this.mfg_date);
            this.groupBox1.Controls.Add(this.modify_btn);
            this.groupBox1.Controls.Add(this.remove_btn);
            this.groupBox1.Controls.Add(this.med_rating);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.remark_detail);
            this.groupBox1.Controls.Add(this.price_detail);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.med_detail);
            this.groupBox1.Controls.Add(this.stockdate);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.batch_detail);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 313);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Register";
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
            this.exp_date.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.exp_date.Properties.Mask.BeepOnError = true;
            this.exp_date.Properties.Mask.EditMask = "y";
            this.exp_date.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.exp_date.Size = new System.Drawing.Size(147, 20);
            this.exp_date.TabIndex = 5;
            // 
            // mfg_date
            // 
            this.mfg_date.EditValue = null;
            this.mfg_date.Location = new System.Drawing.Point(459, 38);
            this.mfg_date.Name = "mfg_date";
            this.mfg_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.mfg_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mfg_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mfg_date.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.mfg_date.Properties.Mask.BeepOnError = true;
            this.mfg_date.Properties.Mask.EditMask = "y";
            this.mfg_date.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.mfg_date.Size = new System.Drawing.Size(147, 20);
            this.mfg_date.TabIndex = 4;
            this.mfg_date.ToolTip = "Choose the Manufacturing Date for the Medicine";
            // 
            // modify_btn
            // 
            this.modify_btn.Image = global::TCS.Properties.Resources.Pen;
            this.modify_btn.Location = new System.Drawing.Point(493, 260);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(113, 40);
            this.modify_btn.TabIndex = 12;
            this.modify_btn.Text = "Modify";
            this.modify_btn.Visible = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Image = global::TCS.Properties.Resources.Remove;
            this.remove_btn.Location = new System.Drawing.Point(493, 260);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(113, 40);
            this.remove_btn.TabIndex = 13;
            this.remove_btn.Text = "Remove";
            this.remove_btn.Visible = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // med_rating
            // 
            this.med_rating.Location = new System.Drawing.Point(459, 139);
            this.med_rating.Name = "med_rating";
            this.med_rating.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.med_rating.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.med_rating.Size = new System.Drawing.Size(87, 16);
            this.med_rating.TabIndex = 7;
            this.med_rating.Text = "ratingControl1";
            this.med_rating.ToolTip = "Rate the Medicine Quality\r\nFull 5 Stars as Very Good\r\nOnly 1 Star as Very Poor";
            this.med_rating.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.med_rating.ToolTipTitle = "Info";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(336, 139);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(90, 16);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Medicine Rating";
            // 
            // clear_btn
            // 
            this.clear_btn.Image = global::TCS.Properties.Resources.Clock;
            this.clear_btn.Location = new System.Drawing.Point(31, 260);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(113, 40);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = global::TCS.Properties.Resources.Success;
            this.save_btn.Location = new System.Drawing.Point(493, 260);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(113, 40);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save Now";
            this.save_btn.Visible = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // remark_detail
            // 
            this.remark_detail.Location = new System.Drawing.Point(157, 172);
            this.remark_detail.Name = "remark_detail";
            this.remark_detail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.remark_detail.Size = new System.Drawing.Size(449, 79);
            this.remark_detail.TabIndex = 8;
            // 
            // price_detail
            // 
            this.price_detail.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.price_detail.Location = new System.Drawing.Point(459, 102);
            this.price_detail.Name = "price_detail";
            this.price_detail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.price_detail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.price_detail.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.price_detail.Properties.Mask.BeepOnError = true;
            this.price_detail.Properties.Mask.EditMask = "c";
            this.price_detail.Properties.MaxLength = 9;
            this.price_detail.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.price_detail.Size = new System.Drawing.Size(147, 20);
            this.price_detail.TabIndex = 6;
            this.price_detail.ToolTip = "Enter the price detail";
            this.price_detail.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.price_detail.ToolTipTitle = "Info";
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
            this.quantity.Properties.Mask.BeepOnError = true;
            this.quantity.Properties.Mask.EditMask = "d";
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
            this.med_detail.Size = new System.Drawing.Size(147, 20);
            this.med_detail.TabIndex = 1;
            this.med_detail.ToolTip = "Choose the Medicine Detail or Enter it Yourself.";
            this.med_detail.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.med_detail.ToolTipTitle = "Info";
            this.med_detail.Validating += new System.ComponentModel.CancelEventHandler(this.med_detail_Validating);
            // 
            // stockdate
            // 
            this.stockdate.EditValue = null;
            this.stockdate.Location = new System.Drawing.Point(157, 38);
            this.stockdate.Name = "stockdate";
            this.stockdate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.stockdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stockdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stockdate.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.stockdate.Size = new System.Drawing.Size(147, 20);
            this.stockdate.TabIndex = 0;
            this.stockdate.ToolTip = "Choose the Stock Entry Date";
            this.stockdate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.stockdate.ToolTipTitle = "Info";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(31, 172);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 16);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Remark";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(336, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 16);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Price";
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
            this.labelControl5.Size = new System.Drawing.Size(111, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Manufacturing Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(31, 139);
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
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Medicine Detail";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(31, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stock Date";
            // 
            // batch_detail
            // 
            this.batch_detail.Location = new System.Drawing.Point(157, 138);
            this.batch_detail.Name = "batch_detail";
            this.batch_detail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.batch_detail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.batch_detail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.batch_detail.Size = new System.Drawing.Size(147, 20);
            this.batch_detail.TabIndex = 3;
            this.batch_detail.ToolTip = "Enter the Batch Number Details as it appears in the medicine box.";
            this.batch_detail.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.batch_detail.ToolTipTitle = "Info";
            // 
            // PharmoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 560);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PharmoStock";
            this.Text = "Pharmacological Stock";
            this.Load += new System.EventHandler(this.PharmoStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfg_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfg_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_rating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark_detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_detail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_detail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton modify_btn;
        public DevExpress.XtraEditors.SimpleButton remove_btn;
        private DevExpress.XtraEditors.RatingControl med_rating;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton clear_btn;
        public DevExpress.XtraEditors.SimpleButton save_btn;
        private DevExpress.XtraEditors.MemoEdit remark_detail;
        private DevExpress.XtraEditors.SpinEdit price_detail;
        private DevExpress.XtraEditors.SpinEdit quantity;
        private DevExpress.XtraEditors.ComboBoxEdit med_detail;
        private DevExpress.XtraEditors.DateEdit stockdate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit batch_detail;
        private DevExpress.XtraEditors.DateEdit mfg_date;
        private DevExpress.XtraEditors.DateEdit exp_date;
    }
}