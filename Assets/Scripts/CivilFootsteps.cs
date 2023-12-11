using UnityEngine;

public class CivilFootsteps : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager; // Asocia el AudioManager aqu�

    // ...

    // Llama a este m�todo para reproducir el sonido de pasos del civil
    public void PlayFootstepSound()
    {
        audioManager.Play("CivilFootstepSound");
    }
}
