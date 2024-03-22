using ReadyPlayerMe.Core;
using UnityEngine;

namespace CavrnusReadyPlayerMe
{
    public class ReadyPlayerMeManager : MonoBehaviour
    {
        public string CurrentAvatarUrl = "";
        
        public AvatarObjectLoader ObjectLoader{ get; private set; }

        private void Awake() => ObjectLoader = new AvatarObjectLoader();

        public void Load(string url)
        {
            CurrentAvatarUrl = url;
            ObjectLoader.LoadAvatar(url);
        }
    }
}