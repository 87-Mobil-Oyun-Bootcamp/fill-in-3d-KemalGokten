using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilledCubes : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Color RColor;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColorCubes"))
        {
            Debug.Log("Selam");
            this.GetComponent<Renderer>().material.color = RColor;
            this.GetComponent<Collider>().enabled = false;
            Destroy(other.gameObject);

        }
    }
}
