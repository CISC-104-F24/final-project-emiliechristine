using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript3 : MonoBehaviour
{    
    public void ResetGame()
    {
        Debug.Log("Back to title!");    
        SceneManager.LoadScene(0);
    }
}