using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{

    private const string VolumeKey = "Volume";
    public const float DefaultVolumeValue = 0.5f;
    private const float MinimumVolumeValue = 0f;
    private const float MaximumVolumeValue = 1f;

    private const string DifficultyKey = "Difficulty";
    public const float DefaultDifficultyValue = 2;
    private const float MinimumDifficultyValue = 1f;
    private const float MaximumDifficultyValue = 3f;

    public static float Volume
    {
        get => PlayerPrefs.GetFloat(VolumeKey, DefaultVolumeValue);
        set => PlayerPrefs.SetFloat(VolumeKey, Mathf.Clamp(value, MinimumVolumeValue, MaximumVolumeValue));
    }
    public static float Difficulty
    {
        get => PlayerPrefs.GetFloat(DifficultyKey, DefaultDifficultyValue);
        set => PlayerPrefs.SetFloat(DifficultyKey, Mathf.Clamp(value, MinimumDifficultyValue, MaximumDifficultyValue));
    }

    public static float GetVolume()
    {
        return PlayerPrefs.GetFloat(VolumeKey);
    }
    public static void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat(VolumeKey, volume);
    }
}
