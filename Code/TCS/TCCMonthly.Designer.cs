namespace TCS
{
    partial class TCCMonthly
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCCMonthly));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentMonthCommand = new DevExpress.XtraEditors.SimpleButton();
            this.search_Button = new DevExpress.XtraEditors.SimpleButton();
            this.yearOf = new DevExpress.XtraEditors.ComboBoxEdit();
            this.monthOf = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.printButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.MSWord = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearOf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthOf.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentMonthCommand);
            this.groupBox1.Controls.Add(this.search_Button);
            this.groupBox1.Controls.Add(this.yearOf);
            this.groupBox1.Controls.Add(this.monthOf);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // currentMonthCommand
            // 
            this.currentMonthCommand.Image = global::TCS.Properties.Resources.Calendar;
            this.currentMonthCommand.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.currentMonthCommand.Location = new System.Drawing.Point(328, 31);
            this.currentMonthCommand.Name = "currentMonthCommand";
            this.currentMonthCommand.Size = new System.Drawing.Size(43, 50);
            toolTipTitleItem1.Text = "Information";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Choose Current Month";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.currentMonthCommand.SuperTip = superToolTip1;
            this.currentMonthCommand.TabIndex = 9;
            this.currentMonthCommand.ToolTip = "Choose Current Month";
            this.currentMonthCommand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.currentMonthCommand.Click += new System.EventHandler(this.currentMonthCommand_Click);
            // 
            // search_Button
            // 
            this.search_Button.Image = global::TCS.Properties.Resources.Magnifier;
            this.search_Button.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.search_Button.Location = new System.Drawing.Point(387, 31);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(43, 50);
            this.search_Button.TabIndex = 8;
            this.search_Button.ToolTip = "Click here to generate the Short Report";
            this.search_Button.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // yearOf
            // 
            this.yearOf.Location = new System.Drawing.Point(162, 61);
            this.yearOf.Name = "yearOf";
            this.yearOf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.yearOf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.yearOf.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.yearOf.Size = new System.Drawing.Size(146, 20);
            this.yearOf.TabIndex = 4;
            // 
            // monthOf
            // 
            this.monthOf.Location = new System.Drawing.Point(162, 30);
            this.monthOf.Name = "monthOf";
            this.monthOf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.monthOf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.monthOf.Size = new System.Drawing.Size(146, 20);
            this.monthOf.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(26, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Year";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(26, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "For the Month Of";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 130);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 209);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // printButton
            // 
            this.printButton.Image = global::TCS.Properties.Resources.Print;
            this.printButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.printButton.Location = new System.Drawing.Point(393, 344);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(68, 50);
            toolTipTitleItem2.Text = "Information";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Click here to Print";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.printButton.SuperTip = superToolTip2;
            this.printButton.TabIndex = 10;
            this.printButton.ToolTip = "Click here to Print";
            this.printButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.printButton.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::TCS.Properties.Resources.Diskette;
            this.SaveButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SaveButton.Location = new System.Drawing.Point(216, 344);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(68, 50);
            toolTipTitleItem3.Text = "Information";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Click here to Save the Report";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.SaveButton.SuperTip = superToolTip3;
            this.SaveButton.TabIndex = 11;
            this.SaveButton.ToolTip = "Click here to Save the Report";
            this.SaveButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MSWord
            // 
            this.MSWord.Image = global::TCS.Properties.Resources.Document;
            this.MSWord.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.MSWord.Location = new System.Drawing.Point(306, 344);
            this.MSWord.Name = "MSWord";
            this.MSWord.Size = new System.Drawing.Size(68, 50);
            toolTipTitleItem4.Text = "Information";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Click here to Print Preview";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.MSWord.SuperTip = superToolTip4;
            this.MSWord.TabIndex = 12;
            this.MSWord.ToolTip = "Click here to Print Preview";
            this.MSWord.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // TCCMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 406);
            this.Controls.Add(this.MSWord);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TCCMonthly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TCC Monthly Report";
            this.Load += new System.EventHandler(this.TCCMonthly_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearOf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthOf.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit yearOf;
        private DevExpress.XtraScheduler.UI.MonthEdit monthOf;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton search_Button;
        private DevExpress.XtraEditors.SimpleButton currentMonthCommand;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.SimpleButton printButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton MSWord;
    }
}