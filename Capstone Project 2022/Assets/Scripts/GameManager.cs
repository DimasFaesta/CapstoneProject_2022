using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;
public class GameManager : MonoBehaviour
{
    public static float nilaigempa;
    public float IntensitasGempa;
    CameraShakeInstance preset;

    private void Start()
    {
        preset = CameraShaker.Instance.StartShake(.5f, 1, .5f);
        preset.DeleteOnInactive = false;
    }
    private void Update()
    {
        nilaigempa = IntensitasGempa;
        preset.ScaleMagnitude = nilaigempa * 1.5f;
    }
}
