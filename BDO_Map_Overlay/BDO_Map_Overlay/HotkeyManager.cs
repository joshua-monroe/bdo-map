using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Input;


namespace BDO_Map_Overlay
{
    class HotkeyManager
    {
        private enum Hotkey {ShowHideOverlay, ShowAllNodes, ShowNode1, ShowNode2, ShowNode3, ShowNode4, ShowNode5};
        private string hotkeyFile;
        private Dictionary<Hotkey, Key> hotkeys;

        // Constructor
        public HotkeyManager(string hotkeyFile)
        {
            //this.hotkeyFile = hotkeyFile;
            //loadHotkeysFromFile();
        }

        //// Converts key string to Key enum
        //[DllImport("user32.dll")]
        //static extern short VkKeyScan(char ch);
        //static public Key ResolveKey(char charToResolve)
        //{
        //    return KeyInterop.KeyFromVirtualKey(VkKeyScan(charToResolve));
        //}

        //// Loads hotkeys from given file and converts them into key enum form
        //private void loadHotkeysFromFile()
        //{
        //    // Reads in a list of strings from the hotkeyfile, delimited by ','
        //    List<string> hotkeyList = File.ReadAllText(hotkeyFile).Split(',').ToList();
        //    for(int i = 0; i < hotkeyList.Count && i < Enum.GetNames(typeof(Hotkey)).Length; i++)
        //    {
        //        // Gets first char of string to convert into a key
        //        hotkeys.Add((Hotkey)i, ResolveKey(hotkeyList.ElementAt(i)[0]));
        //    }
        //}
    }
}
