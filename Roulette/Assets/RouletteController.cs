using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float _rotationSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _rotationSpeed = 100;
        }

        transform.Rotate(0, 0, _rotationSpeed);

        _rotationSpeed *= 0.96f;
    }
}
