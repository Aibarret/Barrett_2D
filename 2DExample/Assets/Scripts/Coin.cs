using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coin;

    public void disable()
    {
        coin.SetActive(false);
    }
}
