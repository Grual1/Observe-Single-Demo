using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int coins = 0;

    public Button AddBtn;
    public Button ReduceBtn;
    public TextMeshProUGUI  textNum;

    private void Start()
    {
        AddBtn.onClick.AddListener(() =>
        {
            coins++;
            Subject.Instance.UpdateCoins(coins); // 触发事件通知
        });

        ReduceBtn.onClick.AddListener(() =>
        {
            coins--;
            Subject.Instance.UpdateCoins(coins); // 触发事件通知
        });
    }

    private void OnEnable()
    {
        ObserverCenter.Instance.CoinsUpdatedEvent.AddListener(NumCoinsUpdated);
    }

    private void OnDisable()
    {
        ObserverCenter.Instance.CoinsUpdatedEvent.RemoveListener(NumCoinsUpdated);
    }

    private void NumCoinsUpdated(int coins)
    {
        textNum.text = coins.ToString();
    }
}