using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;

public class ImageService
{
    private readonly Cloudinary _cloudinary;

    public ImageService(IConfiguration config)
    {
        var account = new Account(
            config["Cloudinary:CloudName"],
            config["Cloudinary:ApiKey"],
            config["Cloudinary:ApiSecret"]
        );
        _cloudinary = new Cloudinary(account);
    }

    public async Task<string> UploadImageAsync(IFormFile imageFile)
    {
        using var stream = imageFile.OpenReadStream();
        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(imageFile.FileName, stream)
        };
        var uploadResult = await _cloudinary.UploadAsync(uploadParams);
        return uploadResult.Url.ToString();
    }
}
