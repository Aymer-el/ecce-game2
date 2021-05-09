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
        Debug.Log(Global.EcceInstance.GetPiece(Global.EcceInstance.mouseOver));
        if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).x == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).x)
        {
            if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).y + 2 == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).y)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.mouseOver.x, Global.EcceInstance.mouseOver.y + (1 * Global.caseLength)),
                    Global.EcceInstance.mouseOver
               );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();

            }
            else if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).y - 2 == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).y)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.mouseOver.x, Global.EcceInstance.mouseOver.y - (1 * Global.caseLength)),
                    Global.EcceInstance.mouseOver
                );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();
            }
        }
        else if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).y == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).y)
        {
            Debug.Log("in mouseover" + Global.ToArrayCoordinates(Global.EcceInstance.mouseOver));
            Debug.Log("in startdrag" + Global.ToArrayCoordinates(Global.EcceInstance.startDrag));

            if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).x + (2) == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).x)
            {
                Debug.Log("in effect2");
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.mouseOver.x + (1 * Global.caseLength), Global.EcceInstance.mouseOver.y),
                    Global.EcceInstance.mouseOver
                );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();
            }
            else if (Global.ToArrayCoordinates(Global.EcceInstance.mouseOver).x - (2)  == Global.ToArrayCoordinates(Global.EcceInstance.startDrag).x)
            {
                Debug.Log("in effect2");
                Debug.Log(Global.EcceInstance.GetPiece(Global.EcceInstance.mouseOver));
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x - (1 * Global.caseLength), Global.EcceInstance.startDrag.y),
                    target
                );
                Global.EcceInstance.DeselectPiece(Global.EcceInstance.startDrag);
                Global.EcceInstance.FinishTurn();
                Global.EcceInstance.DetermineWinner();

            }

        }
    }

}



