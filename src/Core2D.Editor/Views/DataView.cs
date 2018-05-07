﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;

namespace Core2D.Editor.Views
{
    /// <summary>
    /// Data view.
    /// </summary>
    public class DataView : ViewBase<ProjectEditor>
    {
        private readonly IServiceProvider _serviceProvider;
        private Lazy<ProjectEditor> _context;

        /// <inheritdoc/>
        public override string Title => "Data";

        /// <inheritdoc/>
        public override object Context => _context.Value;

        /// <summary>
        /// Initialize new instance of <see cref="DataView"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public DataView(IServiceProvider serviceProvider) : base()
        {
            _serviceProvider = serviceProvider;
            _context = serviceProvider.GetServiceLazily<ProjectEditor>();
        }
    }
}
