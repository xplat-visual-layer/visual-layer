namespace Avalonia
{
    /// <summary>
    /// Base class for controls that provides rendering and related visual properties.
    /// </summary>
    /// <remarks>
    /// The <see cref="Visual"/> class represents elements that have a visual on-screen
    /// representation and stores all the information needed for an 
    /// <see cref="IRenderer"/> to render the control. To traverse the visual tree, use the
    /// extension methods defined in <see cref="VisualExtensions"/>.
    /// </remarks>
    public class Visual
    {
        /// <summary>
        /// Gets or sets the Z index of the control.
        /// </summary>
        /// <remarks>
        /// Controls with a higher <see cref="ZIndex"/> will appear in front of controls with
        /// a lower ZIndex. If two controls have the same ZIndex then the control that appears
        /// later in the containing element's children collection will appear on top.
        /// </remarks>
        public int ZIndex
        {
            get => 0;
            set { }
        }
    }
}
