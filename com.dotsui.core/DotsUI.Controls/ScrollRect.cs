﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;

namespace DotsUI.Controls
{
    public enum ScrollBarAxis
    {
        Vertical,
        Horizontal
    }
    public struct ScrollRect : IComponentData
    {
        public Entity Content;
        public Entity Viewport;
        public Entity VerticalBar;
        public Entity HorizontalBar;
        public float VerticalBarSpacing;
        public float HorizontalBarSpacing;
    }

    public struct ScrollBar : IComponentData
    {
        public Entity ScrollHandle;
        public Entity ParentScrollRect;
        public float Value;
        /// <summary>
        /// Calculated automatically in ScrollRectSystem
        /// </summary>
        public float DragSensitivity;
    }

    public struct ScrollBarHandle : IComponentData
    {

    }
}
