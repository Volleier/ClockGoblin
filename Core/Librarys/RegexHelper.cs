﻿using System;
using System.Text.RegularExpressions;

namespace Core.Librarys
{
    public static class RegexHelper
    {
        /// <summary>
        /// 是否正则匹配成功
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(string input, string pattern)
        {
            try
            {
                return Regex.IsMatch(input, pattern);
            }
            catch (Exception ex)
            {
                Logger.Error("正则表达式错误。" + ex.ToString());
                return false;
            }
        }
    }
}
