using System.Collections.Generic;
using System.IO;

namespace SERVER
{
    class ServerUtil
    {

        public static string[] GetRecords()
        {
            return File.ReadAllLines(Paths.root + Paths.compFile);
        }

        public static void SaveRecords(List<string> lines)
        {
            File.WriteAllText(Paths.root + Paths.compFile, string.Empty);
            File.WriteAllLines(Paths.root + Paths.compFile, lines);
        }
    }
}