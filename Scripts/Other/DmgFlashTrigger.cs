/*****************************************************************************
* Project: CMN5201gpr-0322-Game
* File   : Rotateable.cs
* Date   : 17.04.22
* Author : Jan Apsel (JA)
*
* These coded instructions, statements, and computer programs contain
* proprietary information of the author and are protected by Federal
* copyright law. They may not be disclosed to third parties or copied
* or duplicated in any form, in whole or in part, without the prior
* written consent of the author.
*
* History:
*   22.4.22 JA created 
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgFlashTrigger : MonoBehaviour, IDamageable, IReturnEntityType
{
    [SerializeField] DmgFlash _dmgFlash;
    public void DealDamage(float attackPower, float armorPenetration, bool canCrit, float critChance)
    {
        _dmgFlash.StartFlash(true);
    }

    public eEntityType GetEntityType()
    {
        return eEntityType.Environment;
    }
}
