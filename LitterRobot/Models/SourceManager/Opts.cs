using System;

namespace LitterRobot.Models.SourceManager
{
    /// <summary>
    /// The source options
    /// </summary>
    public class Opts
    {
        public const string Section = "LitterRobot";

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Login { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TimeSpan PollingInterval { get; set; } = new TimeSpan(0, 0, 31);
    }
}