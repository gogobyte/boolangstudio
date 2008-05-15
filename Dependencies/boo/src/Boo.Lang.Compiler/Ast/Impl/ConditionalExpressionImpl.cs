#region license
// Copyright (c) 2003, 2004, 2005 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public partial class ConditionalExpression : Expression
	{
		protected Expression _condition;

		protected Expression _trueValue;

		protected Expression _falseValue;


		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public ConditionalExpression CloneNode()
		{
			return Clone() as ConditionalExpression;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public NodeType NodeType
		{
			get
			{
				return NodeType.ConditionalExpression;
			}
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnConditionalExpression(this);
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Matches(Node node)
		{	
			ConditionalExpression other = node as ConditionalExpression;
			if (null == other) return false;
			if (!Node.Matches(_condition, other._condition)) return NoMatch("ConditionalExpression._condition");
			if (!Node.Matches(_trueValue, other._trueValue)) return NoMatch("ConditionalExpression._trueValue");
			if (!Node.Matches(_falseValue, other._falseValue)) return NoMatch("ConditionalExpression._falseValue");
			return true;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_condition == existing)
			{
				this.Condition = (Expression)newNode;
				return true;
			}
			if (_trueValue == existing)
			{
				this.TrueValue = (Expression)newNode;
				return true;
			}
			if (_falseValue == existing)
			{
				this.FalseValue = (Expression)newNode;
				return true;
			}
			return false;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public object Clone()
		{
			ConditionalExpression clone = (ConditionalExpression)FormatterServices.GetUninitializedObject(typeof(ConditionalExpression));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._expressionType = _expressionType;
			if (null != _condition)
			{
				clone._condition = _condition.Clone() as Expression;
				clone._condition.InitializeParent(clone);
			}
			if (null != _trueValue)
			{
				clone._trueValue = _trueValue.Clone() as Expression;
				clone._trueValue.InitializeParent(clone);
			}
			if (null != _falseValue)
			{
				clone._falseValue = _falseValue.Clone() as Expression;
				clone._falseValue.InitializeParent(clone);
			}
			return clone;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_expressionType = null;
			if (null != _condition)
			{
				_condition.ClearTypeSystemBindings();
			}
			if (null != _trueValue)
			{
				_trueValue.ClearTypeSystemBindings();
			}
			if (null != _falseValue)
			{
				_falseValue.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression Condition
		{
			get
			{

				return _condition;
			}

			set
			{
				if (_condition != value)
				{
					_condition = value;
					if (null != _condition)
					{
						_condition.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression TrueValue
		{
			get
			{

				return _trueValue;
			}

			set
			{
				if (_trueValue != value)
				{
					_trueValue = value;
					if (null != _trueValue)
					{
						_trueValue.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression FalseValue
		{
			get
			{

				return _falseValue;
			}

			set
			{
				if (_falseValue != value)
				{
					_falseValue = value;
					if (null != _falseValue)
					{
						_falseValue.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

