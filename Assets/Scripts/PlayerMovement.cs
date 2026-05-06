using System.Data;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D player;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Sprite[] directionalSprites;
    private Vector2 moveInput;
    private Vector2Int direction = Vector2Int.left;

    void Start()
    {
        
    }
    private void Update()
    {
        player.linearVelocity = moveInput * moveSpeed;
    }
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        if (context.ReadValue<Vector2>().x < 0)
        {
            SetDirection(Vector2Int.left);
        }
        else if (context.ReadValue<Vector2>().x > 0)
        {
            SetDirection(Vector2Int.right);
        }
        else if (context.ReadValue<Vector2>().y < 0)
        {
            SetDirection(Vector2Int.down);
        }
        else if (context.ReadValue <Vector2>().y > 0)
        {
            SetDirection(Vector2Int.up);
        }
    }
    public void SetDirection(Vector2Int dir)
    {
        direction = dir;
        if (direction == Vector2Int.left)
        {
            GetComponent<SpriteRenderer>().sprite = directionalSprites[3];
        }
        else if (direction == Vector2Int.right)
        {
            GetComponent<SpriteRenderer>().sprite = directionalSprites[1];
        }
        else if (direction == Vector2Int.up)
        {
            GetComponent<SpriteRenderer>().sprite = directionalSprites[0];
        }
        else if (direction == Vector2Int.down)
        {
            GetComponent<SpriteRenderer>().sprite = directionalSprites[2];
        }
    }

    public Vector2Int GetDirection()
    {
        return direction;
    }
}
