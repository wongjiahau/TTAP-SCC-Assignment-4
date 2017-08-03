﻿using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using NUnit.Framework;
using Time_Table_Arranging_Program;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.Converter;
using Time_Table_Arranging_Program.Class.TokenParser;

namespace NUnit.Tests2 {
    [TestFixture]
    public class Test_HtmlSlotParser {
        [Test]
        public void Test_HtmlSlotParser_1() {
            string input = Helper.RawStringOfTestFile("Sample HTML.txt");
            var result = new HtmlSlotParser().Parse(input);
            Test_SlotParser.TestForResultCorrectness(result);         
        }

        [Test]
        public void Test_HtmlSlotParser_2() {
            string input = Helper.RawStringOfTestFile("Sample HTML.txt");
            var result = new HtmlSlotParser().Parse(input);
            var expectedUids = new HashSet<int>();
            for (int i = 1; i <= 130; i++) {
                expectedUids.Add(i);
            }
            var actualUids = new HashSet<int>();
            for (int i = 0; i < result.Count; i++) {
                actualUids.Add(result[i].UID);
            }
            Assert.IsTrue(expectedUids.SetEquals(actualUids));
        }
    }
}
