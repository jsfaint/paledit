namespace PalEditor
{
    partial class FormMagic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemOK = new System.Windows.Forms.MenuItem();
            this.menuItemCancel = new System.Windows.Forms.MenuItem();
            this.labelMagic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemOK);
            this.mainMenu1.MenuItems.Add(this.menuItemCancel);
            // 
            // menuItemOK
            // 
            this.menuItemOK.Text = "确认";
            this.menuItemOK.Click += new System.EventHandler(this.menuItemOK_Click);
            // 
            // menuItemCancel
            // 
            this.menuItemCancel.Text = "取消";
            this.menuItemCancel.Click += new System.EventHandler(this.menuItemCancel_Click);
            // 
            // labelMagic
            // 
            this.labelMagic.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.labelMagic.Location = new System.Drawing.Point(0, 0);
            this.labelMagic.Name = "labelMagic";
            this.labelMagic.Size = new System.Drawing.Size(451, 41);
            // 
            // FormMagic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.ControlBox = false;
            this.Controls.Add(this.labelMagic);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "FormMagic";
            this.Text = "仙术修改";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMagic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemOK;
        private System.Windows.Forms.MenuItem menuItemCancel;
        private System.Windows.Forms.Label labelMagic;
    }
}