using System;

namespace EventLoop
{
    /// <summary>
    /// Game methods class.
    /// </summary>
    public class CursorGame
    {
        /// <summary>
        /// Method on left key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft != 0)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }

        /// <summary>
        /// Method on right key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
            {
                Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            }
        }

        /// <summary>
        /// Method on up key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnUp(object sender, EventArgs args)
        {
            if (Console.CursorTop != 0)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            }
        }

        /// <summary>
        /// Method on down key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDown(object sender, EventArgs args)
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
            }
        }
    }
}
