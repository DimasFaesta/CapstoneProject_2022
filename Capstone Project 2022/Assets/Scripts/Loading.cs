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
        async = SceneManager.LoadSceneAsync(1);
        async.allowSceneActivation = true;
    }

    // Update is called once per frame
    void Update()
    {
        text.text= "Sedang memuat: " + (async.progress * 100) + "%";
    }
}
