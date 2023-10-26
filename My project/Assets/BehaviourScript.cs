using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject capsule;
    public void ButtonClick()
    {
        capsule.SetActive(!capsule.activeSelf);
    }

}
