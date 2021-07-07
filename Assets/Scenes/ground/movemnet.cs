using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemnet : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;

    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        //Vector3 direction = new Vector3(hori, 0f, ver).normalized;
        Vector3 player_movement = new Vector3(hori, 0f, ver) * speed * Time.deltaTime;

        if (player_movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(player_movement.x, player_movement.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            //controller.Move(direction.normalized * speed * Time.deltaTime);

            transform.Translate(player_movement, Space.Self);
            //transform.Translate(speed * hori * Time.deltaTime, 0f, speed * ver * Time.deltaTime);
        }
    }
}
