using UnityEngine;

public class Observer : MonoBehaviour
{
    public void HandleEvent(int coins)
    {
        Debug.Log("Observer: Coins updated - " + coins);
        // 在这里执行观察者的操作，比如更新UI等
    }
}