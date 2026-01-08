using UnityEngine;

public class MusicTransition : MonoBehaviour
{
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

}
