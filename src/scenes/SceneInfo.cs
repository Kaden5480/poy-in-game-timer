using UnityEngine.SceneManagement;

namespace InGameTimer {
    public class SceneInfo {
        public string internalName { get; }
        public string displayName { get; }

        /**
         * <summary>
         * Constructs an instance of SceneInfo.
         * </summary>
         * <param name="internalName">The name of the scene internally</param>
         * <param name="displayName">The name to display for the scene</param>
         */
        public SceneInfo(string internalName, string displayName) {
            this.internalName = internalName;
            this.displayName = displayName;
        }

        /**
         * <summary>
         * Checks if the specified scene is the same as this.
         * </summary>
         * <param name="scene">The scene to check</param>
         * <return>True if it is equal, false otherwise</return>
         */
        public bool IsScene(Scene scene) {
            return internalName.Equals(scene.name);
        }

        /**
         * <summary>
         * Checks if the specified scene is the same as this.
         * </summary>
         * <param name="sceneName">The name of the scene to check</param>
         * <return>True if it is equal, false otherwise</return>
         */
        public bool IsScene(string sceneName) {
            return internalName.Equals(sceneName);
        }
    }
}
