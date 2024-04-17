using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textposis : MonoBehaviour
{
    public Transform center;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = center.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
