namespace Games.Win.Editors
{
    partial class InfoControl
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
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(22, 28);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(319, 162);
            memoEdit1.TabIndex = 0;
           
            memoEdit1.TextChanged += memoEdit1_TextChanged;
            // 
            // InfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(memoEdit1);
            MinimumSize = new Size(368, 225);
            Name = "InfoControl";
            Size = new Size(368, 225);
         
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}
