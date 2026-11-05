using UnityEngine;

//11/3/26 - Sasha Avteniev 
public static class PlayerLook
{
    public static void Look(GameObject camera, GameObject player, float mouseX, float mouseY, float speedX, float speedY)
    {
        float currentXRotation = camera.transform.eulerAngles.x;
        currentXRotation -= mouseY * Time.deltaTime * speedY;

        camera.transform.localRotation = Quaternion.Euler(currentXRotation, 0, 0);

        player.transform.Rotate(Vector3.up * mouseX * Time.deltaTime * speedX);
    }
}
