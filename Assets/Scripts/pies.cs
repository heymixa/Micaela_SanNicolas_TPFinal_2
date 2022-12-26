using UnityEngine;

public class pies : MonoBehaviour
{
    public Jumping saltar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        saltar.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        saltar.puedoSaltar = false;
    }
}
