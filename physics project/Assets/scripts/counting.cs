using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public TextMeshPro timer;
    public Transform center;
    public GameObject pug;
    public float speed = 1f;
    private bool spacepressed = false;
   


    public GameObject StartScreen;



    // Start is called before the first frame update
    void Start()
    {
      
       
        
        StartScreen.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !spacepressed) 
        {
            spacepressed = true;
            
            StartScreen.SetActive(false);
           StartCoroutine(Countdown());
        }

        
        
    }

    public IEnumerator Countdown()
    {
            timer.text = "5";
            yield return new WaitForSeconds(1);

            timer.text = "4";
            yield return new WaitForSeconds(1);

            timer.text = "3";
            yield return new WaitForSeconds(1);

            timer.text = "2";
            yield return new WaitForSeconds(1);

            timer.text = "1";
            yield return new WaitForSeconds(1);

            timer.text = "Bully";

            AndStart();

        yield return new WaitForSeconds(3);
        timer.text = "";

        
    }



    // Update is called once per frame
    void AndStart()
    {

        Rigidbody2D rb = pug.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.velocity = Random.insideUnitCircle.normalized * speed;
        }
    }
   
}
