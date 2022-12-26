using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class saludBoss : MonoBehaviour
{
    public float HpBoss = 5;
    public float maxHpBoss = 5;
    public Image saluteBoss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actulizarHp(); 
    }

    //void recibirDmg(float dmg)
    //{
    //    HpBoss -= dmg;
    //}

    void actulizarHp()
    {
        saluteBoss.fillAmount = HpBoss / maxHpBoss;
    }
}
