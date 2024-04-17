using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamerestsrt : MonoBehaviour
{
   
    public void Gamerestart()
    {
        
        
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentSceneIndex);
          
        
    }

    
}
