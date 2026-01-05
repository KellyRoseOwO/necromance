using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DOFFocalLengthSimple : MonoBehaviour
{
    public Volume volume;               // Global Volume z DOF
    private DepthOfField dof;

    public float targetFocalLength = 50f;  // nova Focal Length
    private float initialFocalLength = 1f; // začetna Focal Length = 1

        void Awake()
    {
        if (volume.profile.TryGet(out dof))
        {
            dof.focalLength.overrideState = true;
            dof.focalLength.value = initialFocalLength;
        }
    }

    public void ActivateFocalLength()
    {
        if (dof != null)
        {
            dof.focalLength.overrideState = true;
            dof.focalLength.value = targetFocalLength;
        }
    }


    // Funkcija za izklop / vrnitev na začetno vrednost (1)
    public void DeactivateFocalLength()
    {
        if(dof != null)
        {
            dof.focalLength.value = initialFocalLength;
        }
    }
}
