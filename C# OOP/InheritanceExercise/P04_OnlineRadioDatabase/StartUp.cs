using P04_OnlineRadioDatabase.Core;
using System;

namespace P04_OnlineRadioDatabase
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
