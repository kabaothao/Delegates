// See https://aka.ms/new-console-template for more information

namespace Delegates // Note: actual namespace depends on the project name.
{
     public class PhotoFilters
    { 
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}


/*
What is Delegates?

An object that knows how to calla method (or a group of methods)

A reference to a function

 
Why do we need delegates?

For designing extensible and flexible applications (eg frameworks)


 */