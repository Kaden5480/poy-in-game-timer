using System;

using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

#if BEPINEX

using BepInEx;
using BepInEx.Configuration;

namespace InGameTimer {
    [BepInPlugin("com.github.Kaden5480.poy-in-game-timer", "InGameTimer", PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        /**
         * <summary>
         * Executes when the plugin is being loaded.
         * </summary>
         */
        public void Awake() {
            Harmony.CreateAndPatchAll(typeof(PatchMoveTimeAttack));
            Harmony.CreateAndPatchAll(typeof(PatchStampJournal));

            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        /**
         * <summary>
         * Executes when the plugin object is destroyed.
         * </summary>
         */
        public void OnDestroy() {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        /*
         * <summary>
         * Executes whenever a scene loads.
         * </summary>
         * <param name="scene">The scene which loaded</param>
         * <param name="mode">The mode the scene was loaded with</param>
         */
        public void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
            CommonSceneLoad(scene.buildIndex, scene.name);
        }

        /*
         * <summary>
         * Executes once per frame.
         * </summary>
         */
        public void Update() {
            CommonUpdate();
        }

#elif MELONLOADER

using MelonLoader;

[assembly: MelonInfo(typeof(InGameTimer.Plugin), "InGameTimer", PluginInfo.PLUGIN_VERSION, "Kaden5480")]
[assembly: MelonGame("TraipseWare", "Peaks of Yore")]

namespace InGameTimer {
    public class Plugin: MelonMod {
        /*
         * <summary>
         * Executes once per frame.
         * </summary>
         */
        public override void OnUpdate() {
            CommonUpdate();
        }

        /*
         * <summary>
         * Executes whenever a scene loads.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
            CommonSceneLoad(buildIndex, sceneName);
        }

#endif
        private static Plugin plugin = null;

        private UI.Info info = null;
        private UI.Timer timer = null;

        public Plugin() {
            plugin = this;
        }

        /**
         * <summary>
         * Common code to run on each scene load.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        private void CommonSceneLoad(int buildIndex, string sceneName) {
            if (timer == null) {
                timer = new UI.Timer();
            }

            if (info == null) {
                info = new UI.Info();
            }

            timer.LoadScene(sceneName);
        }

        /**
         * <summary>
         * Common code to run each frame.
         * </summary>
         */
        private void CommonUpdate() {
            if (Input.GetKeyDown(KeyCode.PageDown)) {
                info.Toggle();
            }

            timer.Update();
        }

        /**
         * <summary>
         * Moves the location of the pocketwatch timer.
         * </summary>
         */
        [HarmonyPatch(typeof(TimeAttack), "Awake")]
        static class PatchMoveTimeAttack {
            static void Prefix(TimeAttack __instance) {
                Vector3 oldPosition = __instance.txtActivatedPoint.position;
                Vector3 newPosition = new Vector3(oldPosition.x, oldPosition.y - 20, oldPosition.z);
                __instance.txtActivatedPoint.position = newPosition;
            }
        }

        /**
         * <summary>
         * Marks a scene as complete when stamping.
         * </summary>
         */
        [HarmonyPatch(typeof(StamperPeakSummit), "StampJournal")]
        static class PatchStampJournal {
            static void Postfix(StamperPeakSummit __instance) {
                string sceneName = SceneManager.GetActiveScene().name;
                Plugin.plugin.timer.CompleteScene(sceneName);
            }
        }
    }
}
