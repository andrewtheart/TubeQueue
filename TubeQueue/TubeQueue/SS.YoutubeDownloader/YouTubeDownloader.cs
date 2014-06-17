using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;

namespace SS.YoutubeDownloader.AdvLib
{
    /// <summary>
    ///     Contains information about the video url extension and dimension
    /// </summary>
    public class YouTubeVideoQuality
    {
        /// <summary>
        ///     Gets or Sets the file name
        /// </summary>
        public string VideoTitle { get; set; }

        /// <summary>
        ///     Gets or Sets the file extention
        /// </summary>
        public string Extention { get; private set; }

        /// <summary>
        ///     Gets or Sets the file url
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        ///     Gets or Sets the youtube video url
        /// </summary>
        public string VideoUrl { get; set; }

        /// <summary>
        ///     Gets or Sets the youtube video size
        /// </summary>
        public long VideoSize { get; private set; }

        /// <summary>
        ///     Gets or Sets the youtube video dimension
        /// </summary>
        public Size Dimension { get; private set; }

        /// <summary>
        ///     Gets the youtube video length
        /// </summary>
        public long Length { get; set; }

        public override string ToString()
        {
            return Extention + " File " + Dimension.Width + "x" + Dimension.Height;
        }

        public void SetQuality(string Extention, Size Dimension)
        {
            this.Extention = Extention;
            this.Dimension = Dimension;
        }

        public void SetSize(long size)
        {
            VideoSize = size;
        }
    }

    /// <summary>
    ///     Use this class to get youtube video urls
    /// </summary>
    public static class YouTubeDownloader
    {
        public static IList<YouTubeVideoQuality> GetYouTubeVideoUrls(params string[] VideoUrls)
        {
            IList<YouTubeVideoQuality> urls = new List<YouTubeVideoQuality>();
            foreach (var VideoUrl in VideoUrls)
            {
                string html = Helper.DownloadWebPage(VideoUrl);
                string title = GetTitle(html);
                foreach (var videoLink in ExtractUrls(html))
                {
                    var quality = new YouTubeVideoQuality
                    {
                        VideoUrl = VideoUrl,
                        VideoTitle = title,
                        DownloadUrl = videoLink + "&title=" + title
                    };
                    if (!getSize(quality)) continue;
                    quality.Length =
                        long.Parse(
                            Regex.Match(html, "\"length_seconds\":(.+?),", RegexOptions.Singleline).Groups[1].ToString());
                    bool IsWide = IsWideScreen(html);
                    if (getQuality(quality, IsWide))
                        urls.Add(quality);
                }
            }
            return urls;
        }

