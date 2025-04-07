using UnityEngine;

interface iInteractable
{
    public void Interact();
}

public class Interactable : MonoBehaviour
{
    public Transform interactionSource;
    public float interactionRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Ray r = new Ray(interactionSource.position, interactionSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactionRange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out iInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}
