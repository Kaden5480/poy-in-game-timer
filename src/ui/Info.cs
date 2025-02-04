using UnityEngine;
using UnityEngine.UI;

namespace InGameTimer.UI {
    public class Info {
        private bool displayUI = false;
        private Font font = null;
        private GameObject uiObj = null;

        private Vector2 defaultSizeDelta = new Vector2(500, 500);

        public Info() {
            GetFont();
            MakeUI();
        }

        private void GetFont() {
            GameObject textObj = GameObject.Find("Text");
            Text text = textObj.GetComponent<Text>();
            font = text.font;
        }

        private void MakeUI() {
            uiObj = new GameObject("IGT Info UI");
            uiObj.layer = LayerMask.NameToLayer("UI");
            GameObject.DontDestroyOnLoad(uiObj);

            uiObj.SetActive(displayUI);

            Canvas canvas = uiObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 90;

            uiObj.AddComponent<CanvasScaler>();
            uiObj.AddComponent<GraphicRaycaster>();

            RectTransform uiTransform = uiObj.GetComponent<RectTransform>();
            uiTransform.anchorMax = new Vector2(0.5f, 0.5f);
            uiTransform.anchorMin = new Vector2(0.5f, 0.5f);
            uiTransform.anchoredPosition = new Vector2(0f, 0f);

            GameObject backgroundObj = new GameObject("Background");
            backgroundObj.transform.SetParent(uiObj.transform);
            Image background = backgroundObj.AddComponent<Image>();
            background.color = new Color(0.5f, 0.5f, 1f, 0.8f);

            backgroundObj.GetComponent<RectTransform>().sizeDelta = defaultSizeDelta;

            DisplayPeaks();
        }

        public void Toggle() {
            displayUI = !displayUI;
            uiObj.SetActive(displayUI);
        }

        private void DisplayPeaks() {
            /**
             * UI setup:
             *
             * - Scroll Rect
             *   - Viewport
             *     - Content
             *       - Element
             *       - Element
             *   - Scrollbar
             */

            GameObject scrollRectObj = new GameObject("Scroll Rect");
            ScrollRect scrollRect = scrollRectObj.AddComponent<ScrollRect>();
            RectTransform scrollRectTransform = scrollRect.GetComponent<RectTransform>();
            scrollRectObj.transform.SetParent(uiObj.transform);

            scrollRectTransform.sizeDelta = defaultSizeDelta;
            scrollRect.horizontal = false;
            scrollRect.scrollSensitivity = 10f;

            // Viewport
            GameObject viewportObj = new GameObject("Viewport");
            RectTransform viewportRectTransform = viewportObj.AddComponent<RectTransform>();
            viewportObj.transform.SetParent(scrollRectObj.transform);
            scrollRect.viewport = viewportRectTransform;
            viewportObj.AddComponent<Mask>();

            // Scrollbar
            GameObject scrollBarObj = new GameObject("Scrollbar");
            scrollBarObj.transform.SetParent(scrollRectObj.transform);

            Scrollbar scrollBar = scrollBarObj.AddComponent<Scrollbar>();
            scrollBar.direction = Scrollbar.Direction.TopToBottom;

            scrollRect.verticalScrollbar = scrollBar;

            // The content of the scroll rect
            GameObject contentObj = new GameObject("Content");
            RectTransform contentRectTransform = contentObj.AddComponent<RectTransform>();
            VerticalLayoutGroup contentLayout = contentObj.AddComponent<VerticalLayoutGroup>();
            contentObj.transform.SetParent(viewportObj.transform);
            scrollRect.content = contentRectTransform;

            contentLayout.spacing = 5f;

            for (int i = 0; i < 20; i++) {
                GameObject textObj = new GameObject("Example Text");
                textObj.transform.SetParent(contentObj.transform);
                Text text = textObj.AddComponent<Text>();
                text.font = font;
                text.text = "Hello!";
            }
        }
    }
}
