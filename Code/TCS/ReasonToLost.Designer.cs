namespace TCS
{
    partial class ReasonToLost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.reason = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.reason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Reason for Losing to FollowUp";
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(18, 58);
            this.reason.Name = "reason";
            this.reason.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Properties.Appearance.Options.UseFont = true;
            this.reason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.reason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reason.Properties.Items.AddRange(new object[] {
            "Does not own Phone or Number",
            "Phone Connectivity Problem",
            "Call Not Picking",
            "Not Reachable",
            "Others"});
            this.reason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.reason.Size = new System.Drawing.Size(173, 22);
            this.reason.TabIndex = 1;
            this.reason.SelectedIndexChanged += new System.EventHandler(this.reason_SelectedIndexChanged);
            // 
            // ReasonToLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reason);
            this.Controls.Add(this.labelControl1);
            this.Name = "ReasonToLost";
            this.Size = new System.Drawing.Size(225, 111);
            ((System.ComponentModel.ISupportInitialize)(this.reason.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit reason;
    }
}
