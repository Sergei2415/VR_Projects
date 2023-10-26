using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject obj;
    public void Deactive()
    {
        if(obj.activeSelf)
            obj.SetActive(false); 
        else
            obj.SetActive(true);
    }
}
