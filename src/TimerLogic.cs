using UnityEngine;

namespace InGameTimer {
    public class TimerLogic {
        private string currentScene = "";
        private bool running = false;
        private float timer = 0f;

        public Category category = null;

        public TimerLogic() {
            Reset();
        }

        public void Reset() {
            category = new Categories.Expert();
            currentScene = "";
            running = false;
            timer = 0f;
        }

        public float GetTimer() {
            return timer;
        }

        public void Update() {
            if (running == false || category == null) {
                return;
            }

            if (InGameMenu.isLoading == true || category.PauseTimer(currentScene)) {
                return;
            }

            timer += Time.deltaTime;
        }

        public void LoadScene(string sceneName) {
            if (Scenes.titleScreen.IsScene(sceneName)) {
                Reset();
            }

            currentScene = sceneName;

            if (category.StartTimer(sceneName)) {
                running = true;
            }

            if (category.EndTimer(sceneName)) {
                running = false;
            }
        }

        public void UnloadScene(string sceneName) {
            category.CompleteScene(sceneName);
        }
    }
}
