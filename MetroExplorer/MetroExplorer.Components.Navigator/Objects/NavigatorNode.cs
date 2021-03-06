﻿namespace MetroExplorer.Components.Navigator.Objects
{
    using System.Collections.Generic;
    using System.Windows.Input;
    using Windows.UI.Xaml.Media;

    public sealed class NavigatorNode
    {
        public string NodeName { get; set; }
        public ICommand NodeAction { get; private set; }
        public int NodeIndex { get; private set; }
        public IEnumerable<string> ItemList { get; private set; }
        public Brush Background { get; private set; }
        public bool IsLast { get; private set; }

        public NavigatorNode(
            int index,
            string name,
            ICommand action,
            Brush background,
            bool isLast)
        {
            NodeIndex = index;
            NodeName = name;
            NodeAction = action;
            Background = background;
            IsLast = isLast;
        }

        public NavigatorNode(
            int index,
            string name,
            ICommand action,
            Brush background,
            bool isLast,
            IEnumerable<string> itemList)
            : this(index, name, action, background, isLast)
        {
            ItemList = itemList;
        }
    }
}
