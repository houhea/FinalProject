namespace Ordering
{
    partial class Ordering
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
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.btnSpecialty = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlPreviousNext = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlStart.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlPreviousNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.lblStart);
            this.pnlStart.Controls.Add(this.pnlOrderType);
            this.pnlStart.Controls.Add(this.pnlLocation);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(41, 12);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(563, 458);
            this.pnlStart.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStart.Location = new System.Drawing.Point(187, 178);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(257, 31);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Push Button to Start";
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.Controls.Add(this.btnSpecialty);
            this.pnlOrderType.Controls.Add(this.btnBuild);
            this.pnlOrderType.Controls.Add(this.lblOrderType);
            this.pnlOrderType.Location = new System.Drawing.Point(0, 3);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(642, 416);
            this.pnlOrderType.TabIndex = 2;
            // 
            // btnSpecialty
            // 
            this.btnSpecialty.Location = new System.Drawing.Point(401, 293);
            this.btnSpecialty.Name = "btnSpecialty";
            this.btnSpecialty.Size = new System.Drawing.Size(104, 74);
            this.btnSpecialty.TabIndex = 4;
            this.btnSpecialty.Text = "Specialty";
            this.btnSpecialty.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(114, 294);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(111, 73);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(53, 110);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(550, 73);
            this.lblOrderType.TabIndex = 2;
            this.lblOrderType.Text = "Choose an Option";
            // 
            // pnlLocation
            // 
            this.pnlLocation.Controls.Add(this.btnOut);
            this.pnlLocation.Controls.Add(this.label1);
            this.pnlLocation.Controls.Add(this.btnIn);
            this.pnlLocation.Location = new System.Drawing.Point(55, 1);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(560, 454);
            this.pnlLocation.TabIndex = 1;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(384, 259);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(94, 81);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eating Location";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(66, 259);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 81);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(221, 333);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 82);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlPreviousNext
            // 
            this.pnlPreviousNext.Controls.Add(this.btnNext);
            this.pnlPreviousNext.Controls.Add(this.btnPrev);
            this.pnlPreviousNext.Location = new System.Drawing.Point(86, 472);
            this.pnlPreviousNext.Name = "pnlPreviousNext";
            this.pnlPreviousNext.Size = new System.Drawing.Size(630, 176);
            this.pnlPreviousNext.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(324, 69);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 64);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(91, 70);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 63);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 589);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlPreviousNext);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlPreviousNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Panel pnlPreviousNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSpecialty;
        private System.Windows.Forms.Button btnBuild;
    }
}

