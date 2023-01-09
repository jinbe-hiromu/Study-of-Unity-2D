using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    private float _initPositionZ;

    public int GetScore()
    {
        return 50;
    }

    // Start is called before the first frame update
    void Start()
    {
        _initPositionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > _initPositionZ + 30)
        {
            Destroy(gameObject);
        }
    }

    // •¨‘Ì‚Ì’†S‚ªÚG‚µ‚½‚Æ‚«
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("HITTED!!!");
    //}
}
