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
            category = new Categories.Intermediate();
            currentScene = "";
            running = false;
            timer = 0f;
        }

        public void SetCategory(Category category) {
            Reset();
            this.category = category;
            category.Reset();
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

        public void CompleteScene(string sceneName) {
            category.CompleteScene(sceneName);
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
    }
}
