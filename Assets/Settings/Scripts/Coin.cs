using UnityEngine;

public class Coin : MonoBehaviour, ICollectible
{
    public void OnCollect()
    {
        Destroy(gameObject);
    }
}