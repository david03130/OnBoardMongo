
namespace OnBoardTree.DetailForms
{
    partial class frmFiliationsDetails
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
            this.lbl_DescriptionTitle = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.grp_GeneralInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_GeneralInfo
            // 
            this.grp_GeneralInfo.Controls.Add(this.lbl_Description);
            this.grp_GeneralInfo.Controls.Add(this.lbl_DescriptionTitle);
            this.grp_GeneralInfo.Location = new System.Drawing.Point(12, 12);
            this.grp_GeneralInfo.Name = "grp_GeneralInfo";
            this.grp_GeneralInfo.Size = new System.Drawing.Size(290, 106);
            this.grp_GeneralInfo.TabIndex = 0;
            this.grp_GeneralInfo.TabStop = false;
            this.grp_GeneralInfo.Text = "General Info";
            // 
            // lbl_DescriptionTitle
            // 
            this.lbl_DescriptionTitle.AutoSize = true;
            this.lbl_DescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescriptionTitle.Location = new System.Drawing.Point(13, 29);
            this.lbl_DescriptionTitle.Name = "lbl_DescriptionTitle";
            this.lbl_DescriptionTitle.Size = new System.Drawing.Size(79, 16);
            this.lbl_DescriptionTitle.TabIndex = 3;
            this.lbl_DescriptionTitle.Text = "Description:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(130, 29);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(76, 16);
            this.lbl_Description.TabIndex = 4;
            this.lbl_Description.Text = "Description";
            // 
            // frmFiliationsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 144);
            this.Controls.Add(this.grp_GeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFiliationsDetails";
            this.Text = "frmPlanetDetails";
            this.grp_GeneralInfo.ResumeLayout(false);
            this.grp_GeneralInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_GeneralInfo;
        private System.Windows.Forms.Label lbl_DescriptionTitle;
        private System.Windows.Forms.Label lbl_Description;
    }
}