using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField] int amount;
    [SerializeField] GameObject allOptions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        GameManager.outcomeValue += amount;
        allOptions.SetActive(false);
        Debug.Log(GameManager.outcomeValue);
    }
}
