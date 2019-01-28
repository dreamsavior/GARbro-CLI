// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace GameRes.Formats.Artemis
{
internal enum Token {
    error=127,EOF=128,NUMBER=129,STRING_LITERAL=130,IDENTIFIER=131};

internal partial struct ValueType
{ 
	public int n; 
	public string s; 
	public IPTObject o;
}
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class IPTParser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[19];
  private static State[] states = new State[26];
  private static string[] nonTerms = new string[] {
      "input", "$accept", "root_definition", "object", "Anon@1", "decl_list", 
      "optional_comma", "statement", "definition", "lvalue", "value", "string", 
      "number", };

  static IPTParser() {
    states[0] = new State(new int[]{131,4},new int[]{-1,1,-3,3});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{61,5});
    states[5] = new State(new int[]{123,7},new int[]{-4,6});
    states[6] = new State(-3);
    states[7] = new State(-4,new int[]{-5,8});
    states[8] = new State(new int[]{131,15,123,7,130,20,129,22},new int[]{-6,9,-8,25,-9,14,-10,23,-11,24,-4,18,-12,19,-13,21});
    states[9] = new State(new int[]{44,12,125,-9},new int[]{-7,10});
    states[10] = new State(new int[]{125,11});
    states[11] = new State(-5);
    states[12] = new State(new int[]{131,15,123,7,130,20,129,22,125,-8},new int[]{-8,13,-9,14,-10,23,-11,24,-4,18,-12,19,-13,21});
    states[13] = new State(-7);
    states[14] = new State(-10);
    states[15] = new State(new int[]{61,16});
    states[16] = new State(new int[]{123,7,130,20,129,22},new int[]{-11,17,-4,18,-12,19,-13,21});
    states[17] = new State(-12);
    states[18] = new State(-14);
    states[19] = new State(-15);
    states[20] = new State(-17);
    states[21] = new State(-16);
    states[22] = new State(-18);
    states[23] = new State(-11);
    states[24] = new State(-13);
    states[25] = new State(-6);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,128});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{131,61,-4});
    rules[4] = new Rule(-5, new int[]{});
    rules[5] = new Rule(-4, new int[]{123,-5,-6,-7,125});
    rules[6] = new Rule(-6, new int[]{-8});
    rules[7] = new Rule(-6, new int[]{-6,44,-8});
    rules[8] = new Rule(-7, new int[]{44});
    rules[9] = new Rule(-7, new int[]{});
    rules[10] = new Rule(-8, new int[]{-9});
    rules[11] = new Rule(-8, new int[]{-10});
    rules[12] = new Rule(-9, new int[]{131,61,-11});
    rules[13] = new Rule(-10, new int[]{-11});
    rules[14] = new Rule(-11, new int[]{-4});
    rules[15] = new Rule(-11, new int[]{-12});
    rules[16] = new Rule(-11, new int[]{-13});
    rules[17] = new Rule(-12, new int[]{130});
    rules[18] = new Rule(-13, new int[]{129});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 3: // root_definition -> IDENTIFIER, '=', object
{ RootObject[ValueStack[ValueStack.Depth-3].s] = ValueStack[ValueStack.Depth-1].o; }
        break;
      case 4: // Anon@1 -> /* empty */
{ BeginObject(); }
        break;
      case 5: // object -> '{', Anon@1, decl_list, optional_comma, '}'
{ EndObject(); }
        break;
      case 12: // definition -> IDENTIFIER, '=', value
{ CurrentObject[ValueStack[ValueStack.Depth-3].s] = ValueStack[ValueStack.Depth-1].Value; }
        break;
      case 13: // lvalue -> value
{ CurrentObject.Values.Add (ValueStack[ValueStack.Depth-1].Value); }
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
