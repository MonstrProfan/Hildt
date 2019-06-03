using static System.Console;

namespace Dom
{
    class ParametrDom
    {
        int a, b, c;
        string s;

        public int A
        {
            get => this.a; set => this.a = value;
        }
        public int B
        {
            get => this.b; set => this.b = value;
        }
        public int C
        {
            get => this.c; set => this.c = value;
        }
        public string S
        {
            get => this.s; set => this.s = value;
        }
                     
        /// <summary>
        /// расчет приходящейся площади на одного человека
        /// </summary>
        /// <returns></returns>
        public int PlOdChel()
        {
            return B / C;
        }

        /// <summary>
        /// расчет колличества возможных жильцов исходя из нормирования площади
        /// </summary>
        /// <param name="B"></param>
        /// <returns></returns>
        public int KolChel(int B)
        {
            return B / 12;
        }

        public void Oth()
        {
            WriteLine($"При полученных данных: ");
            WriteLine($"Объект: - {S}");
            WriteLine($"Имеим: - Площадь на 1-го чел. = {PlOdChel()}");
            WriteLine($"Исхдя из общей площади здания = {B}m2 и ноpме на 1-го человека 12 м2 в здании может быть {KolChel(B)} человек");

            ReadKey();
        }
    }
}
 