namespace UzbRusEngTextTransformer
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
            this.input_text = new System.Windows.Forms.RichTextBox();
            this.natija_text = new System.Windows.Forms.RichTextBox();
            this.button_uzb_krill = new System.Windows.Forms.Button();
            this.button_krill_uzb = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_text
            // 
            this.input_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_text.Location = new System.Drawing.Point(0, 0);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(677, 597);
            this.input_text.TabIndex = 0;
            this.input_text.Text = "";
            this.input_text.TextChanged += new System.EventHandler(this.input_text_TextChanged);
            this.input_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_text_KeyPress);
            // 
            // natija_text
            // 
            this.natija_text.Dock = System.Windows.Forms.DockStyle.Right;
            this.natija_text.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.natija_text.Location = new System.Drawing.Point(3, 0);
            this.natija_text.Name = "natija_text";
            this.natija_text.ReadOnly = true;
            this.natija_text.Size = new System.Drawing.Size(674, 597);
            this.natija_text.TabIndex = 1;
            this.natija_text.Text = "";
            // 
            // button_uzb_krill
            // 
            this.button_uzb_krill.Location = new System.Drawing.Point(31, 35);
            this.button_uzb_krill.Name = "button_uzb_krill";
            this.button_uzb_krill.Size = new System.Drawing.Size(140, 38);
            this.button_uzb_krill.TabIndex = 2;
            this.button_uzb_krill.Text = "Uzb - Крилл";
            this.button_uzb_krill.UseVisualStyleBackColor = true;
            this.button_uzb_krill.Click += new System.EventHandler(this.button_uzb_krill_Click);
            // 
            // button_krill_uzb
            // 
            this.button_krill_uzb.Location = new System.Drawing.Point(204, 35);
            this.button_krill_uzb.Name = "button_krill_uzb";
            this.button_krill_uzb.Size = new System.Drawing.Size(140, 38);
            this.button_krill_uzb.TabIndex = 3;
            this.button_krill_uzb.Text = "Крилл - Uzb";
            this.button_krill_uzb.UseVisualStyleBackColor = true;
            this.button_krill_uzb.Click += new System.EventHandler(this.button_krill_uzb_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(1141, 36);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(163, 37);
            this.button_copy.TabIndex = 4;
            this.button_copy.Text = "Nusxa olish";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.Color.Red;
            this.button_clear.Location = new System.Drawing.Point(469, 35);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(139, 38);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Tozalash";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_uzb_krill);
            this.panel1.Controls.Add(this.button_copy);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_krill_uzb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 108);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.input_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 597);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.natija_text);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(683, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 597);
            this.panel3.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(668, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ochish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(844, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Saqlash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 705);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Conventor";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_text;
        private System.Windows.Forms.RichTextBox natija_text;
        private System.Windows.Forms.Button button_uzb_krill;
        private System.Windows.Forms.Button button_krill_uzb;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

