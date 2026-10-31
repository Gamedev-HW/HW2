using UnityEngine;
using UnityEngine.InputSystem;

public class SlimeMovement : MonoBehaviour
{
    public Camera playerCamera;
    [SerializeField] private float moveSpeed = 10f;

    private Vector2 movement;


    void Update()
    {
        this.movement = Vector2.zero;

        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            movement.x = -1;

        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            movement.x = 1;

        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
            movement.y = 1;

        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
            movement.y = -1;

        this.movement.Normalize();

        this.transform.position += (Vector3)this.movement * moveSpeed * Time.deltaTime;
        playerCamera.transform.position += (Vector3)this.movement * moveSpeed * Time.deltaTime;

    }
}
