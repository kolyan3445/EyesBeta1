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
                { "Огонь", EyeTypes.D },    //0
                { "Вода", EyeTypes.D },     //1
                { "Воздух", EyeTypes.D },   //2
                { "Земля", EyeTypes.D },    //3
                { "Электро", EyeTypes.D },  //4 
                { "Растения", EyeTypes.D }, //5
                { "Лёд", EyeTypes.D },      //6
                { "Иллюзии", EyeTypes.C },  //7
                { "Животные", EyeTypes.C }, //8
                { "Зеркала", EyeTypes.C },  //9
                { "Зелья", EyeTypes.C },    //10
                { "Тени", EyeTypes.B },     //11
                { "Яд", EyeTypes.B },       //12
                { "Телепорт", EyeTypes.B }, //13
                { "Сны", EyeTypes.B },      //14
                { "Телепатия", EyeTypes.A },//15
                { "Гипноз", EyeTypes.A },   //16
                { "Разум", EyeTypes.A },    //17
            };

        //Выбор рандомного глаза
        private string RandomEye(Random random)
        {
            //Получение рандомного глаза из словаря (dictionary) выше - EyePool.
            int buffer = random.Next(0, EyePool.Count - 1);
            (string, EyeTypes) currEye = (EyePool.ElementAt(buffer).Key, EyePool.ElementAt(buffer).Value);

            //Запихиваем тип глаза в switch
            switch (currEye.Item2)
            {
                case EyeTypes.A:
                    if (ValidateEye(random, 8)) //К8 (или че это бля я хуй знает если честно)
                        return currEye.Item1; //Возвращаем полученный глаз, если выпала нужная циферка
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

        //Валидация/К8 глаза.
        //Должны получить число, переданное в метод, через рандом. Только в этом случае у нас true. Иначе - false.
        private bool ValidateEye(Random random, int value)
        {
            var maxValue = value + 1;
            int dice = random.Next(1, maxValue);
            return dice == value;
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
