// <copyright file=Downloads>
// Copyright (c) 2019-2020 All Rights Reserved
// </copyright>
// <author>Franco28</author>
// <date> 29/1/2020 13:16:41</date>
// <summary>A DLL Lib needed by Redmi Note 7 Tool</summary>

namespace Franco28Tool.Engine
{
    public class Downloads
    {
        public static void downloadcall(string title, string url, string path)
        {
            var downloads = new DownloadEngineVisual();
            downloads.Show();
            downloads.Text = title;
            downloads.startDownload(url, path);
        }
    }
}
