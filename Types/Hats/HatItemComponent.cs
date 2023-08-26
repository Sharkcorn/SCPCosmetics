﻿using InventorySystem.Items.Pickups;
using MapEditorReborn.API.Features.Objects;
using UnityEngine;

namespace SCPCosmetics.Types
{
    public class HatItemComponent : MonoBehaviour
    {
        internal HatPlayerComponent player;
        internal Vector3 pos;
        internal Vector3 itemOffset;
        internal Quaternion rot;
        internal ItemPickupBase item;
        internal bool showHat;
        internal SchematicObject hatSchematic;
        internal bool isSchematic;
    }
}