namespace microsoftLearnExercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] corporate =
            {
                {"Robert", "Bavin"},
                {"Simon", "Bright"},
                {"Kim", "Sinclair"},
                {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"},
                {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"},
                {"Cody", "Dysart"},
                {"Shay", "Lawrence"},
                {"Daren", "Valdes"}
            };



            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                DisplayEmail(Name: corporate[i,0], Surname: corporate[i,1]);
            }

            string externalDomain = "hayworth.com";

            for (int i = 0; i < external.GetLength(0); i++)
            {
                DisplayEmail(Name: external[i, 0], Surname: external[i, 1], Domain: externalDomain);
            }



            void DisplayEmail(string Name, string Surname, string Domain = "contoso.com")
            {
                string First2Chars = Name.Substring(0, 2);
                string EmailName = (First2Chars + Surname).ToLower();

                Console.WriteLine($"{EmailName}@{Domain}");
            };
        }
    }
}
