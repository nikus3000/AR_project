using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJoystick2 : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));

    }

    void moveCharacter(Vector3 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
}