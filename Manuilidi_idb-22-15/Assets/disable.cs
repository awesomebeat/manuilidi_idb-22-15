using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disable : MonoBehaviour
{
    public GameObject obj;
    public bool i = true;

    public void Disabling()
    {
        if (i)
        {
            obj.SetActive(false);
            i = false;
        }
        else
        {
            obj.SetActive(true);
            i = true;
        }
    }
}
