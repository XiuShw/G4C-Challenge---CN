using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class OutcomeSlider : MonoBehaviour
{
    private Slider slider;
    bool playSound =false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value != GameManager.outcomeValue && playSound == false)
        {
            playSound = true;
            PlaySound();
        }
        else if (slider.value == GameManager.outcomeValue)
        {
            playSound = false;
        }
            slider.value = Mathf.MoveTowards(slider.value, GameManager.outcomeValue, 15f * Time.deltaTime);
    }

    void PlaySound()
    {
        if (playSound)
        {
            if (slider.value <= 3 || slider.value >= 7)
            {
                Debug.Log("soundPlayed");
                AudioSFXManager.Instance.PlayAudio("outcomeBad");
            }
            else if (slider.value > 3 || slider.value < 7)
            {
                Debug.Log("soundPlayed");
                AudioSFXManager.Instance.PlayAudio("outcomeGood");
            }
        }
    }
}
