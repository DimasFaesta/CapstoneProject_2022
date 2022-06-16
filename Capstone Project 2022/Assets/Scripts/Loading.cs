using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    AsyncOperation async;
   public Text text;

    void Start()
    {
        async = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        async.allowSceneActivation = true;
    }

    void Update()
    {
        if (text != null)
        {
            text.text = "Sedang memuat: " + (async.progress * 100) + "%";
        }
    }
}
