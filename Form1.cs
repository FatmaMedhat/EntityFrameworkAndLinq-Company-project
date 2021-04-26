using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace pp
{
    public partial class Form1 : Form
    {
        private IconButton currentbtn;
        private Panel leftBorderBtn;
        private Form currentchildform;

        CFDB ENT = new CFDB();
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void openchildform(Form child)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(currentchildform);
            panelDesktop.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(75, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(50, 100, 200);

        }
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            openchildform(new Form2());
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disablebtn();
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentbtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentchildform.IconChar = currentbtn.IconChar;
                iconCurrentchildform.IconColor = color;
                lblTitlechileform.Text = currentbtn.Text;
            }
        }
        private void disablebtn()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitlechileform.Text = childForm.Text;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            openchildform(new Form3());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            openchildform(new Form5());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            openchildform(new Form4());
        }
        private void reset()
        {
            disablebtn();
            iconCurrentchildform.IconChar = IconChar.Home;
            iconCurrentchildform.IconColor = Color.MediumPurple;

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);
            openchildform(new Form6());


        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            openchildform(new Form7());


        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            openchildform(new Form7());
        }
    }
}
