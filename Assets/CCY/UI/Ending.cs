using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Title");

    }

    public void GoToFirst()
    {
        SceneManager.LoadScene("Stage1");
    }
}
