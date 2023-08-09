using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*  XML Documentation */
    /// <summary>
    /// The Main Generator Class
    /// </summary>
    /// <remarks>
    /// This Class can Generate Employee Ids and Password 
    /// </remarks>
    public class Generator
    {
        public static int LAstIdSequence { get; private set; } = 1;
        /// <include file='Generator.xml' path='docs/members[@name="generator"]/GenerteId/'/>    -> دي بدال اللي بعدها كلها "External XML Documentation";
        //////////////////////////////////////////////
        /// <summary>
        /// Generate Employee Id by processing <paramref name="fname"/>, <paramref name="lname"/>, <paramref name="hireDate"/>
        /// <list type="bullet">
        /// <item>
        /// <term>II</term>
        /// <description>Employee initials (first letter of <paramref name="lname"/> and first letter of <paramref name="fname"/>)</description>
        /// </item>
        /// <item>
        /// <term>YY</term>
        /// <description>hire date 2 Digit year</description>
        /// </item>
        /// <item>
        /// <term>MM</term>
        /// <description>hire date 2 Digite month</description>
        /// </item
        /// <item>
        /// <term>DD</term>
        /// <description>hire Date 2 Digit day</description>
        /// </item>>    
        /// <item>
        /// <term>SS</term>
        /// <description>Sequence no. of (01-99)</description>
        /// </item>
        /// </list>
        /// </summary>      
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="hireDate"></param>
        /// <example>
        /// <code>
        /// var id = Generator.Generate("john", "swith", new DataTime(2023, 08, 15, 0, 0, 0);
        /// Console.writeLine(id);
        /// </code>
        /// </example>
        /// <returns>
        /// Employee Id as a string
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="fname"/> is null</exception>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="lname"/> is null</exception>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="hireDate"/> is in the past</exception>

        public static string GenerateId(string fname, string lname, DateTime? hireDate)
        {
            // II YY MM DD 01  -> ID

            if (fname is null)
                throw new InvalidOperationException($"{nameof(fname)} can not be null");
            if (lname is null)
                throw new InvalidOperationException($"{nameof(lname)} can not be null");
            if(hireDate is null)
            {
                hireDate = DateTime.Now;
            }
            else
            {
                if(hireDate.Value.Date < DateTime.Now)      // yyyy-MM-dd hh:mm:ss
                {
                    throw new InvalidOperationException($"{nameof(hireDate)} can not be in the past");
                }
            }

            var yy = hireDate.Value.ToString("yy");
            var MM = hireDate.Value.ToString("MM");
            var dd = hireDate.Value.ToString("dd");

            var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]} {yy} {MM} {dd} {LAstIdSequence++.ToString().PadLeft(2, '0')}";

            return code;
        }

        public static string GenerateRandomPassword(int length)
        {
            const string ValidScope = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var result = "";

            Random rnd = new Random();

            while (0 < length--)
            {
                result += (ValidScope[rnd.Next(ValidScope.Length)]);
            }
            return result;
        }
    }
}
