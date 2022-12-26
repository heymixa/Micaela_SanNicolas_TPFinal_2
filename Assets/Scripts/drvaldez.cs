using UnityEngine;
using UnityEngine.SceneManagement;

public class drvaldez : MonoBehaviour
{
    public Transform posJugador;
    public float hp;
    public float dmgGolpe;
    public Animator anim;
    public saludBoss salute;
    public AudioSource punch;
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;
    public GameObject wave4;

    // Start is called before the first frame update
    void Start()
    {
        wave1.SetActive(true);
        wave2.SetActive(false);
        wave3.SetActive(false);
        wave4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPl();
    }
    public virtual void LookAtPl()
    {
        Quaternion lookOnLook = Quaternion.LookRotation(posJugador.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fist")
        {
            //if (anim != null)
            //{
            //    anim.Play("dmgRecibido");
            //}
            hp -= dmgGolpe;
            salute.HpBoss -= dmgGolpe;
            punch.Play();
                                  

        }
        if (hp == 4)
        {
            wave2.SetActive(true);
        }

        if(hp == 3)
        {
            wave3.SetActive(true);
        }

        if (hp == 2)
        {
            wave4.SetActive(true);
        }

        if (hp == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(4);

        }
    }
}
