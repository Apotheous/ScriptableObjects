using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Hareket Stili/Ziplama")]
public class ZıplamaHareketStili : MoveSteel
{
    public float hiz = 5;
    public float yükseklik = 10;

    public ForceMode mode;
    public override void HareketEt(Move move, Vector3 vector3)
    {
        vector3 *= hiz;
        vector3.y = yükseklik;

        move.GetComponent<Rigidbody>().AddForce(vector3, mode);

    }

}
