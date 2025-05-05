using UnityEngine;

public class activateParticles : MonoBehaviour
{
    public GameObject particles;

   public void npcSeduced()
    {
        particles.SetActive(true);
    }
}
