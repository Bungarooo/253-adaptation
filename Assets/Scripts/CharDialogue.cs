using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharDialogue : MonoBehaviour
{
    [TextArea(1, 4)]
    public string CharTitle;
    [TextArea(5, 20)]
    public string OutwardAppearance;
    [TextArea(5, 20)]
    public string InsideInfo;
    [TextArea(5, 20)]
    public string Thinking;

    [HideInInspector] public GameObject c;

    public void SetTexts()
    {
        c = GameObject.Find("Canvas");
        c.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = CharTitle;
        c.transform.GetChild(0).GetChild(0).GetChild(4).GetChild(0).GetComponent<TextMeshProUGUI>().text = OutwardAppearance;
        c.transform.GetChild(0).GetChild(0).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().text = InsideInfo;
        c.transform.GetChild(0).GetChild(0).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = Thinking;

    }
}
