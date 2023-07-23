using System;

// RealImage.cs
public class RealImage : IImage
{
    private string filename;

    public RealImage(string filename)
    {
        this.filename = filename;
        LoadFromDisk(); // Expensive operation to load the image from disk
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {filename}");
    }

    private void LoadFromDisk()
    {
        // Simulate loading the image from disk (expensive operation)
        Console.WriteLine($"Loading {filename} from disk...");
    }
}
