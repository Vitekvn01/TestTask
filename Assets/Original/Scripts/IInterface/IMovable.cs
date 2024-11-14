using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    void Move(float dirZ, float dirX, float speed, bool isSpeedUp);
}
