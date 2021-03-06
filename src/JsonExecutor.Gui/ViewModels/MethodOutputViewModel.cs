﻿using Wpf.Util.Core.Model;
using Wpf.Util.Core.ViewModels;

namespace JsonExecutor.Gui.ViewModels
{
    /// <summary>
    /// Method output view model.
    /// </summary>
    internal class MethodOutputViewModel : TreeViewItemViewModel
    {
        /// <summary>
        /// Method return value.
        /// </summary>
        private readonly object _output;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodOutputViewModel"/> class.
        /// </summary>
        /// <param name="output">
        /// Output value.
        /// </param>
        public MethodOutputViewModel(object output)
            : base(null, "Return", true)
        {
            this._output = output;
            this.IsExpanded = true;
        }

        /// <summary>
        /// Loads the return value tree item.
        /// </summary>
        protected override void LoadChildren()
        {
            this.Children.Add(new ObjectTreeViewModel(null, "return", this._output, InfoType.Properties));
        }
    }
}
