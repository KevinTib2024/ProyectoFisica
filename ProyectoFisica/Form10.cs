using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFisica
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Opacity = 0.8;

            // Configurar Labels y asignar tamaños iniciales
            ConfigurarLabels();
            AjustarTamaño();

            // Asegurar que el evento Resize esté enlazado
            this.Resize += Form10_Resize;
        }

        private void ConfigurarLabels()
        {
            label1.AutoSize = false;
            label3.AutoSize = false;

            label1.TextAlign = ContentAlignment.MiddleCenter;
            label3.TextAlign = ContentAlignment.MiddleCenter;

            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Form10_Resize(object sender, EventArgs e)
        {
            AjustarTamaño();
        }

        private void AjustarTamaño()
        {
            if (this.ClientSize.Width == 0 || this.ClientSize.Height == 0) return;

            // Ajustar tamaño del panel
            panel1.Width = this.ClientSize.Width - 40;
            panel1.Height = this.ClientSize.Height / 2;
            panel1.Left = 20;
            panel1.Top = this.ClientSize.Height / 4;

            // Ajustar tamaño de los Labels
            label1.Size = new Size(panel1.Width - 20, panel1.Height / 4);
            label3.Size = new Size(panel1.Width - 20, panel1.Height / 6);

            // Ajustar tamaño de fuente basado en el tamaño de la ventana
            float fontSize = Math.Max(8, this.ClientSize.Width * 0.02f);
            float fontSizeTitle = Math.Max(12, this.ClientSize.Width * 0.035f);

            // Verificar que las fuentes se apliquen correctamente
            label1.Font = new Font(label1.Font.FontFamily, fontSize, FontStyle.Regular);
            label3.Font = new Font(label3.Font.FontFamily, fontSizeTitle, FontStyle.Bold);

            // Forzar actualización visual
            label1.Invalidate();
            label3.Invalidate();
            label1.Refresh();
            label3.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            AjustarTamaño();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
