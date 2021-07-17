using HarmonyLib;
using UnityEngine;

namespace AdofaiUtils2.Core.Settings
{
    public class SettingsModule
    {
        public static SettingsModule Instance { get; private set; }

        private GameObject GameObject;

        private CoreSettings _settings;

        public SettingsModule()
        {
            Instance = this;
        }

        public void Init()
        {
            GameObject = new GameObject();
            GameObject.AddComponent<SettingsUI>();
            Object.DontDestroyOnLoad(GameObject);
            _settings = new CoreSettings();
            SettingsManager.Register(_settings);
        }

        public void Destroy()
        {
            Object.Destroy(GameObject);
            GameObject = null;
            SettingsManager.Unregister(_settings);
        }
    }
}