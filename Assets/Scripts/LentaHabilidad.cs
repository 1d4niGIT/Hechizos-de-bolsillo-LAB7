using MoreMountains.Feedbacks;
using UnityEngine;

public class LentaHabilidad : HabilidadBase
{
    [SerializeField] private MMF_Player slowParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();                         // primero el feedback común
        if (slowParticlesFeedback != null)
            slowParticlesFeedback.PlayFeedbacks();   // luego las partículas propias
    }
    public override void Ejecutar()
    {
        PlayFeedback();
        GenerarProyectil(duracion: 7f); // Ralentizar con duración
    }
}
