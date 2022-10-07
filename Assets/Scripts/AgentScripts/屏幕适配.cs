using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 屏幕适配 : MonoBehaviour
{
    public Camera ForcosCam;
    public Slider FOVslider;
    public Button ChangeFOv;
    public List<int> Fovlist;
    public bool Is4_3;

    public void checkFOV() 
    {
        if (Is4_3 == false)
        {
            ChangeFOV4_3();
            Is4_3= true;
        }
        else
        {
            ChangeFOVNormal();
            Is4_3 = false;
        }
    }
    public void ChangeFOV4_3()
    {
        ForcosCam.fieldOfView = Fovlist[0];
    }
    public void ChangeFOVNormal()
    {
        ForcosCam.fieldOfView = Fovlist[1];
    }
}
