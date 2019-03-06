using System;
using System.IO;

namespace HwQueryMasterTest
{
    internal class WrapManager
    {
        internal static string Wrap(IStrategy strategy)
        {
            throw new NotImplementedException();
        }

        internal static bool WrapToText(string queries)
        {
            try
            {
                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "QueryScript.txt"), queries);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        internal static string WrapToJson(object queries)
        {
            throw new NotImplementedException();
        }

        internal static string WrapToXml(object queries)
        {
            throw new NotImplementedException();
        }

        internal static string WrapToDb(object queries)
        {
            throw new NotImplementedException();
        }
    }
}