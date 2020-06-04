﻿using Infrastructure;

namespace Widgets
{
    /// <summary>
    /// Represents a Widget that is a size of two by three
    /// Implements the <see cref="WidgetBase" />
    /// </summary>
    /// <seealso cref="WidgetBase" />
    public class TwoByThreeViewModel : WidgetBase
    {
        #region Private Fields

        private string _widgetTitle;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Gets or sets the widget title.
        /// </summary>
        /// <value>The widget title.</value>
        public sealed override string WidgetTitle
        {
            get => _widgetTitle;
            set => RaiseAndSetIfChanged(ref _widgetTitle, value);
        }

        #endregion Public Properties

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoByThreeViewModel"/> class.
        /// </summary>
        public TwoByThreeViewModel(int widgetNumber) : base(WidgetSize.TwoByThree)
        {
            WidgetTitle = $"TwoTwo{widgetNumber}";
        }

        #endregion Public Constructors
    }
}