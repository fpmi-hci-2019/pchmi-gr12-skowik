using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GameTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void GameTestsSimplePasses()
        {
	        var equations = LineEquationAlgorithms.CreateLineEquation(new Vector3(1, 2, 3), new Vector3(2, 3, 4));
            Assert.True(Math.Abs(equations[0](20) - 21) < 1e-2);
            Assert.True(Math.Abs(equations[1](20) - 22) < 1e-2);
        }

        [Test]
        public void GameTestsSimplePasses2()
        {
	        var equations = LineEquationAlgorithms.CreateLineEquationOfParallelLine(new Vector3(1, 2, 3), new Vector3(2, 3, 4), new Vector3(4, 6, 20));

	        Assert.True(Math.Abs(equations[0](20) - 24) < 1e-2);
	        Assert.True(Math.Abs(equations[1](20) - 26) < 1e-2);
	        Assert.True(Math.Abs(equations[2](20) - 40) < 1e-2);
        }

        [Test]
        public void GameTestsSimplePasses3()
        {
	        var dot = LineEquationAlgorithms.FindLinesIntersection(new Line(new Vector3(1, 2, 3), new Vector3(2, 3, 4)), new Line(new Vector3(4, 6, 20), new Vector3(5, 20, 10)));
	        
	        Assert.True(Math.Abs(dot.x - 3.923f) < 1e-2);
	        Assert.True(Math.Abs(dot.y - 4.923f) < 1e-2);
	        Assert.True(Math.Abs(dot.z - 5.923f) < 1e-2);
        }

        [Test]
        public void GameTest()
        {

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator GameTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
