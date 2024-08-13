using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EyesBeta1
{
    public partial class EyeSelector : Form
    {
        private Random _random = new Random();
        
        public EyeSelector()
        {
            InitializeComponent();
        }

        private enum EyeTypes
        {
            A,
            B,
            C,
            D
        }
        
        private readonly Dictionary<string, EyeTypes> EyePool = new Dictionary<string, EyeTypes>()
            {
                { "Огонь", EyeTypes.D },
                { "Вода", EyeTypes.D },
                { "Воздух", EyeTypes.D },
                { "Земля", EyeTypes.D },
                { "Электро", EyeTypes.D },
                { "Растения", EyeTypes.D },
                { "Лёд", EyeTypes.D },
                { "Иллюзии", EyeTypes.C },
                { "Животные", EyeTypes.C },
                { "Зеркала", EyeTypes.C },
                { "Зелья", EyeTypes.C },
                { "Тени", EyeTypes.B },
                { "Яд", EyeTypes.B },
                { "Телепорт", EyeTypes.B },
                { "Сны", EyeTypes.B },
                { "Телепатия", EyeTypes.A },
                { "Гипноз", EyeTypes.A },
                { "Разум", EyeTypes.A },
            };

        private string RandomEye(Random random)
        {
            int buffer = random.Next(0, EyePool.Count);
            
            (string, EyeTypes) currEye = (EyePool.ElementAt(buffer).Key, EyePool.ElementAt(buffer).Value);

            switch (currEye.Item2)
            {
                case EyeTypes.A:
                    if (ValidateEye(random, 8))
                        return currEye.Item1;
                    break;
                case EyeTypes.B:
                    if (ValidateEye(random, 4))
                        return currEye.Item1;
                    break;
                case EyeTypes.C:
                    if (ValidateEye(random, 2))
                        return currEye.Item1;
                    break;
                case EyeTypes.D:
                    Console.WriteLine(currEye.Item1);
                    return currEye.Item1;
            }

            return RandomEye(random);
        }

        private bool ValidateEye(Random random, int maxValue)
        {
            int dice = random.Next(1, maxValue);
            return dice == maxValue;
        }
        
        private void EyeSelectorButton_Click(object sender, EventArgs e)
        {
            string eye = RandomEye(_random);

            if (DoubleEyeSelected)
            {
                EyeSelectResultLabel.Text = eye + " " + RandomEye(_random);
            }
            else
            {
                EyeSelectResultLabel.Text = eye; 
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
