﻿using Net.RichardLord.Ash.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Nodes
{
    public class MovementNode : Node
    {
        public Transform Transform { get; set; }
        public Rigidbody2D Rigidbody { get; set; }
    }
}
