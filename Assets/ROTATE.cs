using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.down,Vector3.right,40*Time.deltaTime);
    }
}
