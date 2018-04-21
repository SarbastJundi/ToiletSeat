using System;

/*
 * Sarbast Jundi
 * Högskolan i Skövde
 * 
 */

namespace Ladder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String data = Console.ReadLine();

            int userPreferencesPolicy = data[0] == data[1] ? 0 : 1; // should first user adjust on entering?
            int alwaysUpPolicy = (data[1] == 'U' ? 0 : 1) + userPreferencesPolicy;  // should first user adjust on leave?
            int alwaysDownPolicy = (data[1] == 'D' ? 0 : 1) + userPreferencesPolicy; // should first user adjust on leave?

            for (int i = 2; i < data.Length; i++)
            {
                if (data[i - 1] != data[i])
                {
                    userPreferencesPolicy++;
                }
                if (data[i] == 'U')
                {
                    alwaysDownPolicy++; // on enter
                    alwaysDownPolicy++; // on leave
                }
                else if (data[i] == 'D')
                {
                    alwaysUpPolicy++; // on enter
                    alwaysUpPolicy++; // on leave
                }
            }

            Console.WriteLine(alwaysUpPolicy);
            Console.WriteLine(alwaysDownPolicy);
            Console.WriteLine(userPreferencesPolicy);
        }

    }

}
