using TMPro;
using UnityEngine;

public class UIObserver : MonoBehaviour
{
    public TextMeshProUGUI textNum;

    private void Start()
    {
        ObserverCenter.Instance.CoinsUpdatedEvent.AddListener(HandleCoinsUpdated);
    }

    private void HandleCoinsUpdated(int coins)
    {
        Debug.Log("UI Observer: Coins updated - " + coins);
        textNum.text = (coins - 1).ToString();
        // 在这里执行UI更新操作
    }

    private void OnDestroy()
    {
        ObserverCenter.Instance.CoinsUpdatedEvent.RemoveListener(HandleCoinsUpdated);
    }
}