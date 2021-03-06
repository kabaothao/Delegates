// See https://aka.ms/new-console-template for more information

namespace Delegates // Note: actual namespace depends on the project name.
{
        public class PhotoProcessor
        {
            public void Process(string path, Action<Photo> filterHandler)
            {
                var photo = Photo.Load(path);

                filterHandler(photo);

                photo.Save();
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