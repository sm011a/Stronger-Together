﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float speed = 8f;
    private float speedRotation = 8f;
    private float jumpForce = 7f;

    private Rigidbody playerRb;

    private Animator playerAnim;
    private int stateAnim;


    public bool isGrounded;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        Jump();
    }

    private void MovePlayer() // Для управления играком
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontalInput * speedRotation, 0); // Вращение(поворот)
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        if (verticalInput == 0)
        {
            playerAnim.SetBool("isRunning", false);
        }
        else
        {
            playerAnim.SetBool("isRunning", true);
        }
    }

    private void Jump() // Прыжок
    {
        if ((Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Keypad0)) && isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            playerAnim.SetTrigger("takeOf");
        }
        if(isGrounded == true)
        {
            playerAnim.SetBool("isJumping", false);
        }
        else
        {
            playerAnim.SetBool("isJumping", true);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plane end")) // Для перезапуска сцены
        {
            Debug.Log("Restarted");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
