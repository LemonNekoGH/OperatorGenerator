using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SPdataSet : MonoBehaviour
{
    public Text TarText;
    public InputField TarField;
    // Start is called before the first frame update
    void Start()
    {
        TarField.onValueChanged.AddListener((string e) => TarText.text = e);
    }

    // Update is called once per frame
   
}
