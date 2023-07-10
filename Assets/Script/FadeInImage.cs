using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInImage : MonoBehaviour
{
    public float fadeInDuration = 1f; // Duration of the fade-in effect in seconds
    public Image Logo; // Reference to the Image component

    private float currentAlpha = 0f;
    private float timer = 0f;
    private bool isFading = false;
   
    private void Start()
    {
        // If the image reference is not set, try to get it from the same GameObject
        if (Logo == null)
            Logo = GetComponent<Image>();
    }

    private void Update()
    {
        if (isFading)
        {
            timer += Time.deltaTime;
            currentAlpha = Mathf.Lerp(0f, 1f, timer / fadeInDuration);
            Logo.color = new Color(Logo.color.r, Logo.color.g, Logo.color.b, currentAlpha);

            // If the fade-in is complete, stop updating the alpha
            if (timer >= fadeInDuration)
            {
                isFading = false;
            }
        }
    }

    public void StartFadeIn()
    {
        // Reset the timer and current alpha
        timer = 0f;
        currentAlpha = 0f;

        // Start fading in
        isFading = true;
    }
}
