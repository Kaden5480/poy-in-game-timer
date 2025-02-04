using System.Collections.Generic;

using UnityEngine.SceneManagement;

namespace InGameTimer {
    public abstract class Category {
        public string name { get; }
        public Dictionary<string, SceneState> sceneStates { get; }

        public Category(string name, SceneInfo[] scenes) {
            this.name = name;
            sceneStates = new Dictionary<string, SceneState>();

            foreach (SceneInfo info in scenes) {
                sceneStates.Add(info.internalName, new SceneState(info));
            }
        }

        public virtual bool StartTimer(string sceneName) {
            return sceneStates.ContainsKey(sceneName);
        }

        public virtual bool EndTimer(string sceneName) {
            foreach (KeyValuePair<string, SceneState> entry in sceneStates) {
                if (entry.Value.completed == false) {
                    return false;
                }
            }

            return true;
        }

        public virtual bool PauseTimer(string sceneName) {
            return false;
        }

        public virtual void CompleteScene(string sceneName) {
            if (sceneStates.ContainsKey(sceneName) == false) {
                return;
            }

            sceneStates[sceneName].completed = true;
        }

        public virtual void Reset() {
            foreach (KeyValuePair<string, SceneState> entry in sceneStates) {
                entry.Value.completed = false;
            }
        }

        public virtual IEnumerable<(string, string)> GetUIInfo() {
            foreach (KeyValuePair<string, SceneState> entry in sceneStates) {
                SceneState state = entry.Value;
                yield return (state.info.displayName, state.completed.ToString());
            }
        }
    }
}
