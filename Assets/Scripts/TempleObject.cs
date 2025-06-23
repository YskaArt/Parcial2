using UnityEngine;

public abstract class TempleObject : MonoBehaviour, IInteractable
{
    [SerializeField] private string objectName;
    [TextArea(2, 4)]
    [SerializeField] protected string dialogueText;

    public string ObjectName => objectName;

    public void Interact()
    {
        Debug.Log($"Interacting with: {objectName}");
        
        OnInteract();
    }

    protected virtual void ShowDialogue()
    {
        if (!string.IsNullOrEmpty(dialogueText))
        {
            Debug.Log($"[{objectName}] : {dialogueText}");
            // Aquí se puede conectar con un sistema de UI de diálogos más adelante y más sofisticado pero de momento se comprende que es para darle un Texto único a cada objeto que herede de esta clase
        }
    }

    protected abstract void OnInteract();
}
