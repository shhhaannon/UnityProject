using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Text collectedText;
    private Vector3 moveDirection = Vector3.zero;

    public Transform cam;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    private Vector3 initialPosition;
    private Quaternion initialRotation;


    public Animator animator;
    public bool isFalling = false;
    public float health = 100f;
    public Slider healthBar;
    private int colllected = 0;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        initialPosition.y += 50;
        animator = transform.Find("ty").GetComponent<Animator>();
        healthBar.maxValue = health;
        healthBar.value = health;
    }
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal");
        float zDisplacement = Input.GetAxis("Vertical");
        animator.SetBool("isGrounded", controller.isGrounded);

        if (isFalling)
            xDisplacement = zDisplacement = 0.0f;

        if (controller.isGrounded)
        {
            animator.SetBool("isFalling", false);
            moveDirection = new Vector3(xDisplacement * speed, 0, zDisplacement * speed);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("isJumping");
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", false);
            }
        }
        else
        {
            moveDirection = new Vector3(xDisplacement * speed, moveDirection.y, zDisplacement * speed);
        }
        moveDirection.y += gravity * Time.deltaTime;
        if (moveDirection.x != 0.0f || moveDirection.z != 0.0f)
        {
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            moveDir.y = moveDirection.y;
            moveDir.x *= speed;
            moveDir.z *= speed;
            controller.Move(moveDir * Time.deltaTime);
            if (controller.isGrounded)
            {
                animator.SetBool("isRunning", true);
                animator.SetBool("isIdling", false);
            }
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", false);
            }
        }
        else
        {
            controller.Move(moveDirection * Time.deltaTime);
            if (controller.isGrounded)
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", false);
            }
        }
        if (transform.position.y < -30)
        {
            transform.position = initialPosition;
            transform.rotation = initialRotation;
            healthBar.maxValue = health;
            healthBar.value = health;
            animator.SetBool("isFalling", true);
        }
        if (healthBar.value <= 0f)
        {
            //Vector3 resetPosition = initialPosition;
            //resetPosition.y = 20f;
            animator.SetBool("isFalling", true);
            animator.SetBool("isGrounded", false);
            animator.SetBool("isIdling", false);
            controller.enabled = false;
            transform.position = initialPosition;
            transform.rotation = initialRotation;
            healthBar.maxValue = health;
            healthBar.value = health;
            controller.enabled = true;
        }
    }

    public void TakeDamage(float damage)
    {
        healthBar.value -= damage;

    }

    private void OnTriggerEnter(Collider other)


    {


        // Check if the object touched has the tag "Collectible"


        if (other.CompareTag("Collectible"))


        {


            // Destroy the collectible item
            colllected += 1;
            collectedText.text = $"{colllected}";

            Destroy(other.gameObject);

            // Optional: Add sound, score, effects, etc.Add commentMore actions


            Debug.Log("Collected an item!");


        }


    }
}
