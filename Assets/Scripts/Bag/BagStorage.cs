﻿using System.Collections.Generic;
using UnityEngine;

namespace ThisGame.Bag {
    [CreateAssetMenu(fileName = "DefaultBagStorage", menuName = "Items/Bag Storage")]
    public class BagStorage : ScriptableObject {
        // todo: write to file
        public Dictionary<Items.ItemDescription, int> inBag;
        public int gold;
    }
}
