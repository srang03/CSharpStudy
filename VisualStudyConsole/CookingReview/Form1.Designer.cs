namespace CookingReview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cooking = new System.Windows.Forms.Button();
            this.btn_watching = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cookingStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_watching = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cooking
            // 
            this.btn_cooking.Location = new System.Drawing.Point(3, 38);
            this.btn_cooking.Name = "btn_cooking";
            this.btn_cooking.Size = new System.Drawing.Size(295, 65);
            this.btn_cooking.TabIndex = 0;
            this.btn_cooking.Text = "Cooking";
            this.btn_cooking.UseVisualStyleBackColor = true;
            this.btn_cooking.Click += new System.EventHandler(this.btn_cooking_Click);
            // 
            // btn_watching
            // 
            this.btn_watching.Location = new System.Drawing.Point(3, 38);
            this.btn_watching.Name = "btn_watching";
            this.btn_watching.Size = new System.Drawing.Size(290, 74);
            this.btn_watching.TabIndex = 1;
            this.btn_watching.Text = "Watching";
            this.btn_watching.UseVisualStyleBackColor = true;
            this.btn_watching.Click += new System.EventHandler(this.btn_watching_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cooking Space";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // lbl_cookingStatus
            // 
            this.lbl_cookingStatus.AutoSize = true;
            this.lbl_cookingStatus.Location = new System.Drawing.Point(52, 119);
            this.lbl_cookingStatus.Name = "lbl_cookingStatus";
            this.lbl_cookingStatus.Size = new System.Drawing.Size(39, 15);
            this.lbl_cookingStatus.TabIndex = 2;
            this.lbl_cookingStatus.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cooking);
            this.panel1.Controls.Add(this.lbl_cookingStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 211);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lbl_watching);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_watching);
            this.panel2.Location = new System.Drawing.Point(319, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 211);
            this.panel2.TabIndex = 4;
            // 
            // lbl_watching
            // 
            this.lbl_watching.AutoSize = true;
            this.lbl_watching.Location = new System.Drawing.Point(57, 119);
            this.lbl_watching.Name = "lbl_watching";
            this.lbl_watching.Size = new System.Drawing.Size(39, 15);
            this.lbl_watching.TabIndex = 2;
            this.lbl_watching.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Watching Space";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cooking;
        private System.Windows.Forms.Button btn_watching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cookingStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_watching;
        private System.Windows.Forms.Label label3;
    }
}
