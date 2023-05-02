
namespace OnBoardTree.DetailForms
{
    partial class frmPlanetDetails
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
            this.grp_GeneralInfo = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.grp_GeneralInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_GeneralInfo
            // 
            this.grp_GeneralInfo.Controls.Add(this.lbl_Name);
            this.grp_GeneralInfo.Location = new System.Drawing.Point(12, 12);
            this.grp_GeneralInfo.Name = "grp_GeneralInfo";
            this.grp_GeneralInfo.Size = new System.Drawing.Size(262, 193);
            this.grp_GeneralInfo.TabIndex = 0;
            this.grp_GeneralInfo.TabStop = false;
            this.grp_GeneralInfo.Text = "General Info";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(18, 34);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // frmPlanetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 505);
            this.Controls.Add(this.grp_GeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanetDetails";
            this.Text = "frmPlanetDetails";
            this.grp_GeneralInfo.ResumeLayout(false);
            this.grp_GeneralInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_GeneralInfo;
        private System.Windows.Forms.Label lbl_Name;
    }
}