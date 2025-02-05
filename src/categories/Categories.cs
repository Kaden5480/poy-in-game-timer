using System.Collections.Generic;

namespace InGameTimer.Categories {
    // 100%
    public class FullBaseGame : Category {
        public FullBaseGame() : base("100%", Scenes.baseGamePeaks) {}

        public override bool EndTimer(string sceneName) {
            return Progression.Peaks.CompletedBaseGame()
                && Progression.Artefacts.UnlockedAllBaseGame()
                && Progression.Ropes.UnlockedAll()
                && Progression.Tools.UnlockedAll();
        }

        public override IEnumerable<(string, string)> GetUIInfo() {
            // Peaks
            yield return ("Peaks", $"{GameManager.control.progression}/37");
            foreach ((string displayName, string state) in base.GetUIInfo()) {
                yield return (displayName, state);
            }

            // Collectables
            int artefactCount = 0;
            foreach (Progression.Artefact artefact in Progression.Artefacts.baseGame) {
                if (artefact.IsUnlocked()) {
                    artefactCount++;
                }
            }

            yield return ("Artefacts", $"{artefactCount}/20");
            foreach (Progression.Artefact artefact in Progression.Artefacts.baseGame) {
                yield return (artefact.displayName, artefact.IsUnlocked().ToString());
            }

            // Tools
            int toolCount = 0;
            foreach (Progression.Tool tool in Progression.Tools.tools) {
                if (tool.IsUnlocked()) {
                    toolCount++;
                }
            }

            yield return ("Tools", $"{toolCount}/13");
            foreach (Progression.Tool tool in Progression.Tools.tools) {
                yield return (tool.displayName, tool.IsUnlocked().ToString());
            }

            yield return ("Ropes", $"{GameManager.control.ropesCollected}/{Progression.Ropes.maxRopes}");
        }
    }

    // Any%
    public class Any : Category {
        public Any() : base("Any%", Scenes.baseGamePeaks) {}

        public override bool EndTimer(string sceneName) {
            return Scenes.normalEnding.IsScene(sceneName);
        }
    }

    // All Peaks
    public class AllPeaks : Category {
        public AllPeaks() : base("All Peaks", Scenes.baseGamePeaks) {}

        public override bool EndTimer(string sceneName) {
            return Progression.Peaks.CompletedBaseGame();
        }
    }

    // Fundamentals%
    public class Fundamentals : Category {
        public Fundamentals() : base("Fundamentals%", Scenes.fundamentalPeaks) {}
    }

    // Intermediate%
    public class Intermediate : Category {
        public Intermediate() : base("Intermediate%", Scenes.intermediatePeaks) {}
    }

    // Advanced%
    public class Advanced : Category {
        public Advanced() : base("Advanced%", Scenes.advancedPeaks) {}
    }

    // Expert%
    public class Expert : Category {
        public Expert() : base("Expert%", Scenes.expertPeaks) {}
    }
}
