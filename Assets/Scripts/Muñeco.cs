using MoreMountains.Feedbacks;
using UnityEngine;

public class Muñeco : MonoBehaviour
{
    [Header("Feedback de impacto por efecto")]
    [SerializeField] private MMF_Player impactoFuego;
    [SerializeField] private MMF_Player impactoHielo;
    [SerializeField] private MMF_Player impactoVeneno;
    [SerializeField] private MMF_Player impactoRayo;
    [SerializeField] private MMF_Player impactoLenta;
    public void AplicarEstado(EfectoEstado efecto)
    {
        Debug.Log($"Muñeco recibe {efecto}");
        ReproducirImpacto(efecto);
    }

    public void AplicarEstado(EfectoEstado efecto, float duracion)
    {
        Debug.Log($"Muñeco recibe {efecto} durante {duracion} segundos");
        ReproducirImpacto(efecto);
    }

    private void ReproducirImpacto(EfectoEstado efecto)
    {
        MMF_Player feedback = efecto switch
        {
            EfectoEstado.Quemar => impactoFuego,
            EfectoEstado.Congelar => impactoHielo,
            EfectoEstado.Envenenar => impactoVeneno,
            EfectoEstado.Electrocutar => impactoRayo,
            EfectoEstado.Ralentizar => impactoLenta,
            _ => null
        };

        if (feedback != null) feedback.PlayFeedbacks();
    }
}
