using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarBillboard : MonoBehaviour
{
    public Camera playerCamera;


    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + playerCamera.transform.forward);
    }
}
