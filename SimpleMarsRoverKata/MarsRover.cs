namespace SimpleMarsRoverKata
{
    public static class MarsRover
    {
        const string DIRECTIONSL = "NWSE";
        const string DIRECTIONSR = "NESW";
        public static string Execute(string command)
        {
            var lcount = command.Count(c => c == 'L');
            var rcount = command.Count(c => c == 'R');

            if (lcount > 0)
                return $"0:0:{DIRECTIONSL[lcount % 4]}";
            else
                return $"0:0:{DIRECTIONSR[rcount % 4]}";
        }
    }
}