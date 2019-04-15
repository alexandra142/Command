using System;

namespace Cube
{
    internal interface IThrowCube
    {
        void Show();
    }

    internal class ThrowOne : IThrowCube
    {
        private Cube _cube;

        public ThrowOne(Cube cube)
        {
            _cube = cube;
        }

        public void Show()
        {
            Console.WriteLine(_cube.SE + _cube.S0 + _cube.S1C + _cube.S0 + _cube.SE);
        }
    }

    internal class ThrowTwo : IThrowCube
    {
        private Cube _cube;

        public ThrowTwo(Cube cube)
        {
            _cube = cube;
        }

        public void Show()
        {
            Console.WriteLine(_cube.SE + _cube.S1L + _cube.S0 + _cube.S1R + _cube.SE);
        }
    }

    internal class ThrowThree : IThrowCube
    {
        private Cube _cube;

        public ThrowThree(Cube cube)
        {
            _cube = cube;
        }

        public void Show()
        {
            Console.WriteLine(_cube.SE + _cube.S1L + _cube.S1C + _cube.S1R + _cube.SE);
        }
    }

    internal class ThrowFour : IThrowCube
    {
        private Cube _cube;

        public ThrowFour(Cube cube)
        {
            _cube = cube;
        }

        public void Show()
        {
            Console.WriteLine(_cube.SE + _cube.S2 + _cube.S0 + _cube.S2 + _cube.SE);
        }
    }

    internal class ThrowFive : IThrowCube
    {
        private Cube _cube;

        public ThrowFive(Cube cube)
        {
            _cube = cube;
        }

        public void Show()
        {
            Console.WriteLine(_cube.SE + _cube.S2 + _cube.S1C + _cube.S2 + _cube.SE);
        }
    }

    internal class ThrowSix : IThrowCube
    {
        private Cube _cube;

        public ThrowSix(Cube cube)
        {
            _cube = cube;
        }

        public void Show()
        {
            Console.WriteLine(_cube.SE + _cube.S2 + _cube.S2 + _cube.S2 + _cube.SE);
        }
    }
}
