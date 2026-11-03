using System;
using UnityEngine;
using UnityEngine.InputSystem;

//11/3/26 - Sasha Avteniev

//This should be on your actual character/player model
public class PlayerActions : MonoBehaviour
{
    //Reference to the main first person camera
    [SerializeField] private GameObject camera;

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

    public void OnLook(InputAction context)
    {
        Debug.Log("hit");
        float mouseX = context.ReadValue<Vector2>().x;
        float mouseY = context.ReadValue<Vector2>().y;

        PlayerLook.Look(camera, this.gameObject, mouseX, mouseY);
    }

    public void OnScan(InputAction context)
    {

    }
}
