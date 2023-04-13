namespace WFA230413_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbCoral.MouseEnter += OnPictureBoxMouseEnter; 
            pbPale.MouseEnter += OnPictureBoxMouseEnter;
            pbAqua.MouseEnter += OnPictureBoxMouseEnter;

            pbCoral.MouseLeave += OnPictureBoxMouseLeave;
            pbPale.MouseLeave += OnPictureBoxMouseLeave;
            pbAqua.MouseLeave += OnPictureBoxMouseLeave;

        }

        private void OnPictureBoxMouseLeave(object? sender, EventArgs e)
        {
            ((PictureBox)sender!).Image = null;
        }

        private void OnPictureBoxMouseEnter(object? sender, EventArgs e)
        {
            (sender as PictureBox)!.Image = Properties.Resources.sadcat;
        }
    }
}