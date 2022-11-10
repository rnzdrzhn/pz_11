namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = "\nВсем привет" + "\nМеня возут Арина" + "\nЯ учусь на втором курсе" + "\nМне шестнадцать лет";

            string[] SArr = S.Split('\n');
            string[][] S2Arr = new string[SArr.Length][];

            for (int i = 0; i < SArr.Length; i++)
            {
                string[] words = SArr[i].Split();
                S2Arr[i] = words;

            }

        }
    }
}