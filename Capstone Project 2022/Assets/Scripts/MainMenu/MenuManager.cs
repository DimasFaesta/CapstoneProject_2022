using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static float VolMusik = .7f;
    public static float VolSfx = 1f;
    public static float SensitifX, SensitifY;

    public AudioSource[] Musik,Sfx;
    public Slider MusikSlid, X, Y, SfxSlide;

    void Start()
    {
        MusikSlid.value = VolMusik;
        SfxSlide.value = VolSfx;
        X.value = SensitifX;
        Y.value = SensitifY;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        VolMusik = MusikSlid.value;
        VolSfx = SfxSlide.value;
        SensitifX = X.value;
        SensitifY = Y.value;

        for (int i = 0; i < Musik.Length; i++)
        {
            Musik[i].volume = VolMusik;
        }

        for (int i = 0; i < Sfx.Length; i++)
        {
            Sfx[i].volume = VolSfx;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

}
