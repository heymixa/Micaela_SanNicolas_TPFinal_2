using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie2 : zombie1
{
    public float dmgGhoul;
    // Start is called before the first frame update
    void Start()
    {
        posJugador = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowP1();
        LookAtPl();
        checkDist();
        DondeEsta();
    }

    public override void BasicAttack()
    {
        Debug.Log("Recibes " + dmgGhoul + " de daño ghoul");
    }
}
