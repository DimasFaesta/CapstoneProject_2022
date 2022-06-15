using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jebakan : MonoBehaviour
{
    Rigidbody rig;

    float durasi = 1;
    bool dorong;
    bool masuk;

    public float kekuatan;

    public Transform target;
    public Transform doroongan;


    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        doroongan.LookAt(target.position);
        if (dorong == true)
        {
            rig.AddForceAtPosition(doroongan.forward*kekuatan, doroongan.position);
            dorong = false;
        }

        if (masuk)
        {
            durasi -= Time.deltaTime;

            if (durasi <= 0)
            {
                dorong = true;
                masuk = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FisikPlayer"))
        {
            masuk = true;
            Debug.Log(other.gameObject.name);
        }
    }


}
