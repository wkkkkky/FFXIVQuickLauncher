using System;

namespace XIVLauncher.Game
{
    public class SteamException : Exception
    {
        public SteamException(string context, Exception inner = null) : base(context, inner)
        { }
    }
}