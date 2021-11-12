﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudVisualization.Extensions
{
    public static class BitmapExtensions
    {
        private static int _count;

        public static void SaveDefault(this Bitmap bitmap, string filename = null)
        {
            var currentDir = AppDomain.CurrentDomain.BaseDirectory;
            var imagesDir = Directory.CreateDirectory(Path.Combine(currentDir, "images"));
            var name = filename ?? $"tag_cloud_0{_count}";
            var path = Path.Combine(imagesDir.FullName, name);

            bitmap.Save($"{path}.png", ImageFormat.Png);
            _count++;
        }
    }
}
