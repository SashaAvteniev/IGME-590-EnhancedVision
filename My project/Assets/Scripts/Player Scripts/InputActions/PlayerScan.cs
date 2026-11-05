using UnityEngine;

public static class PlayerScan 
{
    public static void Scan(Vector3 currentPosition, float scanRadius)
    {
        Collider[] colliderArray = Physics.OverlapSphere(currentPosition, scanRadius);
        if(colliderArray.Length == 0)
        {
            Debug.LogError("Scan Missed");
        }
        foreach(Collider collider in colliderArray)
        {
            if (collider.gameObject.activeSelf)
            {
                Debug.Log("WOW");
            }
        }
    }
}
