using System;

/*
 * Sarbast Jundi
 * Högskolan i Skövde
 * 
 */

namespace ToiletSeat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();

            int UserPrefferedPosition = input[0] == input[1] ? 0 : 1; // should first user adjust on entering?
            int UP = (input[1] == 'U' ? 0 : 1) + UserPrefferedPosition;  // should first user adjust on leave?
            int DOWN = (input[1] == 'D' ? 0 : 1) + UserPrefferedPosition; // should first user adjust on leave?

            for (int i = 2; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    UserPrefferedPosition++;
                }
                if (input[i] == 'U')
                {
                    DOWN++; // on enter
                    DOWN++; // on leave
                }
                else if (input[i] == 'D')
                {
                    UP++; // on enter
                    UP++; // on leave
                }
            }

            Console.WriteLine(UP);
            Console.WriteLine(DOWN);
            Console.WriteLine(UserPrefferedPosition);
        }

    }

}
