using System.Collections.Generic;
using UnityEngine;

/**
 * Each Piece represents an instanciated game object, either _white or _black
 */

public enum PieceType
{
    warrior,
    knight,
    rogue,
    cleric,
    wizard,
    engineer,
    standard
}

public class Piece : MonoBehaviour
{

    /**** Dependency ****/
    public NPalBoard Board { get; private set; }
    public bool isEcce = true;
    public Material[] myMaterials = new Material[2];
    public PieceType pieceType = PieceType.standard;
    public Vector2 location;
    public int stamina = 5;

    /**** View ****/
    // Space between spaces
    protected int pieceMargin = 2;

    public virtual void Effect(Vector2 target) { }
}

public class Warriorpiece : Piece
{

}


public class DecoratorPiece : Piece
{
    protected Piece piece;
    public string sprite;

    public virtual DecoratorPiece SetPiece(Piece piece)
    {
        this.piece = piece;
        return this;
    }

    public new void Effect(Vector2 target)
    {

    }
}
    public class BringEnnemy : DecoratorPiece
{
    public string Name = "BringEnnemypiece";
    public string Description = "Bring the ennemy on one case";
    public new int stamina = 7;

    public new void Effect(Vector2 target)
    {
        Debug.Log("in effect2");
        this.piece.Effect(target);
        Piece advPiece = Global.EcceInstance.GetPiece(target);
        if (Global.EcceInstance.mouseOver.x == Global.EcceInstance.startDrag.x)
        {
            if (Global.EcceInstance.mouseOver.y + 2 == Global.EcceInstance.startDrag.y)
            {
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x, Global.EcceInstance.startDrag.y + 1),
                    target
               );
            }
            else if (Global.EcceInstance.mouseOver.y - 2 == Global.EcceInstance.startDrag.y)
            {
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x, Global.EcceInstance.startDrag.y - 1),
                    target
                );
            }
        }
        else if (Global.EcceInstance.mouseOver.y == Global.EcceInstance.startDrag.y)
        {
            if (Global.EcceInstance.mouseOver.x + 2 == Global.EcceInstance.startDrag.x)
            {
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x + 1, Global.EcceInstance.startDrag.y),
                    target
                );
            }
            else if (Global.EcceInstance.mouseOver.y - 2 == Global.EcceInstance.startDrag.y)
            {
                Global.EcceInstance.Move(
                    new Vector2(Global.EcceInstance.startDrag.x - 1, Global.EcceInstance.startDrag.y),
                    target
                );
            }

        }
    }

    public new DecoratorPiece SetPiece(Piece piece)
    {
        this.piece = piece;
        return this;
    }
}

