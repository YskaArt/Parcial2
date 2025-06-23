using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance
    {
        get; private set;
    }

    private int coins = 0;
    private int potions = 0;

    public int Coins => coins;
    public int Potions => potions;

    // Se usó de esta manera pero puede ser reemplazodo por un lista para añadir objetos de manera más escalable, con cada objeto teniendo un nombre y cantidad del mismo, dentro de cierta cantidad de slots del inventario
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddCoin()
    {
        coins++;
        Debug.Log($"Monedas: {coins}");
    }

    public void AddPotion()
    {
        potions++;
        Debug.Log($"Pociones: {potions}");
    }
}
