using System;


namespace EventLoop
{
    class Program
    {
        /// <summary>
        /// It's game.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var eventLoop = new CursorEventLoop();
            var game = new CursorGame();

            eventLoop.LeftHandler += game.OnLeft;
            eventLoop.RightHandler += game.OnRight;
            eventLoop.UpHandler += game.OnUp;
            eventLoop.DownHandler += game.OnDown;

            eventLoop.Run();
        }
    }
}
