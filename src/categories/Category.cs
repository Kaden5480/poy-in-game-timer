using System.Collections.Generic;

using UnityEngine.SceneManagement;

namespace InGameTimer {
    public abstract class Category {
        public string name = "";
        public Dictionary<string, bool> sceneStates = new Dictionary<string, bool>();

        public virtual bool StartTimer(string sceneName) {
            return sceneStates.ContainsKey(sceneName);
        }

        public virtual bool EndTimer(string sceneName) {
            bool shouldEnd = true;

            foreach (KeyValuePair<string, bool> entry in sceneStates) {
                if (entry.Value == false) {
                    shouldEnd = false;
                    break;
                }
            }

            return shouldEnd;
        }

        public virtual bool PauseTimer(string sceneName) {
            return false;
        }

        public virtual void CompleteScene(string sceneName) {
            if (sceneStates.ContainsKey(sceneName) == false) {
                return;
            }

            sceneStates[sceneName] = true;
        }
    }
}
