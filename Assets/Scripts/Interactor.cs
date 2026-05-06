using UnityEngine;
using UnityEngine.InputSystem;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    [SerializeField] private PlayerMovement script;
    public Transform InteractorSource;
    public float InteractRange = 1;

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, script.GetDirection(), InteractRange);
            if (hit.collider && hit.collider.gameObject.TryGetComponent(out IInteractable interactObj))
            {
                interactObj.Interact();
            }
        }
    }
}
