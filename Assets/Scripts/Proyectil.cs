using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private Vector2 direccion;
    private float velocidad;
    private EfectoEstado efecto;
    private float duracion;

    public void Lanzar(Vector2 direccion, float velocidad, EfectoEstado efecto, float duracion)
    {
        this.direccion = direccion.normalized;
        this.velocidad = velocidad;
        this.efecto = efecto;
        this.duracion = duracion;
        Destroy(gameObject, 5f);   // limpieza si no impacta
    }

    private void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D algo)
    {
        Muñeco muñeco = algo.GetComponent<Muñeco>();
        if (muñeco == null) return;

        //elegimos la sobrecarga según si hay duración
        if (duracion > 0f) muñeco.AplicarEstado(efecto, duracion);
        else muñeco.AplicarEstado(efecto);

        Destroy(gameObject);
    }
}