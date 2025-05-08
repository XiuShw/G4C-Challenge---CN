using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowOutcome : MonoBehaviour
{
    [SerializeField] Text outcome;
    [SerializeField] Sprite whale;
    [SerializeField] Sprite poor;
    [SerializeField] Sprite balance;

    [SerializeField] Text restartTime;
    [SerializeField] GameObject restartWarn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MapLevelManager.Instance.countRestarts <= 0)
        {
            restartTime.text = "";
            restartWarn.SetActive(true);
        }
        else
        {
            restartTime.text = "Ê£Óà" + MapLevelManager.Instance.countRestarts.ToString() + "´Î";
        }


        if (MapLevelManager.Instance.scoreResult > 0)
        {
            GetComponent<SpriteRenderer>().sprite = poor;
        }
        else if (MapLevelManager.Instance.scoreResult < 0)
        {
            GetComponent<SpriteRenderer>().sprite = whale;
        }
        else if (MapLevelManager.Instance.scoreResult == 0)
        {
            GetComponent<SpriteRenderer>().sprite = balance;
        }

        outcome.text = "+" + Mathf.Abs(MapLevelManager.Instance.scoreResult).ToString();
    }
}
