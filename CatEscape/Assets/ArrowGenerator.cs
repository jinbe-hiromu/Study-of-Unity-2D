using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    float _span = 1.0f;
    float _delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _delta += Time.deltaTime;
        if(_delta > _span)
        {
            _delta = 0;
            var copyObject = Instantiate(ArrowPrefab);
            var initXPosition = Random.Range(-6,7);

            copyObject.transform.position = new Vector3(initXPosition, 7, 0);
        }
    }
}
