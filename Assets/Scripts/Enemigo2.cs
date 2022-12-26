using UnityEngine;

public class Enemigo2 : Enemigo1
{
    public float maxDist = 2f;
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
        Debug.Log("Recibes " +dmgGhoul+ " de daño ghoul");
    }
}
