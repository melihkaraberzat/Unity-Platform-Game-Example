using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    float _enemyspeed = 1.0f;
    CharacterController controller;
    Transform _player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        _player = playerGameObject.transform;
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = _player.position - transform.position;
        Vector3 _velocity = direction * _enemyspeed;
        direction.Normalize();
        controller.Move(_velocity * Time.deltaTime);
    }
}
