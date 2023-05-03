
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
            this.lbl_NameTitle = new System.Windows.Forms.Label();
            this.lbl_NativesTitle = new System.Windows.Forms.Label();
            this.lbl_Natives = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_GeneralInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_GeneralInfo
            // 
            this.grp_GeneralInfo.Controls.Add(this.label4);
            this.grp_GeneralInfo.Controls.Add(this.lbl_NativesTitle);
            this.grp_GeneralInfo.Controls.Add(this.label3);
            this.grp_GeneralInfo.Controls.Add(this.lbl_Natives);
            this.grp_GeneralInfo.Controls.Add(this.lbl_NameTitle);
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
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(115, 31);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_NameTitle
            // 
            this.lbl_NameTitle.AutoSize = true;
            this.lbl_NameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameTitle.Location = new System.Drawing.Point(13, 31);
            this.lbl_NameTitle.Name = "lbl_NameTitle";
            this.lbl_NameTitle.Size = new System.Drawing.Size(48, 16);
            this.lbl_NameTitle.TabIndex = 1;
            this.lbl_NameTitle.Text = "Name:";
            // 
            // lbl_NativesTitle
            // 
            this.lbl_NativesTitle.AutoSize = true;
            this.lbl_NativesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NativesTitle.Location = new System.Drawing.Point(13, 63);
            this.lbl_NativesTitle.Name = "lbl_NativesTitle";
            this.lbl_NativesTitle.Size = new System.Drawing.Size(57, 16);
            this.lbl_NativesTitle.TabIndex = 3;
            this.lbl_NativesTitle.Text = "Natives:";
            // 
            // lbl_Natives
            // 
            this.lbl_Natives.AutoSize = true;
            this.lbl_Natives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Natives.Location = new System.Drawing.Point(115, 63);
            this.lbl_Natives.Name = "lbl_Natives";
            this.lbl_Natives.Size = new System.Drawing.Size(54, 16);
            this.lbl_Natives.TabIndex = 2;
            this.lbl_Natives.Text = "Natives";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_NativesTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Natives;
        private System.Windows.Forms.Label lbl_NameTitle;
    }
}