using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Prog6221
{
    internal class Recording
    {
         public static void PlayVoiceGreeting()
        {
            try
            {
                string filepath = @"C:\projects\PROG6221Pt1\Prog6221\Files\Welcome.wav.wav"; // Ensure this file exists in the project folder
                SoundPlayer player = new SoundPlayer(filepath); // Ensure this file exists in the project folder
                player.Play();
            }
            catch (Exception)
            {
                Console.WriteLine(" Voice file missing or unsupported.");
            }
        }

    }
}
