using Core.Models.AppObserver;
using System;

namespace Core.Servicers.Interfaces
{
    public interface IWindowManager
    {
        /// <summary>
        /// 获取窗口信息
        /// </summary>
        /// <param name="handle_">窗口句柄</param>
        /// <returns></returns>
        WindowInfo GetWindowInfo(IntPtr handle_);
    }
}
