using System;
using UnityEngine;
using UnityEngine.UI;

namespace InGameTimer.UI {
    public class CategoryPicker {
        private Category[] categories = new Category[] {
            new Categories.FullBaseGame(),
            new Categories.Any(),
            new Categories.AllPeaks(),
            new Categories.Fundamentals(),
            new Categories.Intermediate(),
            new Categories.Advanced(),
            new Categories.Expert(),
        };

        private Timer timer = null;
        private GameObject uiObj = null;

        public CategoryPicker(Timer timer) {
            this.timer = timer;
            MakeUI();
        }

        private void MakeUI() {
            const float width = 400f;
            const float height = 500f;
            const float padding = 20f;

            uiObj = new GameObject("IGT Category Picker");
            uiObj.layer = LayerMask.NameToLayer("UI");
            GameObject.DontDestroyOnLoad(uiObj);

            // Add canvas
            Canvas canvas = uiObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 90;

            uiObj.AddComponent<CanvasScaler>();
            uiObj.AddComponent<GraphicRaycaster>();

            RectTransform uiTransform = uiObj.GetComponent<RectTransform>();
            uiTransform.anchorMax = new Vector2(0.5f, 0.5f);
            uiTransform.anchorMin = new Vector2(0.5f, 0.5f);
            uiTransform.anchoredPosition = new Vector2(0, 0);

            // Background
            GameObject backgroundObj =  new GameObject("Background");
            backgroundObj.transform.SetParent(uiObj.transform);

            Image background = backgroundObj.AddComponent<Image>();
            background.color = new Color(0.5f, 0.5f, 1f, 0.8f);
            backgroundObj.GetComponent<RectTransform>()
                .sizeDelta = new Vector2(width + padding, height + padding);

            // Content
            GameObject contentObj = new GameObject("Content");
            contentObj.transform.SetParent(uiObj.transform);

            RectTransform contentRectTransform = contentObj.AddComponent<RectTransform>();
            VerticalLayoutGroup contentLayout = contentObj.AddComponent<VerticalLayoutGroup>();
            contentLayout.spacing = 10f;

            ContentSizeFitter fitter = contentObj.AddComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            GameObject gameTextObj = GameObject.Find("Text");
            Text gameText = gameTextObj.GetComponent<Text>();
            Font gameFont = gameText.font;

            // Categories
            foreach (Category category in categories) {
                GameObject buttonObj = new GameObject("Button");
                buttonObj.transform.SetParent(contentObj.transform);

                UnityEngine.UI.Button button = buttonObj.AddComponent<UnityEngine.UI.Button>();
                button.onClick.AddListener(() => {
                    Console.WriteLine($"{category.name} selected");
                    timer.SetCategory(category);
                });

                GameObject textObj = new GameObject("Button Text");
                textObj.transform.SetParent(buttonObj.transform);

                Text text = textObj.AddComponent<Text>();
                text.font = gameFont;
                text.fontSize = 54;
                text.text = category.name;
                text.alignment = TextAnchor.MiddleCenter;

                button.targetGraphic = text;

                LayoutElement layoutElement = buttonObj.AddComponent<LayoutElement>();
                layoutElement.preferredHeight = 60;
            }

            contentObj.GetComponent<RectTransform>()
                .sizeDelta = new Vector2(width, height);
        }

        public void Update() {
            uiObj.SetActive(true);
        }
    }
}
