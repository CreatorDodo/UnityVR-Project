using UnityEngine;
using UnityEngine.Events;

public class Mob : MonoBehaviour
{
    public UnityEvent OnCreated;
    public UnityEvent OnDestroyed;

    // public float hueMin = 0f;
    // public float hueMax = 1f;
    // public float saturationMin = 0.7f;
    // public float saturationMax = 1f;
    // public float valueMin = 0.7f;
    // public float valueMax = 1f;

    // public float arrangeRange = 0.5f;

    // public float emissionIntensity = 5f;

    public float destroyDelay = 1f;
    private bool isDestroyed = false;

    // public ParticleSystem environmentParticle;
    // public MeshRenderer holeMeshRenderer;

    // public ParticleSystem destroyParticle;
    // public AudioSource destroyAudio;
    // public GameObject modelGameObject;

    // private NavMeshAgent agent;

    // private void Awake()
    // {
    //     agent = GetComponent<NavMeshAgent>();
    // }

    private void Start()
    {
        // agent.SetDestination(new Vector3(0f, 2f, 1f));
        // agent.speed *= Random.Range(0.8f, 1.5f);

        // RandomColor();

        // Invoke(nameof(Destroy), 3f);

        OnCreated?.Invoke();
    }

    // private void RandomColor()
    // {
    //     var color = Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax);

    //     var main = environmentParticle.main;
    //     main.startColor = new ParticleSystem.MinMaxGradient(color, color * Random.Range(1f - arrangeRange, 1f + arrangeRange));

    //     var renderer = environmentParticle.GetComponent<ParticleSystemRenderer>();
    //     renderer.material.SetColor("_EmissionColor", color * emissionIntensity);

    //     holeMeshRenderer.material.SetColor("_EmissionColor", color * emissionIntensity);


    //     main = destroyParticle.main;
    //     main.startColor = new ParticleSystem.MinMaxGradient(color, color * Random.Range(1f - arrangeRange, 1f + arrangeRange));

    //     renderer = destroyParticle.GetComponent<ParticleSystemRenderer>();
    //     renderer.material.SetColor("_EmissionColor", color * emissionIntensity);
    // }

    public void Destroy()
    {
        if (isDestroyed)
            return;
        isDestroyed = true;

        // destroyParticle.Play();
        // destroyAudio.Play();

        // environmentParticle.Stop();
        // agent.enabled = false;
        // modelGameObject.SetActive(false);

        Destroy(gameObject, destroyDelay);

        OnDestroyed?.Invoke();
    }
}
