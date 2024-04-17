using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class numberpoints : MonoBehaviour
{
    public TextMeshPro PLayerScoretext;
    public TextMeshPro AIScoretext;

    public int Playerscore;
    public int AIscore;

    private int PLayerTouches;
    private int AITouches;

    public GameObject Winner;
    public GameObject Loser;
    public Transform center;
    public GameObject RestartButton;
    public GameObject Player;
    public GameObject AI;
    public GameObject Puck;
    public GameObject timer;

    public bool AItouched = false;
    public bool Playertouched = false;  

    // Start is called before the first frame update
    void Start()
    {
        
        RestartButton.SetActive(false);
        Winner.SetActive(false);
        Loser.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            Playerscore++;


        }

        if (collision.gameObject.CompareTag("Goal2"))
        {
            AIscore++;


        }
        UpdateScoreText();

        if (collision.gameObject.CompareTag("AI"))
        {
            AItouched = true;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Playertouched = true;
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            PLayerTouches++;
            if (PLayerTouches == 1)
            {
                if (AItouched == true)
                {
                    PLayerTouches = 0;
                    AItouched = false;
                    Debug.Log("count = 0");

                }
            }
            else if (PLayerTouches == 2)
            {
                Playerscore--;
                PLayerTouches = 0;
                AItouched = false;

            }

           


            }


        }

         void UpdateScoreText()
        {
            // Update the text of the TextMeshPro components
            PLayerScoretext.text = "" + Playerscore;
            AIScoretext.text = "" + AIscore;
        }

        // Update is called once per frame
        void Update()
        {
            // Check if the player or AI has won
            if (Playerscore >= 5)
            {
                Instantiate(Winner, center.position, Quaternion.identity);
                RestartButton.SetActive(true);
                Winner.SetActive(true);
                Loser.SetActive(true);
                Player.SetActive(false);
                AI.SetActive(false);
                Puck.SetActive(false);
                timer.SetActive(false);

            }

            if (AIscore >= 5)
            {
                Instantiate(Loser, center.position, Quaternion.identity);
                RestartButton.SetActive(true);
                Winner.SetActive(true);
                Loser.SetActive(true);
                Player.SetActive(false);
                AI.SetActive(false);
                Puck.SetActive(false);
                timer.SetActive(false);
            }


        }




    }

