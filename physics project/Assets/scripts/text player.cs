using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textplayer : MonoBehaviour
{
    public Transform playertext;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playertext.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
