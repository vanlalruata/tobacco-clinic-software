namespace TCS
{
    partial class FollowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowUp));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addictionTypeText = new DevExpress.XtraEditors.LabelControl();
            this.nameText = new DevExpress.XtraEditors.LabelControl();
            this.remark_box = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.source_info = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.client_no = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.medication = new DevExpress.XtraEditors.ComboBoxEdit();
            this.treatment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CO_level = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CO_Breath_test = new DevExpress.XtraEditors.RadioGroup();
            this.continine = new DevExpress.XtraEditors.RadioGroup();
            this.use_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.visiting_date = new DevExpress.XtraEditors.DateEdit();
            this.fu_visit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.search_button = new DevExpress.XtraEditors.SimpleButton();
            this.modify_btn = new DevExpress.XtraEditors.SimpleButton();
            this.save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.genderText = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remark_box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_info.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_Breath_test.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiting_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiting_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fu_visit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 466);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(639, 132);
            this.listView1.TabIndex = 130;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderText);
            this.groupBox1.Controls.Add(this.addictionTypeText);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.remark_box);
            this.groupBox1.Controls.Add(this.labelControl42);
            this.groupBox1.Controls.Add(this.source_info);
            this.groupBox1.Controls.Add(this.labelControl41);
            this.groupBox1.Controls.Add(this.client_no);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.medication);
            this.groupBox1.Controls.Add(this.treatment);
            this.groupBox1.Controls.Add(this.CO_level);
            this.groupBox1.Controls.Add(this.CO_Breath_test);
            this.groupBox1.Controls.Add(this.continine);
            this.groupBox1.Controls.Add(this.use_status);
            this.groupBox1.Controls.Add(this.visiting_date);
            this.groupBox1.Controls.Add(this.fu_visit);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 427);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Followup Register";
            // 
            // addictionTypeText
            // 
            this.addictionTypeText.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addictionTypeText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.addictionTypeText.Location = new System.Drawing.Point(23, 60);
            this.addictionTypeText.Name = "addictionTypeText";
            this.addictionTypeText.Size = new System.Drawing.Size(462, 26);
            this.addictionTypeText.TabIndex = 135;
            this.addictionTypeText.Visible = false;
            // 
            // nameText
            // 
            this.nameText.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.nameText.Location = new System.Drawing.Point(24, 50);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(462, 26);
            this.nameText.TabIndex = 127;
            // 
            // remark_box
            // 
            this.remark_box.Location = new System.Drawing.Point(121, 370);
            this.remark_box.Name = "remark_box";
            this.remark_box.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.remark_box.Size = new System.Drawing.Size(365, 43);
            this.remark_box.TabIndex = 10;
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl42.Location = new System.Drawing.Point(23, 368);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(45, 16);
            this.labelControl42.TabIndex = 126;
            this.labelControl42.Text = "Remark";
            // 
            // source_info
            // 
            this.source_info.Location = new System.Drawing.Point(294, 341);
            this.source_info.Name = "source_info";
            this.source_info.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.source_info.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.source_info.Properties.DisplayFormat.FormatString = "d";
            this.source_info.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.source_info.Properties.EditFormat.FormatString = "d";
            this.source_info.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.source_info.Properties.Items.AddRange(new object[] {
            "Follow-up",
            "Phone Call",
            "Email",
            "Mail"});
            this.source_info.Size = new System.Drawing.Size(194, 20);
            this.source_info.TabIndex = 9;
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl41.Location = new System.Drawing.Point(24, 342);
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
            this.client_no.TabIndex = 0;
            this.client_no.SelectedIndexChanged += new System.EventHandler(this.client_no_SelectedIndexChanged);
            this.client_no.Validating += new System.ComponentModel.CancelEventHandler(this.client_no_Validating);
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
            // medication
            // 
            this.medication.Enabled = false;
            this.medication.Location = new System.Drawing.Point(294, 312);
            this.medication.Name = "medication";
            this.medication.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.medication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.medication.Properties.Items.AddRange(new object[] {
            "Nicogum 2Mg",
            "Nicogum 4Mg"});
            this.medication.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.medication.Size = new System.Drawing.Size(193, 20);
            this.medication.TabIndex = 8;
            // 
            // treatment
            // 
            this.treatment.Location = new System.Drawing.Point(294, 281);
            this.treatment.Name = "treatment";
            this.treatment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.treatment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treatment.Properties.Items.AddRange(new object[] {
            "Behaviour Counselling",
            "Behaviour Counselling + Medication",
            "Behaviour Counselling + NRT",
            "Behaviour Counselling + NRT + Medication"});
            this.treatment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.treatment.Size = new System.Drawing.Size(193, 20);
            this.treatment.TabIndex = 7;
            this.treatment.SelectedIndexChanged += new System.EventHandler(this.treatment_SelectedIndexChanged);
            // 
            // CO_level
            // 
            this.CO_level.Enabled = false;
            this.CO_level.Location = new System.Drawing.Point(294, 250);
            this.CO_level.Name = "CO_level";
            this.CO_level.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.CO_level.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CO_level.Properties.Items.AddRange(new object[] {
            "0-6N",
            "7-10N",
            "More than 10N"});
            this.CO_level.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CO_level.Size = new System.Drawing.Size(193, 20);
            this.CO_level.TabIndex = 6;
            // 
            // CO_Breath_test
            // 
            this.CO_Breath_test.Location = new System.Drawing.Point(296, 216);
            this.CO_Breath_test.Name = "CO_Breath_test";
            this.CO_Breath_test.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.CO_Breath_test.Properties.Appearance.Options.UseBackColor = true;
            this.CO_Breath_test.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CO_Breath_test.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Done", "Done"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Not Done", "Not Done")});
            this.CO_Breath_test.Size = new System.Drawing.Size(192, 24);
            this.CO_Breath_test.TabIndex = 5;
            this.CO_Breath_test.SelectedIndexChanged += new System.EventHandler(this.CO_Breath_test_SelectedIndexChanged);
            // 
            // continine
            // 
            this.continine.Location = new System.Drawing.Point(295, 186);
            this.continine.Name = "continine";
            this.continine.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.continine.Properties.Appearance.Options.UseBackColor = true;
            this.continine.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.continine.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Done", "Done"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Not Done", "Not Done")});
            this.continine.Size = new System.Drawing.Size(192, 24);
            this.continine.TabIndex = 4;
            // 
            // use_status
            // 
            this.use_status.Location = new System.Drawing.Point(295, 154);
            this.use_status.Name = "use_status";
            this.use_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.use_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.use_status.Properties.Items.AddRange(new object[] {
            "No Change",
            "Reduce",
            "Lost to Follow-up",
            "Relapse",
            "Quit",
            "Terminated"});
            this.use_status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.use_status.Size = new System.Drawing.Size(193, 20);
            this.use_status.TabIndex = 3;
            this.use_status.SelectedIndexChanged += new System.EventHandler(this.use_status_SelectedIndexChanged);
            // 
            // visiting_date
            // 
            this.visiting_date.EditValue = null;
            this.visiting_date.Location = new System.Drawing.Point(295, 122);
            this.visiting_date.Name = "visiting_date";
            this.visiting_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.visiting_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.visiting_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.visiting_date.Properties.CalendarTimeProperties.Mask.EditMask = "d";
            this.visiting_date.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.visiting_date.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.visiting_date.Size = new System.Drawing.Size(193, 20);
            this.visiting_date.TabIndex = 2;
            // 
            // fu_visit
            // 
            this.fu_visit.Location = new System.Drawing.Point(295, 91);
            this.fu_visit.Name = "fu_visit";
            this.fu_visit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fu_visit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fu_visit.Properties.Items.AddRange(new object[] {
            "0 - 2 Weeks",
            "2 - 4 Weeks",
            "4 - 6 Weeks",
            "6 Weeks - 3 Months",
            "3 - 6 Months",
            "6 - 9 Months",
            "9 - 12 Months"});
            this.fu_visit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fu_visit.Size = new System.Drawing.Size(193, 20);
            this.fu_visit.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(23, 313);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 16);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Medication / NRT";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(23, 282);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 16);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Treatment";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(23, 251);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "CO Level";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(23, 220);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(107, 16);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "CO Breath analysis";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(23, 186);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(190, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Continine Test (Done / Not Done)";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(23, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Use Status";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Visiting Date";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(226, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "F/U Visit No. and source of information.";
            // 
            // search_button
            // 
            this.search_button.Image = global::TCS.Properties.Resources.Magnifier;
            this.search_button.Location = new System.Drawing.Point(560, 164);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(99, 40);
            this.search_button.TabIndex = 134;
            this.search_button.Text = "Search";
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.Image = global::TCS.Properties.Resources.Pen;
            this.modify_btn.Location = new System.Drawing.Point(560, 96);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(99, 40);
            this.modify_btn.TabIndex = 132;
            this.modify_btn.Text = "Modify";
            this.modify_btn.Visible = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = global::TCS.Properties.Resources.Success;
            this.save_btn.Location = new System.Drawing.Point(560, 96);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(99, 40);
            this.save_btn.TabIndex = 133;
            this.save_btn.Text = "Save Now";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Image = global::TCS.Properties.Resources.Clock;
            this.clear_btn.Location = new System.Drawing.Point(560, 33);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(99, 40);
            this.clear_btn.TabIndex = 131;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // genderText
            // 
            this.genderText.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.genderText.Location = new System.Drawing.Point(25, 60);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(462, 26);
            this.genderText.TabIndex = 136;
            this.genderText.Visible = false;
            // 
            // FollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 617);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FollowUp";
            this.Text = "Follow Up Register";
            this.Load += new System.EventHandler(this.FollowUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remark_box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_info.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_Breath_test.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiting_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiting_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fu_visit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit remark_box;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.ComboBoxEdit source_info;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.ComboBoxEdit client_no;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit medication;
        private DevExpress.XtraEditors.ComboBoxEdit treatment;
        private DevExpress.XtraEditors.ComboBoxEdit CO_level;
        private DevExpress.XtraEditors.RadioGroup CO_Breath_test;
        private DevExpress.XtraEditors.RadioGroup continine;
        private DevExpress.XtraEditors.ComboBoxEdit use_status;
        private DevExpress.XtraEditors.DateEdit visiting_date;
        private DevExpress.XtraEditors.ComboBoxEdit fu_visit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SimpleButton modify_btn;
        public DevExpress.XtraEditors.SimpleButton save_btn;
        private DevExpress.XtraEditors.SimpleButton clear_btn;
        private DevExpress.XtraEditors.LabelControl nameText;
        public DevExpress.XtraEditors.SimpleButton search_button;
        private DevExpress.XtraEditors.LabelControl addictionTypeText;
        private DevExpress.XtraEditors.LabelControl genderText;
    }
}