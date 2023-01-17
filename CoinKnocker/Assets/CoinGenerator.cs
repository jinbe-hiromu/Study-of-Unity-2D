using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject Coin50Prefab;
    public GameObject Coin100Prefab;
    public GameObject minusCoin50Prefab;
    public GameObject minusCoin100Prefab;
    private GameObject _gameDirector;
    float _timeSpan = 2.0f;
    float _delta = 0;
    int _100CoinAppearanceRatio = 2;
    int _minus50CoinAppearanceRatio = 2;
    int _minus100CoinAppearanceRatio = 1;


    // Start is called before the first frame update
    void Start()
    {
        _gameDirector = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameDirector.GetComponent<GameDirector>().IsTimeup)
        {
            return;
        }

        _delta += Time.deltaTime;
        if (_delta > _timeSpan)
        {
            _delta = 0;

            GameObject coin;
            var dice = Random.Range(1, 11);
            if (dice <= _100CoinAppearanceRatio)
            {
                coin = Instantiate(Coin100Prefab);
            }
            else if (dice <= _100CoinAppearanceRatio + _minus100CoinAppearanceRatio)
            {
                coin = Instantiate(minusCoin100Prefab);
            }
            else if (dice <= _100CoinAppearanceRatio + _minus100CoinAppearanceRatio + _minus50CoinAppearanceRatio)
            {
                coin = Instantiate(minusCoin50Prefab);
            }
            else
            {
                coin = Instantiate(Coin50Prefab);

            }

            var x = Random.Range(-9.0f, 9.0f);
            coin.transform.position = new Vector3(x, coin.transform.position.y, coin.transform.position.z);
        }
    }
}
