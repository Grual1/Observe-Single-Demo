using UnityEngine;

public class Subject : Singleton<Subject>
{
    /// <summary>
    /// 更新Coin事件
    /// </summary>
    /// <param name="coins"></param>
    public void UpdateCoins(int coins)
    {
        ObserverCenter.Instance.CoinsUpdatedEvent.Invoke(coins);
    }
}