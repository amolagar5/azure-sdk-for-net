// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A region consists of multiple lines (e.g. a column of text in a
    /// multi-column document).
    /// </summary>
    public partial class OcrRegion
    {
        /// <summary>
        /// Initializes a new instance of the OcrRegion class.
        /// </summary>
        public OcrRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OcrRegion class.
        /// </summary>
        /// <param name="boundingBox">Bounding box of a recognized region. The
        /// four integers represent the x-coordinate of the left edge, the
        /// y-coordinate of the top edge, width, and height of the bounding
        /// box, in the coordinate system of the input image, after it has been
        /// rotated around its center according to the detected text angle (see
        /// textAngle property), with the origin at the top-left corner, and
        /// the y-axis pointing down.</param>
        /// <param name="lines">An array of recognized lines of text.</param>
        public OcrRegion(string boundingBox = default(string), IList<OcrLine> lines = default(IList<OcrLine>))
        {
            BoundingBox = boundingBox;
            Lines = lines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets bounding box of a recognized region. The four integers
        /// represent the x-coordinate of the left edge, the y-coordinate of
        /// the top edge, width, and height of the bounding box, in the
        /// coordinate system of the input image, after it has been rotated
        /// around its center according to the detected text angle (see
        /// textAngle property), with the origin at the top-left corner, and
        /// the y-axis pointing down.
        /// </summary>
        [JsonProperty(PropertyName = "boundingBox")]
        public string BoundingBox { get; set; }

        /// <summary>
        /// Gets or sets an array of recognized lines of text.
        /// </summary>
        [JsonProperty(PropertyName = "lines")]
        public IList<OcrLine> Lines { get; set; }

    }
}
