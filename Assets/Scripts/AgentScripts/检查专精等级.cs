using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class 检查专精等级 : MonoBehaviour
{
    public GameObject buttonGroup;
    public Text Ranktext;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void CheckRank()
    {
        Debug.Log("1");

        Debug.Log("Check");
        if (int.Parse(Ranktext.text) >= 7)
        {
            buttonGroup.SetActive(true);
        }
        else
        {
            buttonGroup.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Ranktext.text == null)
        {
            Ranktext.text = "0";
        }
    }
}