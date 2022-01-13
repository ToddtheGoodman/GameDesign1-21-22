using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public string nextScene;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        Debug.Log("scene load");
        SceneManager.LoadScene(nextScene);
    }


}
