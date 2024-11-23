namespace EXAMEN_WINDOWS
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
            BUSCAR = new Button();
            CREAR = new Button();
            EDITAR = new Button();
            ELIMINAR = new Button();
            SuspendLayout();
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(299, 60);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(112, 73);
            BUSCAR.TabIndex = 0;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // CREAR
            // 
            CREAR.Location = new Point(299, 160);
            CREAR.Name = "CREAR";
            CREAR.Size = new Size(112, 77);
            CREAR.TabIndex = 1;
            CREAR.Text = "CREAR";
            CREAR.UseVisualStyleBackColor = true;
            CREAR.Click += CREAR_Click;
            // 
            // EDITAR
            // 
            EDITAR.Location = new Point(299, 252);
            EDITAR.Name = "EDITAR";
            EDITAR.Size = new Size(112, 76);
            EDITAR.TabIndex = 2;
            EDITAR.Text = "EDITAR";
            EDITAR.UseVisualStyleBackColor = true;
            EDITAR.Click += EDITAR_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(299, 348);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(112, 78);
            ELIMINAR.TabIndex = 3;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ELIMINAR);
            Controls.Add(EDITAR);
            Controls.Add(CREAR);
            Controls.Add(BUSCAR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BUSCAR;
        private Button CREAR;
        private Button EDITAR;
        private Button ELIMINAR;
    }
}
