using System.Collections.Generic;
using UnityEngine;

namespace AdofaiUtils2.Core.Settings
{
    public static class SettingsManager
    {
        public static readonly Dictionary<string, SettingsBase> SettingsMap = new Dictionary<string, SettingsBase>();
        
        public static void Register(SettingsBase settings)
        {
            SettingsBase s;
            if (!SettingsMap.TryGetValue(settings.Id, out s))
            {
                SettingsMap[settings.Id] = settings;
                Debug.Log($"Registered setting with id {settings.Id}");
            }
            else
            {
                Debug.Log($"Settings with id {s.Id} is already registered");
            }
        }

        public static void Unregister(SettingsBase settings)
        {
            if (SettingsMap[settings.Id] == null)
            {
                Debug.Log($"Settings with id {settings.Id} is already registered");
            }
            else
            {
                SettingsMap.Remove(settings.Id);
                Debug.Log($"UnRegistered setting with id {settings.Id}");
            }
        }
    }
}