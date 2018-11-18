using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTrump : MonoBehaviour {

    private Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    void Update()
    {
        if (!anim.IsPlaying("walk"))
            anim.Play("walk");
    }
}
