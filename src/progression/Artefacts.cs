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
            new Artefact("hasArtefact_Hat1",            "artefact_Hat1_IsDirty",            "Hat (Old Mill)"),
            new Artefact("hasArtefact_Hat2",            "artefact_Hat2_IsDirty",            "Hat (Evergreen's End)"),
            new Artefact("hasArtefact_Shoe",            "artefact_Shoe_IsDirty",            "Shoe (Old Man of Sjór)"),
            new Artefact("hasArtefact_Photograph1",     "artefact_Photograph1_IsDirty",     "Photograph (Gray Gully)"),
            new Artefact("hasArtefact_Photograph2",     "artefact_Photograph2_IsDirty",     "Photograph (Land's End)"),
            new Artefact("hasArtefact_Photograph3",     "artefact_Photograph3_IsDirty",     "Photograph (The Great Crevice)"),
            new Artefact("hasArtefact_Photograph4",     "artefact_Photograph4_IsDirty",     "Photograph (St Haelga)"),
            new Artefact("hasArtefact_PhotographFrame", "artefact_PhotographFrame_IsDirty", "Photograph Frame (Great Gaol)"),
            new Artefact("hasArtefact_Backpack",        "artefact_Backpack_IsDirty",        "Backpack (Aldr Grotto)"),
            new Artefact("hasArtefact_Sleepingbag",     "artefact_Sleepingbag_IsDirty",     "Sleeping Bag (Giant's Shelf)"),
            new Artefact("hasArtefact_Shovel",          "artefact_Shovel_IsDirty",          "Shovel (Three Brothers)"),
            new Artefact("hasArtefact_Helmet",          "artefact_Helmet_IsDirty",          "Helmet (Old Grove's Skelf)"),
            new Artefact("hasArtefact_Coffeebox1",      "artefact_Coffeebox1_IsDirty",      "Coffee (Old Langr)"),
            new Artefact("hasArtefact_Coffeebox2",      "artefact_Coffeebox2_IsDirty",      "Coffee (Wuthering Crest)"),
            new Artefact("hasArtefact_Chalkbox1",       "artefact_Chalkbox1_IsDirty",       "Chalk (Walker's Pillar)"),
            new Artefact("hasArtefact_Chalkbox2",       "artefact_Chalkbox2_IsDirty",       "Chalk (Eldenhorn)"),
            new Artefact("hasArtefact_Statue0",         "artefact_Statue0_IsDirty",         "Statue (Walter's Crag)"),
            new Artefact("hasArtefact_Statue1",         "artefact_Statue1_IsDirty",         "Statue (Leaning Spire)"),
            new Artefact("hasArtefact_Statue2",         "artefact_Statue2_IsDirty",         "Statue (Ymir's Shadow)"),
            new Artefact("hasArtefact_Statue3",         "artefact_Statue3_IsDirty",         "Statue (Great Bulwark)"),
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
