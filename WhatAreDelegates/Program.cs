namespace WhatAreDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.js", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove red eyes...");
        }
    }
}