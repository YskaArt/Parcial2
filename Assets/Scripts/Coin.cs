using UnityEngine;

public class Coin : TempleObject
{
    protected override void OnInteract()
    {
        ShowDialogue();
        PlayerInventory.Instance.AddCoin();
        //Se llama a la intancia del Inventario del PLayer para Añadir la moneda al mismo y se procede a eliminarla de la Escena.
        Destroy(gameObject); 
    }
}
