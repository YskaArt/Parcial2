using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private bool questCompleted = false;
    [SerializeField] private GameObject princePrefab;
    [SerializeField] private Transform spawnPoint;

    void Update()
    {
        if (!questCompleted)
        {
            bool noCoins = GameObject.FindGameObjectsWithTag("Coin").Length == 0;
            bool noPotions = GameObject.FindGameObjectsWithTag("Potion").Length == 0;

            if (noCoins && noPotions)
            {
                CompleteQuest();
            }
        }
    }

    void CompleteQuest()
    {
        questCompleted = true;
        Debug.Log("¡Misión completada! Has recogido todo.");

        if (princePrefab != null && spawnPoint != null)
        {
            Instantiate(princePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
