using UnityEngine;

public class Jumping : MonoBehaviour
{
    private Animator anim;
    Rigidbody rb;
    public float jumpHeight = 10;
    public bool grounded;
    public int maxJumpCount = 2;
    public int jumpsRemaining = 0;
    public bool puedoSaltar;

   

    void Start()
    {
        puedoSaltar = false;
        rb = gameObject.GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puedoSaltar) 
        {
            if ((Input.GetKeyDown(KeyCode.Space)) && (jumpsRemaining > 0))
            {
                anim.SetBool("salte", true);
                rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                jumpsRemaining -= 1;
            }

            anim.SetBool("tocarSuelo", true);
        }
        else
        {
            Caigo();
        }
      
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = true;
            jumpsRemaining = maxJumpCount;
        }
    }
    public void OnCollisionExit(Collision collision) 
    {
        if(collision.gameObject.tag == "Floor")
        grounded = false;
    }

    public void Caigo()
    {
        anim.SetBool("tocarSuelo", false);
        anim.SetBool("salte", false);
    }
}
