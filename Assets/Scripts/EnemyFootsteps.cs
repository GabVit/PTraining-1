using UnityEngine;

public class EnemyFootsteps : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager; // Asocia el AudioManager aqu�

    // ...

    // Llama a este m�todo para reproducir el sonido de pasos del enemigo
    public void PlayFootstepSound()
    {
        audioManager.Play("EnemyFootstepSound");
    }
}

