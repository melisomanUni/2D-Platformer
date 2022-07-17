using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class PlayerRun : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private GameObject _groundCheckObject;
    [SerializeField] private float _radiusGroundCheck = 1f;
    [SerializeField] LayerMask _groundMask;

    private Rigidbody2D _rigidbody;
    private float _input;
    private bool _isMoving;
    private bool _isGrounded= true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        CheckGround();

        if (Input.GetKeyDown(KeyCode.Space)&& _isGrounded == true)
        {
            Jump();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(_groundCheckObject.transform.position, _radiusGroundCheck);
    }

    private void CheckGround()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheckObject.transform.position, _radiusGroundCheck, _groundMask);
    }

    private void Jump()
    {
        _rigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void Move()
    {
        _input = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(_input * _speed * Time.deltaTime, _rigidbody.velocity.y);
        _isMoving = _input != 0 ? true : false;

        if (_isMoving)
        {
            _playerAnimation.Flip(_input > 0 ? false : true);
        }

        _playerAnimation.IsMoving = _isMoving;
    }
}
