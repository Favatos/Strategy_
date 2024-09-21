namespace Strategy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            int choice  = 0;
            GenerateStrategy generate = null;
            while (true)
            {
                Console.WriteLine("Choose the tipe of map: \n1 - plains \n2 - mointain region \n3 - archipelago \n0 - exit");
                choice  = int.Parse(Console.ReadLine());
                switch (choice){
                    case 0:
                        return;
                    case 1:
                        generate = GeneratePlains;
                        break;
                    case 2:
                        generate = GenerateMountainRegion;
                        break;
                    case 3:
                        generate = GenerateArchipelago;
                        break;
                    default:
                        break;

                }
                generate(map);
                map.Print();
            }

        }


        public static void GenerateMountainRegion(Map map)
        {
            for (int row = 0; row < map.Height; row++)
            {
                for (int col = 0; col < map.Width; col++)
                {
                    int num = new Random().Next(2);
                    if (num == 1) map[row, col] = '^';
                    else map[row, col] = '&';
                }
            }
        }

        public static void GeneratePlains(Map map)
        {
            for (int row = 0; row < map.Height; row++)
                for (int col = 0; col < map.Width; col++)
                    map[row, col] = '.';
        }

        public static void GenerateArchipelago(Map map)
        {
            for (int row = 0; row < map.Height; row++)
                for (int col = 0; col < map.Width; col++)
                    map[row, col] = '~';

            for (int i = 0; i <= new Random().Next(4,11); i++)
            {
                int row = new Random().Next(6);
                int col = new Random().Next(6);
                map[row,col] = '.';
            }
        }

    }
}
