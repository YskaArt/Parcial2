using UnityEngine;

public class Potion : TempleObject
{
    protected override void OnInteract()
    {
        ShowDialogue();
        PlayerInventory.Instance.AddPotion();
        //Lo mismo que en Coin, está diferido porque por ejemplo se podria usar la Potion como Objeto usable y la Coin como objeto de Mision

        Destroy(gameObject);
    }
}
