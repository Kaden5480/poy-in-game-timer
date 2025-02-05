namespace InGameTimer.Progression {
    public class Tool {
        public string internalName { get; }
        public string displayName { get; }

        public Tool(string internalName, string displayName) {
            this.internalName = internalName;
            this.displayName = displayName;
        }

        public bool IsUnlocked() {
            return (bool) typeof(GameManager).GetField(internalName)
                .GetValue(GameManager.control);
        }
    }

    public class Tools {
        public static Tool[] tools = new[] {
            new Tool("rope",            "Ropes"),
            new Tool("ropesUpgrade",    "Double Length Ropes"),
            new Tool("pocketwatch",     "Pocketwatch"),
            new Tool("monocular",       "Monocular"),
            new Tool("coffee",          "Coffee"),
            new Tool("iceAxes",         "Ice Axes"),
            new Tool("chalkBag",        "Chalk"),
            new Tool("crampons",        "Crampons (6 Point)"),
            new Tool("cramponsUpgrade", "Crampons (10 Point)"),
            new Tool("smokingpipe",     "Smoking Pipe"),
            new Tool("artefactMap",     "Collectable Map"),
            new Tool("barometer",       "Barometer"),
            new Tool("phonograph",      "Phonograph"),
        };

        public static bool UnlockedAll() {
            foreach (Tool tool in tools) {
                if (tool.IsUnlocked() == false) {
                    return false;
                }
            }

            return true;
        }
    }
}
