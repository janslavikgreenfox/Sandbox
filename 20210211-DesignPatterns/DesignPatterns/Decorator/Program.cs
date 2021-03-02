using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var surface = 
                new ExportPictures(
                    new Export2Ensight(
                        new Surface()));
            var volume = 
                new Export2ParaView(
                    new Export2Ensight(
                        new ExportPictures(
                            new Volume())));

            var surfacePostproResult = surface.Postpro();
            var volumePostproResult = volume.Postpro();
        }
    }
}
