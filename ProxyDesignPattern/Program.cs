IImage image1 = new ImageProxy("image1.jpg");
IImage image2 = new ImageProxy("image2.jpg");
IImage image3 = new ImageProxy("image3.jpg");

// Display images. Only loaded images are displayed, and expensive loading occurs only once per image.
image1.Display(); // ImageProxy loads "image1.jpg" from disk (real Image)
image2.Display(); // ImageProxy loads "image2.jpg" from disk (real Image)
image1.Display(); // ImageProxy retrieves "image1.jpg" from cache (real Image already loaded)
image3.Display(); // ImageProxy loads "image3.jpg" from disk (real Image)

// Displaying images again; only cached images are displayed.
image1.Display(); // ImageProxy retrieves "image1.jpg" from cache (real Image already loaded)
image2.Display(); // ImageProxy retrieves "image2.jpg" from cache (real Image already loaded)
image3.Display(); // ImageProxy retrieves "image3.jpg" from cache (real Image already loaded)
