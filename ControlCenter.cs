using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlCenter : MonoBehaviour
{
    

    public void RestartLevel()
    {
        SceneManager.LoadScene("ShablonAR");
    }
}
