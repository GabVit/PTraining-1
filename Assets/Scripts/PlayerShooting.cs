using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Referencia al AudioManager
    private AudioManager audioManager;

    private void Start()
    {
        // Obt�n la instancia del AudioManager
        audioManager = AudioManager.instance;
    }

    // Llama a este m�todo para reproducir el sonido de disparo del jugador
    public void PlayShootSound()
    {
        audioManager.Play("PlayerShootSound");
    }
}
