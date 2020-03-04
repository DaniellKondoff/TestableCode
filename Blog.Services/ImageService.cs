﻿namespace Blog.Services
{
    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.Processing;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;

    public class ImageService : IImageService
    {
        public async Task UpdateImage(
            string imageUrl, 
            string destination, 
            int? width = null,
            int? height = null)
        {
            var webClient = new WebClient();

            destination = $"{destination}.jpg";

            await webClient.DownloadFileTaskAsync(imageUrl, destination);

            using var image = Image.Load(destination);

            (int optimalWidth, int optimalHeight) = this.CalculateOptimalSize(
                width, 
                height, 
                image.Width, 
                image.Height);

            image.Mutate(i => i.Resize(optimalWidth, optimalHeight));

            await using var output = File.OpenWrite($"{destination}_optimized.jpg");

            image.SaveAsJpeg(output);
        }

        //Internal for unit test
        internal (int width, int height) CalculateOptimalSize(
            int? width,
            int? height,
            int originalWidth,
            int originalHeight)
        {
            const int minimumSize = 100;

            width ??= originalWidth;
            height ??= originalHeight;

            if (width < minimumSize)
            {
                width = minimumSize;
            }

            if (height < minimumSize)
            {
                height = minimumSize;
            }

            if (width > originalWidth)
            {
                width = originalWidth;
            }

            if (height > originalHeight)
            {
                height = originalHeight;
            }

            return (width.Value, height.Value);
        }
    }
}
