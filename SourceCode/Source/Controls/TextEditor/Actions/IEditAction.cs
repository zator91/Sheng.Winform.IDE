﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
using System;
using System.Windows.Forms;
namespace Sheng.SailingEase.Controls.TextEditor.Actions
{
	public interface IEditAction
	{
		Keys[] Keys {
			get;
			set;
		}
		void Execute(TextArea textArea);
	}
	public abstract class AbstractEditAction : IEditAction
	{
		Keys[] keys = null;
		public Keys[] Keys {
			get {
				return keys;
			}
			set {
				keys = value;
			}
		}
		public abstract void Execute(TextArea textArea);
	}		
}
