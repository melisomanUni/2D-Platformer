using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class OpponentsAnimation : MonoBehaviour
{
    [SerializeField] private Transform _point;

    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Flip(bool isFlipped)
    {
            _spriteRenderer.flipX = isFlipped;
    }
}
