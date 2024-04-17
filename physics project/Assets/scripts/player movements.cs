using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovements : MonoBehaviour
{
    [SerializeField]
    private bool isdragging = false;
    private Vector3 offset;
    public float forceAdd = 10f;
    private Rigidbody2D pugRb;

    [SerializeField]    
    private float minX = -5f;
    [SerializeField]
    private float maxX = 5f;

    [SerializeField]
    private float minY = -5f;
    [SerializeField]
    private float maxY = 5f;

    private void Start()
    {
        pugRb = GameObject.FindGameObjectWithTag("Pug").GetComponent<Rigidbody2D>();
    }
    
    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        offset = gameObject.transform.position - GetMouseWorldPosition();
        isdragging = true;    
    }


    // Update is called once
    // per frame
    void OnMouseDrag()
    {
        if (isdragging)
        {
            Vector3 targetPosition = GetMouseWorldPosition() + offset;

            targetPosition.x =Mathf.Clamp(targetPosition.x, minX, maxX); 
            targetPosition.y = Mathf.Clamp(targetPosition.y, minY, maxY);

            transform.position = targetPosition;

        }
        
    }
   
    
    private void OnMouseUp()
    {
        isdragging = false;
    }
    
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0f;
        return mousePosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pug") )
        {
            Vector2 Pugvelocity = pugRb.velocity;
            Vector2 force = Pugvelocity * forceAdd ;

            pugRb.AddForce(force, ForceMode2D.Impulse);


        }
    }
}
