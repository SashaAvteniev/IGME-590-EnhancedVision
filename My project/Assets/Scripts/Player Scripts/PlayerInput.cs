using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

//11/3/26 - Sasha Avteniev

//This should be on your actual character/player model
public class PlayerActions : MonoBehaviour
{
    [Header("Camera Settings")]
    //Reference to the main first person camera
    [Tooltip("This is the main camera for your first person controller")]
    [SerializeField] private GameObject mainCamera;

    [SerializeField] private float cameraSpeedX;
    [SerializeField] private float cameraSpeedY;

    [Header("Scan Settings")]
    [SerializeField] private float radius;
    void Awake()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnLook(InputAction.CallbackContext context)
    {
        float mouseX = context.ReadValue<Vector2>().x;
        float mouseY = context.ReadValue<Vector2>().y;

        PlayerLook.Look(mainCamera, this.gameObject, mouseX, mouseY,cameraSpeedX,cameraSpeedY);
    }

    public void OnScan(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            PlayerScan.Scan(transform.position, radius);
        }
    }
}
