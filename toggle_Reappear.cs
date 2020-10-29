using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_Reappear : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject model;

    private bool pressed = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            pressed=!pressed;
            model.gameObject.SetActive(pressed);
        }
        
    }


}
