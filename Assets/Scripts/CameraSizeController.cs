using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraSizeController : MonoBehaviour
{
    private Camera cam;

    [SerializeField] private float referenceAspect = 16f / 9f;
    
    private float originalSize;

    void Start()
    {
        cam = GetComponent<Camera>();

        originalSize = cam.orthographicSize;
    }

    void Update()
    {
        float currentAspect = (float)Screen.width / Screen.height;

        cam.orthographicSize = originalSize * (referenceAspect / currentAspect) ;
    }
}