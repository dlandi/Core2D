﻿using System;
using System.IO;
using Core2D;
using Core2D.Containers;
using Core2D.Data;
using Core2D.Renderer;
using Core2D.Renderer.PdfSharp;

namespace Core2D.FileWriter.PdfSharp
{
    /// <summary>
    /// PdfSharp file writer.
    /// </summary>
    public sealed class PdfSharpWriter : IFileWriter
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSharpWriter"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public PdfSharpWriter(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <inheritdoc/>
        public string Name { get; } = "Pdf (PdfSharp)";

        /// <inheritdoc/>
        public string Extension { get; } = "pdf";

        /// <inheritdoc/>
        public void Save(Stream stream, object item, object options)
        {
            if (item == null)
            {
                return;
            }

            var ic = options as IImageCache;
            if (options == null)
            {
                return;
            }

            IProjectExporter exporter = new PdfSharpRenderer(_serviceProvider);

            IShapeRenderer renderer = (IShapeRenderer)exporter;
            renderer.State.DrawShapeState.Flags = ShapeStateFlags.Printable;
            renderer.State.ImageCache = ic;

            if (item is IPageContainer page)
            {
                var dataFlow = _serviceProvider.GetService<IDataFlow>();
                var db = (object)page.Data.Properties;
                var record = (object)page.Data.Record;

                dataFlow.Bind(page.Template, db, record);
                dataFlow.Bind(page, db, record);

                exporter.Save(stream, page);
            }
            else if (item is IDocumentContainer document)
            {
                var dataFlow = _serviceProvider.GetService<IDataFlow>();

                dataFlow.Bind(document);

                exporter.Save(stream, document);
            }
            else if (item is IProjectContainer project)
            {
                var dataFlow = _serviceProvider.GetService<IDataFlow>();

                dataFlow.Bind(project);

                exporter.Save(stream, project);
            }
        }
    }
}
