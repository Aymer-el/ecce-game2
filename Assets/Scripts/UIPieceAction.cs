using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIPieceAction: MonoBehaviour
{
    public GameObject menu;
    public GameObject abilityOne;
    public bool abilityOn;
    

    public static UIPieceAction instance;

    public void Awake()
    {
        playAbility(() => {
            abilityOn = true;
        });
        UIPieceAction.instance = this;
    }
    void playAbility(UnityAction action)
    {
        abilityOne.GetComponentInChildren<Button>().onClick.AddListener(action);
    }

    void toggleAbility()
    {
        this.abilityOn = !abilityOn;
    }

    public void Update()
    {
       // menu.SetActive(abilityOn);
    }
}

