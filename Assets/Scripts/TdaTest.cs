using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TdaTest : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] puntoSpawn;

    public List<string> zombies = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        zombies.Add("Zombie1");
        zombies.Add("Zombie2");
        zombies.Add("Zombie3");

        for (int i = 0; i < puntoSpawn.Length; i++)
        {
            Instantiate(prefab, puntoSpawn[Random.Range(0, puntoSpawn.Length)].position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            zombies.Add("Ghoul1");
            for (int i = 0; i < zombies.Count; i++)
            {
                Debug.Log(zombies[i] + " fue agregado en la posición " + i);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            zombies.Insert(0, "Demon1");
            foreach (string zombie in zombies)
            {
                Debug.Log("El " + zombie + " está en la colección");
            }
        }

        for (int i = 0; i < zombies.Count; i++)
        {
            if (zombies[i].Length >= 6)
            {
                Debug.Log("El " + zombies[i] + " contiene 6 letras o más");
            }
        }
    }
}
