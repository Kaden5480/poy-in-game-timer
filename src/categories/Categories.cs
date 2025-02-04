namespace InGameTimer.Categories {
    // All Peaks
    public class AllPeaks : Category {
        public AllPeaks() {
            name = "All Peaks";

            foreach (SceneInfo info in Scenes.baseGamePeaks) {
                sceneStates.Add(info.internalName, false);
            }
        }
    }

    // Fundamentals%
    public class Fundamentals : Category {
        public Fundamentals() {
            name = "Fundamentals%";

            foreach (SceneInfo info in Scenes.fundamentalPeaks) {
                sceneStates.Add(info.internalName, false);
            }
        }
    }

    // Intermediate%
    public class Intermediate : Category {
        public Intermediate() {
            name = "Intermediate%";

            foreach (SceneInfo info in Scenes.intermediatePeaks) {
                sceneStates.Add(info.internalName, false);
            }
        }
    }

    // Advanced%
    public class Advanced : Category {
        public Advanced() {
            name = "Advanced%";

            foreach (SceneInfo info in Scenes.advancedPeaks) {
                sceneStates.Add(info.internalName, false);
            }
        }
    }

    // Expert%
    public class Expert : Category {
        public Expert() {
            name = "Expert%";

            foreach (SceneInfo info in Scenes.expertPeaks) {
                sceneStates.Add(info.internalName, false);
            }
        }
    }
}
