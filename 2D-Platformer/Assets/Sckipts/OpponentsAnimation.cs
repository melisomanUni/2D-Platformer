using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentsAnimation : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private bool _isForward;
    //[SerializeField] private Transform _point1;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

    //private void Update()
    //{
    //        Flip();
    //}

    //private void Flip()
    //{
    //    var dir = transform.position - _point1.position;

    //    if (dir.x < 0.0f)
    //    {
    //        _spriteRenderer.flipX = true;
    //        _isForward = true;
    //    }
    //    else
    //    {
    //        _spriteRenderer.flipX = false;
    //        _isForward = false;
    //    }
    //}

}
