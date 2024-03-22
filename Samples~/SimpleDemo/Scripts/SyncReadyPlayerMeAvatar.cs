using CavrnusSdk.PropertySynchronizers;
using UnityEngine;

namespace CavrnusReadyPlayerMe
{
    [RequireComponent(typeof(ReadyPlayerMeManager))]
    public class SyncReadyPlayerMeAvatar : CavrnusStringPropertySynchronizer
    {
        public override string GetValue()
        {
            return GetComponent<ReadyPlayerMeManager>().CurrentAvatarUrl;
        }

        public override void SetValue(string value)
        {
            GetComponent<ReadyPlayerMeManager>().Load(value);
        }
    }
}