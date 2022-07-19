using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class OpponentsAnimation : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private bool _isForward;
    [SerializeField] private Transform _point;

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
