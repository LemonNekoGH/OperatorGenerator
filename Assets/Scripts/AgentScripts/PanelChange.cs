using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelChange : MonoBehaviour
{
    public Toggle PanelTog1;
    public Toggle PanelTog2;
    public Toggle PanelTog3;

    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    

    // Start is called before the first frame update
    void Start()
    {
        PanelTog1.onValueChanged.AddListener((bool actived)=> 
        {
            if (actived == true)
            {
                Panel1.GetComponent<CanvasGroup>().alpha = 1;
                Panel1.GetComponent<CanvasGroup>().blocksRaycasts = true;

            }
            else
            {
                Panel1.GetComponent<CanvasGroup>().alpha = 0;
                Panel1.GetComponent<CanvasGroup>().blocksRaycasts = false;

            }
        });
        PanelTog2.onValueChanged.AddListener((bool actived) => {
            if (actived == true)
            {
                Panel2.GetComponent<CanvasGroup>().alpha = 1;
                Panel2.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            else
            {
                Panel2.GetComponent<CanvasGroup>().alpha = 0;
                Panel2.GetComponent<CanvasGroup>().blocksRaycasts = false;

            }
        });
        PanelTog3.onValueChanged.AddListener((bool actived) => {
            if (actived == true) 
            {
                Panel3.GetComponent<CanvasGroup>().alpha = 1; 
                Panel3.GetComponent<CanvasGroup>().blocksRaycasts = true;
            } else
            {
                Panel3.GetComponent<CanvasGroup>().alpha = 0;
                Panel3.GetComponent<CanvasGroup>().blocksRaycasts = false; } });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
