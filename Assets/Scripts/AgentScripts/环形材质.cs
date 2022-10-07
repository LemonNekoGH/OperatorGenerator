using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 环形材质 : MonoBehaviour
{
    public GameObject FillCircle;
    public InputField maxexp;
    public InputField minexp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FillCircle.GetComponent<Image>().fillAmount = int.Parse(minexp.text) / int.Parse(maxexp.text);
    }
}
