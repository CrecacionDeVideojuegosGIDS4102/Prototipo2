using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject proyectil;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float coordX = Input.GetAxis("Horizontal");

        if(transform.position.z > 34)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y,
            34);   
        }
        if(transform.position.z < -14)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y,
            -14);   
        }

        transform.Translate(Vector3.right * Time.deltaTime * 30 * coordX);

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(proyectil, gameObject.transform.position, transform.rotation);
        }
    }
}
