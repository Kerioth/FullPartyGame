using System;
using UnityEngine;

namespace Audio
{
    public class AudioBox : MonoBehaviour
    {
        public AudioSettings settings;
        [Space]
        public Sound[] musics;
        [Space]
        public Sound[] sounds;

        public static AudioBox Instance;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);

            foreach (Sound music in musics)
                AddSouce(music);
            foreach (Sound sound in sounds)
                AddSouce(sound);
        }

        //Adding AudioSource with Sound prefs to AudioSystem
        void AddSouce(Sound s)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            s.source.playOnAwake = false;
            //sources.Add(s.source);
        }

        #region Common

        public static void TurnOff() => AudioListener.pause = true;
        public static void TurnOn() => AudioListener.pause = false;

        public void Play(string name)
        {
            //ManagerLog.Log($"Play sound {name}");
            Sound soundToPlay = FindSound(name);
            if (soundToPlay == null) return;
            Play(soundToPlay);
        }

        public void Play(Sound name)
        {
            if (!name.source)
            {
                AddSouce(name);
            }
            if (name.source.isPlaying && name.fullPlay) return;
            if (name.source.isActiveAndEnabled)
                name.source.Play();
        }

        public void Pause(Sound name)
        {
            if (name.source.isActiveAndEnabled)
                name.source.Pause();
        }

        public void Stop(string name)
        {
            Sound soundToStop = FindSound(name);
            if (soundToStop == null) return;
            soundToStop.source.Stop();
        }
        #endregion

        #region Music

        //Turn on/off music
        public void MusicSwitch(bool isPlay)
        {
            settings.ToggleMusic(isPlay);

            foreach (Sound music in musics)
            {
                if (isPlay) Play(music);
                else Pause(music);
            }
        }

        public void MusicMute(bool isMute)
        {
            foreach (Sound music in musics)
            {
                music.source.mute = isMute;
            }
        }

        //Change volume of Music
        public void MusicVolume(float newVolume)
        {
            settings.ChangeMusicVolume(newVolume);

            foreach (Sound music in musics)
            {
                music.source.volume = newVolume;
            }
        }

        #endregion

        #region Sounds

        //Turn on/off sounds
        public void SoundSwitch(bool isPlay)
        {
            settings.ToggleSound(isPlay);

            foreach (Sound sound in sounds)
            {
                if (isPlay) sound.source.enabled = true;
                else sound.source.enabled = false;
            }
        }

        public void SoundsStopAll()
        {
            foreach (Sound sound in sounds)
            {
                if (sound.unstop) continue;

                Stop(sound.name);
            }
        }

        //Change volume of Music
        public void SoundVolume(float newVolume)
        {
            settings.ChangeSoundVolume(newVolume);

            foreach (Sound sound in sounds)
            {
                sound.source.volume = newVolume;
            }
        }
        #endregion

        public AudioSource GetSource(string name)
        {
            Sound sound = FindSound(name);
            return sound.source;
        }

        Sound FindSound(string name)
        {
            Sound lookingSound = Array.Find(musics, sound => sound.name == name);

            if(lookingSound == null)
                lookingSound = Array.Find(sounds, sound => sound.name == name);

            return lookingSound;
        }

    }

}

