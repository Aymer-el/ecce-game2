using System.Collections.Generic;
using UnityEngine;


public class Warrior : Piece
{
    Piece piece;
    public GameObject display;
    public new Ability[] abilities = new Ability[3];

    public Piece setPiece(Piece piece)
    {
        this.piece = piece;
        return this;
    }

    public void Start()
    {
        /*Debug.Log(display);
        GameObject go = Instantiate(display) as GameObject;
        this.abilities[0] = go.AddComponent<WarriorAbility>();
        this.abilities[0] = Instantiate(display).AddComponent<BringEnnemy>().SetAbility(go.GetComponent<WarriorAbility>());
        this.abilities[0].Effect();
        */
    }

    public void Move(Vector2 location)
    {
        Debug.Log("test2");
    }

}



