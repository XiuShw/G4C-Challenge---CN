using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class OutcomeSlider : MonoBehaviour
{
    private Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GameObject.Find("Outcome Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, GameManager.outcomeValue, 15f * Time.deltaTime);
    }
}
