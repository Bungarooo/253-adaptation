using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    //20 minutes
    public float currentTime = 1200.0f;

    public GameObject EndCanvas;

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        int RoundedTime = (int)currentTime;
        string timeString;
        if ((RoundedTime % 60) > 9)
            timeString = (RoundedTime / 60).ToString() + ":" + (RoundedTime % 60).ToString();
        else
            timeString = (RoundedTime / 60).ToString() + ":0" + (RoundedTime % 60).ToString();

        GetComponent<TextMeshProUGUI>().text = timeString;

        if (currentTime < 0f)
        {
            EndCanvas.SetActive(true);
            GameObject.Find("Canvas").SetActive(false);
            FindObjectOfType<PlayerController>().TheEnd = true;
            gameObject.SetActive(false);
        }
    }
}
