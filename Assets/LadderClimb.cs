using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderClimb : MonoBehaviour {
    public float climbSpeed = 5f;
    private bool isClimbing = false;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Ladder")) {
            isClimbing = true;
            rb.useGravity = false; // Отключаем гравитацию
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Ladder")) {
            isClimbing = false;
            rb.useGravity = true; // Включаем гравитацию
        }
    }

    void Update() {
        if (isClimbing) {
            float verticalInput = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(0, verticalInput * climbSpeed, 0);
        }
    }
}
