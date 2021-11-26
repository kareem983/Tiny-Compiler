﻿using System.Collections.Generic;

namespace TinyCompiler.Core
{
    class Compiler
    {
        public static Scanner TinyScanner = new Scanner();

        // TODO: Parser Object
        public static List<int> Lines = new List<int>();
        public static List<string> Lexemes = new List<string>();
        public static List<Token> TokenStream = new List<Token>();

        /// <summary>
        /// Start compiling source code, pass it to a Scanner, Parser and Semantic Analysis.
        /// </summary>
        /// <param name="sourceCode">Source code to compile as a string</param>
        public static void StartCompiling(string sourceCode) 
        {
            // Scanner
            TinyScanner.StartScanning(sourceCode);
            // Parser

            // Semantic Analysis
        }

    }
}
