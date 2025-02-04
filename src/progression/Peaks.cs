using System;

namespace InGameTimer.Progression {
    public class Peaks {
        /**
         * <summary>
         * Checks whether all base game peaks have been completed.
         * </summary>
         * <return>True if they have, false otherwise</return>
         */
        public static bool CompletedAllBaseGame() {
            Console.WriteLine($"Checking: {Scenes.baseGamePeaks.Length}");

            foreach (SceneInfo info in Scenes.baseGamePeaks) {
                Console.WriteLine($"Checking: {info.displayName}");

                bool completed = (bool) typeof(GameManager)
                    .GetField(info.gameManagerName)
                    .GetValue(GameManager.control);

                if (completed == false) {
                    return false;
                }
            }

            return true;
        }
    }
}
