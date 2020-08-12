using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 15.0f;
    public float rotationSpeed = 1000.0f;
    private bool isGreaterThan45 = false;
    private float initialYRotation;
    private Quaternion currentRotation;
    private Quaternion targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        initialYRotation = transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Camera.main.transform.rotation.eulerAngles.x >= 45.0f)
            isGreaterThan45 = true;
        initialYRotation = Camera.main.transform.rotation.eulerAngles.y;
        PlayerController(isGreaterThan45);
    }

    void PlayerController(bool trueOrNot)
    {
        if (trueOrNot)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = transform.position + Camera.main.transform.up * speed * Time.deltaTime;
                if (Input.GetKey(KeyCode.A))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation - 45, 0); 
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation + 45, 0); 
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = transform.position - Camera.main.transform.up * speed * Time.deltaTime;
                if (Input.GetKey(KeyCode.A))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation - 135, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation + 135, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, 180 + initialYRotation, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
                }
            }
        }   
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
                if (Input.GetKey(KeyCode.A))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation - 45, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation + 45, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = transform.position - Camera.main.transform.forward * speed * Time.deltaTime;
                if (Input.GetKey(KeyCode.A))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation - 135, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, initialYRotation + 135, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
                else
                {
                    currentRotation = transform.rotation;
                    targetRotation = Quaternion.Euler(0, 180 + initialYRotation, 0);
                    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
                }
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - Camera.main.transform.right * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.W))
            {
                currentRotation = transform.rotation;
                targetRotation = Quaternion.Euler(0, initialYRotation - 45, 0); 
                transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                currentRotation = transform.rotation;
                targetRotation = Quaternion.Euler(0, initialYRotation - 135, 0);
                transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
            else
            {
                currentRotation = transform.rotation;
                targetRotation = Quaternion.Euler(0, initialYRotation - 90, 0);
                transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Camera.main.transform.right * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.W))
            {
                currentRotation = transform.rotation;
                targetRotation = Quaternion.Euler(0, initialYRotation + 45, 0);
                transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                currentRotation = transform.rotation;
                targetRotation = Quaternion.Euler(0, initialYRotation + 135, 0);
                transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
            else
            {
                currentRotation = transform.rotation;
                targetRotation = Quaternion.Euler(0, 90 + initialYRotation, 0);
                transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
        if((Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)) && Input.GetKeyDown(KeyCode.A))
        {
            currentRotation = transform.rotation;
            targetRotation = Quaternion.Euler(0, initialYRotation - 90, 0);
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            currentRotation = transform.rotation;
            targetRotation = Quaternion.Euler(0, initialYRotation + 90, 0);
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            currentRotation = transform.rotation;
            targetRotation = Quaternion.Euler(0, initialYRotation, 0);
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            currentRotation = transform.rotation;
            targetRotation = Quaternion.Euler(0, initialYRotation + 180, 0);
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }
}
