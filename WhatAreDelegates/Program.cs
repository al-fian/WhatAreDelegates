namespace WhatAreDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;

            processor.Process("photo.js", filterHandler);
        }
    }
}