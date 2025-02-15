using UnityEngine;

namespace Audio
{
    [System.Serializable]
    public class Sound
    {
        public string name;

        public AudioClip clip;

        [Range(0f, 2f)]
        //[HideInInspector]
        public float volume = 1f;
        [Range(0.1f, 3f)]
        //[HideInInspector]
        public float pitch = 1f;
        public bool loop;
        public bool fullPlay;
        public bool unstop;

        [HideInInspector]
        public AudioSource source;
    }
}
