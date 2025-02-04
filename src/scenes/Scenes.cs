namespace InGameTimer {
    public class Scenes {
        // Fundamentals
        public static SceneInfo greenhornsTop    { get; } = new SceneInfo("Peak_1_GreenhornNEW", "Greenhorn's Top");
        public static SceneInfo paltryPeak       { get; } = new SceneInfo("Peak_2_PaltryNEW", "Paltry Peak");
        public static SceneInfo oldMill          { get; } = new SceneInfo("Peak_3_OldMill", "Old Mill");
        public static SceneInfo grayGully        { get; } = new SceneInfo("Peak_3_GrayGullyNEW", "Gray Gully");
        public static SceneInfo theLighthouse    { get; } = new SceneInfo("Peak_LighthouseNew", "The Lighthouse");
        public static SceneInfo oldManOfSjor     { get; } = new SceneInfo("Peak_4_OldManOfSjorNEW", "Old Man of Sjór");
        public static SceneInfo giantsShelf      { get; } = new SceneInfo("Peak_5_GiantsShelfNEW", "Giant's Shelf");
        public static SceneInfo evergreensEnd    { get; } = new SceneInfo("Peak_8_EvergreensEndNEW", "Evergreen's End");
        public static SceneInfo theTwins         { get; } = new SceneInfo("Peak_9_TheTwinsNEW", "The Twins");
        public static SceneInfo oldGrovesSkelf   { get; } = new SceneInfo("Peak_6_OldGroveSkelf", "Old Grove's Skelf");
        public static SceneInfo hangmansLeap     { get; } = new SceneInfo("Peak_7_HangmansLeapNEW", "Hangman's Leap");
        public static SceneInfo landsEnd         { get; } = new SceneInfo("Peak_13_LandsEndNEW", "Land's End");
        public static SceneInfo oldLangr         { get; } = new SceneInfo("Peak_19_OldLangr", "Old Langr");
        public static SceneInfo aldrGrotto       { get; } = new SceneInfo("Peak_14_Cavern", "Aldr Grotto");
        public static SceneInfo threeBrothers    { get; } = new SceneInfo("Peak_16_ThreeSeaStacks", "Three Brothers");
        public static SceneInfo waltersCrag      { get; } = new SceneInfo("Peak_10_WaltersCragNEW", "Walter's Crag");
        public static SceneInfo theGreatCrevice  { get; } = new SceneInfo("Peak_15_TheGreatCrevice", "The Great Crevice");
        public static SceneInfo oldHagger        { get; } = new SceneInfo("Peak_17_RainyPeak", "Old Hagger");
        public static SceneInfo ugsomeStorr      { get; } = new SceneInfo("Peak_18_FallingBoulders", "Ugsome Stórr");
        public static SceneInfo wutheringCrest   { get; } = new SceneInfo("Peak_11_WutheringCrestNEW", "Wuthering Crest");

        // Intermediate
        public static SceneInfo portersBoulder   { get; } = new SceneInfo("Boulder_1_OldWalkersBoulder", "Porter's Boulder");
        public static SceneInfo jotunnsThumb     { get; } = new SceneInfo("Boulder_2_JotunnsThumb", "Jotunn's Thumb");
        public static SceneInfo oldSkerry        { get; } = new SceneInfo("Boulder_3_OldSkerry", "Old Skerry");
        public static SceneInfo hamarrStone      { get; } = new SceneInfo("Boulder_4_TheHamarrStone", "Hamarr Stone");
        public static SceneInfo giantsNose       { get; } = new SceneInfo("Boulder_5_GiantsNose", "Giant's Nose");
        public static SceneInfo waltersBoulder   { get; } = new SceneInfo("Boulder_6_WaltersBoulder", "Walter's Boulder");
        public static SceneInfo sunderedSons     { get; } = new SceneInfo("Boulder_7_SunderedSons", "Sundered Sons");
        public static SceneInfo oldWealdsBoulder { get; } = new SceneInfo("Boulder_8_OldWealdsBoulder", "Old Weald's Boulder");
        public static SceneInfo leaningSpire     { get; } = new SceneInfo("Boulder_9_LeaningSpire", "Leaning Spire");
        public static SceneInfo cromlech         { get; } = new SceneInfo("Boulder_10_Cromlech", "Cromlech");

        // Advanced
        public static SceneInfo walkersPillar    { get; } = new SceneInfo("Tind_1_WalkersPillar", "Walker's Pillar");
        public static SceneInfo greatGaol        { get; } = new SceneInfo("Tind_3_GreatGaol", "Great Gaol");
        public static SceneInfo eldenhorn        { get; } = new SceneInfo("Tind_2_Eldenhorn", "Eldenhorn");
        public static SceneInfo stHaelga         { get; } = new SceneInfo("Tind_4_StHaelga", "St. Haelga");
        public static SceneInfo ymirsShadow      { get; } = new SceneInfo("Tind_5_YmirsShadow", "Ymir's Shadow");

        // Expert
        public static SceneInfo greatBulwark     { get; } = new SceneInfo("Category4_1_FrozenWaterfall", "Great Bulwark");
        public static SceneInfo solemnTempest    { get; } = new SceneInfo("Category4_2_SolemnTempest", "Solemn Tempest");

        // Misc
        public static SceneInfo galesCabin       { get; } = new SceneInfo("Cabin", "Cabin");
        public static SceneInfo northernCabin    { get; } = new SceneInfo("Category4_1_Cabin", "North Cabin");
        public static SceneInfo titleScreen      { get; } = new SceneInfo("TitleScreen", "Main Menu");
        public static SceneInfo normalEnding     { get; } = new SceneInfo("GameEnding_BaseGame", "Normal Ending");
        public static SceneInfo trueEnding       { get; } = new SceneInfo("GameEnding_TrueEnding", "True Ending");

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
