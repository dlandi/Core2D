﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Core2D.UI.Avalonia.Views.Path
{
    /// <summary>
    /// Interaction logic for <see cref="PolyQuadraticBezierSegmentControl"/> xaml.
    /// </summary>
    public class PolyQuadraticBezierSegmentControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolyQuadraticBezierSegmentControl"/> class.
        /// </summary>
        public PolyQuadraticBezierSegmentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the Xaml components.
        /// </summary>
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
