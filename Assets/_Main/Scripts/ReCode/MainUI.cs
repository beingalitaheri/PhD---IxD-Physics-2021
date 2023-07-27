using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public GameObject mainUI;
    //
    public void OpenUI() 
    {
        mainUI.SetActive(true);
    }
    //
    public void CloseUI() 
    {
        mainUI.SetActive(false);
    }
}
