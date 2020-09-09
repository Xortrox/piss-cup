using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public Animator Animator;

    public int TimeHash;
    
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();

        TimeHash = Animator.StringToHash("Time");
    }

    void SetLevel(float level)
    {
        Animator.SetFloat(TimeHash, level);
    }
}
