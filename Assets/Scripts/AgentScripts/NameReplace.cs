using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameReplace : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public InputField nameinp;
    public Text nametext;
    public void SetName()
    {
        nametext.text = nameinp.text;   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
