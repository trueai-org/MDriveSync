﻿using MDriveSync.Core.DB;
using ServiceStack.DataAnnotations;

namespace MDriveSync.Core
{
    /// <summary>
    /// 本地文件信息
    /// </summary>
    public class LocalFileInfo : IBaseKey<string> // : INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName = null)
        //{
        //    Console.WriteLine("值更新: " + propertyName);

        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //    if (nameof(UpdateId) != propertyName)
        //    {
        //        UpdateId = Guid.NewGuid().ToString();
        //    }
        //}

        /// <summary>
        /// 本地完整路径
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// 相对路径
        /// 不包含 / 前缀
        /// </summary>
        [PrimaryKey]
        public string Key { get; set; }

        /// <summary>
        /// 文件 key 对应的路径
        /// </summary>
        public string KeyPath { get; set; }

        /// <summary>
        /// 是否为文件
        /// </summary>
        public bool IsFile { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 文件大小（字节数）
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 获取或设置文件的创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 获取或设置上次写入文件的时间
        /// </summary>
        public DateTime LastWriteTime { get; set; }

        /// <summary>
        /// 文件对比 hash 值
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// 文件内容 sha1 值
        /// </summary>
        public string Sha1 { get; set; }

        /// <summary>
        /// 是否已同步
        /// </summary>
        public bool IsSync { get; set; }

        /// <summary>
        /// 云文件ID
        /// </summary>
        public string AliyunFileId { get; set; }

        /// <summary>
        /// 云文件名
        /// </summary>
        public string AliyunName { get; set; }

        /// <summary>
        /// 云文件内容哈希
        /// </summary>
        public string AliyunContentHash { get; set; }

        ///// <summary>
        ///// 更新标识，如果字段有变更，则标识重新赋值
        ///// 可以用于字段变更后，是否需要更新到数据库
        ///// </summary>
        //[Ignore]
        //public string UpdateId { get; private set; }
    }
}