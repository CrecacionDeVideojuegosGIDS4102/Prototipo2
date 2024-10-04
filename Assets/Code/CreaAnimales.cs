using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaAnimales : MonoBehaviour
{
    public GameObject[] animales;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    void SpawnAnimal() {
        int ind = Random.Range(0, animales.Length);

        int z = Random.Range(-20, 20);
        Vector3 posz = new Vector3(animales[ind].transform.position.x, 
        animales[ind].transform.position.y, z);

        Instantiate(animales[ind], posz, animales[ind].transform.rotation);
    }
}
