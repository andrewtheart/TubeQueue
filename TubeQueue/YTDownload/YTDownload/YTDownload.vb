Public Class YTDownload

    Private ytUrl As String
    Private fUrls As New Dictionary(Of String, String)
    Private Title As String

    Public Sub New(ByVal url As String)
        GenerateLinks(url)
    End Sub

    ReadOnly Property getTitle() As String
        Get
            Return Title
        End Get
    End Property


    ReadOnly Property GetAllUrls() As Dictionary(Of String, String)
        Get
            Return fUrls
        End Get

    End Property

    Private Sub GenerateLinks(ByVal Url As String)
        Try
            'videoInfo.Items.Clear()
            Dim ID = Web.HttpUtility.ParseQueryString((New Uri(Url)).Query)("v")
            Dim videoInfo_ = Web.HttpUtility.ParseQueryString(New Net.WebClient().DownloadString(String.Format("http://www.youtube.com/get_video_info?&video_id={0}&el=detailpage&ps=default&eurl=&gl=US&hl=en", ID)))
            Dim availableFormats = videoInfo_("url_encoded_fmt_stream_map")
            If availableFormats = String.Empty Then
                Return
            End If
            Dim formatList = New List(Of String)(System.Text.RegularExpressions.Regex.Split(availableFormats, ","))
            formatList.ForEach(Sub(format As String)
                                   If String.IsNullOrEmpty(format.Trim()) Then
                                       Return
                                   End If
                                   Dim formatInfo = Web.HttpUtility.ParseQueryString(format)
                                   Dim urlEncoded = formatInfo("url")
                                   urlEncoded = String.Format("{0}&fallback_host={1}&signature={2}", urlEncoded, formatInfo("fallback_host"), formatInfo("sig"))
                                   Dim VideoTitle = videoInfo_("title")
                                   VideoTitle = System.Text.RegularExpressions.Regex.Replace(VideoTitle, "[:\*\?""\<\>\|]", String.Empty)
                                   VideoTitle = VideoTitle.Replace("\", "-").Replace("/", "-").Trim()
                                   If String.IsNullOrEmpty(VideoTitle) Then
                                       VideoTitle = ID
                                   End If
                                   Dim finalURL = Web.HttpUtility.UrlDecode(urlEncoded)
                                   Dim fileName As String = VideoTitle & GetExtension(finalURL)
                                   fUrls.Item(GetInfo(finalURL)) = finalURL

                                   Dim theId As String = ID

                                   Title = VideoTitle

                               End Sub)
        Catch ex As Exception
            MsgBox(ex.StackTrace, MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

    Function GetExtension(ByVal e As String) As String
        If e.Contains("itag=34") OrElse e.Contains("itag=35") OrElse e.Contains("itag=5") OrElse e.Contains("itag=6") OrElse e.Contains("itag=120") Then
            Return ".FLV"
        ElseIf e.Contains("itag=18") OrElse e.Contains("itag=22") OrElse e.Contains("itag=37") OrElse e.Contains("itag=38") OrElse e.Contains("itag=82") OrElse e.Contains("itag=83") OrElse e.Contains("itag=84") OrElse e.Contains("itag=85") Then
            Return ".MP4"
        ElseIf e.Contains("itag=13") OrElse e.Contains("itag=17") OrElse e.Contains("itag=36") Then
            Return ".3GP"
        ElseIf e.Contains("itag=43") OrElse e.Contains("itag=44") OrElse e.Contains("itag=45") OrElse e.Contains("itag=46") OrElse e.Contains("itag=100") OrElse e.Contains("itag=101") OrElse e.Contains("itag=102") Then
            Return ".WebM"
        End If
        Return ".Unknown"
    End Function

    Function GetInfo(ByVal e As String) As String
        '3GP
        If e.Contains("itag=13") Then
            Return "3GP MPEG-4 Visual 0.5 AAC"
        ElseIf e.Contains("itag=17") Then
            Return "3GP 144p MPEG-4 Visual Simple 0.05 AAC 24k"
        ElseIf e.Contains("itag=36") Then
            Return "3GP 240p MPEG-4 Visual Simple 0.17 AAC 38k"
            'FLV
        ElseIf e.Contains("itag=5") Then
            Return "FLV 240p Sorenson H.263 0.25 MP3 64k"
        ElseIf e.Contains("itag=6") Then
            Return "FLV 270p Sorenson H.263 0.8 MP3 64k"
        ElseIf e.Contains("itag=34") Then
            Return "FLV 360p H.264 Main 0.5 AAC 128k"
        ElseIf e.Contains("itag=35") Then
            Return "FLV 480p H.264 Main 0.8-1 AAC 128k"
        ElseIf e.Contains("itag=120") Then
            Return "FLV 720p AVC Main@L3.1 2 AAC 128k"
            'MP4
        ElseIf e.Contains("itag=18") Then
            Return "MP4 360p H.264 Baseline 0.5 AAC 96k"
        ElseIf e.Contains("itag=22") Then
            Return "MP4 720p H.264 High 2-2.9 AAC 192k"
        ElseIf e.Contains("itag=37") Then
            Return "MP4 1080p H.264 High 3–4.3 AAC 192k"
        ElseIf e.Contains("itag=38") Then
            Return "MP4 3072p H.264 High 3.5-5 AAC 192k"
        ElseIf e.Contains("itag=82") Then
            Return "MP4 360p H.264 3D 0.5 AAC 96k"
        ElseIf e.Contains("itag=83") Then
            Return "MP4 240p H.264 3D 0.5 AAC 96k"
        ElseIf e.Contains("itag=84") Then
            Return "MP4 720p H.264 3D 2-2.9 AAC 152k"
        ElseIf e.Contains("itag=85") Then
            Return "MP4 520p H.264 3D 2-2.9 AAC 152k"
            'WebM
        ElseIf e.Contains("itag=43") Then
            Return "WebM 360p VP8 0.5 Vorbis 128k"
        ElseIf e.Contains("itag=44") Then
            Return "WebM 480p VP8 1 Vorbis 128k"
        ElseIf e.Contains("itag=45") Then
            Return "WebM 720p VP8 2 Vorbis 192k"
        ElseIf e.Contains("itag=46") Then
            Return "WebM 1080p VP8 Vorbis 192k"
        ElseIf e.Contains("itag=100") Then
            Return "WebM 360p VP8 3D Vorbis 128k"
        ElseIf e.Contains("itag=101") Then
            Return "WebM 360p VP8 3D Vorbis 192k"
        ElseIf e.Contains("itag=102") Then
            Return "WebM 720p VP8 3D Vorbis 192k"
        End If
        Return "Unknown"
    End Function
End Class
