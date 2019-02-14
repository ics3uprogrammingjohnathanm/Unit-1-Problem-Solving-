namespace MovingCatJohnathanM
{
    partial class frmMovingCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovingCat));
            this.picZombie = new System.Windows.Forms.PictureBox();
            this.btnForwards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picZombie)).BeginInit();
            this.SuspendLayout();
            // 
            // picZombie
            // 
            this.picZombie.BackColor = System.Drawing.Color.Transparent;
            this.picZombie.Image = global::MovingCatJohnathanM.Properties.Resources.zombie1;
            this.picZombie.InitialImage = null;
            this.picZombie.Location = new System.Drawing.Point(64, 31);
            this.picZombie.Name = "picZombie";
            this.picZombie.Size = new System.Drawing.Size(192, 193);
            this.picZombie.TabIndex = 0;
            this.picZombie.TabStop = false;
            this.picZombie.Click += new System.EventHandler(this.picZombie_Click);
            // 
            // btnForwards
            // 
            this.btnForwards.Location = new System.Drawing.Point(300, 106);
            this.btnForwards.Name = "btnForwards";
            this.btnForwards.Size = new System.Drawing.Size(125, 30);
            this.btnForwards.TabIndex = 2;
            this.btnForwards.Text = "Click to make him run";
            this.btnForwards.UseVisualStyleBackColor = true;
            this.btnForwards.Click += new System.EventHandler(this.btnForwards_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 264);
            this.Controls.Add(this.btnForwards);
            this.Controls.Add(this.picZombie);
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat by Johnathan M";
            this.Load += new System.EventHandler(this.frmMovingCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picZombie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picZombie;
        public System.Windows.Forms.Button btnForwards;
    }
}