        private static string GetTitle(string RssDoc)
        {
            string str14 = Helper.GetTxtBtwn(RssDoc, "'VIDEO_TITLE': '", "'", 0);
            if (str14 == "") str14 = Helper.GetTxtBtwn(RssDoc, "\"title\" content=\"", "\"", 0);
            if (str14 == "") str14 = Helper.GetTxtBtwn(RssDoc, "&title=", "&", 0);
            str14 =
                str14.Replace(@"\", "")
                    .Replace("'", "&#39;")
                    .Replace("\"", "&quot;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("+", " ");
            return str14;
        }

        private static IEnumerable<string> ExtractUrls(string html)
        {
            IList<string> urls = new List<string>();
            const string DataBlockStart = "\"url_encoded_fmt_stream_map\":\\s+\"(.+?)&";
                // Marks start of Javascript Data Block

            html =
                Uri.UnescapeDataString(Regex.Match(html, DataBlockStart, RegexOptions.Singleline).Groups[1].ToString());

            string firstPatren = html.Substring(0, html.IndexOf('=') + 1);
            var matchs = Regex.Split(html, firstPatren);
            for (int i = 0; i < matchs.Length; i++)
                matchs[i] = firstPatren + matchs[i];
            foreach (var match in matchs)
            {
                if (!match.Contains("url=")) continue;

                string url = Helper.GetTxtBtwn(match, "url=", "\\u0026", 0);
                if (url == "") url = Helper.GetTxtBtwn(match, "url=", ",url", 0);
                if (url == "") url = Helper.GetTxtBtwn(match, "url=", "\",", 0);

                string sig = Helper.GetTxtBtwn(match, "sig=", "\\u0026", 0);
                if (sig == "") sig = Helper.GetTxtBtwn(match, "sig=", ",sig", 0);
                if (sig == "") sig = Helper.GetTxtBtwn(match, "sig=", "\",", 0);

                while ((url.EndsWith(",")) || (url.EndsWith(".")) || (url.EndsWith("\"")))
                    url = url.Remove(url.Length - 1, 1);

                while ((sig.EndsWith(",")) || (sig.EndsWith(".")) || (sig.EndsWith("\"")))
                    sig = sig.Remove(sig.Length - 1, 1);

                if (string.IsNullOrEmpty(url)) continue;
                if (!string.IsNullOrEmpty(sig))
                    url += "&signature=" + sig;
                urls.Add(url);
            }
            return urls;
        }

        private static bool getQuality(YouTubeVideoQuality q, Boolean _Wide)
        {
            int iTagValue;
            string itag =
                Regex.Match(q.DownloadUrl, @"itag=([1-9]?[0-9]?[0-9])", RegexOptions.Singleline).Groups[1].ToString();
            if (itag != "")
            {
                if (int.TryParse(itag, out iTagValue) == false)
                    iTagValue = 0;

                switch (iTagValue)
                {
                    case 5:
                        q.SetQuality("flv", new Size(320, (_Wide ? 180 : 240)));
                        break;
                    case 6:
                        q.SetQuality("flv", new Size(480, (_Wide ? 270 : 360)));
                        break;
                    case 17:
                        q.SetQuality("3gp", new Size(176, (_Wide ? 99 : 144)));
                        break;
                    case 18:
                        q.SetQuality("mp4", new Size(640, (_Wide ? 360 : 480)));
                        break;
                    case 22:
                        q.SetQuality("mp4", new Size(1280, (_Wide ? 720 : 960)));
                        break;
                    case 34:
                        q.SetQuality("flv", new Size(640, (_Wide ? 360 : 480)));
                        break;
                    case 35:
                        q.SetQuality("flv", new Size(854, (_Wide ? 480 : 640)));
                        break;
                    case 36:
                        q.SetQuality("3gp", new Size(320, (_Wide ? 180 : 240)));
                        break;
                    case 37:
                        q.SetQuality("mp4", new Size(1920, (_Wide ? 1080 : 1440)));
                        break;
                    case 38:
                        q.SetQuality("mp4", new Size(2048, (_Wide ? 1152 : 1536)));
                        break;
                    case 43:
                        q.SetQuality("webm", new Size(640, (_Wide ? 360 : 480)));
                        break;
                    case 44:
                        q.SetQuality("webm", new Size(854, (_Wide ? 480 : 640)));
                        break;
                    case 45:
                        q.SetQuality("webm", new Size(1280, (_Wide ? 720 : 960)));
                        break;
                    case 46:
                        q.SetQuality("webm", new Size(1920, (_Wide ? 1080 : 1440)));
                        break;
                    case 82:
                        q.SetQuality("3D.mp4", new Size(480, (_Wide ? 270 : 360)));
                        break; // 3D
                    case 83:
                        q.SetQuality("3D.mp4", new Size(640, (_Wide ? 360 : 480)));
                        break; // 3D
                    case 84:
                        q.SetQuality("3D.mp4", new Size(1280, (_Wide ? 720 : 960)));
                        break; // 3D
                    case 85:
                        q.SetQuality("3D.mp4", new Size(1920, (_Wide ? 1080 : 1440)));
                        break; // 3D
                    case 100:
                        q.SetQuality("3D.webm", new Size(640, (_Wide ? 360 : 480)));
                        break; // 3D
                    case 101:
                        q.SetQuality("3D.webm", new Size(640, (_Wide ? 360 : 480)));
                        break; // 3D
                    case 102:
                        q.SetQuality("3D.webm", new Size(1280, (_Wide ? 720 : 960)));
                        break; // 3D
                    case 120:
                        q.SetQuality("live.flv", new Size(1280, (_Wide ? 720 : 960)));
                        break; // Live-streaming - should be ignored?
                    default:
                        q.SetQuality("itag-" + itag, new Size(0, 0));
                        break; // unknown or parse error
                }
                return true;
            }
            return false;
        }

        /// <summary>
        ///     check whether the video is in widescreen format
        /// </summary>
        public static Boolean IsWideScreen(string html)
        {
            bool res = false;

            string match =
                Regex.Match(html, @"'IS_WIDESCREEN':\s+(.+?)\s+", RegexOptions.Singleline).Groups[1].ToString()
                    .ToLower()
                    .Trim();
            res = ((match == "true") || (match == "true,"));
            return res;
        }

        private static bool getSize(YouTubeVideoQuality q)
        {
            try
            {
                var fileInfoRequest = (HttpWebRequest) WebRequest.Create(q.DownloadUrl);
                var fileInfoResponse = (HttpWebResponse) fileInfoRequest.GetResponse();
                long bytesLength = fileInfoResponse.ContentLength;
                fileInfoRequest.Abort();
                if (bytesLength != -1)
                {
                    q.SetSize(bytesLength);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}