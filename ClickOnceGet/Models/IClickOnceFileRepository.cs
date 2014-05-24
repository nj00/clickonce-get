﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOnceGet.Models
{
    public interface IClickOnceFileRepository
    {
        byte[] GetFileContent(string appName, string subPath);

        bool GetOwnerRight(string userId, string appName);

        void ClearUpFiles(string appName);

        void SaveFileContent(string appName, string subPath, byte[] contents);

        IEnumerable<ClickOnceAppInfo> EnumAllApps();

        void DeleteApp(string appName);
    }
}
