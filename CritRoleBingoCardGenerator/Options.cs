using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriticalRoleBingoCardGenerator
{
    public static class Options
    {
        private static Random _random = new Random();
        private static string _freeSpace = "FREE SPACE: This episode of Critical Role. [eyebrows intensify]";

        private static List<string> _options = new List<string>
        {
            "New Accent",
            "Dead Relative",
            "Sam Shirt Gag",
            "Gleam the Cube",
            "Makin My Way",
            "HDYWTDT",
            "Marisha Battle Crouch",
            "PC Gets Knocked Out",
            "Player Accidentally Uses Wrong Character Name",
            "Travis Hides in the Hoodie",
            "It's Been a While",
            "Chaotic Bisexual",
            "Toothy Maw",
            "DM Whispers",
            "Food/Drink Spill",
            "Marisha Hits Someone",
            "Ashley \"OKOKOKOK\" ",
            "Liam's Character Is Sad",
            "Laura's Dice Betray Her",
            "Laura Shows Off New Dice",
            "Nat20",
            "Nat1",
            "PC hits on an NPC",
            "Dwarven Forge",
            "Matt Apologizes for Sam",
            "Taliesin Ruins Matt's Plan",
            "Reference to a Cast Member's VO Role",
            "Laura's Character Interacts With an Animal",
            "PC Gets Laid",
            "NPC with Scottish Accent",
            "PC Gets Drunk",
            "Travis Forgets Something",
            "Travis Breaks Something",
            "Someone Cries",
            "Taliesin New Hair",
            " \"Up the Butt\" ",
            "Laura Has a Dirty Mind",
            "Dice are Jailed",
            "Matt Double Face Palm"
        };

        public static IEnumerable<string> GetOptions()
        {
            var result = _options.OrderBy(x => _random.Next()).Take(24).ToList();
            result.Insert(12, _freeSpace);
            return result;
            //jemma
        }
    }
}
