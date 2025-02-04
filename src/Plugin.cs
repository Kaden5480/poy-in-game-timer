using System;

using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
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

            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;

            CommonAwake();
        }

        /**
         * <summary>
         * Executes when the plugin object is destroyed.
         * </summary>
         */
        public void OnDestroy() {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.sceneUnloaded -= OnSceneUnloaded;
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

        /**
         * <summary>
         * Executes whenever a scene unloads.
         * </summary>
         * <param name="scene">The scene which unloaded</param>
         */
        public void OnSceneUnloaded(Scene scene) {
            CommonSceneUnload(scene.buildIndex, scene.name);
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
        public override void OnInitializeMelon() {
            CommonAwake();
        }

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

        /**
         * <summary>
         * Executes whenever a scene unloads.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) {
            CommonSceneUnload(buildIndex, sceneName);
        }

#endif
        private GameObject gui = null;
        private GameObject timerObj = null;
        private Text timerText = null;

        private TimerLogic logic = new TimerLogic();

        /**
         * <summary>
         * Common code to execute on awake.
         * </summary>
         */
        private void CommonAwake() {
            MakeGUI();
        }

        /**
         * <summary>
         * Creates the timer UI.
         * </summary>
         */
        private void MakeGUI() {
            gui = new GameObject("IGT UI");
            gui.layer = LayerMask.NameToLayer("UI");
            GameObject.DontDestroyOnLoad(gui);

            // Add canvas
            Canvas canvas = gui.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 100;

            gui.AddComponent<CanvasScaler>();
            gui.AddComponent<GraphicRaycaster>();

            timerObj = new GameObject("IGT Timer");
            timerObj.transform.SetParent(gui.transform);

            timerText = timerObj.AddComponent<Text>();

            GameObject textObj = GameObject.Find("Text");
            Text text = textObj.GetComponent<Text>();

            timerText.font = text.font;
            timerText.fontSize = 54;
            logic.Reset();

            timerText.rectTransform.anchorMin = new Vector2(0.053f, 0.945f);
            timerText.rectTransform.anchorMax = new Vector2(1, 0.945f);
            timerText.rectTransform.anchoredPosition = new Vector2(0, 0);

            // Add outline
            Outline outline = timerObj.AddComponent<Outline>();
            outline.effectColor = new Color(0, 0, 0, 0.5f);
            outline.effectDistance = new Vector2(2f, -2f);
        }

        /**
         * <summary>
         * Common code to run on each scene load.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        private void CommonSceneLoad(int buildIndex, string sceneName) {
            if (Progression.Peaks.CompletedAllBaseGame() == true) {
                Console.WriteLine("All peaks done");
            }
            else {
                Console.WriteLine("Not all peaks done");
            }

            logic.LoadScene(sceneName);
        }

        /**
         * <summary>
         * Common code to run on each scene unload.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        private void CommonSceneUnload(int buildIndex, string sceneName) {
            logic.UnloadScene(sceneName);
        }

        /**
         * <summary>
         * Common code to run each frame.
         * </summary>
         */
        private void CommonUpdate() {
            gui.SetActive(true);

            logic.Update();

            string categoryName = "N/A";

            if (logic.category != null) {
                categoryName = logic.category.name;
            }

            TimeSpan span = TimeSpan.FromSeconds(logic.GetTimer());
            timerText.text = $"IGT ({categoryName}): {span.Hours:00}:{span.Minutes:00}:{span.Seconds:00}:{span.Milliseconds:00}";
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
    }
}
