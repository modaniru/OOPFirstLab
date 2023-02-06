namespace LabaratoryOOP1
{
    public partial class frmMain : Form
    {

        private DateTime bd = new DateTime(DateTime.Now.Year, 5, 16);

        public frmMain()
        {
            this.InitializeComponent();
            DateTime now = DateTime.Now; 
            if(now.CompareTo(bd) > 0 )
            {
                lblBirthDay.Text = "До моего др " + bd.AddYears(1).Subtract(DateTime.Now).Days + " дней";
            }
            else
            {
                lblBirthDay.Text = "До моего др " + bd.Subtract(DateTime.Now).Days + " дней";
            }
            
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
            lblRed.Text = getColor(red).ToString();
        }

        private void greenTick_Tick(object sender, EventArgs e)
        {
            changeColor();
            green++;
            lblGreen.Text = getColor(green).ToString();
        }

        private void blueTick_Tick(object sender, EventArgs e)
        {
            blue++;
            changeColor();
            lblBlue.Text = getColor(blue).ToString();
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            //test
        }

        private void dtpChooseDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = dtpChooseDate.Value.Date;
            if (now.Equals(bd))
            {
                lblBirthDay.Text = "с др!";
            }
            else if (now.CompareTo(bd) > 0)
            {

                lblBirthDay.Text = "До моего др " + bd.AddYears(1).Subtract(now).Days + " дней";
            }
            else
            {
                lblBirthDay.Text = "До моего др " + bd.Subtract(now).Days + " дней";
            }
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redTick.Interval = redTrackBar.Value;
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenTick.Interval = greenTrackBar.Value;
        }

        private void BlueTrackBar_Scroll(object sender, EventArgs e)
        {
            blueTick.Interval = BlueTrackBar.Value;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}