namespace WindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bSlumpaTal = new System.Windows.Forms.Button();
            this.bJämförTal = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSvar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // bSlumpaTal
            // 
            this.bSlumpaTal.Location = new System.Drawing.Point(325, 39);
            this.bSlumpaTal.Name = "bSlumpaTal";
            this.bSlumpaTal.Size = new System.Drawing.Size(141, 84);
            this.bSlumpaTal.TabIndex = 2;
            this.bSlumpaTal.Text = "Generera ett tal";
            this.bSlumpaTal.UseVisualStyleBackColor = true;
            this.bSlumpaTal.Click += new System.EventHandler(this.bSlumpaTal_Click);
            // 
            // bJämförTal
            // 
            this.bJämförTal.Location = new System.Drawing.Point(325, 241);
            this.bJämförTal.Name = "bJämförTal";
            this.bJämförTal.Size = new System.Drawing.Size(141, 61);
            this.bJämförTal.TabIndex = 3;
            this.bJämförTal.Text = "Jämför talen";
            this.bJämförTal.UseVisualStyleBackColor = true;
            this.bJämförTal.Click += new System.EventHandler(this.bJämförTal_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.richTextBox1.Location = new System.Drawing.Point(344, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 50);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // richTextBoxSvar
            // 
            this.richTextBoxSvar.Location = new System.Drawing.Point(172, 308);
            this.richTextBoxSvar.Name = "richTextBoxSvar";
            this.richTextBoxSvar.Size = new System.Drawing.Size(478, 96);
            this.richTextBoxSvar.TabIndex = 7;
            this.richTextBoxSvar.Text = "";
            this.richTextBoxSvar.TextChanged += new System.EventHandler(this.richTextBoxSvar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxSvar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bJämförTal);
            this.Controls.Add(this.bSlumpaTal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bSlumpaTal;
        private System.Windows.Forms.Button bJämförTal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBoxSvar;
    }
}

