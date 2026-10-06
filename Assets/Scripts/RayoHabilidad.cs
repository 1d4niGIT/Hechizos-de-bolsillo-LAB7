using MoreMountains.Feedbacks;
using UnityEngine;

public class RayoHabilidad : HabilidadBase
{
    [SerializeField] private MMF_Player shockParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();                         // primero el feedback común
        if (shockParticlesFeedback != null)
            shockParticlesFeedback.PlayFeedbacks();   // luego las partículas propias
    }
    public override void Ejecutar()
    {
        PlayFeedback();
        GenerarProyectil(duracion: 1f); // Electrocutar con duración
    }
}
