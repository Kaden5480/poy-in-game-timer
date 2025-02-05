using UnityEngine;

namespace InGameTimer.UI {
    public class Info {
        private bool enabled;

        private int selectedCategory = 0;
        private string[] categoryNames;

        private Category[] categories = new Category[] {
            new Categories.Any(),
            new Categories.FullBaseGame(),
            new Categories.AllPeaks(),
            new Categories.Fundamentals(),
            new Categories.Intermediate(),
            new Categories.Advanced(),
            new Categories.Expert(),
        };

        private Vector2 scrollPosition = new Vector2(0f, 0f);

        private Timer timer;

        public Info(Timer timer) {
            enabled = true;
            this.timer = timer;
            this.categoryNames = new[] {
                categories[0].name,
                categories[1].name,
                categories[2].name,
                categories[3].name,
                categories[4].name,
                categories[5].name,
                categories[6].name,
            };
        }

        public void Toggle() {
            enabled = !enabled;
        }

        public void Render() {
            if (enabled == false) {
                return;
            }

            // Category info
            Category category = timer.GetCategory();

            GUILayout.BeginArea(new Rect(70, 70, 450, 560), GUI.skin.box);
            scrollPosition = GUILayout.BeginScrollView(
                scrollPosition,
                GUILayout.Width(430), GUILayout.Height(480)
            );

            foreach ((string displayName, string value) in category.GetUIInfo()) {
                GUILayout.Label($"{displayName}: {value}");
            }

            GUILayout.EndScrollView();

            // Category selection
            GUILayout.BeginVertical();

            int currentSelected = GUILayout.SelectionGrid(
                selectedCategory, categoryNames, 3
            );

            if (currentSelected != selectedCategory) {
                timer.SetCategory(categories[currentSelected]);
            }

            selectedCategory = currentSelected;

            GUILayout.EndVertical();

            GUILayout.EndArea();
        }
    }
}
