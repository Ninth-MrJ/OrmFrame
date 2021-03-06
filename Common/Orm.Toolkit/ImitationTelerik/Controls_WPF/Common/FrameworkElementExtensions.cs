﻿using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class FrameworkElementExtensions
	{
        public static string GetPlainText(this FrameworkElement element)
        {
            TextBox textBox = element as TextBox;
            if (textBox != null)
            {
                return textBox.Text;
            }
            TextBlock textBlock = element as TextBlock;
            if (textBlock != null)
            {
                return textBlock.Text;
            }
            HeaderedContentControl headeredContent = element as HeaderedContentControl;
            if (headeredContent != null)
            {
                return TextSearch.ConvertToPlainText(headeredContent.Header);
            }
            HeaderedItemsControl headeredItems = element as HeaderedItemsControl;
            if (headeredItems != null)
            {
                return TextSearch.ConvertToPlainText(headeredItems.Header);
            }
            ContentControl content = element as ContentControl;
            if (content != null)
            {
                return TextSearch.ConvertToPlainText(content.Content);
            }
            return element.ToString();
        }

        public static FrameworkElement GetChildByName(this FrameworkElement parentVisual, string partName)
        {
            FrameworkElement result = null;

            result = (FrameworkElement) parentVisual.FindName(partName);
            if (result != null)
                return result;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parentVisual);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parentVisual, i) as FrameworkElement;
                if (child != null)
                {
                    result = GetChildByName(child, partName);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }

		/// <summary>
		///     Does a deep search of the element tree, trying to find a descendant of the given type 
        ///     (including the element itself).
		/// </summary>
		/// <returns>True if the target is one of the elements.</returns>
		internal static T GetFirstDescendantOfType<T>(this DependencyObject target) where T : DependencyObject
		{
			// TODO: Recursion can potentially lead to stack overflow, replace if necessary!
			T descendant = target as T;
			if (descendant != null)
			{
				return descendant;
			}

			int childCount = VisualTreeHelper.GetChildrenCount(target);
			for (int i = 0; i < childCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(target, i);
				T recursiveFind = child.GetFirstDescendantOfType<T>();
				if (recursiveFind != null)
				{
					return recursiveFind;
				}
			}
			return null;
		}

        internal static IList<DependencyProperty> GetDependencyProperties(this FrameworkElement element)
        {
            List<DependencyProperty> list = new List<DependencyProperty>();
            if ((((!(element is Panel) && !(element is Button)) 
                && (!(element is Image) && !(element is ScrollViewer))) && !(element is ScrollBar)
                && ((!(element is TextBlock) && !(element is Border)) 
                && !(element is Shape))) && !(element is ContentPresenter))
            {
                foreach (FieldInfo info in element.GetType().GetFields(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Static))
                {
                    if (info.FieldType == typeof(DependencyProperty))
                    {
                        list.Add((DependencyProperty) info.GetValue(null));
                    }
                }
            }
            return list;
        }

        internal static List<BindingExpression> GetBindingExpressionFromSingleElement(this FrameworkElement element, object inheritedDataContext, object dataItem, bool twoWayOnly)
        {
            List<BindingExpression> result = new List<BindingExpression>();
            foreach (DependencyProperty property in element.GetDependencyProperties())
            {
                BindingExpression bindingExpression = element.GetBindingExpression(property);
                if ((((bindingExpression != null) && (bindingExpression.ParentBinding != null)) && (!twoWayOnly || (bindingExpression.ParentBinding.Mode == BindingMode.TwoWay))) && (bindingExpression.ParentBinding.Source == null))
                {
                    object obj2;
                    if ((property == FrameworkElement.DataContextProperty) || ((element is ContentPresenter) && (property == ContentPresenter.ContentProperty)))
                    {
                        obj2 = inheritedDataContext;
                    }
                    else
                    {
                        obj2 = element.DataContext ?? inheritedDataContext;
                    }
                    if (dataItem == obj2)
                    {
                        result.Add(bindingExpression);
                    }
                }
            }
            return result;
        }
	}
}
