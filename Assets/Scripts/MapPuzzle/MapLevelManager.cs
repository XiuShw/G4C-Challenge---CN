using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapLevelManager : MonoBehaviour
{
    public static MapLevelManager Instance { get; private set; }

    public float foodOwn;
    [SerializeField] float beginFoodOwn;
    private float originFoodOwn;
    private Slider slider;
    private int sceneIndex;
    private int peopleWFood = 0;
    private int peopleFedThisLevel = 0;
    [SerializeField] float fillSpeed = 10f;



    public int countRestarts = 10;
    public int scoreResult = 0;
    public int originScore = 0;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        originFoodOwn = foodOwn;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //sceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log("scene loaded: " + sceneIndex);
        scoreResult = originScore;
        if (countRestarts <= 0)
        {
            scoreResult += countRestarts;
        }
        peopleFedThisLevel = 0;
        AudioSFXManager.Instance.PlayAudio("thump");
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        beginFoodOwn = foodOwn;
        
    }

    void Update()
    {
        
        slider.value = Mathf.MoveTowards(slider.value, foodOwn, 15f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.R))
        {
            foodOwn = beginFoodOwn;
            peopleWFood -= peopleFedThisLevel;
            peopleFedThisLevel = 0;
            countRestarts--;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            foodOwn = originFoodOwn;
            peopleWFood = 0;
            peopleFedThisLevel = 0;
            peopleWFood = 0;
            countRestarts--;

            SceneManager.LoadScene(sceneIndex);
        }

        if (foodOwn < 1)
        {
            slider.handleRect.gameObject.SetActive(false);
        }
        else
        {
            slider.handleRect.gameObject.SetActive(true);
        }

        if (slider == null)
        {
            Destroy(gameObject);
        }
    }

    public void setFood(float amount)
    {
        foodOwn -= amount;
    }

    public float getFood()
    {
        return foodOwn;
    }
    public void AddpeopleWFood() {
        peopleWFood++;
        peopleFedThisLevel++;
    }
    public int GetpeopleWFood() {
        return peopleWFood;
    }
    public void peopleWFoodReset() {
        peopleWFood = 0;
    }

    private void OnDestroy()
    {
        GameManager.outcomeValue += originScore;
    }
}
