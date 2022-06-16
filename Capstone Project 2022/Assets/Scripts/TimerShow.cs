using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerShow : MonoBehaviour
{
    public ScriptableValue scr;

    public float timer;
    public Text timerText;
    public Animator transitionFade;

    private void Start() {
        scr.value = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        float minutes = Mathf.FloorToInt((timer / 60));
        float seconds = timer % 60;

        string secodsString = seconds.ToString("F2");

        // timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = minutes + ":" + secodsString;

        if (timer <= 0)
        {
            timer = 0;
            timerText.text = "00:00";
            StartCoroutine(FadeScene());
        }
    }

    IEnumerator FadeScene(){
        transitionFade.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
