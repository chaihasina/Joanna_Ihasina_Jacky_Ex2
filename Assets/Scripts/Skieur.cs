using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
public class Skieur : MonoBehaviour
{
    public InputAction mouvHoriz;
    public InputAction mouvVert;
    public float vitesse = 3f;

    void Start()
    {
       
    }

    // Utiliser ces fonctions pour activer et désactiver les InputActions
    private void OnEnable()
    {
        mouvHoriz.Enable();
        mouvVert.Enable();
    }

    private void OnDisable()
    {
        mouvHoriz.Disable();
        mouvVert.Disable();
    }



    // Il faut appeller cette fonction dans la collision avec le yéti.
    void DeconnecterCamera()
    {
        Camera.main.GetComponent<PositionConstraint>().enabled = false;
    }
}
