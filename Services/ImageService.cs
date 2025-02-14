﻿using FleaMarket.Models.Entities;
using Microsoft.AspNetCore.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FleaMarket.Services
{
    public class ImageService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly int imgWidth = 800;
        private readonly int imgHeight = 600;

        public ImageService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<bool> UploadUserPlaceImageAsync(UserEntity entity, IFormFile image)
        {
            try
            {
                string imagePath = $"{_webHostEnvironment.WebRootPath}/Images/UserPlaces/{entity.PlaceImgUrl}";
                // Open the uploaded image using ImageSharp
                using (var stream = new MemoryStream())
                {
                    await image.CopyToAsync(stream);
                    stream.Seek(0, SeekOrigin.Begin);

                    using (var imageSharp = Image.Load(stream))
                    {
                        // Resize the image to a smaller size
                        imageSharp.Mutate(x => x.Resize(imgWidth, imgHeight));

                        // Save the compressed image
                        imageSharp.Save(imagePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UploadProductImageAsync(ProductEntity entity, IFormFile image)
        {
            try
            {
                string imagePath = $"{_webHostEnvironment.WebRootPath}/Images/Products/{entity.ImageUrl}";
                // Open the uploaded image using ImageSharp
                using (var stream = new MemoryStream())
                {
                    await image.CopyToAsync(stream);
                    stream.Seek(0, SeekOrigin.Begin);

                    using (var imageSharp = Image.Load(stream))
                    {
                        // Resize the image to a smaller size
                        imageSharp.Mutate(x => x.Resize(imgWidth, imgHeight));

                        // Save the compressed image
                        imageSharp.Save(imagePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UploadMarketImageAsync(MarketEntity entity, IFormFile image)
        {
            try
            {
                string imagePath = $"{_webHostEnvironment.WebRootPath}/Images/Markets/{entity.ImageUrl}";
                // Open the uploaded image using ImageSharp
                using (var stream = new MemoryStream())
                {
                    await image.CopyToAsync(stream);
                    stream.Seek(0, SeekOrigin.Begin);

                    using (var imageSharp = Image.Load(stream))
                    {
                        // Resize the image to a smaller size
                        imageSharp.Mutate(x => x.Resize(imgWidth, imgHeight));

                        // Save the compressed image
                        imageSharp.Save(imagePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
