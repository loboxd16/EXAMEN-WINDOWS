namespace EXAMEN_WINDOWS
{
    partial class BUSCAR
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
            txtID = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtSTOCK = new TextBox();
            txtPRECIO = new TextBox();
            txtNOMBRE = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(338, 98);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 98);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 20;
            label7.Text = "ID_PRODUCTO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSTOCK);
            groupBox1.Controls.Add(txtPRECIO);
            groupBox1.Controls.Add(txtNOMBRE);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(238, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 198);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "PRECIO";
            // 
            // txtSTOCK
            // 
            txtSTOCK.Location = new Point(80, 108);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.Size = new Size(100, 23);
            txtSTOCK.TabIndex = 5;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Location = new Point(80, 70);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.Size = new Size(100, 23);
            txtPRECIO.TabIndex = 4;
            // 
            // txtNOMBRE
            // 
            txtNOMBRE.Location = new Point(80, 34);
            txtNOMBRE.Name = "txtNOMBRE";
            txtNOMBRE.Size = new Size(100, 23);
            txtNOMBRE.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 108);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 2;
            label6.Text = "STOCK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 34);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 281);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 227);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 181);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(488, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BUSCAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "BUSCAR";
            Text = "BUSCAR";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label7;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtSTOCK;
        private TextBox txtPRECIO;
        private TextBox txtNOMBRE;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}