using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getOptions : MonoBehaviour
{

    public void GetOptions()
    {
        SceneManager.LoadScene("Options");
    }
}