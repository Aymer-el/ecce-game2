using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class UIPieceSelection : MonoBehaviour
{
    public GameObject menu;
    public GameObject WarriorButtonSelection;

    public bool isShowingCanvas = true;

    public static UIPieceSelection instance;

    public void Awake()
    {
        AddWarrior(() => {
            Global.EcceInstance.TryPlaceNewPiece(Global.EcceInstance.player);
            isShowingCanvas = false;
        });
        UIPieceSelection.instance = this;
    }
    void AddWarrior(UnityAction action)
    {
        WarriorButtonSelection.GetComponentInChildren<Button>().onClick.AddListener(action);
    }

    public void Update()
    {
        menu.SetActive(isShowingCanvas);
    }
}
