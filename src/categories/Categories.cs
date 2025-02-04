namespace InGameTimer.Categories {
    // 100%
    public class FullBaseGame : Category {
        public FullBaseGame() : base("100%", Scenes.baseGamePeaks) {}

        public override bool EndTimer(string sceneName) {
            return Progression.Peaks.CompletedBaseGame()
                && Progression.Artefacts.UnlockedAllBaseGame()
                && Progression.Tools.UnlockedAll();
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
