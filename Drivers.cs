using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_drivers
{
    public partial class Drivers : Form
    {
        // Fields
        private Button currentButton;
        private Form activeForm;
        private int user_id;

        public Drivers(int user_id)
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormTruck(1), btnCamion);
            this.FormClosing += onCloseDrivers;
            this.user_id = user_id;
        }

        private void onCloseDrivers(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#D8D8D8");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnCamion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTruck(1), sender);
            ActivateButton(sender);
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLot(1), sender);
            ActivateButton(sender);
        }
    }
}
