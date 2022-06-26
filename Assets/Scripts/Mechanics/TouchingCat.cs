using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingCat : MonoBehaviour
{
    public Collider2D collider2d;
    public Animator Animator;
    void Start()
    {
        collider2d = GetComponent<Collider2D>();
        Animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Animator.SetBool("isHappy", true);
    }
}
