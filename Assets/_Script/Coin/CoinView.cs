using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinView : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] Vector3 minCoinSpawnPoint;
    [SerializeField] Vector3 maxCoinSpawnPoint;

    bool isCoinSpawned = false;
    private GameObject coins;
    // Update is called once per frame
    void Update()
    {
        if(isCoinSpawned == false)
        {
            Vector3 randomPos = new Vector3(Random.Range(minCoinSpawnPoint.x, maxCoinSpawnPoint.x), Random.Range(minCoinSpawnPoint.y, maxCoinSpawnPoint.y), Random.Range(minCoinSpawnPoint.z, maxCoinSpawnPoint.z));
            coins = Instantiate(coinPrefab, randomPos, coinPrefab.transform.rotation);
            isCoinSpawned = true;
            Invoke("DestroyCoin", 7f);
        }
       
    }

    public void DestroyCoin()
    {
        Destroy(coins);
        isCoinSpawned = false;
    }

    public GameObject Coin
    {
        get => coins;
        set => coins = value;
    }
}
