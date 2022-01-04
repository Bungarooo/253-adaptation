using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(1);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject.Find("Canvas").transform.GetChild(0).GetChild(5).gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
