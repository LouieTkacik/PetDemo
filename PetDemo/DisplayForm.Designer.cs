namespace PetDemo
{
    partial class DisplayForm
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
            this.displayList = new System.Windows.Forms.ListBox();
            this.exitButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayList
            // 
            this.displayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayList.FormattingEnabled = true;
            this.displayList.ItemHeight = 20;
            this.displayList.Location = new System.Drawing.Point(94, 60);
            this.displayList.Name = "displayList";
            this.displayList.Size = new System.Drawing.Size(439, 264);
            this.displayList.TabIndex = 0;
            // 
            // exitButt
            // 
            this.exitButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButt.Location = new System.Drawing.Point(259, 342);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(91, 51);
            this.exitButt.TabIndex = 1;
            this.exitButt.Text = "Exit";
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.exitButt);
            this.Controls.Add(this.displayList);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButt;
        public System.Windows.Forms.ListBox displayList;
    }
}