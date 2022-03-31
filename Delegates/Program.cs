// See https://aka.ms/new-console-template for more information
using System;

namespace Delegates // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            processor.Process("photo.jpg", filterHandler);

          

        }
    }
}


/*
What is Delegates?

An object that knows how to call a method (or a group of methods)

A reference to a function

 
Why do we need delegates?

For designing extensible and flexible applications (eg frameworks)


 */