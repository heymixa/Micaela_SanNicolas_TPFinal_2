using UnityEngine;

public class Enemigo3 : Enemigo1
{
   
    public float dmgYuri;

    void Start()
    {
        posJugador = GameObject.FindWithTag("Player").transform;
    }
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
