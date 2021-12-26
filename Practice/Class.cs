using System;

namespace Practice
{
    public class Class
    {
        static Random random = new Random();
        public static (double allNumbers, string calculations) ProductEvenWithOut(int count)
        {

            int product = 1;
            string numbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);

                numbers += number.ToString() + " ";

                product *= number;
            }

            var finding = (product, numbers);
            return finding;
        }

    }
}
