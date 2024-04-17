using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textAi : MonoBehaviour
{
    public Transform AIposition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = AIposition.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
