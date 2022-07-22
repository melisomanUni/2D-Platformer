using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private const string isMoving = "isMoving";
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    public bool IsMoving { private get; set; }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        _animator.SetBool(isMoving, IsMoving);
    }

    public void Flip(bool flip)
    {
        _spriteRenderer.flipX = flip;
    }
}
