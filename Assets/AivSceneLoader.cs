using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AivSceneLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


        SceneManager.LoadScene("Foo", LoadSceneMode.Additive);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
