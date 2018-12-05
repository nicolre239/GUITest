using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using UKPO_5_TEST.ParserUIMapClasses;


namespace UIMaps
{
    /// <summary>
    /// Сводное описание для CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        private ParserUIMap parserUiMap = new ParserUIMap();

        ////TestInitialize используется для выполнения кода перед запуском каждого теста 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            parserUiMap.StartApp();
        }

       [TestMethod]
        public void GeneralCheck()
        {
            parserUiMap.EnterText();
            parserUiMap.EnterExpression();
            parserUiMap.ButtonActive();
            parserUiMap.FindStart();
        }

       [TestMethod]
       public void TextBoxAccesable()
       {
           parserUiMap.TextIsVisible();
           parserUiMap.EnterText();
       }

       [TestMethod]
       public void ExpressionBoxAccesable()
       {
           parserUiMap.ExpressionIsVisible();
           parserUiMap.EnterExpression();
       }

       [TestMethod]
       public void ButtonAccesable()
       {
           parserUiMap.ButtonVisible();
       }

       [TestMethod]
       public void AnswerAccesable()
       {
           parserUiMap.AnswerVisible();
       }

       [TestMethod]
       public void AnswerBoxNotTabAble()
       {
           parserUiMap.AnswerFieldNotTabAble();
       }

       [TestMethod]
       public void TextBoxTabAble()
       {
           parserUiMap.TextBoxTabAble();
       }

       [TestMethod]
       public void ExpressionBoxTabAble()
       {
           parserUiMap.ExpressionBoxTabAble();
       }

       [TestMethod]
       public void ButtonTabAble()
       {
           parserUiMap.ButtonTabAble();
       }

       [TestMethod]
       public void ButtonDisabled()
       {
           parserUiMap.ButtonNotActive();
           parserUiMap.EnterText();
           parserUiMap.ButtonNotActive();
           parserUiMap.TextBoxClear();
           parserUiMap.EnterExpression();
           parserUiMap.ButtonNotActive();
       }

       [TestMethod]
       public void ButtonActive()
       {
           parserUiMap.ButtonNotActive();
           parserUiMap.EnterText();
           parserUiMap.EnterExpression();
           parserUiMap.ButtonActive();
       }

       [TestMethod]
       public void GeneralTabs()
       {
           parserUiMap.TabOrderTest();
       }
    }
}
