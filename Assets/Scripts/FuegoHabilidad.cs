using MoreMountains.Feedbacks;
using UnityEngine;

public class FuegoHabilidad : HabilidadBase
{
    [SerializeField] private MMF_Player fireParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();                         // primero el feedback común
        if (fireParticlesFeedback != null)
            fireParticlesFeedback.PlayFeedbacks();   // luego las partículas propias
    }

    public override void Ejecutar()
    {
        PlayFeedback();
        GenerarProyectil(duracion: 3f);            // Quemar, velocidad media
    }
}
