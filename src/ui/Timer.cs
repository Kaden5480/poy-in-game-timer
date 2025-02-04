using System;

using UnityEngine;
using UnityEngine.UI;

namespace InGameTimer.UI {
    public class Timer {
        private GameObject uiObj = null;
        private GameObject timerObj = null;
        private Text timerText = null;

        private TimerLogic logic = new TimerLogic();

        public Timer() {
            logic.Reset();
            MakeUI();
        }

        private void MakeUI() {
            uiObj = new GameObject("IGT UI");
            uiObj.layer = LayerMask.NameToLayer("UI");
            GameObject.DontDestroyOnLoad(uiObj);

            // Add canvas
            Canvas canvas = uiObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 100;

            uiObj.AddComponent<CanvasScaler>();
            uiObj.AddComponent<GraphicRaycaster>();

            timerObj = new GameObject("IGT Timer");
            timerObj.transform.SetParent(uiObj.transform);

            timerText = timerObj.AddComponent<Text>();

            GameObject textObj = GameObject.Find("Text");
            Text text = textObj.GetComponent<Text>();

            timerText.font = text.font;
            timerText.fontSize = 54;

            timerText.rectTransform.anchorMin = new Vector2(0.053f, 0.945f);
            timerText.rectTransform.anchorMax = new Vector2(1, 0.945f);
            timerText.rectTransform.anchoredPosition = new Vector2(0, 0);

            // Add outline
            Outline outline = timerObj.AddComponent<Outline>();
            outline.effectColor = new Color(0, 0, 0, 0.5f);
            outline.effectDistance = new Vector2(2f, -2f);
        }

        public void CompleteScene(string sceneName) {
            logic.CompleteScene(sceneName);
        }

        public void LoadScene(string sceneName) {
            logic.LoadScene(sceneName);
        }

        public void Update() {
            uiObj.SetActive(true);

            string categoryName = "N/A";

            if (logic.category != null) {
                categoryName = logic.category.name;
            }

            TimeSpan span = TimeSpan.FromSeconds(logic.GetTimer());
            timerText.text = $"IGT ({categoryName}): {span.Hours:00}:{span.Minutes:00}:{span.Seconds:00}:{span.Milliseconds:00}";
        }
    }
}
