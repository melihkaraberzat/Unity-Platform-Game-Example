using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour

{
    float _mouseX = 0.0f;
    float sensitivy = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _mouseX = Input.GetAxis("Mouse X");

        Vector3 rot = transform.localEulerAngles;
        rot.y += _mouseX * sensitivy;
        transform.localEulerAngles = rot;

    }
}
