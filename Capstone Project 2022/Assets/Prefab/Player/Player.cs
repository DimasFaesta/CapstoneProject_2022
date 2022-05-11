using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    CharacterController player;
    Vector3 arah;

    float gravitasi;
    bool lompat;

    public bool napak;
    public float Kecepatan;
    public float KekuatanLoncat;

    void Awake()
    {
        player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        napak = Physics.CheckSphere(transform.position - new Vector3(0, 1f, 0), .1f);

        Gravitasi();
        if (lompat==true)
        {
            gravitasi = KekuatanLoncat;
            player.Move(new Vector3(0, gravitasi * Time.deltaTime, 0));
            lompat = false;
        }
        arah.y = gravitasi;
        player.Move(arah*Time.deltaTime);
    }

    public void Jalan(float ArahX,float ArahZ)
    {
        player.Move(transform.forward *ArahZ *Kecepatan);
        player.Move(transform.right * ArahX * Kecepatan);
    }

    public void Gravitasi()
    {
        if (napak == true)
        {
            gravitasi = -2;
        }
        else
        {
            gravitasi += -9 * Time.deltaTime;
        }
    }

    public void Lompat()
    {
        if (napak == true)
        {
            lompat = true;
        }
    }



}
