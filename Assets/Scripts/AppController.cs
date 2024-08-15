using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public GameObject MyActivity;
    public GameObject LoginAcctivity;

    public void OnClickLogin()
    {
        MyActivity.SetActive(false);
        LoginAcctivity.SetActive(true);
    }
}
