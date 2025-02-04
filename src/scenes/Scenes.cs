namespace InGameTimer {
    public class Scenes {
        // Fundamentals
        public static SceneInfo greenhornsTop    { get; } = new SceneInfo("Peak_1_GreenhornNEW", "Greenhorn's Top", "greenhornspeak");
        public static SceneInfo paltryPeak       { get; } = new SceneInfo("Peak_2_PaltryNEW", "Paltry Peak", "paltrypeak");
        public static SceneInfo oldMill          { get; } = new SceneInfo("Peak_3_OldMill", "Old Mill", "oldmill");
        public static SceneInfo grayGully        { get; } = new SceneInfo("Peak_3_GrayGullyNEW", "Gray Gully", "graygully");
        public static SceneInfo theLighthouse    { get; } = new SceneInfo("Peak_LighthouseNew", "The Lighthouse", "lighthouse");
        public static SceneInfo oldManOfSjor     { get; } = new SceneInfo("Peak_4_OldManOfSjorNEW", "Old Man of Sjór", "oldmanofsjor");
        public static SceneInfo giantsShelf      { get; } = new SceneInfo("Peak_5_GiantsShelfNEW", "Giant's Shelf", "giantsshelf");
        public static SceneInfo evergreensEnd    { get; } = new SceneInfo("Peak_8_EvergreensEndNEW", "Evergreen's End", "evergreensend");
        public static SceneInfo theTwins         { get; } = new SceneInfo("Peak_9_TheTwinsNEW", "The Twins", "thetwins");
        public static SceneInfo oldGrovesSkelf   { get; } = new SceneInfo("Peak_6_OldGroveSkelf", "Old Grove's Skelf", "oldgroveskelf");
        public static SceneInfo hangmansLeap     { get; } = new SceneInfo("Peak_7_HangmansLeapNEW", "Hangman's Leap", "hangmansleap");
        public static SceneInfo landsEnd         { get; } = new SceneInfo("Peak_13_LandsEndNEW", "Land's End", "landsend");
        public static SceneInfo oldLangr         { get; } = new SceneInfo("Peak_19_OldLangr", "Old Langr", "oldlangr");
        public static SceneInfo aldrGrotto       { get; } = new SceneInfo("Peak_14_Cavern", "Aldr Grotto", "aldrgrotto");
        public static SceneInfo threeBrothers    { get; } = new SceneInfo("Peak_16_ThreeSeaStacks", "Three Brothers", "threebrothers");
        public static SceneInfo waltersCrag      { get; } = new SceneInfo("Peak_10_WaltersCragNEW", "Walter's Crag", "walterscrag");
        public static SceneInfo theGreatCrevice  { get; } = new SceneInfo("Peak_15_TheGreatCrevice", "The Great Crevice", "greatcrevice");
        public static SceneInfo oldHagger        { get; } = new SceneInfo("Peak_17_RainyPeak", "Old Hagger", "oldhagger");
        public static SceneInfo ugsomeStorr      { get; } = new SceneInfo("Peak_18_FallingBoulders", "Ugsome Stórr", "ugsomestorr");
        public static SceneInfo wutheringCrest   { get; } = new SceneInfo("Peak_11_WutheringCrestNEW", "Wuthering Crest", "wutheringcrest");

        // Intermediate
        public static SceneInfo portersBoulder   { get; } = new SceneInfo("Boulder_1_OldWalkersBoulder", "Porter's Boulder", "portersboulder");
        public static SceneInfo jotunnsThumb     { get; } = new SceneInfo("Boulder_2_JotunnsThumb", "Jotunn's Thumb", "jotunnsthumb");
        public static SceneInfo oldSkerry        { get; } = new SceneInfo("Boulder_3_OldSkerry", "Old Skerry", "oldskerry");
        public static SceneInfo hamarrStone      { get; } = new SceneInfo("Boulder_4_TheHamarrStone", "Hamarr Stone", "hamarrstone");
        public static SceneInfo giantsNose       { get; } = new SceneInfo("Boulder_5_GiantsNose", "Giant's Nose", "giantsnose");
        public static SceneInfo waltersBoulder   { get; } = new SceneInfo("Boulder_6_WaltersBoulder", "Walter's Boulder", "waltersboulder");
        public static SceneInfo sunderedSons     { get; } = new SceneInfo("Boulder_7_SunderedSons", "Sundered Sons", "sunderedsons");
        public static SceneInfo oldWealdsBoulder { get; } = new SceneInfo("Boulder_8_OldWealdsBoulder", "Old Weald's Boulder", "oldwealdsboulder");
        public static SceneInfo leaningSpire     { get; } = new SceneInfo("Boulder_9_LeaningSpire", "Leaning Spire", "leaningspire");
        public static SceneInfo cromlech         { get; } = new SceneInfo("Boulder_10_Cromlech", "Cromlech", "cromlech");

        // Advanced
        public static SceneInfo walkersPillar    { get; } = new SceneInfo("Tind_1_WalkersPillar", "Walker's Pillar", "walkerspillar");
        public static SceneInfo greatGaol        { get; } = new SceneInfo("Tind_3_GreatGaol", "Great Gaol", "greatgaol");
        public static SceneInfo eldenhorn        { get; } = new SceneInfo("Tind_2_Eldenhorn", "Eldenhorn", "eldenhorn");
        public static SceneInfo stHaelga         { get; } = new SceneInfo("Tind_4_StHaelga", "St. Haelga", "sthaelga");
        public static SceneInfo ymirsShadow      { get; } = new SceneInfo("Tind_5_YmirsShadow", "Ymir's Shadow", "ymirsshadow");

        // Expert
        public static SceneInfo greatBulwark     { get; } = new SceneInfo("Category4_1_FrozenWaterfall", "Great Bulwark", "greatbulwark");
        public static SceneInfo solemnTempest    { get; } = new SceneInfo("Category4_2_SolemnTempest", "Solemn Tempest", "solemntempest");

        // Misc
        public static SceneInfo galesCabin       { get; } = new SceneInfo("Cabin", "Cabin", null);
        public static SceneInfo northernCabin    { get; } = new SceneInfo("Category4_1_Cabin", "North Cabin", null);
        public static SceneInfo titleScreen      { get; } = new SceneInfo("TitleScreen", "Main Menu", null);
        public static SceneInfo normalEnding     { get; } = new SceneInfo("GameEnding_BaseGame", "Normal Ending", null);
        public static SceneInfo trueEnding       { get; } = new SceneInfo("GameEnding_TrueEnding", "True Ending", null);

        // All fundamental peaks
        public static SceneInfo[] fundamentalPeaks = new[] {
            greenhornsTop, paltryPeak, oldMill, grayGully, theLighthouse, oldManOfSjor,
            giantsShelf, evergreensEnd, theTwins, oldGrovesSkelf, hangmansLeap, landsEnd,
            oldLangr, aldrGrotto, threeBrothers, waltersCrag, theGreatCrevice, oldHagger,
            ugsomeStorr, wutheringCrest,
        };

        // All intermediate peaks
        public static SceneInfo[] intermediatePeaks = new[] {
            portersBoulder, jotunnsThumb, oldSkerry, hamarrStone, giantsNose,
            waltersBoulder, sunderedSons, oldWealdsBoulder, leaningSpire, cromlech,
        };

        // All advanced peaks
        public static SceneInfo[] advancedPeaks = new[] {
            walkersPillar, greatGaol, eldenhorn, stHaelga, ymirsShadow,
        };

        // All expert peaks
        public static SceneInfo[] expertPeaks = new[] {
            greatBulwark, solemnTempest,
        };

        // All peaks in the base game
        public static SceneInfo[] baseGamePeaks = new[] {
            greenhornsTop, paltryPeak, oldMill, grayGully, theLighthouse, oldManOfSjor,
            giantsShelf, evergreensEnd, theTwins, oldGrovesSkelf, hangmansLeap, landsEnd,
            oldLangr, aldrGrotto, threeBrothers, waltersCrag, theGreatCrevice, oldHagger,
            ugsomeStorr, wutheringCrest,
            portersBoulder, jotunnsThumb, oldSkerry, hamarrStone, giantsNose,
            waltersBoulder, sunderedSons, oldWealdsBoulder, leaningSpire, cromlech,
            walkersPillar, greatGaol, eldenhorn, stHaelga, ymirsShadow,
            greatBulwark, solemnTempest,
        };

        /**
         * <summary>
         * Checks if a scene is a fundamental peak.
         * </summary>
         * <param name="sceneName">The name of the scene to check</param>
         * <return>True if it is, false otherwise</return>
         */
        public static bool IsFundamental(string sceneName) {
            foreach (SceneInfo info in fundamentalPeaks) {
                if (info.IsScene(sceneName)) {
                    return true;
                }
            }

            return false;
        }

        /**
         * <summary>
         * Checks if a scene is an intermediate peak.
         * </summary>
         * <param name="sceneName">The name of the scene to check</param>
         * <return>True if it is, false otherwise</return>
         */
        public static bool IsIntermediate(string sceneName) {
            foreach (SceneInfo info in intermediatePeaks) {
                if (info.IsScene(sceneName)) {
                    return true;
                }
            }

            return false;
        }

        /**
         * <summary>
         * Checks if a scene is an advanced peak.
         * </summary>
         * <param name="sceneName">The name of the scene to check</param>
         * <return>True if it is, false otherwise</return>
         */
        public static bool IsAdvanced(string sceneName) {
            foreach (SceneInfo info in advancedPeaks) {
                if (info.IsScene(sceneName)) {
                    return true;
                }
            }

            return false;
        }

        /**
         * <summary>
         * Checks if a scene is an expert peak.
         * </summary>
         * <param name="sceneName">The name of the scene to check</param>
         * <return>True if it is, false otherwise</return>
         */
        public static bool IsExpert(string sceneName) {
            foreach (SceneInfo info in expertPeaks) {
                if (info.IsScene(sceneName)) {
                    return true;
                }
            }

            return false;
        }

        /**
         * <summary>
         * Checks if a scene is a base game peak.
         * </summary>
         * <param name="sceneName">The name of the scene to check</param>
         * <return>True if it is, false otherwise</return>
         */
        public static bool IsBaseGamePeak(string sceneName) {
            foreach (SceneInfo info in baseGamePeaks) {
                if (info.IsScene(sceneName)) {
                    return true;
                }
            }

            return false;
        }
    }
}
