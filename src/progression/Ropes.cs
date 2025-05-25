namespace InGameTimer.Progression {
    public class Rope {
        public string internalName { get; }
        public string displayName { get; }

        public Rope(string internalName, string displayName) {
            this.internalName = internalName;
            this.displayName = displayName;
        }

        public bool IsUnlocked() {
            return (bool) typeof(GameManager).GetField(internalName)
                .GetValue(GameManager.control);
        }
    }

    public class Ropes {
        public static int maxRopes = 42;

        public static Rope[] all = new[] {
            // Collectables
            new Rope("hasExtraFirstRope",               "+2 (Old Man of Sjór)"),
            new Rope("hasExtra10Rope",                  "+2 (Evergreen's End)"),
            new Rope("hasExtraSecondRope",              "+2 (Hangman's Leap)"),
            new Rope("hasExtra9Rope",                   "+2 (Land's End)"),
            new Rope("hasExtra8Rope",                   "+2 (Walter's Crag)"),
            new Rope("hasExtra11Rope",                  "+2 (The Great Crevice)"),
            new Rope("hasExtra12Rope",                  "+2 (Old Hagger)"),
            new Rope("hasExtraThirdRope",               "+2 (Ugsome Stórr)"),
            new Rope("hasExtra6Rope",                   "+2 (Wuthering Crest)"),
            new Rope("hasExtra7Rope",                   "+2 (Great Gaol)"),
            new Rope("hasExtraFourthRope",              "+2 (Eldenhorn)"),
            new Rope("hasExtra5Rope",                   "+2 (Ymir's Shadow)"),

            // Co-Climbs
            new Rope("oldcouple_encounter_walterscrag", "+1 (Walter's Crag Co-Climb)"),
            new Rope("walker_encounter_walkerspillar",  "+1 (Walker's Pillar Co-Climb)"),

            // NPC Encounters
            new Rope("greatgaol_encounter_oasclimber",  "+1 (Great Gaol NPC)"),
            new Rope("sthaelga_encounter_oasclimber",   "+1 (St Haelga NPC)"),
        };

        public static bool UnlockedAll() {
            foreach (Rope rope in all) {
                if (rope.IsUnlocked() == false) {
                    return false;
                }
            }

            return GameManager.control.ropesCollected >= maxRopes;
        }
    }
}
