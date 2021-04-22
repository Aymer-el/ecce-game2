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

public class Piece : MonoBehaviour {

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

    public void Effect(Piece piece, Vector2 location)
    {
    }
   
}

public class Warriorpiece : Piece
{

}

public abstract class DecoratorPiece : Piece
{
    protected Piece piece;
    public string sprite;

    public DecoratorPiece SetPiece(Piece piece)
    {
        this.piece = piece;
        return this;
    }
}

public class BringEnnemy : DecoratorPiece
{
    public string Name = "BringEnnemypiece";
    public string Description = "Bring the ennemy on one case";
    public new int stamina = 7;

    public void Effect(Vector2 location)
    {
        this.piece.Effect(piece, location);
        piece.stamina = piece.stamina - 2;
        if(Global.EcceInstance.startDrag.x == Global.EcceInstance.startDrag.x)
        {
           (Global.EcceInstance.mouseOver.x + 2, Global.EcceInstance.mouseOver.x) 
        }
            if ((Global.EcceInstance.startDrag.x -2) == Global.EcceInstance.startDrag.y)
        {
            new Vector2(Global.EcceInstance.startDrag.x + 1, Global.EcceInstance.startDrag.y);
            new Vector2(Global.EcceInstance.startDrag.x, Global.EcceInstance.startDrag.y +1);
            new Vector2(Global.EcceInstance.startDrag.x + 1, Global.EcceInstance.startDrag.x + 1)

        }
        {
            Global.EcceInstance.TryMovePiece(new Vector2(Global.EcceInstance.mouseOver.x - 2, Global.EcceInstance.startDrag.y),
                new Vector2(Global.EcceInstance.startDrag.x, Global.EcceInstance.startDrag.y));
        }
        else
        {

        }
    }

    public DecoratorPiece SetPiece(Piece piece)
    {
        this.piece = piece;
        return this;
    }
}

public class AttackEnnemy : DecoratorPiece
{
    public new void Effect()
    {
        this.piece.Effect();
        Debug.Log("3");
    }
}

