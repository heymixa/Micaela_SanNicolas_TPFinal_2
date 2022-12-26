using UnityEngine;

public class PJ1 : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 1f;
    public float range = 100f;
    public Camera fpsCam;
    public AudioClip clip_hit;
    public AudioSource _audSource; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckRotation();
        DondeEstanLosZombies();
    }
    void DondeEstanLosZombies()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
           //Debug.Log(hit.transform.name);
            if(hit.transform.tag == "enemigo")
            {
                Debug.Log("Has visto un Zombie");
                PonerPlaySonido(clip_hit);

            }
        }
    }
    void CheckMovement()
    {
        var xMove = transform.right * (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove = transform.forward * (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }
    void PonerPlaySonido(AudioClip clip)
    {
        _audSource.clip = clip;
        _audSource.Play();
    }

}
