using UnityEngine;

[System.Serializable]
public class FlickerLight : MonoBehaviour
{
    public Light lightSource;       // The light to flicker
    public bool blinking = true;    // Only flicker if blinking
    public Color baseColor = Color.white;

    private class FlickerState
    {
        public float intensity;
        public float target;
        public float timer;
    }

    private FlickerState _flicker;

    void Start()
    {
        if (lightSource == null) lightSource = GetComponent<Light>();
        lightSource.color = baseColor;

        _flicker = new FlickerState
        {
            intensity = 1f,
            target = 1f,
            timer = Random.value * 0.5f
        };
    }

    void Update()
    {
        if (!blinking) 
        {
            lightSource.color = baseColor;
            lightSource.intensity = 1f;
            return;
        }

        float dt = Time.deltaTime;
        _flicker.timer -= dt;

        if (_flicker.timer <= 0f)
        {
            // Randomly pick new target intensity and timer
            _flicker.target = (Random.value < 0.1f) ? 0f : 0.6f + Random.value * 0.4f;
            _flicker.timer = 0.05f + Random.value * 0.3f;
        }

        // Smoothly interpolate intensity toward target
        float lerpFactor = 0.2f;
        _flicker.intensity += (_flicker.target - _flicker.intensity) * lerpFactor;

        // Apply intensity to light
        lightSource.intensity = _flicker.intensity;
    }
}
