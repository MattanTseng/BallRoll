using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //public string NewScene;
        
   public void SwitchScene(string NewScene)
    {
        SceneManager.LoadScene(NewScene);
    }
}
