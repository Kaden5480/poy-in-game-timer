using System;

namespace InGameTimer.Progression {
    public class Peaks {
        private static bool CompletedAll(SceneInfo[] peaks) {
            foreach (SceneInfo info in peaks) {
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

        /**
         * <summary>
         * Checks whether all fundamental peaks have been completed.
         * </summary>
         * <return>True if they have, false otherwise</return>
         */
        public static bool CompletedFundamentals() {
            return CompletedAll(Scenes.fundamentalPeaks);
        }

        /**
         * <summary>
         * Checks whether all intermediate peaks have been completed.
         * </summary>
         * <return>True if they have, false otherwise</return>
         */
        public static bool CompletedIntermediate() {
            return CompletedAll(Scenes.intermediatePeaks);
        }

        /**
         * <summary>
         * Checks whether all advanced peaks have been completed.
         * </summary>
         * <return>True if they have, false otherwise</return>
         */
        public static bool CompletedAdvanced() {
            return CompletedAll(Scenes.advancedPeaks);
        }

        /**
         * <summary>
         * Checks whether all expert peaks have been completed.
         * </summary>
         * <return>True if they have, false otherwise</return>
         */
        public static bool CompletedExpert() {
            return CompletedAll(Scenes.expertPeaks);
        }

        /**
         * <summary>
         * Checks whether all base game peaks have been completed.
         * </summary>
         * <return>True if they have, false otherwise</return>
         */
        public static bool CompletedBaseGame() {
            return CompletedAll(Scenes.baseGamePeaks);
        }
    }
}
