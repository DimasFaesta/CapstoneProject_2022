using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public string nameScene;

    public void Change(string nameScene){
        SceneManager.LoadScene(nameScene);
    }
}
