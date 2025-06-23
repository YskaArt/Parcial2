using UnityEngine;

public class Guardian : TempleObject
{
    private bool missionGiven = false;

    protected override void OnInteract()
    {
        if (!missionGiven)
        {
            ShowDialogue();
            Debug.Log("Misión asignada: Recolecta las monedas y pociones para el Principe .");
            missionGiven = true;

            // Aquí Se puede aplicar un sistema de Misiones, pero de momento es comprensible el objetivo 
        }
        else
        {
            Debug.Log("¡Ve a completar la misión, valiente!");
        }
    }
}
