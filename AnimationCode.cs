using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCode : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anime;
    void Start()
    {
        anime = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //state 1 is running
        if (Input.GetKeyDown(KeyCode.W)){
            anime.SetInteger("state",1);
        }
        //state 0 is idle
        else if (Input.GetKeyUp(KeyCode.W)){
          
            anime.SetInteger("state",0);
        
        }
        
    }
}
