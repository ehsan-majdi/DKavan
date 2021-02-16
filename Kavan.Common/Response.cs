using System;

namespace Kavan.Common
{
    /// <summary>
    /// شی بازگشتی برای درخواست های اجکس
    /// </summary>
    public class Response
    {
        /// <summary>
        /// وضعیت
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// پیام سیستم
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// پاسخ بازگشتی
        /// </summary>
        public object data { get; set; }
    }
}
