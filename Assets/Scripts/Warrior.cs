using System.Collections.Generic;
using UnityEngine;


public class Warrior : Piece
{

    public void Start()
    {
    }

    public override void Effect(Vector2 target)
    {
        Debug.Log(Global.EcceInstance.GetPiece(target));
        if (Global.EcceInstance.mouseOver.x == Global.EcceInstance.startDrag.x)
        {
            if (Global.EcceInstance.mouseOver.y + 2 == Global.EcceInstance.startDrag.y)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x, Global.EcceInstance.startDrag.y + 1),
                    target
               );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();

            }
            else if (Global.EcceInstance.mouseOver.y - 2 == Global.EcceInstance.startDrag.y)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x, Global.EcceInstance.startDrag.y - (1 * Global.caseLength)),
                    target
                );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();
            }
        }
        else if (Global.EcceInstance.mouseOver.y == Global.EcceInstance.startDrag.y)
        {
            Debug.Log("in mouseover" + Global.ToArrayCoordinates(Global.EcceInstance.mouseOver));
            Debug.Log("in startdrag" + Global.ToArrayCoordinates(Global.EcceInstance.startDrag));

            if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).x + (2) == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).x)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x - (1 * Global.caseLength), Global.EcceInstance.startDrag.y),
                    target
                );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();
            }
            else if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).x - (2)  == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).x)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x + (1 * Global.caseLength), Global.EcceInstance.startDrag.y),
                    target
                );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();

            }

        }
    }

}



