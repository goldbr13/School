using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Animator anim;
    public bool isAnimationFinished = false;
    private Vector3 translation = new Vector3(0, 0, 5);

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("idle", false);
        Invoke("NotWalking", 24);
    }

    void Walking()
    {
        // Set the flag to allow movement to proceed
        isAnimationFinished = true;
    }

    void NotWalking(){
        isAnimationFinished = false;
        anim.SetBool("idle", true);
        transform.Rotate(0, 180, 0);
    }

    void Update()
    {
        // Move the object after the animation has finished
        if (isAnimationFinished)
        {
            transform.Translate(translation * Time.deltaTime);
        }
    }
}
