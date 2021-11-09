﻿using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsCloudVisualization;

namespace TagsCloudVisualization_Test
{
    class CoordinatesConverter_Test
    {
        [TestCase(5, 3, 5.83, 0.54)]
        [TestCase(5, -3, 5.83, -0.54)]
        [TestCase(-5, 3, 5.83, 2.6)]
        [TestCase(-5, -3, 5.83, -2.6)]
        [TestCase(50, 30, 58.3, 0.54)]
        public void ToPolar_ShouldBeCorrect(int x, int y, double expectedRho, double expectedPhi)
        {
            var polar = CoordinatesConverter.ToPolar(new Point(x, y));
            using (new AssertionScope())
            {
                polar.rho.Should().BeApproximately(expectedRho, 0.01d);
                polar.phi.Should().BeApproximately(expectedPhi, 0.01d);
            }
        }

        [TestCase(5.8309, 0.5404, 5, 3)]
        [TestCase(5.8309, -0.5404, 5, -3)]
        [TestCase(5.8309, -2.6011, -5, -3)]
        [TestCase(5.8309, 2.6011, -5, 3)]
        [TestCase(58.3095, 0.5404, 50, 30)]
        public void ToCartesian_ShouldBeCorrect(double rho, double phi, int expectedX, int expectedY)
        {
            var point = CoordinatesConverter.ToCartesian(rho, phi);
            using (new AssertionScope())
            {
                point.X.Should().Be(expectedX);
                point.Y.Should().Be(expectedY);
            }
        }
    }
}
