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
            D,
            T
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
                { "Иллюзии2", EyeTypes.T },
                { "Животные2", EyeTypes.T },
                { "Зеркала2", EyeTypes.T },
                { "Зелья2", EyeTypes.T },
                { "Тени", EyeTypes.B },
                { "Яд", EyeTypes.B },
                { "Телепорт", EyeTypes.B },
                { "Сны", EyeTypes.B },
                { "Иллюзии1", EyeTypes.T },
                { "Животные1", EyeTypes.T },
                { "Зеркала1", EyeTypes.T },
                { "Зелья1", EyeTypes.T },
                { "Иллюзии13", EyeTypes.T },
                { "Животные13", EyeTypes.T },
                { "Зеркала13", EyeTypes.T },
                { "Зелья13", EyeTypes.T },
                { "Телепатия", EyeTypes.A },
                { "Гипноз", EyeTypes.A },
                { "Разум", EyeTypes.A },
                { "Телепатия123", EyeTypes.T },
                { "Гипноз123", EyeTypes.T },
                { "Разум123", EyeTypes.T },
                { "Телепатия1234", EyeTypes.T },
                { "Гипноз1234", EyeTypes.T },
                { "Разум1234", EyeTypes.T },
                { "Телепатия12345", EyeTypes.T },
                { "Гипноз12345", EyeTypes.T },
                { "Разум12345", EyeTypes.T },
                { "Телепатия123456", EyeTypes.T },
                { "Гипноз123456", EyeTypes.T },
                { "Разум123456", EyeTypes.T },
                { "Разум12764", EyeTypes.T },
                { "Телепатия129", EyeTypes.T },
                { "Гипноз129", EyeTypes.T },
                { "Разум129", EyeTypes.T },
            };

        private string RandomEye(Random random)
        {
            int buffer = random.Next(0, EyePool.Count);
            
            (string, EyeTypes) currEye = (EyePool.ElementAt(buffer).Key, EyePool.ElementAt(buffer).Value);

            switch (currEye.Item2)
            {
                case EyeTypes.A:
                    return currEye.Item1;
                    //break;

                case EyeTypes.B:
                    return currEye.Item1;
                    //break;

                case EyeTypes.C:
                    return currEye.Item1;
                    //break;

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
            if (EyeCountSelectCheckBox.Checked)
            {
                DoubleEyeSelected = true;
            }
            else
            {
                DoubleEyeSelected = false;
            }

        }
    }
}
