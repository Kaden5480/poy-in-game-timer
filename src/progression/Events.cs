namespace InGameTimer.Progression {
    public class Event {
        public string internalName { get; }
        public string displayName { get; }

        public Event(string internalName, string displayName) {
            this.internalName = internalName;
            this.displayName = displayName;
        }

        public bool IsUnlocked() {
            return (bool) typeof(GameManager).GetField(internalName)
                .GetValue(GameManager.control);
        }
    }

    public class Events {
        public static Event[] baseGame = new[] {
            new Event("npc_oas_category1" , "Fundamentals Medal"),
            new Event("npc_oas_category2" , "Intermediate Medal"),
            new Event("npc_oas_category3" , "Advanced Medal"),
        }

        public static bool UnlockedAll() {
            foreach(Event event in baseGame) {
                if (event.IsUnlocked() == false) {
                    return false;
                }
            }

            return true;
        }
    }
}
