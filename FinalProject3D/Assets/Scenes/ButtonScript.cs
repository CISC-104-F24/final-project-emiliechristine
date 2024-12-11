using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{    
    public void ResetGame()
    {
        Debug.Log("Entered Game!");    
        SceneManager.LoadScene(1);
    }
}
