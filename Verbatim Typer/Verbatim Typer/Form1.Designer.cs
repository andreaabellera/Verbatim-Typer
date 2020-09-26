namespace Verbatim_Typer
{
    partial class Form1
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
            this.head_lbl = new System.Windows.Forms.Label();
            this.input_tbx = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.score_lbl = new System.Windows.Forms.Label();
            this.masterlist_lbl = new System.Windows.Forms.Label();
            this.defSelector_cmbx = new System.Windows.Forms.ComboBox();
            this.random_btn = new System.Windows.Forms.Button();
            this.repeat_btn = new System.Windows.Forms.Button();
            this.newDef_btn = new System.Windows.Forms.Button();
            this.output_tbx = new System.Windows.Forms.TextBox();
            this.switch_btn = new System.Windows.Forms.Button();
            this.src_tbx = new System.Windows.Forms.TextBox();
            this.src_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // head_lbl
            // 
            this.head_lbl.AutoSize = true;
            this.head_lbl.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_lbl.Location = new System.Drawing.Point(350, 20);
            this.head_lbl.Name = "head_lbl";
            this.head_lbl.Size = new System.Drawing.Size(152, 23);
            this.head_lbl.TabIndex = 0;
            this.head_lbl.Text = "VERBATIM TYPER";
            this.head_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_tbx
            // 
            this.input_tbx.BackColor = System.Drawing.SystemColors.Window;
            this.input_tbx.Enabled = false;
            this.input_tbx.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_tbx.Location = new System.Drawing.Point(250, 50);
            this.input_tbx.MaximumSize = new System.Drawing.Size(350, 250);
            this.input_tbx.Multiline = true;
            this.input_tbx.Name = "input_tbx";
            this.input_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_tbx.Size = new System.Drawing.Size(350, 40);
            this.input_tbx.TabIndex = 2;
            this.input_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_tbx_KeyPress);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.reset_btn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(700, 260);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 40);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Text = "Reset List";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(142, 230);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(93, 21);
            this.score_lbl.TabIndex = 7;
            this.score_lbl.Text = "Score: 0/0";
            // 
            // masterlist_lbl
            // 
            this.masterlist_lbl.AutoSize = true;
            this.masterlist_lbl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterlist_lbl.Location = new System.Drawing.Point(625, 50);
            this.masterlist_lbl.MaximumSize = new System.Drawing.Size(120, 300);
            this.masterlist_lbl.Name = "masterlist_lbl";
            this.masterlist_lbl.Size = new System.Drawing.Size(82, 19);
            this.masterlist_lbl.TabIndex = 8;
            this.masterlist_lbl.Text = "Masterlist:";
            // 
            // defSelector_cmbx
            // 
            this.defSelector_cmbx.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defSelector_cmbx.FormattingEnabled = true;
            this.defSelector_cmbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.defSelector_cmbx.Location = new System.Drawing.Point(15, 50);
            this.defSelector_cmbx.MaxDropDownItems = 10;
            this.defSelector_cmbx.Name = "defSelector_cmbx";
            this.defSelector_cmbx.Size = new System.Drawing.Size(121, 23);
            this.defSelector_cmbx.TabIndex = 9;
            this.defSelector_cmbx.Text = "Choose definition";
            this.defSelector_cmbx.SelectedIndexChanged += new System.EventHandler(this.defSelector_cmbx_SelectedIndexChanged);
            // 
            // random_btn
            // 
            this.random_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.random_btn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_btn.Location = new System.Drawing.Point(150, 50);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(75, 40);
            this.random_btn.TabIndex = 11;
            this.random_btn.Text = "Random";
            this.random_btn.UseVisualStyleBackColor = false;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // repeat_btn
            // 
            this.repeat_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.repeat_btn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeat_btn.Location = new System.Drawing.Point(150, 260);
            this.repeat_btn.Name = "repeat_btn";
            this.repeat_btn.Size = new System.Drawing.Size(75, 40);
            this.repeat_btn.TabIndex = 12;
            this.repeat_btn.Text = "Start Over";
            this.repeat_btn.UseVisualStyleBackColor = false;
            this.repeat_btn.Click += new System.EventHandler(this.repeat_btn_Click);
            // 
            // newDef_btn
            // 
            this.newDef_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.newDef_btn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDef_btn.Location = new System.Drawing.Point(150, 100);
            this.newDef_btn.Name = "newDef_btn";
            this.newDef_btn.Size = new System.Drawing.Size(75, 40);
            this.newDef_btn.TabIndex = 13;
            this.newDef_btn.Text = "Add New Definition";
            this.newDef_btn.UseVisualStyleBackColor = false;
            this.newDef_btn.Click += new System.EventHandler(this.newDef_btn_Click);
            // 
            // output_tbx
            // 
            this.output_tbx.BackColor = System.Drawing.SystemColors.Window;
            this.output_tbx.Enabled = false;
            this.output_tbx.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_tbx.Location = new System.Drawing.Point(250, 100);
            this.output_tbx.MaximumSize = new System.Drawing.Size(350, 250);
            this.output_tbx.Multiline = true;
            this.output_tbx.Name = "output_tbx";
            this.output_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_tbx.Size = new System.Drawing.Size(350, 203);
            this.output_tbx.TabIndex = 14;
            // 
            // switch_btn
            // 
            this.switch_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.switch_btn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_btn.Location = new System.Drawing.Point(150, 150);
            this.switch_btn.Name = "switch_btn";
            this.switch_btn.Size = new System.Drawing.Size(75, 40);
            this.switch_btn.TabIndex = 15;
            this.switch_btn.Text = "Switch File Source";
            this.switch_btn.UseVisualStyleBackColor = false;
            this.switch_btn.Click += new System.EventHandler(this.switch_btn_Click);
            // 
            // src_tbx
            // 
            this.src_tbx.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_tbx.Location = new System.Drawing.Point(15, 160);
            this.src_tbx.Name = "src_tbx";
            this.src_tbx.Size = new System.Drawing.Size(121, 23);
            this.src_tbx.TabIndex = 16;
            // 
            // src_lbl
            // 
            this.src_lbl.AutoSize = true;
            this.src_lbl.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_lbl.Location = new System.Drawing.Point(12, 144);
            this.src_lbl.MaximumSize = new System.Drawing.Size(150, 300);
            this.src_lbl.Name = "src_lbl";
            this.src_lbl.Size = new System.Drawing.Size(120, 13);
            this.src_lbl.TabIndex = 17;
            this.src_lbl.Text = "Current Source: data.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(784, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.src_lbl);
            this.Controls.Add(this.src_tbx);
            this.Controls.Add(this.switch_btn);
            this.Controls.Add(this.output_tbx);
            this.Controls.Add(this.newDef_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.repeat_btn);
            this.Controls.Add(this.random_btn);
            this.Controls.Add(this.defSelector_cmbx);
            this.Controls.Add(this.masterlist_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.input_tbx);
            this.Controls.Add(this.head_lbl);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Verbatim Typer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head_lbl;
        private System.Windows.Forms.TextBox input_tbx;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label masterlist_lbl;
        private System.Windows.Forms.ComboBox defSelector_cmbx;
        private System.Windows.Forms.Button random_btn;
        private System.Windows.Forms.Button repeat_btn;
        private System.Windows.Forms.Button newDef_btn;
        private System.Windows.Forms.TextBox output_tbx;
        private System.Windows.Forms.Button switch_btn;
        private System.Windows.Forms.TextBox src_tbx;
        private System.Windows.Forms.Label src_lbl;
        private System.Windows.Forms.Button button1;
    }
}

