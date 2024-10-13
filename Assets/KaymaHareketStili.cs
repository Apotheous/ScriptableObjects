using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName= "Hareket Stili/Kayma")]
public class KaymaHareketStili : MoveSteel
{
    public float hiz = 5;
    public ForceMode mode;
    public override void HareketEt(Move move,Vector3 vector3)
    {
        move.GetComponent<Rigidbody>().AddForce(vector3 * hiz, mode);
        
    }
}
