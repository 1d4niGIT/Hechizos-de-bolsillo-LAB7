using UnityEngine;
using UnityEngine.InputSystem;
using MoreMountains.Feedbacks;

public abstract class HabilidadBase : MonoBehaviour
{
    [SerializeField] protected Proyectil proyectilPrefab;
    [SerializeField] protected float velocidad = 8f;
    [SerializeField] protected EfectoEstado efecto;

    [SerializeField] protected MMF_Player castFeedback;

    protected virtual void PlayFeedback()
    {
        if (castFeedback != null)
            castFeedback.PlayFeedbacks();
    }

    public abstract void Ejecutar();   // cada hija DEBE definirlo}

    // Método normal (sin modificador): igual para todas
    protected Vector2 ObtenerDireccionPunteria()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        return (mouse - (Vector2)transform.position).normalized;
    }

    protected void GenerarProyectil(float duracion = 0f)
    {
        Proyectil p = Instantiate(proyectilPrefab, transform.position, Quaternion.identity);
        p.Lanzar(ObtenerDireccionPunteria(), velocidad, efecto, duracion);
    }
}