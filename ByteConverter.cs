using System;
namespace ByteConverter
{
    public class ByteConverter
    {
        /// <summary>
        /// Converts bytes to a human readable unit. KB, MB, GB, TB etc..
        /// Returns the value as a string.
        /// </summary>
        /// <param name="bytes">number of bytes as a long</param>
        /// <returns></returns>
        public string HumanReadableBytes(long bytes)
        {
            var unitSuffix = new[] { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB"}; //Longs run out around an Exabyte.
            var i = bytes == 0 ? 0 : Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            return $"{(bytes/Math.Pow(1024, i)):N0} {unitSuffix[i]}";
        }
    }
}