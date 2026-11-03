using UnityEngine;

//11/3/26 - Sasha Avteniev 
public static class PlayerLook
{
    public static void Look(GameObject camera, GameObject player, float mouseX, float mouseY)
    {
        float currentXRotation = camera.transform.eulerAngles.x;
        currentXRotation -= mouseY;
        currentXRotation = Mathf.Clamp(currentXRotation, -90, 90);

        camera.transform.localRotation = Quaternion.Euler(currentXRotation, 0, 0);

        player.transform.Rotate(Vector3.up * mouseX);
    }
}
