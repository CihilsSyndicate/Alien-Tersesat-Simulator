using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed;
    Vector3 inputMove;

    private void Update()
    {
        float inputAD;
        float inputWS;

        inputAD = Input.GetAxis("Horizontal");
        inputWS = Input.GetAxis("Vertical");

        inputMove = new Vector3(inputAD, 0, inputWS);

        controller.Move(inputMove * moveSpeed * Time.deltaTime);
    }
}
