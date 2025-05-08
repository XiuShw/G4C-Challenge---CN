using UnityEngine;

public class HunguryMan : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;

    private void Start()
    {
        MapLevelManager.Instance.scoreResult -= 1;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && MapLevelManager.Instance.getFood() >= 1)
        {
            playerMovement.giveFood(1);
            AudioSFXManager.Instance.PlayAudio("savePeople");
            MapLevelManager.Instance.setFood(1);
            MapLevelManager.Instance.AddpeopleWFood();
            Debug.Log(GameManager.peopleFed);
            MapLevelManager.Instance.scoreResult += 1;
            Destroy(gameObject);
        }
    }
}
