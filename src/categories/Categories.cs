namespace InGameTimer.Categories {
    // Fundamentals%
    public class Fundamentals : Category {
        public Fundamentals() {
            name = "Fundamentals%";
            foreach (SceneInfo info in Scenes.categoryFundamentals) {
                sceneStates.Add(info.internalName, false);
            }
        }

        public override bool StartTimer(string sceneName) {
            return Scenes.IsFundamental(sceneName);
        }
    }

    // Intermediate%
    public class Intermediate : Category {
        public Intermediate() {
            name = "Intermediate%";
            foreach (SceneInfo info in Scenes.categoryIntermediate) {
                sceneStates.Add(info.internalName, false);
            }
        }

        public override bool StartTimer(string sceneName) {
            return Scenes.IsIntermediate(sceneName);
        }
    }

    // Advanced%
    public class Advanced : Category {
        public Advanced() {
            name = "Advanced%";
            foreach (SceneInfo info in Scenes.categoryAdvanced) {
                sceneStates.Add(info.internalName, false);
            }
        }

        public override bool StartTimer(string sceneName) {
            return Scenes.IsAdvanced(sceneName);
        }
    }

    // Expert%
    public class Expert : Category {
        public Expert() {
            name = "Expert%";
            foreach (SceneInfo info in Scenes.categoryExpert) {
                sceneStates.Add(info.internalName, false);
            }
        }

        public override bool StartTimer(string sceneName) {
            return Scenes.IsExpert(sceneName);
        }
    }
}
