using UnityEngine;

public class Guardian : TempleObject
{
    //tambien en vez de Guardian se podria llamar NPCWithMission, ya que el script est� pensado para funcion de otorgar misiones
    private bool missionGiven = false;

    protected override void OnInteract()
    {
        if (!missionGiven)
        {
            ShowDialogue();
            Debug.Log("Misi�n asignada: Recolecta las monedas y pociones para el Principe .");
            missionGiven = true;

            // Aqu� Se puede aplicar un sistema de Misiones m�s complejo, pero de momento es comprensible el objetivo 
        }
        else
        {
            Debug.Log("�Ve a completar la misi�n, valiente!");
        }
    }
}
