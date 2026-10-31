using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraSizeController : MonoBehaviour
{
    private Camera cam;

    private float originalSize;
    private int originalHeight;

    void Start()
    {
        cam = GetComponent<Camera>();

        originalSize = cam.orthographicSize;
        originalHeight = Screen.height;
    }

    void Update()
    {
        cam.orthographicSize = originalSize * Screen.height / originalHeight;
    }
}