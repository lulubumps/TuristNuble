using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PanelOpener : MonoBehaviour
{

    public GameObject GameObject;
    public int estado = 0;

    public void openPanel()
    {
        if (GameObject != null){
            bool isActive = GameObject.activeSelf;
            GameObject.SetActive(!isActive);


        }


    }


}