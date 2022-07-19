using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreDisplaer : MonoBehaviour
{
    [SerializeField] TMP_Text _score;
    [SerializeField] private PlayerBag _playerBag;

    private void OnEnable()
    {
        _playerBag.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _playerBag.CoinCollected -= OnCoinCollected;
    }

    private void OnCoinCollected(int coinCount)
    {
        _score.text = coinCount.ToString();
    }
}
