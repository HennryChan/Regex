using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

    public class UserDefinefFunctions
    {
        public static readonly RegexOptions OptipnRegex = RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace;

        [SqlFunction]
        public static SqlBoolean RegexMatch(SqlChars input, SqlString pattern) => (SqlBoolean)new Regex(pattern.Value, UserDefinefFunctions.OptipnRegex).IsMatch(new string(input.Value));
    }
