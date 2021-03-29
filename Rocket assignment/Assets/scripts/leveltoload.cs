using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltoload : MonoBehaviour
{
    public string mleveltoload;
    // Start is called before the first frame update
   public void LoadLevel()
    {
        SceneManager.LoadScene(mleveltoload);
    }
}
