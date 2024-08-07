using System;
using UnityEngine;

namespace Mushakushi.MenuFramework.Runtime.SerializableUQuery
{
    /// <summary>
    /// Describes the type of selector.
    /// </summary>
    public enum SelectorMode
    {
        /// <summary>
        /// Only allow selection by style class. 
        /// </summary>
        Class, 
        
        /// <summary>
        /// Only allow selection by name.
        /// </summary>
        Name, 
        
        /// <summary>
        /// Allows selection by either a style class or name.
        /// </summary>
        All, 
    }
    
    
    [AttributeUsage(AttributeTargets.Field)]
    public class NameClassSelectorAttribute : PropertyAttribute
    {
        public readonly string selectorsContainerName;
        public readonly SelectorMode mode;

        /// <param name="selectorsContainerName">
        /// The property name of the object that names and style classes will be fetched from.
        /// The property should be either a <see cref="UnityEngine.UIElements.UIDocument"/> 
        /// <see cref="UnityEngine.UIElements.VisualTreeAsset"/>.
        /// </param>
        /// <param name="mode">
        /// The <see cref="SelectorMode"/>.
        /// </param>
        /// <remarks>
        /// The <paramref name="selectorsContainerName"/> may also be the name of an
        /// <see cref="System.Collections.Generic.IEnumerable{T}">IEnumerable&lt;string&gt;</see> containing
        /// a list of selectors to use, in which case the <see cref="mode"/> will be ignored.
        /// </remarks>
        public NameClassSelectorAttribute(string selectorsContainerName, SelectorMode mode = SelectorMode.All)
        {
            this.selectorsContainerName = selectorsContainerName;
            this.mode = mode;
        }
    }
}