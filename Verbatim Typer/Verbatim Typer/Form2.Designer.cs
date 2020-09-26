namespace Verbatim_Typer
{
    partial class Form2
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
            this.defHead_tbx = new System.Windows.Forms.TextBox();
            this.defHead_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.defContent_lbl = new System.Windows.Forms.Label();
            this.defContent_tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // defHead_tbx
            // 
            this.defHead_tbx.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defHead_tbx.Location = new System.Drawing.Point(30, 40);
            this.defHead_tbx.Name = "defHead_tbx";
            this.defHead_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.defHead_tbx.Size = new System.Drawing.Size(300, 23);
            this.defHead_tbx.TabIndex = 0;
            // 
            // defHead_lbl
            // 
            this.defHead_lbl.AutoSize = true;
            this.defHead_lbl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defHead_lbl.Location = new System.Drawing.Point(30, 20);
            this.defHead_lbl.Name = "defHead_lbl";
            this.defHead_lbl.Size = new System.Drawing.Size(152, 19);
            this.defHead_lbl.TabIndex = 2;
            this.defHead_lbl.Text = "New Definition Name";
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.submit_btn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(350, 150);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 40);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // defContent_lbl
            // 
            this.defContent_lbl.AutoSize = true;
            this.defContent_lbl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defContent_lbl.Location = new System.Drawing.Point(27, 70);
            this.defContent_lbl.Name = "defContent_lbl";
            this.defContent_lbl.Size = new System.Drawing.Size(323, 19);
            this.defContent_lbl.TabIndex = 6;
            this.defContent_lbl.Text = "New Definition Content (don\'t use line breaks)";
            // 
            // defContent_tbx
            // 
            this.defContent_tbx.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defContent_tbx.Location = new System.Drawing.Point(30, 90);
            this.defContent_tbx.MaximumSize = new System.Drawing.Size(300, 100);
            this.defContent_tbx.Multiline = true;
            this.defContent_tbx.Name = "defContent_tbx";
            this.defContent_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defContent_tbx.Size = new System.Drawing.Size(300, 100);
            this.defContent_tbx.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(454, 211);
            this.Controls.Add(this.defContent_tbx);
            this.Controls.Add(this.defContent_lbl);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.defHead_lbl);
            this.Controls.Add(this.defHead_tbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Add New Definition";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox defHead_tbx;
        private System.Windows.Forms.Label defHead_lbl;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label defContent_lbl;
        private System.Windows.Forms.TextBox defContent_tbx;
    }
}