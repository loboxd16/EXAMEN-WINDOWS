namespace EXAMEN_WINDOWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            BUSCAR productos = new BUSCAR();
            productos.ShowDialog();
        }

        private void CREAR_Click(object sender, EventArgs e)
        {
            CREAR productos = new CREAR();
            productos.ShowDialog();
        }

        private void EDITAR_Click(object sender, EventArgs e)
        {
            ACTUALIZAR productos = new ACTUALIZAR();
            productos.ShowDialog();
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            ELIMINAR productos = new ELIMINAR();
            productos.ShowDialog();
        }
    }
}
