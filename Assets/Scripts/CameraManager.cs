using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Update()
    {
        Camera.main.transform.position = player.position + offset;
    }
}
