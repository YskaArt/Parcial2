using UnityEngine;

public class Potion : TempleObject
{
    protected override void OnInteract()
    {
        ShowDialogue();
        PlayerInventory.Instance.AddPotion();
        //Lo mismo que en Coin, está diferido porque por ejemplo se podria usar la Potion como Objeto usable y la Coin como objeto de Mision, entonces se puede tomar como 2 objetos diferentes porque podrian tener propiedades unicas que en este momento no se aplican

        Destroy(gameObject);
    }
}
