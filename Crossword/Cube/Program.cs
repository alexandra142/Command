using System;

namespace Cube
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cube cube = new Cube();
            CubeShower shower = new CubeShower(cube);
            Random random = new Random();

            for (var i = 0; i < 6; i++)
            {
                shower.ThrowCube(i);
                Console.ReadLine();
            }

            while (true)
            {
                shower.ThrowCube(random.Next(6));
                Console.ReadLine();
            }
        }
    }
}
