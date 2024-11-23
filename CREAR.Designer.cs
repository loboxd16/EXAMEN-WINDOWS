namespace EXAMEN_WINDOWS
{
    partial class CREAR
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtSTOCK = new TextBox();
            txtPRECIO = new TextBox();
            txtNOMBRE = new TextBox();
            label6 = new Label();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 144);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 190);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 244);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSTOCK);
            groupBox1.Controls.Add(txtPRECIO);
            groupBox1.Controls.Add(txtNOMBRE);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(98, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 198);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "PRECIO";
            // 
            // txtSTOCK
            // 
            txtSTOCK.Location = new Point(80, 132);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.Size = new Size(100, 23);
            txtSTOCK.TabIndex = 5;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Location = new Point(80, 94);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.Size = new Size(100, 23);
            txtPRECIO.TabIndex = 4;
            // 
            // txtNOMBRE
            // 
            txtNOMBRE.Location = new Point(80, 58);
            txtNOMBRE.Name = "txtNOMBRE";
            txtNOMBRE.Size = new Size(100, 23);
            txtNOMBRE.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 132);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 2;
            label6.Text = "STOCK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 58);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "NOMBRE";
            // 
            // button2
            // 
            button2.Location = new Point(203, 321);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "AÑADIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CREAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CREAR";
            Text = "CREAR";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtSTOCK;
        private TextBox txtPRECIO;
        private TextBox txtNOMBRE;
        private Label label6;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}