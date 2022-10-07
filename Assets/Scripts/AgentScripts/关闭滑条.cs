using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 关闭滑条 : MonoBehaviour
{
    public GameObject abs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          abs.gameObject.SetActive(true);
        }
    }
}
