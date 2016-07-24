﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Core2D.Project;
using Core2D.Shape;
using Core2D.Shapes;
using Core2D.Style;

namespace Core2D.Editor.Tools.Selection
{
    /// <summary>
    /// Helper class for <see cref="XCubicBezier"/> shape selection.
    /// </summary>
    public class CubicBezierSelection
    {
        private readonly XLayer _layer;
        private readonly XCubicBezier _shape;
        private readonly ShapeStyle _style;
        private readonly BaseShape _point;

        /// <summary>
        /// Initialize new instance of <see cref="CubicBezierSelection"/> class.
        /// </summary>
        /// <param name="layer">The selection shapes layer.</param>
        /// <param name="shape">The selected shape.</param>
        /// <param name="style">The selection shapes style.</param>
        /// <param name="point">The selection point shape.</param>
        public CubicBezierSelection(XLayer layer, XCubicBezier shape, ShapeStyle style, BaseShape point)
        {
            _layer = layer;
            _shape = shape;
            _style = style;
            _point = point;
        }

        // TODO: Implement selection class.
    }
}