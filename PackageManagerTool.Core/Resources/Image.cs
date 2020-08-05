using System;
using System.Drawing;
using System.IO;

namespace PackageManagerTool.Core.Resource
{
    public struct Images
    {
        private static Image GenerateImage(string base64)
        {
            var imageBytes = Convert.FromBase64String(base64);

            using (var memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return Image.FromStream(memoryStream);
            }
        }

        public static Image WHITE_CLOSE_CROSS_32PX => GenerateImage("");
    }
  }

