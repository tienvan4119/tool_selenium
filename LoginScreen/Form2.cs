using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolSubmenu.Visible == true)
                panelToolSubmenu.Visible = false;
        }
        
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
       // CLICK MEDIA BUTTON
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }
        #region Media
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //
            //Code
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            //
            //Code
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }
        #endregion
       
        // CLICK PLAYLIST BUTTON
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }
        #region Playlist
        private void button9_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }
        #endregion
       //CLICK TOOLS BUTTON
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolSubmenu);
        }
        #region Tools
        private void button15_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }
        #endregion
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //
            //Code
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
