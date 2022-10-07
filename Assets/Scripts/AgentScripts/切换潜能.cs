using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 切换潜能 : MonoBehaviour
{
    public List<Sprite> PotenPNG;
    public List<Sprite> PotenPNGBIG;
    public Image Poten;
    public Image PotenBig;
    public Button changepng;
    public int MaxValue;
    public Text RankLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int i;
    public void ChangePNG()
    {
        i = i + 1;
        if (i == MaxValue) 
        {
            i = 0;
        }
        Poten.sprite = PotenPNG[i];
        PotenBig.sprite = PotenPNGBIG[i];
        RankLevel.text = i.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
