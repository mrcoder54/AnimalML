// See https://aka.ms/new-console-template for more information
using MLTest;

Console.WriteLine("Hello, World!");


//Load sample data
var imageBytes = File.ReadAllBytes(@"puppy.jpg");
PhotoML.ModelInput sampleData = new PhotoML.ModelInput()
{
    ImageSource = imageBytes,
};

//Load model and predict output
var result = PhotoML.Predict(sampleData);

Console.WriteLine(result.PredictedLabel);
Console.ReadLine();
