using UnityEngine;

public class Guardian : TempleObject
{
    //tambien en vez de Guardian se podria llamar NPCWithMission, ya que el script está pensado para funcion de otorgar misiones
    private bool missionGiven = false;

    protected override void OnInteract()
    {
        if (!missionGiven)
        {
            ShowDialogue();
            Debug.Log("Misión asignada: Recolecta las monedas y pociones para el Principe .");
            missionGiven = true;

            // Aquí Se puede aplicar un sistema de Misiones más complejo, pero de momento es comprensible el objetivo 
        }
        else
        {
            Debug.Log("¡Ve a completar la misión, valiente!");
        }
    }
}
