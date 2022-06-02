using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;
public class GameManager : MonoBehaviour
{
    public Slider slide;
    public static float nilaigempa;
    CameraShakeInstance preset;

    private void Start()
    {
        preset = CameraShaker.Instance.StartShake(slide.value / 2, 1, .5f);
        preset.DeleteOnInactive = false;
    }
    private void Update()
    {
        nilaigempa = slide.value;
        preset.ScaleMagnitude = slide.value/1.5f;
    }
}
