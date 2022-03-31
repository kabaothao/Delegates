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
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.RemoveRedEyeFilter;
            processor.Process("photo.jpg", filterHandler);
        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}


/*
What is Delegates?

An object that knows how to call a method (or a group of methods)

A reference to a function

 
Why do we need delegates?

For designing extensible and flexible applications (eg frameworks)

We use Delegates to achieve flexibility and extensibility.

Of course, we don't need this all the time,

but if you're designing an application or

a framework where extensibility or flexibility is a concern,

we can use Delegates for that.

Alternatively, we can use Interfaces.

How do we decide whether we need to use

an Interface or a Delegate to achieve flexibility?


Use a delgate when
- An eventing design pattern is used
- the caller doesn't need to access other properties or methods on object implementing the method.



 */