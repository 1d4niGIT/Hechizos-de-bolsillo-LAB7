using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    [SerializeField] private HabilidadBase[] habilidad;   // se asignan en el Inspector
    private HabilidadBase actual;

    private HabilidadEntradaAcciones entradas;

    private void Awake()
    {
        entradas = new HabilidadEntradaAcciones();
    }

    private void Start()
    {
        actual = habilidad[0];   // habilidad inicial
    }

    private void OnEnable()
    {
        
        entradas.Habilidades.Habilidad1.performed += EnHabilidad1;
        entradas.Habilidades.Habilidad2.performed += EnHabilidad2;
        entradas.Habilidades.Habilidad3.performed += EnHabilidad3;
        entradas.Habilidades.Habilidad4.performed += EnHabilidad4;
        entradas.Habilidades.Habilidad5.performed += EnHabilidad5;
        entradas.Habilidades.Castear.performed += AlCastear;
        entradas.Enable();
    }

    private void OnDisable()
    {
        entradas.Habilidades.Habilidad1.performed -= EnHabilidad1;
        entradas.Habilidades.Habilidad2.performed -= EnHabilidad2;
        entradas.Habilidades.Habilidad3.performed -= EnHabilidad3;
        entradas.Habilidades.Habilidad4.performed -= EnHabilidad4;
        entradas.Habilidades.Habilidad5.performed -= EnHabilidad5;
        entradas.Habilidades.Castear.performed -= AlCastear;
        entradas.Disable();
    }

    private void EnHabilidad1(InputAction.CallbackContext c) => Elegir(0);
    private void EnHabilidad2(InputAction.CallbackContext c) => Elegir(1);
    private void EnHabilidad3(InputAction.CallbackContext c) => Elegir(2);
    private void EnHabilidad4(InputAction.CallbackContext c) => Elegir(3);
    private void EnHabilidad5(InputAction.CallbackContext c) => Elegir(4);

    private void Elegir(int index) => actual = habilidad[index];

    private void AlCastear(InputAction.CallbackContext context)
    {
        if (actual == null)
        {
            Debug.LogWarning("No hay habilidad seleccionada o falta asignarla en el Inspector");
            return;
        }
        actual.Ejecutar();
    }
}