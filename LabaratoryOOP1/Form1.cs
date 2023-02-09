using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Policy;

namespace LabaratoryOOP1
{
    public partial class frmMain : Form
    {

        private DateTime bd = new DateTime(DateTime.Now.Year, 5, 16);
        private int XDirection = 0;
        private int YDirection = 0;
        private int count = 1;
        private bool backgroundRgb = false;


        public frmMain()
        {
            this.InitializeComponent();
            pbPos.Maximum = (gpField.Width - player.Width) + (gpField.Height - player.Height);
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
            autoGenerateColor.BackColor = Color.FromArgb(
                (getColor(red)),
                (getColor(green)),
                (getColor(blue)));
            if (backgroundRgb)
            {
                gpField.BackColor = Color.FromArgb(
                (getColor(red)),
                (getColor(green)),
                (getColor(blue)));
            }
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
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            pbColor.BackColor = colorDialog1.Color;
            nuRed.Value = color.R;
            nuGreen.Value = color.G;
            nuBlue.Value = color.B;
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

        private void gitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo() { FileName = "https://github.com/modaniru", UseShellExecute = true });
            LinkLabel l = (LinkLabel)sender;
            this.Controls.Remove(l);
        }

        private void btnX_MouseUp(object sender, MouseEventArgs e)
        {
            timerX.Enabled = false;
        }

        private void timerX_Tick(object sender, EventArgs e)
        {
            int x = player.Location.X + (XDirection * 2);
            if(x < 0 || x > gpField.Width - player.Width)
            {
                x = player.Location.X;
            }
            player.Location = new Point(x, player.Location.Y);
        }

        private void timerY_Tick(object sender, EventArgs e)
        {
            int y = player.Location.Y + (YDirection * 2);
            if(y > gpField.Height - player.Height || y < 0)
            {
                y = player.Location.Y;
            }
            player.Location = new Point(player.Location.X, y);
        }

        private void btnX_MouseEnter(object sender, EventArgs e)
        {
            XDirection = 1;
            timerX.Enabled = true;
        }

        private void btnX_MouseLeave(object sender, EventArgs e)
        {
            timerX.Enabled = false;
        }

        private void btnY_MouseEnter(object sender, EventArgs e)
        {
            YDirection = -1;
            timerY.Enabled = true;
        }

        private void btnY_MouseLeave(object sender, EventArgs e)
        {
            timerY.Enabled = false;
        }

        private void btnXReverse_MouseEnter(object sender, EventArgs e)
        {
            XDirection = -1;
            timerX.Enabled = true;
        }

        private void btnXReverse_MouseLeave(object sender, EventArgs e)
        {
            timerX.Enabled = false;
        }

        private void btnYReverse_MouseEnter(object sender, EventArgs e)
        {
            YDirection = 1;
            timerY.Enabled = true;
        }

        private void btnYReverse_MouseLeave(object sender, EventArgs e)
        {
            timerY.Enabled = false;
        }

        private void niDest_DoubleClick(object sender, EventArgs e)
        {
            comboBox1.Items.Add(player.Location);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Point point = (Point)comboBox1.SelectedItem;

            lbTeleporter.Items.Add("teleport to: " + point);
            player.Location = point;

        }

        private void player_LocationChanged(object sender, EventArgs e)
        {
            pbPos.Value = player.Location.X + player.Location.Y;
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right) {
                LinkLabel lbl = new System.Windows.Forms.LinkLabel();

                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(e.X - 96 / 2, e.Y - 15 / 2);
                lbl.Name = "gitHubLink";
                lbl.Size = new System.Drawing.Size(96, 15);
                lbl.TabIndex = 11;
                lbl.TabStop = true;
                lbl.Text = "go to my GitHub";
                lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);

                this.Controls.Add(lbl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            pbOpenDialog.ImageLocation = openFileDialog1.FileName;
            pbOpenDialog.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Add(count);
            count++;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if ((int)checkedListBox.Items[i] % 2 == 0)
                {
                    checkedListBox.Items.RemoveAt(i);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            backgroundRgb = !backgroundRgb;
        }
    }
}