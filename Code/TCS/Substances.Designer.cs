namespace TCS
{
    partial class Substances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Substances));
            this.listView1 = new System.Windows.Forms.ListView();
            this.modify_btn = new DevExpress.XtraEditors.SimpleButton();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remark_box = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.client_no = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.depend = new DevExpress.XtraEditors.RadioGroup();
            this.sub_used = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pattern_use = new DevExpress.XtraEditors.TextEdit();
            this.avg_unit = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remark_box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_used.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pattern_use.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg_unit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 341);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 181);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 134;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // modify_btn
            // 
            this.modify_btn.Image = global::TCS.Properties.Resources.Pen;
            this.modify_btn.Location = new System.Drawing.Point(414, 281);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(99, 40);
            this.modify_btn.TabIndex = 131;
            this.modify_btn.Text = "Modify";
            this.modify_btn.Visible = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = global::TCS.Properties.Resources.Success;
            this.save_btn.Location = new System.Drawing.Point(414, 281);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(99, 40);
            this.save_btn.TabIndex = 132;
            this.save_btn.Text = "Save Now";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Image = global::TCS.Properties.Resources.Clock;
            this.clear_btn.Location = new System.Drawing.Point(49, 281);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(99, 40);
            this.clear_btn.TabIndex = 130;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remark_box);
            this.groupBox1.Controls.Add(this.labelControl42);
            this.groupBox1.Controls.Add(this.client_no);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.depend);
            this.groupBox1.Controls.Add(this.sub_used);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.pattern_use);
            this.groupBox1.Controls.Add(this.avg_unit);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 237);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Substance Used Register";
            // 
            // remark_box
            // 
            this.remark_box.Location = new System.Drawing.Point(124, 179);
            this.remark_box.Name = "remark_box";
            this.remark_box.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.remark_box.Size = new System.Drawing.Size(365, 43);
            this.remark_box.TabIndex = 5;
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl42.Location = new System.Drawing.Point(23, 177);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(45, 16);
            this.labelControl42.TabIndex = 126;
            this.labelControl42.Text = "Remark";
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
            this.client_no.TabIndex = 0;
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
            // depend
            // 
            this.depend.EditValue = "No";
            this.depend.Location = new System.Drawing.Point(295, 116);
            this.depend.Name = "depend";
            this.depend.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.depend.Properties.Appearance.Options.UseBackColor = true;
            this.depend.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.depend.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")});
            this.depend.Size = new System.Drawing.Size(192, 24);
            this.depend.TabIndex = 3;
            // 
            // sub_used
            // 
            this.sub_used.Location = new System.Drawing.Point(295, 55);
            this.sub_used.Name = "sub_used";
            this.sub_used.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sub_used.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sub_used.Properties.Items.AddRange(new object[] {
            "Cannabis",
            "Benzodiazepines",
            "Opioids",
            "Any other"});
            this.sub_used.Size = new System.Drawing.Size(193, 20);
            this.sub_used.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(23, 149);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(175, 16);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Average Amount/Units per day";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(23, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(114, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Dependence Yes/No";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(201, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Pattern of use in the Past One Year";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Substance Used";
            // 
            // pattern_use
            // 
            this.pattern_use.Location = new System.Drawing.Point(295, 86);
            this.pattern_use.Name = "pattern_use";
            this.pattern_use.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pattern_use.Properties.DisplayFormat.FormatString = "d";
            this.pattern_use.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pattern_use.Properties.EditFormat.FormatString = "d";
            this.pattern_use.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pattern_use.Properties.Mask.EditMask = "d";
            this.pattern_use.Size = new System.Drawing.Size(193, 20);
            this.pattern_use.TabIndex = 2;
            // 
            // avg_unit
            // 
            this.avg_unit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.avg_unit.Location = new System.Drawing.Point(293, 148);
            this.avg_unit.Name = "avg_unit";
            this.avg_unit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.avg_unit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.avg_unit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.avg_unit.Properties.Mask.EditMask = "d";
            this.avg_unit.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.avg_unit.Size = new System.Drawing.Size(193, 20);
            this.avg_unit.TabIndex = 4;
            // 
            // Substances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 553);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Substances";
            this.Text = "Substances";
            this.Load += new System.EventHandler(this.Substances_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remark_box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_used.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pattern_use.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg_unit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        public DevExpress.XtraEditors.SimpleButton modify_btn;
        public DevExpress.XtraEditors.SimpleButton save_btn;
        private DevExpress.XtraEditors.SimpleButton clear_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit remark_box;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        public DevExpress.XtraEditors.ComboBoxEdit client_no;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.RadioGroup depend;
        private DevExpress.XtraEditors.ComboBoxEdit sub_used;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit pattern_use;
        private DevExpress.XtraEditors.SpinEdit avg_unit;
    }
}