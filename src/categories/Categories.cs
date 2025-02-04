namespace InGameTimer.Categories {
    // All Peaks
    public class AllPeaks : Category {
        public AllPeaks() {
            name = "All Peaks";

            foreach (SceneInfo info in Scenes.categoryFundamentals) {
                sceneStates.Add(info.internalName, false);
            }

            foreach (SceneInfo info in Scenes.categoryIntermediate) {
                sceneStates.Add(info.internalName, false);
            }

            foreach (SceneInfo info in Scenes.categoryAdvanced) {
                sceneStates.Add(info.internalName, false);
            }

            foreach (SceneInfo info in Scenes.categoryExpert) {
                sceneStates.Add(info.internalName, false);
            }
        }
    }

    // Fundamentals%
    public class Fundamentals : Category {
        public Fundamentals() {
            name = "Fundamentals%";

            foreach (SceneInfo info in Scenes.categoryFundamentals) {
                sceneStates.Add(info.internalName, false);
            }
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
    }

    // Advanced%
    public class Advanced : Category {
        public Advanced() {
            name = "Advanced%";

            foreach (SceneInfo info in Scenes.categoryAdvanced) {
                sceneStates.Add(info.internalName, false);
            }
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
    }
}
