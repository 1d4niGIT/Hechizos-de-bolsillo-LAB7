using MoreMountains.Feedbacks;
using UnityEngine;

public class HieloHabilidad : HabilidadBase
{
    [SerializeField] private MMF_Player iceParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();                         // primero el feedback común
        if (iceParticlesFeedback != null)
            iceParticlesFeedback.PlayFeedbacks();   // luego las partículas propias
    }
    public override void Ejecutar()
    {
        PlayFeedback();
        GenerarProyectil(duracion: 5f); // Congelar con duración
    }
}
