using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMobile : MonoBehaviour
{
    public FloatingJoystick joy;
    public AudioSource kaki;

    bool suara;

    AimMobile aim;
    Player player;

    void Start()
    {
        player = GetComponent<Player>();
        aim = GetComponentInChildren<AimMobile>();
    }


    void FixedUpdate()
    {
        if (joy.Horizontal != 0 || joy.Vertical != 0)
        {
            player.Jalan(joy.Horizontal * Time.deltaTime, joy.Vertical * Time.deltaTime);
            if (suara == false)
            {
                suara = true;
                kaki.Play();
            }
        }
        else
        {
            kaki.Stop();
            suara = false;
        }
    }
}
