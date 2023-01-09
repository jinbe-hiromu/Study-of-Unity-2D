using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private GameObject _director;
    private float _aliveTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        if(_aliveTime >= 0)
        {
            _aliveTime -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Coin")
        {
            var addScore = other.gameObject.GetComponent<CoinController>().GetScore();
            _director.GetComponent<GameDirector>().AddScore(addScore);
            Destroy(other.gameObject);
        }
    }

    public void Shoot(Vector3 vec)
    {
        GetComponent<Rigidbody>().AddForce(vec);
    }
}
