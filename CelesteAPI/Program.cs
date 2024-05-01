using System;
//using CelesteStudio.Communication;
using StudioCommunication;

namespace CelesteAPI
{

    class Program
    {
        static void Main(string[] args)
        {
            var consoleCommunication = new ConsoleCommunication();
            try
            {
                consoleCommunication.Run();
            }
            finally
            {

            }
        }
    }
}