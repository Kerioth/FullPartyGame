using UnityEngine;

namespace Audio
{
    [System.Serializable]
    public class AudioSettings
    {
        public bool isSound = true;
        public bool isMusic = true;

        [Range(0, 1f)]
        public float MusicVolume;
        [Range(0, 1f)]
        public float SoundVolume;

        public AudioSettings(bool sound, bool music, float musicVolume = 1f, float soundVolume = 1f)
        {
            isSound = sound;
            isMusic = music;
            MusicVolume = musicVolume;
            SoundVolume = soundVolume;
        }

        public void ChangeMusicVolume(float value) => MusicVolume = value;
        public void ChangeSoundVolume(float value) => SoundVolume = value;

        public void ToggleSound(bool isOn)
        {
            isSound = isOn;
            Debug.Log($"Sound {isOn}");
        }

        public void ToggleMusic(bool isOn)
        {
            isMusic = isOn;
            Debug.Log($"Music {isOn}");
        }
    }
}
