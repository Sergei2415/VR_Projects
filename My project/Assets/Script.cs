using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    public void Deactive()
    {
        if(obj.activeSelf)
            obj.SetActive(false); 
        else
            obj.SetActive(true);
    }
}
