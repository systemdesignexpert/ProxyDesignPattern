using System;
using System.Collections.Generic;

// ImageProxy.cs
public class ImageProxy : IImage
{
    private string filename;
    private RealImage realImage;
    private static List<string> cachedImages = new List<string>();

    public ImageProxy(string filename)
    {
        this.filename = filename;
    }

    public void Display()
    {
        // Check authentication
        if (!IsAuthenticated())
        {
            Console.WriteLine("Authentication failed. You are not authorized to view the image.");
            return;
        }

        if (realImage == null)
        {
            // Check if the image is already cached
            if (cachedImages.Contains(filename))
            {
                Console.WriteLine($"Retrieving {filename} from cache...");
            }
            else
            {
                realImage = new RealImage(filename); // Lazy initialization
                cachedImages.Add(filename); // Cache the loaded image
            }
        }

        realImage.Display();
    }

    private bool IsAuthenticated()
    {
        // Simulate authentication. In a real-world scenario, you would use a proper authentication mechanism.
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        return AuthenticationService.IsUserAuthenticated(username, password);
    }
}
