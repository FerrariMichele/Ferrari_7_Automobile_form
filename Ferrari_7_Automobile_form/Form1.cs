using System.ComponentModel.DataAnnotations;

namespace Ferrari_7_Automobile_form
{
    public partial class Form1 : Form
    {
        ClassAutomobile Car = new ClassAutomobile();
        public Form1()
        {
            InitializeComponent();
            ClassAutomobile Car = new ClassAutomobile();
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            int respone = Car.AccendiAuto();
            if (Car.onOff)
            {
                labelOnOff.Text = "Accesa";
            }
        }

        private void buttonUpShift_Click(object sender, EventArgs e)
        {
            int response = Car.AumentaMarcia();
            if (response == 1)
            {
                labelGear.Text = Car.gear.ToString();
                labelRpms.Text = Car.rpms.ToString();
            }
        }

        private void buttonDownShift_Click(object sender, EventArgs e)
        {
            int response = Car.DiminuisciMarcia();
            if (response == 1)
            {
                labelGear.Text = Car.gear.ToString();
                labelRpms.Text = Car.rpms.ToString();
            }
        }

        private void buttonThrottle_Click(object sender, EventArgs e)
        {
            int response = Car.Accelera();
            if (response == 1)
            {
                labelRpms.Text = Car.rpms.ToString();
                labelSpeed.Text = Car.speed.ToString();
            }
        }

        private void buttonBrake_Click(object sender, EventArgs e)
        {
            int response = Car.Frena();
            if (response == 1)
            {
                labelRpms.Text = Car.rpms.ToString();
                labelSpeed.Text = Car.speed.ToString();
            }
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            int respone = Car.SpegniAuto();
            if (Car.onOff)
            {
                labelOnOff.Text = "Spenta";
            }
        }
    }
}