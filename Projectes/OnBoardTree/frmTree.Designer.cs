
namespace OnBoardTree
{
    partial class frmTree
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tree_Documents = new System.Windows.Forms.TreeView();
            this.cmb_Collections = new System.Windows.Forms.ComboBox();
            this.pnl_Details = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tree_Documents
            // 
            this.tree_Documents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree_Documents.Location = new System.Drawing.Point(19, 55);
            this.tree_Documents.Name = "tree_Documents";
            this.tree_Documents.Size = new System.Drawing.Size(230, 488);
            this.tree_Documents.TabIndex = 0;
            // 
            // cmb_Collections
            // 
            this.cmb_Collections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Collections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Collections.FormattingEnabled = true;
            this.cmb_Collections.Location = new System.Drawing.Point(19, 19);
            this.cmb_Collections.Name = "cmb_Collections";
            this.cmb_Collections.Size = new System.Drawing.Size(230, 24);
            this.cmb_Collections.TabIndex = 1;
            // 
            // pnl_Details
            // 
            this.pnl_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Details.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Details.Location = new System.Drawing.Point(275, 19);
            this.pnl_Details.Name = "pnl_Details";
            this.pnl_Details.Size = new System.Drawing.Size(792, 524);
            this.pnl_Details.TabIndex = 2;
            // 
            // frmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 559);
            this.Controls.Add(this.pnl_Details);
            this.Controls.Add(this.cmb_Collections);
            this.Controls.Add(this.tree_Documents);
            this.Name = "frmTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnBoard Detalles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree_Documents;
        private System.Windows.Forms.ComboBox cmb_Collections;
        private System.Windows.Forms.Panel pnl_Details;
    }
}

