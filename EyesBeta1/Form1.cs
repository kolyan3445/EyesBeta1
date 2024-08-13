using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EyesBeta1
{
    public partial class EyeSelector : Form
    {
        public EyeSelector()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> EyePool = new Dictionary<string, string>()
            {
                { "Огонь", "D" },
                { "Вода", "D" },
                { "Воздух", "D" },
                { "Земля", "D" },
                { "Электро", "D" },
                { "Растения", "D" },
                { "Лёд", "D" },
                { "Иллюзии", "C" },
                { "Животные", "C" },
                { "Зеркала", "C" },
                { "Зелья", "C" },
                { "Тени", "B" },
                { "Яд", "B" },
                { "Телепорт", "B" },
                { "Сны", "B" },
                { "Телепатия", "A" },
                { "Гипноз", "А" },
                { "Разум", "А" },
            };

        private string[] RandomEye()
        {
            Random random = new Random();
            int buffer = random.Next(0, EyePool.Count);
            string[] CurrEye = { EyePool.ElementAt(buffer).Key, EyePool.ElementAt(buffer).Value };
            
            int d2 = random.Next(0, 1);

            while (d2 > 0)
            {

            }

            return CurrEye;
        }

        private void EyeSelectorButton_Click(object sender, EventArgs e)
        {
            string[] Eye = RandomEye();

            if (DoubleEyeSelected)
            {
                EyeSelectResultLabel.Text = Eye[0] + " " + RandomEye()[0];
            }
            else
            {
                EyeSelectResultLabel.Text = Eye[0]; 
            }
        }

        private void DoubleEyeDiceButton_Click(object sender, EventArgs e)
        {
            string[] DoubleEyePoolChoice = {"Да", "Нет", "Нет", "Нет", "Нет"};
            Random random = new Random();
            int DoubleEye = random.Next(0, DoubleEyePoolChoice.Length);
            string StandartEyeLabelText = "Двойной глаз: ";

            DoubleEyeLabel.Text = StandartEyeLabelText + DoubleEyePoolChoice[DoubleEye];
            
        }

        public bool DoubleEyeSelected = false;

        private void EyeCountSelectCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            /*if (EyeCountSelectCheckBox.Checked)
            {
                DoubleEyeSelected = true;
            }
            else
            {
                DoubleEyeSelected = false;
            }*/

        }
    }
}
