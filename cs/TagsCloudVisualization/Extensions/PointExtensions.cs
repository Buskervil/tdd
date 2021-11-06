﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudVisualization.Extensions
{
    static class PointExtensions
    {
        /// <summary>
        /// Находит координату левого верхнего угла прямоугольника
        /// </summary>
        /// <param name="center">Центральная точка прямоугольника</param>
        /// <param name="rectSize">Размер прямоугольника</param>
        public static Point GetRectangleLocationByCenter(this Point center, Size rectSize) =>
           new Point(center.X - rectSize.Width / 2, center.Y - rectSize.Height / 2);

    }
}
