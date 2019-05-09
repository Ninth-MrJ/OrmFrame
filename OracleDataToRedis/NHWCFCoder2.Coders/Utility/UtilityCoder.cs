﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Utility
{
    public class UtilityCoder
    {
        public static void Write()
        {
            string path = BaseParams.UtilityPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建FormHelper类
            string filepath = Path.Combine(path, "FormHelper.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("窗体的通用方法辅助类", sw);
            sw.WriteLine("");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("using " + BaseParams.ControlsNameSpace + ";");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine("    /// 窗体的通用方法类");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine("    public class FormHelper");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("        #region 设置所有子控件只读");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 设置父控件中所有子控件的ReadOnly");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"controls\"></param>");
            sw.WriteLine("        /// <param name=\"readOnly\"></param>");
            sw.WriteLine("        public static void SetReadOnly(Control ctlParent, bool readOnly)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (ctlParent.HasChildren)");
            sw.WriteLine("            {");
            sw.WriteLine("                foreach (Control ctl in ctlParent.Controls)");
            sw.WriteLine("                {");
            sw.WriteLine("                    if (ctl.HasChildren)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        SetReadOnly(ctl, readOnly);");
            sw.WriteLine("                        continue;");
            sw.WriteLine("                    }");
            sw.WriteLine("");
            sw.WriteLine("                    if (ctl is TextBox)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        TextBox _txt = (TextBox)ctl;");
            sw.WriteLine("                        _txt.ReadOnly = true;");
            sw.WriteLine("                        _txt.BackColor = System.Drawing.Color.White;");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else if (ctl is ComboBox || ctl is Button || ctl is DateTimePicker)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        ctl.Enabled = false;");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("");
            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        #region 绑定数据");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 绑定数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static void BindData(Control ctlParent, object DataSource)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (ctlParent.HasChildren)");
            sw.WriteLine("            {");
            sw.WriteLine("                foreach (Control ctl in ctlParent.Controls)");
            sw.WriteLine("                {");
            sw.WriteLine("                    if (ctl.HasChildren)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        BindData(ctl, DataSource);");
            sw.WriteLine("                        continue;");
            sw.WriteLine("                    }");
            sw.WriteLine("");
            sw.WriteLine("                    if (ctl is MyTextBox)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        MyTextBox _txt = (MyTextBox)ctl;");
            sw.WriteLine("                        if (_txt.IsNeedBind == false) //不需要绑定");
            sw.WriteLine("                            continue;");
            sw.WriteLine("");
            sw.WriteLine("                        if (_txt.DataBindings[\"Text\"] != null)");
            sw.WriteLine("                            _txt.DataBindings.Remove(_txt.DataBindings[\"Text\"]);");
            sw.WriteLine("");
            sw.WriteLine("                        _txt.DataBindings.Add(\"Text\", DataSource, _txt.FieldName, true);");
            sw.WriteLine("");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else if (ctl is MyComboBox)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        MyComboBox _cbb = (MyComboBox)ctl;");
            sw.WriteLine("                        if (_cbb.IsNeedBind == false) //不需要绑定");
            sw.WriteLine("                            continue;");
            sw.WriteLine("");
            sw.WriteLine("                        if (_cbb.DataBindings[\"SelectedValue\"] != null)");
            sw.WriteLine("                            _cbb.DataBindings.Remove(_cbb.DataBindings[\"SelectedValue\"]);");
            sw.WriteLine("");
            sw.WriteLine("                        _cbb.DataBindings.Add(\"SelectedValue\", DataSource, _cbb.FieldName, true);");
            sw.WriteLine("");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else if (ctl is MyDateTimePicker)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        MyDateTimePicker _dtp = (MyDateTimePicker)ctl;");
            sw.WriteLine("");
            sw.WriteLine("                        if (_dtp.IsNeedBind == false)");
            sw.WriteLine("                            continue;");
            sw.WriteLine("                        if (_dtp.DataBindings[\"Value\"] != null)");
            sw.WriteLine("                            _dtp.DataBindings.Remove(_dtp.DataBindings[\"Value\"]);");
            sw.WriteLine("");
            sw.WriteLine("                        _dtp.DataBindings.Add(\"Value\", DataSource, _dtp.FieldName, true);");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else if (ctl is MyMaskedTextBox)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        MyMaskedTextBox _mtb = (MyMaskedTextBox)ctl;");
            sw.WriteLine("");
            sw.WriteLine("                        if (_mtb.IsNeedBind == false)");
            sw.WriteLine("                            continue;");
            sw.WriteLine("                        if (_mtb.DataBindings[\"Text\"] != null)");
            sw.WriteLine("                            _mtb.DataBindings.Remove(_mtb.DataBindings[\"Text\"]);");
            sw.WriteLine("");
            sw.WriteLine("                        _mtb.DataBindings.Add(\"Text\", DataSource, _mtb.FieldName, true);");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        #region 弹出提示信息");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 弹出提示信息");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"msg\">需要显示的消息</param>");
            sw.WriteLine("        public static void ShowInfo(string msg)");
            sw.WriteLine("        {");
            sw.WriteLine("            MessageBox.Show(msg, \"消息\", MessageBoxButtons.OK, MessageBoxIcon.Information);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 弹出确定对话框");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"msg\">需要显示的消息</param>");
            sw.WriteLine("        /// <returns>");
            sw.WriteLine("        /// true:点击了OK");
            sw.WriteLine("        /// false:点击了Cancel");
            sw.WriteLine("        /// </returns>");
            sw.WriteLine("        public static bool ShowConfirm(string msg)");
            sw.WriteLine("        {");
            sw.WriteLine("            DialogResult _dr = MessageBox.Show(msg, \"消息\", MessageBoxButtons.YesNo, MessageBoxIcon.Question);");
            sw.WriteLine("            if (_dr == DialogResult.Yes)");
            sw.WriteLine("                return true;");
            sw.WriteLine("            else");
            sw.WriteLine("                return false;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 弹出错误信息");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"msg\">需要显示的消息</param>");
            sw.WriteLine("        public static void ShowErr(string msg)");
            sw.WriteLine("        {");
            sw.WriteLine("            MessageBox.Show(msg, \"错误\", MessageBoxButtons.OK, MessageBoxIcon.Error);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 弹出异常信息");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"ex\">需要显示的异常</param>");
            sw.WriteLine("        public static void ShowException(Exception ex)");
            sw.WriteLine("        {");
            sw.WriteLine("            MessageBox.Show(\"程序运行发生异常：\" + ex.Message, \"异常\", MessageBoxButtons.OK, MessageBoxIcon.Error);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建IListHelper类
            filepath = Path.Combine(path, "IListHelper.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("IListHelper", sw);
            sw.WriteLine("");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public class IListHelper");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// Ilist<T> 转换成 DataSet");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"list\">Ilist<T></param>");
            sw.WriteLine("        /// <returns>DataSet</returns>");
            sw.WriteLine("");
            sw.WriteLine("        public static DataSet ConvertToDataSet<T>(IList<T> list)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (list == null || list.Count <= 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                return null;");
            sw.WriteLine("            }");
            sw.WriteLine(" ");
            sw.WriteLine("            DataSet ds = new DataSet();");
            sw.WriteLine("            DataTable dt = new DataTable(typeof(T).Name);");
            sw.WriteLine("            DataColumn column;");
            sw.WriteLine("            DataRow row;");
            sw.WriteLine(" ");
            sw.WriteLine("            System.Reflection.PropertyInfo[] myPropertyInfo = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);");
            sw.WriteLine("");
            sw.WriteLine("            foreach (T t in list)");
            sw.WriteLine("            {");
            sw.WriteLine("                if (t == null)");
            sw.WriteLine("                {");
            sw.WriteLine("                    continue;");
            sw.WriteLine("                }");
            sw.WriteLine("");
            sw.WriteLine("                row = dt.NewRow();");
            sw.WriteLine("");
            sw.WriteLine("                for (int i = 0, j = myPropertyInfo.Length; i < j; i++)");
            sw.WriteLine("                {");
            sw.WriteLine("                    System.Reflection.PropertyInfo pi = myPropertyInfo[i];");
            sw.WriteLine("");
            sw.WriteLine("                    string name = pi.Name;");
            sw.WriteLine("");
            sw.WriteLine("                    if (dt.Columns[name] == null)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        column = new DataColumn(name, pi.PropertyType);");
            sw.WriteLine("                        dt.Columns.Add(column);");
            sw.WriteLine("                    }");
            sw.WriteLine("");
            sw.WriteLine("                    row[name] = pi.GetValue(t, null);");
            sw.WriteLine("                }");
            sw.WriteLine("");
            sw.WriteLine("                dt.Rows.Add(row);");
            sw.WriteLine("            }");
            sw.WriteLine("");
            sw.WriteLine("            ds.Tables.Add(dt);");
            sw.WriteLine("");
            sw.WriteLine("            return ds;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建ObjectHelper<T>类
            filepath = Path.Combine(path, "ObjectHelper.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("ObjectHelper", sw);
            sw.WriteLine("");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.IO;");
            sw.WriteLine("using System.Runtime.Serialization;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.Serialization.Formatters.Binary;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public class ObjectHelper<T>");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("       /// <summary>");
            sw.WriteLine("       /// 采用序列化的方式对对象进行深层克隆");
            sw.WriteLine("       /// </summary>");
            sw.WriteLine("       /// <param name=\"o\">需要克隆的对象</param>");
            sw.WriteLine("       /// <returns>返回克隆对象</returns>");
            sw.WriteLine("        public static T Clone(T o)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (o == null) return o;");
            sw.WriteLine("            System.IO.MemoryStream _memory = new System.IO.MemoryStream();");
            sw.WriteLine("            BinaryFormatter formatter = new BinaryFormatter();");
            sw.WriteLine("            formatter.Serialize(_memory, o);");
            sw.WriteLine("            _memory.Position = 0;");
            sw.WriteLine("            T _newOjb = (T)formatter.Deserialize(_memory);");
            sw.WriteLine("            _memory.Close();");
            sw.WriteLine("            return _newOjb;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建SortableBindingList<T>类
            filepath = Path.Combine(path, "SortableBindingList.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("SortableBindingList", sw);
            sw.WriteLine("");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Reflection;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine("    /// 转换为可排序List对象。");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine("    /// <typeparam name=\"T\">需要转换的泛型对象</typeparam>");
            sw.WriteLine("    public class SortableBindingList<T> :BindingList<T>");
            sw.WriteLine("    {");
            sw.WriteLine("        private bool isSortedCore = true;");
            sw.WriteLine("        private ListSortDirection sortDirectionCore = ListSortDirection.Ascending;");
            sw.WriteLine("        private PropertyDescriptor sortPropertyCore = null;");
            sw.WriteLine("        private string defaultSortItem;");
            sw.WriteLine("");
            sw.WriteLine("        public SortableBindingList() : base() { }");
            sw.WriteLine("");
            sw.WriteLine("        public SortableBindingList(IList<T> list) : base(list) { }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool SupportsSortingCore");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return true; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool SupportsSearchingCore");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return true; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool IsSortedCore");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return isSortedCore; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override ListSortDirection SortDirectionCore");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return sortDirectionCore; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override PropertyDescriptor SortPropertyCore");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return sortPropertyCore; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override int FindCore(PropertyDescriptor prop, object key)");
            sw.WriteLine("        {");
            sw.WriteLine("            for (int i = 0; i < this.Count; i++)");
            sw.WriteLine("            {");
            sw.WriteLine("                if (Equals(prop.GetValue(this[i]), key)) return i;");
            sw.WriteLine("            }");
            sw.WriteLine("            return -1;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)");
            sw.WriteLine("        {");
            sw.WriteLine("            isSortedCore = true;");
            sw.WriteLine("            sortPropertyCore = prop;");
            sw.WriteLine("            sortDirectionCore = direction;");
            sw.WriteLine("            Sort();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void RemoveSortCore()");
            sw.WriteLine("        {");
            sw.WriteLine("            if (isSortedCore)");
            sw.WriteLine("            {");
            sw.WriteLine("                isSortedCore = false;");
            sw.WriteLine("                sortPropertyCore = null;");
            sw.WriteLine("                sortDirectionCore = ListSortDirection.Ascending;");
            sw.WriteLine("                Sort();");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        public string DefaultSortItem");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return defaultSortItem; }");
            sw.WriteLine("            set");
            sw.WriteLine("            {");
            sw.WriteLine("                if (defaultSortItem != value)");
            sw.WriteLine("                {");
            sw.WriteLine("                    defaultSortItem = value;");
            sw.WriteLine("                    Sort();");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void Sort()");
            sw.WriteLine("        {");
            sw.WriteLine("            List<T> list = (this.Items as List<T>);");
            sw.WriteLine("            list.Sort(CompareCore);");
            sw.WriteLine("            ResetBindings();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private int CompareCore(T o1, T o2)");
            sw.WriteLine("        {");
            sw.WriteLine("            int ret = 0;");
            sw.WriteLine("            if (SortPropertyCore != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                ret = CompareValue(SortPropertyCore.GetValue(o1), SortPropertyCore.GetValue(o2), SortPropertyCore.PropertyType);");
            sw.WriteLine("            }");
            sw.WriteLine("            if (ret == 0 && DefaultSortItem != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                PropertyInfo property = typeof(T).GetProperty(DefaultSortItem, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.IgnoreCase, null, null, new Type[0], null);");
            sw.WriteLine("                if (property != null)");
            sw.WriteLine("                {");
            sw.WriteLine("                    ret = CompareValue(property.GetValue(o1, null), property.GetValue(o2, null), property.PropertyType);");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            if (SortDirectionCore == ListSortDirection.Descending) ret = -ret;");
            sw.WriteLine("            return ret;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private static int CompareValue(object o1, object o2, Type type)");
            sw.WriteLine("        {");
            sw.WriteLine("            //这里改成自己定义的比较 ");
            sw.WriteLine("            if (o1 == null) return o2 == null ? 0 : -1;");
            sw.WriteLine("            else if (o2 == null) return 1;");
            sw.WriteLine("            else if (type.IsPrimitive || type.IsEnum) return Convert.ToDouble(o1).CompareTo(Convert.ToDouble(o2));");
            sw.WriteLine("            else if (type == typeof(DateTime)) return Convert.ToDateTime(o1).CompareTo(o2);");
            sw.WriteLine("            else return String.Compare(o1.ToString().Trim(), o2.ToString().Trim());");
            sw.WriteLine("        }");
            sw.WriteLine("    } ");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion
        }
    }
}