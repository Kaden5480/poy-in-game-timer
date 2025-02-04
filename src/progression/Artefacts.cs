namespace InGameTimer.Progression {
    public class Artefact {
        public string fieldClean { get; }
        public string fieldDirty { get; }
        public string displayName { get; }

        public Artefact(string fieldClean, string fieldDirty, string displayName) {
            this.fieldClean = fieldClean;
            this.fieldDirty = fieldDirty;
            this.displayName = displayName;
        }

        public bool IsUnlocked() {
            return (bool) typeof(GameManager).GetField(fieldClean)
                    .GetValue(GameManager.control)
                || (bool) typeof(GameManager).GetField(fieldDirty)
                    .GetValue(GameManager.control);
        }
    }

    public class Artefacts {
        public static Artefact[] baseGame = new[] {
            new Artefact("hasArtefact_Hat1",            "artefact_Hat1_IsDirty",            ""),
            new Artefact("hasArtefact_Hat2",            "artefact_Hat2_IsDirty",            ""),
            new Artefact("hasArtefact_Shoe",            "artefact_Shoe_IsDirty",            ""),
            new Artefact("hasArtefact_Photograph1",     "artefact_Photograph1_IsDirty",     ""),
            new Artefact("hasArtefact_Photograph2",     "artefact_Photograph2_IsDirty",     ""),
            new Artefact("hasArtefact_Photograph3",     "artefact_Photograph3_IsDirty",     ""),
            new Artefact("hasArtefact_Photograph4",     "artefact_Photograph4_IsDirty",     ""),
            new Artefact("hasArtefact_PhotographFrame", "artefact_PhotographFrame_IsDirty", ""),
            new Artefact("hasArtefact_Backpack",        "artefact_Backpack_IsDirty",        ""),
            new Artefact("hasArtefact_Sleepingbag",     "artefact_Sleepingbag_IsDirty",     ""),
            new Artefact("hasArtefact_Shovel",          "artefact_Shovel_IsDirty",          ""),
            new Artefact("hasArtefact_Helmet",          "artefact_Helmet_IsDirty",          ""),
            new Artefact("hasArtefact_Coffeebox1",      "artefact_Coffeebox1_IsDirty",      ""),
            new Artefact("hasArtefact_Coffeebox2",      "artefact_Coffeebox2_IsDirty",      ""),
            new Artefact("hasArtefact_Chalkbox1",       "artefact_Chalkbox1_IsDirty",       ""),
            new Artefact("hasArtefact_Chalkbox2",       "artefact_Chalkbox2_IsDirty",       ""),
            new Artefact("hasArtefact_Statue0",         "artefact_Statue0_IsDirty",         ""),
            new Artefact("hasArtefact_Statue1",         "artefact_Statue1_IsDirty",         ""),
            new Artefact("hasArtefact_Statue2",         "artefact_Statue2_IsDirty",         ""),
            new Artefact("hasArtefact_Statue3",         "artefact_Statue3_IsDirty",         ""),
        };

        public static bool UnlockedAllBaseGame() {
            foreach (Artefact artefact in Artefacts.baseGame) {
                if (artefact.IsUnlocked() == false) {
                    return false;
                }
            }

            return true;
        }
    }
}
