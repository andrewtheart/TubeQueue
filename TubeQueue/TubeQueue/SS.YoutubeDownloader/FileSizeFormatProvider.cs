using System;

namespace SS.YoutubeDownloader.AdvLib
{
    public class FileSizeFormatProvider : IFormatProvider, ICustomFormatter
    {
        private const string fileSizeFormat = "fs";
        private const Decimal OneKiloByte = 1024M;
        private const Decimal OneMegaByte = OneKiloByte*1024M;
        private const Decimal OneGigaByte = OneMegaByte*1024M;

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format == null || !format.StartsWith(fileSizeFormat))
            {
                return defaultFormat(format, arg, formatProvider);
            }

            if (arg is string)
            {
                return defaultFormat(format, arg, formatProvider);
            }

            Decimal size;

            try
            {
                size = Convert.ToDecimal(arg);
            }
            catch (InvalidCastException)
            {
                return defaultFormat(format, arg, formatProvider);
            }

            string suffix;
            if (size > OneGigaByte)
            {
                size /= OneGigaByte;
                suffix = "GB/sec";
            }
            else if (size > OneMegaByte)
            {
                size /= OneMegaByte;
                suffix = "MB/sec";
            }
            else if (size > OneKiloByte)
            {
                size /= OneKiloByte;
                suffix = "KB/sec";
            }
            else
            {
                suffix = "Bytes/sec";
            }

            string precision = format.Substring(2);
            if (String.IsNullOrEmpty(precision)) precision = "2";
            return String.Format("{0:N" + precision + "}{1}", size, " " + suffix);
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof (ICustomFormatter)) return this;
            return null;
        }

        private static string defaultFormat(string format, object arg, IFormatProvider formatProvider)
        {
            var formattableArg = arg as IFormattable;
            if (formattableArg != null)
            {
                return formattableArg.ToString(format, formatProvider);
            }
            return arg.ToString();
        }
    }
}