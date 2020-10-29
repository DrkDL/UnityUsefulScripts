using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class example : MonoBehaviour
{
    // Start is called before the first frame update
    int counter = 0;
    public GameObject congrats_image; //initially disabled from the unity editor




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Checkpoint")
        {

            counter += 1;
        }

        if (counter == 15)
        {
            congrats_image.gameObject.SetActive(true);
        }
    }
}