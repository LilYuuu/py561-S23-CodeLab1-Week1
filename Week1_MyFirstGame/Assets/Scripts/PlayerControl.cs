using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 2;

    public int count = 0;

    public TextMeshProUGUI countText;

    public GameObject winTextObject;

    public GameObject nextLevelButton;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        SetCountText();
        
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Initialize the direction of movement
        Vector3 moveDirection = Vector3.zero;
        
        // Map keycodes with directions
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }
        
        // Normalize the direction vector
        moveDirection.Normalize();

        // Apply to the RB
        Vector3 moveForce = speed * Time.deltaTime * moveDirection;
        rb.position += moveForce;
    }

    // When collides, make the treasure disappear and update the score
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Treasure"))
        {
            other.gameObject.SetActive(false);

            count++;
            SetCountText();
        }
    }
    
// Set the score and show winText
    void SetCountText()
    {
        countText.text = "Score: " + count + " / 10";

        if (count >= 10)
        {
            winTextObject.SetActive(true);
            nextLevelButton.SetActive(true);
        }
    }
}
