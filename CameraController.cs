using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    public Camera camera;

   void Start()
    {
        offset = camera.transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        camera.transform.position = player.transform.position + offset;
    }
}
