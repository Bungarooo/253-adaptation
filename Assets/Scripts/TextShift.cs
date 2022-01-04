using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<RectTransform>().localPosition = new Vector3(GetComponent<RectTransform>().localPosition.x, GetComponent<RectTransform>().localPosition.y - (200 * Time.deltaTime), GetComponent<RectTransform>().localPosition.z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<RectTransform>().localPosition = new Vector3(GetComponent<RectTransform>().localPosition.x, GetComponent<RectTransform>().localPosition.y + (200 * Time.deltaTime), GetComponent<RectTransform>().localPosition.z);

        }
    }

    Vector3 InitialPos;

    void OnEnable()
    {
        InitialPos = GetComponent<RectTransform>().localPosition;
    }
    void OnDisable()
    {
        GetComponent<RectTransform>().localPosition = InitialPos;
    }
}
