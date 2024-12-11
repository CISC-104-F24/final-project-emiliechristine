using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript2 : MonoBehaviour
{    
    public void ResetGame()
    {
        Debug.Log("Doggos!");    
        SceneManager.LoadScene(2);
    }
}

