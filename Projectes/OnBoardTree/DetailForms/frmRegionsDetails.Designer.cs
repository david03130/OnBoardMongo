
namespace OnBoardTree.DetailForms
{
    partial class frmRegionsDetails
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
            this.lbl_NameTitle = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.pic_Map = new System.Windows.Forms.PictureBox();
            this.grp_GeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_GeneralInfo
            // 
            this.grp_GeneralInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_GeneralInfo.Controls.Add(this.lbl_Description);
            this.grp_GeneralInfo.Controls.Add(this.lbl_DescriptionTitle);
            this.grp_GeneralInfo.Controls.Add(this.lbl_NameTitle);
            this.grp_GeneralInfo.Controls.Add(this.lbl_Name);
            this.grp_GeneralInfo.Location = new System.Drawing.Point(12, 12);
            this.grp_GeneralInfo.Name = "grp_GeneralInfo";
            this.grp_GeneralInfo.Size = new System.Drawing.Size(604, 232);
            this.grp_GeneralInfo.TabIndex = 0;
            this.grp_GeneralInfo.TabStop = false;
            this.grp_GeneralInfo.Text = "General Info";
            // 
            // lbl_DescriptionTitle
            // 
            this.lbl_DescriptionTitle.AutoSize = true;
            this.lbl_DescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescriptionTitle.Location = new System.Drawing.Point(13, 63);
            this.lbl_DescriptionTitle.Name = "lbl_DescriptionTitle";
            this.lbl_DescriptionTitle.Size = new System.Drawing.Size(79, 16);
            this.lbl_DescriptionTitle.TabIndex = 3;
            this.lbl_DescriptionTitle.Text = "Description:";
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
            // lbl_Description
            // 
            this.lbl_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(13, 88);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(578, 130);
            this.lbl_Description.TabIndex = 4;
            this.lbl_Description.Text = "Description";
            // 
            // pic_Map
            // 
            this.pic_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Map.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pic_Map.Location = new System.Drawing.Point(41, 261);
            this.pic_Map.Name = "pic_Map";
            this.pic_Map.Size = new System.Drawing.Size(539, 317);
            this.pic_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Map.TabIndex = 1;
            this.pic_Map.TabStop = false;
            // 
            // frmRegionsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 600);
            this.Controls.Add(this.pic_Map);
            this.Controls.Add(this.grp_GeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegionsDetails";
            this.Text = "frmPlanetDetails";
            this.grp_GeneralInfo.ResumeLayout(false);
            this.grp_GeneralInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_GeneralInfo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DescriptionTitle;
        private System.Windows.Forms.Label lbl_NameTitle;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.PictureBox pic_Map;
    }
}