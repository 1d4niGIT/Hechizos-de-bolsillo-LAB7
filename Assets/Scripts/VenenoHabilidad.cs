using MoreMountains.Feedbacks;
using UnityEngine;

public class VenenoHabilidad : HabilidadBase
{
    [SerializeField] private MMF_Player poisonParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();                         // primero el feedback común
        if (poisonParticlesFeedback != null)
            poisonParticlesFeedback.PlayFeedbacks();   // luego las partículas propias
    }
    public override void Ejecutar()
    {
        PlayFeedback();
        GenerarProyectil(duracion: 4f); // Envenenar con duración
    }
}
