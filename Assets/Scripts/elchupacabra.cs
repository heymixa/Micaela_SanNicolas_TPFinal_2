using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elchupacabra : MonoBehaviour
{
    private Animator anim;
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 200.0f;
    public float range = 10f;
    public Camera fpsCam;
    public AudioClip clip_hit;
    public AudioSource _audSource;
    public Jumping saltar;

    public bool estoyAtacando;
    public SphereCollider fistBoxCol;

    // Start is called before the first frame update
    void Start()
    {
        DesactivarCollFist();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {   
        if (!estoyAtacando)
        {
            CheckMovement();
            CheckRotation();

        }
        
    }

    // Update is called once per frame
    void Update()
    {

        DondeEstanLosZombies();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("caminando", true);
        }
        else
        {
            anim.SetBool("caminando", false);
        }

        if (Input.GetKeyDown(KeyCode.E) && !estoyAtacando && saltar.puedoSaltar)
        {
            anim.SetTrigger("golpeo");
            estoyAtacando = true;
        }
    }

    void DondeEstanLosZombies()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            if (hit.transform.tag == "enemigo")
            {
                //Debug.Log("Has visto un Zombie");
                //PonerPlaySonido(clip_hit);

            }
        }
    }
    void CheckMovement()
    {
        var xMove = transform.right * (Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove = transform.forward * (Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
    }
    void CheckRotation()
    {
        var rotation = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }
    void PonerPlaySonido(AudioClip clip)
    {
        _audSource.clip = clip;
        _audSource.Play();
    }

    public void noGolpeo()
    {
        estoyAtacando = false;
    }

    public void DesactivarCollFist()
    {
        fistBoxCol.enabled= false;
    }

    public void ActivarCollFist()
    {
        fistBoxCol.enabled= true;

    }
}
