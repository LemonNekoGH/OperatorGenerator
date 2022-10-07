using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 切换截图模式 : MonoBehaviour
{
    public Button ChangeBtn;
    public static bool ModeActive=false;
    public GameObject ShootCamera;    // Start is called before the first frame update
    void Start()
    {
        ChangeBtn.onClick.AddListener(() => { ChangeShootMode(); });
    }
    private void ChangeShootMode()
    {
        if (ModeActive == true)
        {
           
        }
        else
        {
            ModeActive = true;
            ShootCamera.SetActive(true);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ModeActive = false;
            ShootCamera.SetActive(false);
        }
    }
}
