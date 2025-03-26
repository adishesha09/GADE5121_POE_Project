using System.Media;

namespace GADE5121_POE_Project
{
    public static class MusicManager
    {
        private static SoundPlayer? player; // Make it nullable

        public static void PlayBackgroundMusic(string filePath)
        {
            StopBackgroundMusic(); // Stop any existing music before starting a new one

            if (File.Exists(filePath))
            {
                player = new SoundPlayer(filePath);
                player.PlayLooping(); // Play in a loop
            }
        }

        public static void StopBackgroundMusic()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
    }
}
