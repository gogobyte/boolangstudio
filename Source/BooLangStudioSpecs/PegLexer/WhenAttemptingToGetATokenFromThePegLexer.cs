/*
 * Created by SharpDevelop.
 * User: jeff_2
 * Date: 6/8/2008
 * Time: 8:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using Xunit;
using Microsoft.VisualStudio.Package;
using BooLangService;
using BooPegLexer;
using Rhino.Mocks;

namespace Boo.BooLangStudioSpecs
{
	/// <summary>
	/// Description of WhenAttemptingToGetATokenFromThePegLexer.
	/// </summary>
	public abstract class WhenAttemptingToGetATokenFromThePegLexer : AutoMockingTestFixture
	{
		protected BooPegLexer.BooPegLexer lexer = null;
		protected int state = 0;
		protected string line = string.Empty;
		protected TokenInfo token = null;
		public WhenAttemptingToGetATokenFromThePegLexer()
			: base()
		{
			lexer = Mocks.PartialMock<BooPegLexer.BooPegLexer>();
			token = new TokenInfo();
		}
	}
	
	
	
}
