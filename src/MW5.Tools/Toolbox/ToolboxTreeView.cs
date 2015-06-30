﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MW5.Plugins.Events;
using MW5.Plugins.Interfaces;
using MW5.Tools.Properties;
using MW5.UI.Controls;

namespace MW5.Tools.Toolbox
{
    public class ToolboxTreeView: TreeViewBase
    {
        public ToolboxTreeView()
        {
            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Fill;

            AfterSelect += TreeAfterSelect;
            MouseDoubleClick += TreeMouseDoubleClick;
            PrepareToolTip += OnPrepareToolTip;
        }

        public event EventHandler<ToolboxToolEventArgs> ToolClicked;
        public event EventHandler<ToolboxToolEventArgs> ToolSelected;
        public event EventHandler<ToolboxGroupEventArgs> GroupSelected;

        protected override IEnumerable<Bitmap> OnCreateImageList()
        {
            yield return Resources.img_toolbox16;
            yield return Resources.img_tool16;
        }

        public IGisTool SelectedTool
        {
            get { return SelectedNode.Tag as IGisTool; }
        }

        private void OnPrepareToolTip(object sender, ToolTipEventArgs e)
        {
            e.Cancel = true; // don't show them

            //if (_tree.SelectedTool == null)
            //{
            //    e.Cancel = true;
            //}

            //var tool = _tree.SelectedTool;
            //if (tool != null)
            //{
            //    e.ToolTip.Header.Text = tool.Name;
            //    e.ToolTip.Body.Text = tool.Description;
            //}
        }

        /// <summary>
        /// Fires events, sets the same icons for selected mode as for regular mode
        /// </summary>
        private void TreeAfterSelect(object sender, EventArgs e)
        {
            if (SelectedNode == null)
            {
                return;
            }

            var tool = SelectedNode.Tag as IGisTool;
            if (tool != null)
            {
                FireToolSelected(tool);
            }

            var group = SelectedNode.Tag as IToolboxGroup;
            if (group != null)
            {
                FireGroupSelected(group);
            }
        }

        /// <summary>
        /// Generates tool clicked event for plug-ins
        /// </summary>
        private void TreeMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var node = SelectedNode;
            if (node == null || node.Tag is IToolboxGroup)
            {
                return;
            }

            var tool = node.Tag as IGisTool;
            if (tool != null)
            {
                FireToolClicked(tool);
            }
        }

        private void FireToolClicked(IGisTool tool)
        {
            FireEvent(ToolClicked, new ToolboxToolEventArgs(tool));
        }

        private void FireToolSelected(IGisTool tool)
        {
            FireEvent(ToolSelected, new ToolboxToolEventArgs(tool));
        }

        private void FireGroupSelected(IToolboxGroup group)
        {
            FireEvent(GroupSelected, new ToolboxGroupEventArgs(group));
        }

        private void FireEvent<T>(EventHandler<T> handler, T args)
        {
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}
