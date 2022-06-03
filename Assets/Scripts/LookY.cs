using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour

{
    float _mouseY = 0.0f;
    float sensitivy = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _mouseY = -Input.GetAxis("Mouse Y");

        Vector3 rot = transform.localEulerAngles;
        rot.x += _mouseY * sensitivy;
        transform.localEulerAngles = rot;

    }
}
