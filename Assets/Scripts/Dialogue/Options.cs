using UnityEngine;

public class Options : MonoBehaviour
{
    public void ChangeOutcomeValue (int amt) {
        GameManager.outcomeValue += amt;
    }
}
