using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
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

    void Update()
    {
        Vector2 movement = new Vector2(mouvHoriz.ReadValue<float>(), mouvVert.ReadValue<float>());
        transform.Translate(movement * Time.deltaTime * vitesse);
    }

    // Il faut appeller cette fonction dans la collision avec le yéti.
    void DeconnecterCamera()
    {
        Camera.main.GetComponent<PositionConstraint>().enabled = false;
    }
}
