using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource source;
    public void PlaySound()
    {
        source.Play();
    }
}
