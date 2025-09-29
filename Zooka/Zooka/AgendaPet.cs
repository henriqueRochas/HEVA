using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class formAgendaPet : Form
    {
        public formAgendaPet()
        {
            InitializeComponent();
        }

        private void formAgendaPet_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime agora = new DateTime();

            DateTime iniciarMes = new DateTime(agora.Year, agora.Month,1);

            int dias = DateTime.DaysInMonth(agora.Year,agora.Month);
            int dayOffWeek = Convert.ToInt32(iniciarMes.DayOfWeek.ToString("d"));
        }
    }
}
