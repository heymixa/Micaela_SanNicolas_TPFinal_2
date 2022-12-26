using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie3 : zombie1
{

    public float dmgYuri;
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
        Debug.Log("Recibes " + dmgYuri + " de daño yuri");
    }
}
