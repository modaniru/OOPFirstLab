namespace LabaratoryOOP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            this.InitializeComponent();
        }

        private int red = 0;
        private int green = 0;
        private int blue = 0;

        private void changeColor()
        {
            Console
                .WriteLine("sda");
            autoGenerateColor.BackColor = Color.FromArgb(
                (getColor(red)),
                (getColor(green)),
                (getColor(blue)));
        }

        private int getColor(int color)
        {
            int c = color % 511;
            if(c > 255)
            {
                return 255 - c % 256;
            }
            return c;
        }


        private void nuRed_ValueChanged(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb(((int)nuRed.Value), ((int)nuGreen.Value), ((int)nuBlue.Value));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nuRed.Value = 0;
            nuGreen.Value = 0;
            nuBlue.Value = 0;
        }


        private void redTick_Tick(object sender, EventArgs e)
        {
            changeColor();
            red++;
        }

        private void greenTick_Tick(object sender, EventArgs e)
        {
            green++;
            changeColor();
        }

        private void blueTick_Tick(object sender, EventArgs e)
        {
            blue++;
            changeColor();
        }
    }
}