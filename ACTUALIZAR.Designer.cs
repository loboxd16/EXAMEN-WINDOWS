namespace EXAMEN_WINDOWS
{
    partial class ACTUALIZAR
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
            BUSCAR = new Button();
            txtID = new TextBox();
            groupBox1 = new GroupBox();
            txtSTOCK = new TextBox();
            txtNOMBRE = new TextBox();
            label2 = new Label();
            MO = new Label();
            button1 = new Button();
            label4 = new Label();
            txtPRECIO = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 58);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(351, 54);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(75, 23);
            BUSCAR.TabIndex = 1;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(153, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPRECIO);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSTOCK);
            groupBox1.Controls.Add(txtNOMBRE);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MO);
            groupBox1.Location = new Point(102, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 198);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtSTOCK
            // 
            txtSTOCK.Location = new Point(114, 121);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.Size = new Size(100, 23);
            txtSTOCK.TabIndex = 4;
            // 
            // txtNOMBRE
            // 
            txtNOMBRE.Location = new Point(114, 41);
            txtNOMBRE.Name = "txtNOMBRE";
            txtNOMBRE.Size = new Size(100, 23);
            txtNOMBRE.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "STOCK";
            // 
            // MO
            // 
            MO.AutoSize = true;
            MO.Location = new Point(23, 49);
            MO.Name = "MO";
            MO.Size = new Size(56, 15);
            MO.TabIndex = 0;
            MO.Text = "NOMBRE";
            // 
            // button1
            // 
            button1.Location = new Point(226, 403);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 4;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 82);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "PRECIO";
            // 
            // txtPRECIO
            // 
            txtPRECIO.Location = new Point(114, 79);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.Size = new Size(100, 23);
            txtPRECIO.TabIndex = 7;
            // 
            // ACTUALIZAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(BUSCAR);
            Controls.Add(label1);
            Name = "ACTUALIZAR";
            Text = "ACTUALIZAR";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BUSCAR;
        private TextBox txtID;
        private GroupBox groupBox1;
        private Label label2;
        private Label MO;
        private TextBox txtSTOCK;
        private TextBox txtNOMBRE;
        private Button button1;
        private TextBox txtPRECIO;
        private Label label4;
    }
}