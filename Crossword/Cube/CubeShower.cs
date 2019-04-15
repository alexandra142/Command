using System;
using System.Collections.Generic;
using System.Text;

namespace Cube
{
    internal class CubeShower
    {
        public IThrowCube[] throwCubes;

        public CubeShower(Cube cube)
        {
            throwCubes = new IThrowCube[6];
            throwCubes[0] = new ThrowOne(cube);
            throwCubes[1] = new ThrowTwo(cube);
            throwCubes[2] = new ThrowThree(cube);
            throwCubes[3] = new ThrowFour(cube);
            throwCubes[4] = new ThrowFive(cube);
            throwCubes[5] = new ThrowSix(cube);
        }

        public void ThrowCube(int i)
        {
            throwCubes[i].Show();
        }
    }
}
