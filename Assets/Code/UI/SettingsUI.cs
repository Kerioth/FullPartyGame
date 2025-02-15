using Audio;
using UnityEngine;

public class SettingsUI : MonoBehaviour
{
    public void toggleSound(bool on)
    {
        AudioBox.Instance.SoundSwitch(on);
    }

    public void toggleMusic(bool on) {
        AudioBox.Instance.MusicSwitch(on);
    }
}
