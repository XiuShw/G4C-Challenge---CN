using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destination : MonoBehaviour
{
    [SerializeField] GameObject belt1;
    [SerializeField] GameObject belt2;
    [SerializeField] Text warnText;
    [SerializeField] bool isLastPuzzle;
    public GameObject options;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bool beltsNull = belt1 == null && belt2 == null;
            bool beltsSafe = !beltsNull && 
                             belt1.GetComponent<SpriteRenderer>().color != Color.red && 
                             belt2.GetComponent<SpriteRenderer>().color != Color.red;

            if (beltsNull || beltsSafe)
            {
                MapLevelManager.Instance.originScore = MapLevelManager.Instance.scoreResult;
                if (isLastPuzzle)
                {
                    GameManager.peopleFed += MapLevelManager.Instance.GetpeopleWFood();
                    MapLevelManager.Instance.peopleWFoodReset();
                    Destroy(MapLevelManager.Instance.gameObject);
                }
                // if (SceneManager.GetActiveScene().buildIndex == 11 && options != null) {
                //     options.SetActive(true);
                // }
                //else {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                //}
            }
            else
            {
                warnText.text = "你还有食物在传送带上没拿！\n 按'R'重开";
            }
        }
    }
}
