using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerBag : MonoBehaviour
{
    private int _countCoint;
    public event UnityAction<int> CoinCollected;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            _countCoint++;
            CoinCollected?.Invoke(_countCoint);
            Destroy(collision.gameObject);
        }
    }
}
