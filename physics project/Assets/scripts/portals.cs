using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalManager : MonoBehaviour
{
    public GameObject portalPrefab;
    public float minX, maxX, minY, maxY; 

    void Start()
    {
       
        StartCoroutine(SpawnPortal());
    }

    IEnumerator SpawnPortal()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(Random.Range(5f, 15f));

            
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);

           
            GameObject portal = Instantiate(portalPrefab, randomPosition, Quaternion.identity);

            
            yield return new WaitForSeconds(15f);

            
            Destroy(portal);
        }
    }
}
