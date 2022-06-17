using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jebakan : MonoBehaviour
{
    Rigidbody rig;
    AudioSource detakjantug;

    float durasi = 1.5f;
    bool dorong;
    bool masuk;
    bool sekali;

    public float kekuatan;

    public Transform target;
    public Transform doroongan;


    void Start()
    {
        target = GameObject.FindWithTag("FisikPlayer").transform;
        rig = GetComponent<Rigidbody>();
        detakjantug = GameObject.Find("Detak jantung sfx").GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        doroongan.LookAt(target.position);
        if (dorong == true)
        {
            rig.AddForceAtPosition(doroongan.forward*kekuatan, doroongan.position);
            dorong = false;
        }

        if (masuk && GameManager.nilaigempa > 0)
        {
            durasi -= Time.deltaTime;

            if (durasi <= 0 && sekali == false)
            {
                dorong = true;
                masuk = false;
                sekali = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FisikPlayer"))
        {
            masuk = true;

            if(GameManager.nilaigempa > 0)
            {
                detakjantug.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FisikPlayer") && GameManager.nilaigempa == 0)
        {
            masuk = false;
        }
    }


}
