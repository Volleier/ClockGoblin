﻿using System.ComponentModel.DataAnnotations;

namespace Core.Models.Db
{
    /// <summary>
    /// 网页链接模型
    /// </summary>
    public class WebUrlModel
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string IconFile { get; set; }
    }
}
