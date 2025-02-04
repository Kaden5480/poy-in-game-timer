using UnityEngine.SceneManagement;

namespace InGameTimer {
    public class SceneInfo {
        public string internalName { get; }
        public string displayName { get; }
        public string gameManagerName { get; }

        /**
         * <summary>
         * Constructs an instance of SceneInfo.
         * </summary>
         * <param name="internalName">The name of the scene internally</param>
         * <param name="displayName">The name to display for the scene</param>
         * <param name="gameManagerName">The name of the GameManager field which
         * stores whether this scene is completed (Only used for peaks)</param>
         */
        public SceneInfo(string internalName, string displayName, string gameManagerName) {
            this.internalName = internalName;
            this.displayName = displayName;
            this.gameManagerName = gameManagerName;
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
