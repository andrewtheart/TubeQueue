using System;
using System.Runtime.InteropServices;

namespace HSToolKit.MessagesWin32
{

    public enum Win32L : long
    {
        WS_EX_TOOLWINDOW          = 0x00000080L
    };

    public enum Win32UI : uint
    {
        SWP_NOSIZE          = 0x0001,
        SWP_NOMOVE          = 0x0002,
        SWP_NOZORDER        = 0x0004,
        SWP_NOREDRAW        = 0x0008,
        SWP_NOACTIVATE      = 0x0010,
        SWP_FRAMECHANGED    = 0x0020, /* The frame changed: send WM_NCCALCSIZE */
        SWP_SHOWWINDOW      = 0x0040,
        SWP_HIDEWINDOW      = 0x0080,
        SWP_NOCOPYBITS      = 0x0100,
        SWP_NOOWNERZORDER   = 0x0200, /* Don't do owner Z ordering */
        SWP_NOSENDCHANGING  = 0x0400, /* Don't send WM_WINDOWPOSCHANGING */
        SWP_DRAWFRAME       = SWP_FRAMECHANGED,
        SWP_NOREPOSITION    = SWP_NOOWNERZORDER,
        SWP_DEFERERASE      = 0x2000,
        SWP_ASYNCWINDOWPOS  = 0x4000
    };


    /// <summary>
    /// Windows message codes WM_
    /// </summary>
    public enum Win32 : int
    {
        WM_NULL                   = 0x0000,
        WM_CREATE                 = 0x0001,
        WM_DESTROY                = 0x0002,
        WM_MOVE                   = 0x0003,
        WM_SIZE                   = 0x0005,
        WM_ACTIVATE               = 0x0006,
        WM_SETFOCUS               = 0x0007,
        WM_KILLFOCUS              = 0x0008,
        WM_ENABLE                 = 0x000A,
        WM_SETREDRAW              = 0x000B,
        WM_SETTEXT                = 0x000C,
        WM_GETTEXT                = 0x000D,
        WM_GETTEXTLENGTH          = 0x000E,
        WM_PAINT                  = 0x000F,
        WM_CLOSE                  = 0x0010,
        WM_QUERYENDSESSION        = 0x0011,
        WM_QUIT                   = 0x0012,
        WM_QUERYOPEN              = 0x0013,
        WM_ERASEBKGND             = 0x0014,
        WM_SYSCOLORCHANGE         = 0x0015,
        WM_ENDSESSION             = 0x0016,
        WM_SHOWWINDOW             = 0x0018,
        WM_CTLCOLOR               = 0x0019,
        WM_WININICHANGE           = 0x001A,
        WM_SETTINGCHANGE          = 0x001A,
        WM_DEVMODECHANGE          = 0x001B,
        WM_ACTIVATEAPP            = 0x001C,
        WM_FONTCHANGE             = 0x001D,
        WM_TIMECHANGE             = 0x001E,
        WM_CANCELMODE             = 0x001F,
        WM_SETCURSOR              = 0x0020,
        WM_MOUSEACTIVATE          = 0x0021,
        WM_CHILDACTIVATE          = 0x0022,
        WM_QUEUESYNC              = 0x0023,
        WM_GETMINMAXINFO          = 0x0024,
        WM_PAINTICON              = 0x0026,
        WM_ICONERASEBKGND         = 0x0027,
        WM_NEXTDLGCTL             = 0x0028,
        WM_SPOOLERSTATUS          = 0x002A,
        WM_DRAWITEM               = 0x002B,
        WM_MEASUREITEM            = 0x002C,
        WM_DELETEITEM             = 0x002D,
        WM_VKEYTOITEM             = 0x002E,
        WM_CHARTOITEM             = 0x002F,
        WM_SETFONT                = 0x0030,
        WM_GETFONT                = 0x0031,
        WM_SETHOTKEY              = 0x0032,
        WM_GETHOTKEY              = 0x0033,
        WM_QUERYDRAGICON          = 0x0037,
        WM_COMPAREITEM            = 0x0039,
        WM_GETOBJECT              = 0x003D,
        WM_COMPACTING             = 0x0041,
        WM_COMMNOTIFY             = 0x0044 ,
        WM_WINDOWPOSCHANGING      = 0x0046,
        WM_WINDOWPOSCHANGED       = 0x0047,
        WM_POWER                  = 0x0048,
        WM_COPYDATA               = 0x004A,
        WM_CANCELJOURNAL          = 0x004B,
        WM_NOTIFY                 = 0x004E,
        WM_INPUTLANGCHANGEREQUEST = 0x0050,
        WM_INPUTLANGCHANGE        = 0x0051,
        WM_TCARD                  = 0x0052,
        WM_HELP                   = 0x0053,
        WM_USERCHANGED            = 0x0054,
        WM_NOTIFYFORMAT           = 0x0055,
        WM_CONTEXTMENU            = 0x007B,
        WM_STYLECHANGING          = 0x007C,
        WM_STYLECHANGED           = 0x007D,
        WM_DISPLAYCHANGE          = 0x007E,
        WM_GETICON                = 0x007F,
        WM_SETICON                = 0x0080,
        WM_NCCREATE               = 0x0081,
        WM_NCDESTROY              = 0x0082,
        WM_NCCALCSIZE             = 0x0083,
        WM_NCHITTEST              = 0x0084,
        WM_NCPAINT                = 0x0085,
        WM_NCACTIVATE             = 0x0086,
        WM_GETDLGCODE             = 0x0087,
        WM_SYNCPAINT              = 0x0088,
        WM_NCMOUSEMOVE            = 0x00A0,
        WM_NCLBUTTONDOWN          = 0x00A1,
        WM_NCLBUTTONUP            = 0x00A2,
        WM_NCLBUTTONDBLCLK        = 0x00A3,
        WM_NCRBUTTONDOWN          = 0x00A4,
        WM_NCRBUTTONUP            = 0x00A5,
        WM_NCRBUTTONDBLCLK        = 0x00A6,
        WM_NCMBUTTONDOWN          = 0x00A7,
        WM_NCMBUTTONUP            = 0x00A8,
        WM_NCMBUTTONDBLCLK        = 0x00A9,
        WM_KEYDOWN                = 0x0100,
        WM_KEYUP                  = 0x0101,
        WM_CHAR                   = 0x0102,
        WM_DEADCHAR               = 0x0103,
        WM_SYSKEYDOWN             = 0x0104,
        WM_SYSKEYUP               = 0x0105,
        WM_SYSCHAR                = 0x0106,
        WM_SYSDEADCHAR            = 0x0107,
        WM_KEYLAST                = 0x0108,
        WM_IME_STARTCOMPOSITION   = 0x010D,
        WM_IME_ENDCOMPOSITION     = 0x010E,
        WM_IME_COMPOSITION        = 0x010F,
        WM_IME_KEYLAST            = 0x010F,
        WM_INITDIALOG             = 0x0110,
        WM_COMMAND                = 0x0111,
        WM_SYSCOMMAND             = 0x0112,
        WM_TIMER                  = 0x0113,
        WM_HSCROLL                = 0x0114,
        WM_VSCROLL                = 0x0115,
        WM_INITMENU               = 0x0116,
        WM_INITMENUPOPUP          = 0x0117,
        WM_MENUSELECT             = 0x011F,
        WM_MENUCHAR               = 0x0120,
        WM_ENTERIDLE              = 0x0121,
        WM_MENURBUTTONUP          = 0x0122,
        WM_MENUDRAG               = 0x0123,
        WM_MENUGETOBJECT          = 0x0124,
        WM_UNINITMENUPOPUP        = 0x0125,
        WM_MENUCOMMAND            = 0x0126,
        WM_CTLCOLORMSGBOX         = 0x0132,
        WM_CTLCOLOREDIT           = 0x0133,
        WM_CTLCOLORLISTBOX        = 0x0134,
        WM_CTLCOLORBTN            = 0x0135,
        WM_CTLCOLORDLG            = 0x0136,
        WM_CTLCOLORSCROLLBAR      = 0x0137,
        WM_CTLCOLORSTATIC         = 0x0138,
        WM_MOUSEMOVE              = 0x0200,
        WM_LBUTTONDOWN            = 0x0201,
        WM_LBUTTONUP              = 0x0202,
        WM_LBUTTONDBLCLK          = 0x0203,
        WM_RBUTTONDOWN            = 0x0204,
        WM_RBUTTONUP              = 0x0205,
        WM_RBUTTONDBLCLK          = 0x0206,
        WM_MBUTTONDOWN            = 0x0207,
        WM_MBUTTONUP              = 0x0208,
        WM_MBUTTONDBLCLK          = 0x0209,
        WM_MOUSEWHEEL             = 0x020A,
        WM_PARENTNOTIFY           = 0x0210,
        WM_ENTERMENULOOP          = 0x0211,
        WM_EXITMENULOOP           = 0x0212,
        WM_NEXTMENU               = 0x0213,
        WM_SIZING                 = 0x0214,
        WM_CAPTURECHANGED         = 0x0215,
        WM_MOVING                 = 0x0216,
        WM_DEVICECHANGE           = 0x0219,
        WM_MDICREATE              = 0x0220,
        WM_MDIDESTROY             = 0x0221,
        WM_MDIACTIVATE            = 0x0222,
        WM_MDIRESTORE             = 0x0223,
        WM_MDINEXT                = 0x0224,
        WM_MDIMAXIMIZE            = 0x0225,
        WM_MDITILE                = 0x0226,
        WM_MDICASCADE             = 0x0227,
        WM_MDIICONARRANGE         = 0x0228,
        WM_MDIGETACTIVE           = 0x0229,
        WM_MDISETMENU             = 0x0230,
        WM_ENTERSIZEMOVE          = 0x0231,
        WM_EXITSIZEMOVE           = 0x0232,
        WM_DROPFILES              = 0x0233,
        WM_MDIREFRESHMENU         = 0x0234,
        WM_IME_SETCONTEXT         = 0x0281,
        WM_IME_NOTIFY             = 0x0282,
        WM_IME_CONTROL            = 0x0283,
        WM_IME_COMPOSITIONFULL    = 0x0284,
        WM_IME_SELECT             = 0x0285,
        WM_IME_CHAR               = 0x0286,
        WM_IME_REQUEST            = 0x0288,
        WM_IME_KEYDOWN            = 0x0290,
        WM_IME_KEYUP              = 0x0291,
        WM_MOUSEHOVER             = 0x02A1,
        WM_MOUSELEAVE             = 0x02A3,
        WM_CUT                    = 0x0300,
        WM_COPY                   = 0x0301,
        WM_PASTE                  = 0x0302,
        WM_CLEAR                  = 0x0303,
        WM_UNDO                   = 0x0304,
        WM_RENDERFORMAT           = 0x0305,
        WM_RENDERALLFORMATS       = 0x0306,
        WM_DESTROYCLIPBOARD       = 0x0307,
        WM_DRAWCLIPBOARD          = 0x0308,
        WM_PAINTCLIPBOARD         = 0x0309,
        WM_VSCROLLCLIPBOARD       = 0x030A,
        WM_SIZECLIPBOARD          = 0x030B,
        WM_ASKCBFORMATNAME        = 0x030C,
        WM_CHANGECBCHAIN          = 0x030D,
        WM_HSCROLLCLIPBOARD       = 0x030E,
        WM_QUERYNEWPALETTE        = 0x030F,
        WM_PALETTEISCHANGING      = 0x0310,
        WM_PALETTECHANGED         = 0x0311,
        WM_HOTKEY                 = 0x0312,
        WM_PRINT                  = 0x0317,
        WM_PRINTCLIENT            = 0x0318,
        WM_HANDHELDFIRST          = 0x0358,
        WM_HANDHELDLAST           = 0x035F,
        WM_AFXFIRST               = 0x0360,
        WM_AFXLAST                = 0x037F,
        WM_PENWINFIRST            = 0x0380,
        WM_PENWINLAST             = 0x038F,
        WM_APP                    = 0x8000,
        WM_USER                   = 0x0400,
        WM_REFLECT                = WM_USER + 0x1c00,
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        /*
         * More System Menu Command Values added 10/03/2007
         */
        SC_SIZE                   = 0xF000,
        SC_MOVE                   = 0xF010,
        SC_MINIMIZE               = 0xF020,
        SC_MAXIMIZE               = 0xF030,
        SC_NEXTWINDOW             = 0xF040,
        SC_PREVWINDOW             = 0xF050,
        SC_CLOSE                  = 0xF060,
        SC_VSCROLL                = 0xF070,
        SC_HSCROLL                = 0xF080,
        SC_MOUSEMENU              = 0xF090,
        SC_KEYMENU                = 0xF100,
        SC_ARRANGE                = 0xF110,
        SC_RESTORE                = 0xF120, // added 09/15/07 for Stacker app
        SC_TASKLIST               = 0xF130,
        SC_SCREENSAVE             = 0xF140,
        SC_HOTKEY                 = 0xF150, // added 09/15/07 for Stacker app
        SC_DEFAULT                = 0xF160,
        SC_MONITORPOWER           = 0xF170,
        SC_CONTEXTHELP            = 0xF180,
        SC_SEPARATOR              = 0xF00F,
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        /*
         * ShowWindow() Commands // added 09/15/07 for Stacker app
         */
        SW_HIDE                   = 0,
        SW_SHOWNORMAL             = 1,
        SW_NORMAL                 = 1,
        SW_SHOWMINIMIZED          = 2,
        SW_SHOWMAXIMIZED          = 3,
        SW_MAXIMIZE               = 3,
        SW_SHOWNOACTIVATE         = 4,
        SW_SHOW                   = 5,
        SW_MINIMIZE               = 6,
        SW_SHOWMINNOACTIVE        = 7,
        SW_SHOWNA                 = 8,
        SW_RESTORE                = 9,
        SW_SHOWDEFAULT            = 10,
        SW_FORCEMINIMIZE          = 11,
        SW_MAX                    = 11,
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        KEYEVENTF_EXTENDEDKEY     = 0x0001, // added 09/15/07 for Stacker app
        KEYEVENTF_KEYUP           = 0x0002, // added 09/15/07 for Stacker app
        KEYEVENTF_UNICODE         = 0x0004,
        KEYEVENTF_SCANCODE        = 0x0008,

        SB_HORZ             = 0,
        SB_VERT             = 1,
        SB_CTL              = 2,
        SB_BOTH             = 3,
        /*
         * Scroll Bar Commands
         */
        SB_LINEUP           = 0,
        SB_LINELEFT         = 0,
        SB_LINEDOWN         = 1,
        SB_LINERIGHT        = 1,
        SB_PAGEUP           = 2,
        SB_PAGELEFT         = 2,
        SB_PAGEDOWN         = 3,
        SB_PAGERIGHT        = 3,
        SB_THUMBPOSITION    = 4,
        SB_THUMBTRACK       = 5,
        SB_TOP              = 6,
        SB_LEFT             = 6,
        SB_BOTTOM           = 7,
        SB_RIGHT            = 7,
        SB_ENDSCROLL        = 8,
        MK_LBUTTON          = 0x0001,
        GW_HWNDNEXT         = 2,
        GW_HWNDPREV         = 3,
        GW_CHILD            = 5,
        /*
         * Window field offsets for GetWindowLong()
         */
        GWL_WNDPROC         = -4,
        GWL_HINSTANCE       = -6,
        GWL_HWNDPARENT      = -8,
        GWL_STYLE           = -16,
        GWL_EXSTYLE         = -20,
        GWL_USERDATA        = -21,
        GWL_ID              = -12,
        INPUT_MOUSE         = 0,
        INPUT_KEYBOARD      = 1,
        INPUT_HARDWARE      = 2,
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }; // end public enum Win32 : int

    [Flags] public enum SendMessageTimeoutFlags : uint
    {
        SMTO_NORMAL         = 0x0000,
        SMTO_BLOCK          = 0x0001,
        SMTO_ABORTIFHUNG    = 0x0002,
        SMTO_NOTIMEOUTIFNOTHUNG = 0x0008
    }

    //namespace HPSStructs.Win32
    //{
    [StructLayout(LayoutKind.Sequential)]
    public struct NMHDR
    {
        public IntPtr   hwndFrom;
        public int      idFrom;
        public int      code;
    }

    [ StructLayout(LayoutKind.Explicit) ]
    public struct INPUT
    {
        [FieldOffset(0)] public char chVal;
        [FieldOffset(0)] public int  type;
        [FieldOffset(4)] public MOUSEINPUT mi;
        [FieldOffset(4)] public KEYBDINPUT ki;
        [FieldOffset(4)] public HARDWAREINPUT hi;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSEINPUT {
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        IntPtr dwExtraInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct KEYBDINPUT
    {
        public short    wVk;
        public short    wScan;
        public int      dwFlags;
        public int      time;
        public IntPtr   dwExtraInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct HARDWAREINPUT
    {
        public int   uMsg;
        public short wParamL;
        public short wParamH;
    }

    [StructLayout(LayoutKind.Sequential)]
    // hstein
    public struct ColorRef
    {
        public byte red, green, blue;
        private byte unused;
        public ColorRef(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
            unused = 0;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    // http://www.flounder.com/csharpfactoids.htm

    [StructLayout(LayoutKind.Sequential)]
    public struct NMTVCUSTOMDRAW // for Tree View
    {
        NMCUSTOMDRAW nmcd;
        ColorRef     clrText;
        ColorRef     clrTextBk;
        int         iLevel;
        }; // NMTVCUSTOMDRAW, *LPNMTVCUSTOMDRAW;
    
    [StructLayout(LayoutKind.Sequential)]
    public struct NMLVCUSTOMDRAW // for List View
    {
        NMCUSTOMDRAW nmcd;
        ColorRef    clrText;
        ColorRef    clrTextBk;
        int         iSubItem;
        uint        dwItemType;  //DWORD
        // Item custom draw
        ColorRef    clrFace;
        int         iIconEffect;
        int         iIconPhase;
        int         iPartId;
        int         iStateId;
        // Group Custom Draw
        RECT        rcText;
        uint        uAlign; // Alignment. Use LVGA_HEADER_CENTER, LVGA_HEADER_RIGHT, LVGA_HEADER_LEFT
    };// NMLVCUSTOMDRAW, *LPNMLVCUSTOMDRAW;


    [StructLayout(LayoutKind.Sequential,CharSet=CharSet.Auto)]
    public struct NMCUSTOMDRAW
    {
        public NMHDR    hdr;
        public int      dwDrawStage;
        public IntPtr   hdc;
        public RECT     rc;
        public int      dwItemSpec;
        public int      uItemState;
        public int      lItemlParam;
    }
    //}
    // see http://msdn2.microsoft.com/en-us/library/ms672175.aspx
    // see **http://www.codeproject.com/cs/miscctrl/treelistview.asp
    public enum CDDS : int//Custom draw draw state
    {
        CDDS_PREPAINT           = 0x00000001,
        CDDS_POSTPAINT          = 0x00000002,
        CDDS_PREERASE           = 0x00000003,
        CDDS_POSTERASE          = 0x00000004,
        CDDS_ITEM               = 0x00010000,
        CDDS_ITEMPREPAINT       = (CDDS_ITEM | CDDS_PREPAINT),
        CDDS_ITEMPOSTPAINT      = (CDDS_ITEM | CDDS_POSTPAINT),
        CDDS_ITEMPREERASE       = (CDDS_ITEM | CDDS_PREERASE),
        CDDS_ITEMPOSTERASE      = (CDDS_ITEM | CDDS_POSTERASE),
        CDDS_SUBITEM            = 0x00020000
    }

    public enum NM : int//Notification messages
    {
        NM_FIRST = (0-  0),
        NM_CUSTOMDRAW = (NM_FIRST-12)
    }

    public enum OCM : int//Reflected messages
    {
        OCM__BASE				= 0x0400 + 0x1c00,
        OCM_COMMAND				= ( OCM__BASE + 0x0111),
        OCM_CTLCOLORBTN			= ( OCM__BASE + 0x0135 ),
        OCM_CTLCOLOREDIT		= ( OCM__BASE + 0x0133 ),
        OCM_CTLCOLORDLG			= ( OCM__BASE + 0x0136 ),
        OCM_CTLCOLORLISTBOX		= ( OCM__BASE + 0x0134 ),
        OCM_CTLCOLORMSGBOX		= ( OCM__BASE + 0x0132 ),
        OCM_CTLCOLORSCROLLBAR	= ( OCM__BASE + 0x0137 ),
        OCM_CTLCOLORSTATIC		= ( OCM__BASE + 0x0138 ),
        OCM_CTLCOLOR		    = ( OCM__BASE + 0x0019 ),
        OCM_DRAWITEM			= ( OCM__BASE + 0x002B ),
        OCM_MEASUREITEM			= ( OCM__BASE + 0x002C ),
        OCM_DELETEITEM			= ( OCM__BASE + 0x002D ),
        OCM_VKEYTOITEM			= ( OCM__BASE + 0x002E ),
        OCM_CHARTOITEM			= ( OCM__BASE + 0x002F ),
        OCM_COMPAREITEM			= ( OCM__BASE + 0x0039 ),
        OCM_HSCROLL				= ( OCM__BASE + 0x0114 ),
        OCM_VSCROLL				= ( OCM__BASE + 0x0115 ),
        OCM_PARENTNOTIFY		= ( OCM__BASE + 0x0210 ),
        OCM_NOTIFY				= ( OCM__BASE + 0x004E )
    }

    public enum CDRF : int//Custom draw return flags
    {
        CDRF_DODEFAULT		 = 0x00000000,
        CDRF_NEWFONT		 = 0x00000002,
        CDRF_SKIPDEFAULT	 = 0x00000004,
        CDRF_NOTIFYPOSTPAINT = 0x00000010,
        CDRF_NOTIFYITEMDRAW  = 0x00000020,
        CDRF_NOTIFYPOSTERASE = 0x00000040,
        CDRF_SKIPPOSTPAINT   = 0x00000100, // Windows Vista and later
    }

    public enum NMHDRCodes : uint
    {
        TVM_FIRST             = 0x1100, // need to redo this from commtrl.h
        TVM_LAST              = 0x1165,
        /*
                CommCtrl.h:#define TVM_INSERTITEMA         (TV_FIRST + 0)
                CommCtrl.h:#define TVM_INSERTITEMW         (TV_FIRST + 50)
                CommCtrl.h:#define TVM_INSERTITEM          TVM_INSERTITEMW
                CommCtrl.h:#define TVM_INSERTITEM          TVM_INSERTITEMA
                CommCtrl.h:#define TVM_DELETEITEM          (TV_FIRST + 1)
                CommCtrl.h:#define TVM_EXPAND              (TV_FIRST + 2)
                CommCtrl.h:#define TVM_GETITEMRECT         (TV_FIRST + 4)
                CommCtrl.h:#define TVM_GETCOUNT            (TV_FIRST + 5)
                CommCtrl.h:#define TVM_GETINDENT           (TV_FIRST + 6)
                CommCtrl.h:#define TVM_SETINDENT           (TV_FIRST + 7)
                CommCtrl.h:#define TVM_GETIMAGELIST        (TV_FIRST + 8)
                CommCtrl.h:#define TVM_SETIMAGELIST        (TV_FIRST + 9)
                CommCtrl.h:#define TVM_GETNEXTITEM         (TV_FIRST + 10)
                CommCtrl.h:#define TVM_SELECTITEM          (TV_FIRST + 11)
                CommCtrl.h:#define TVM_GETITEMA            (TV_FIRST + 12)
                CommCtrl.h:#define TVM_GETITEMW            (TV_FIRST + 62)
                CommCtrl.h:#define TVM_GETITEM             TVM_GETITEMW
                CommCtrl.h:#define TVM_GETITEM             TVM_GETITEMA
                CommCtrl.h:#define TVM_SETITEMA            (TV_FIRST + 13)
                CommCtrl.h:#define TVM_SETITEMW            (TV_FIRST + 63)
                CommCtrl.h:#define TVM_SETITEM             TVM_SETITEMW
                CommCtrl.h:#define TVM_SETITEM             TVM_SETITEMA
                CommCtrl.h:#define TVM_EDITLABELA          (TV_FIRST + 14)
                CommCtrl.h:#define TVM_EDITLABELW          (TV_FIRST + 65)
                CommCtrl.h:#define TVM_EDITLABEL           TVM_EDITLABELW
                CommCtrl.h:#define TVM_EDITLABEL           TVM_EDITLABELA
                CommCtrl.h:#define TVM_GETEDITCONTROL      (TV_FIRST + 15)
                CommCtrl.h:#define TVM_GETVISIBLECOUNT     (TV_FIRST + 16)
                CommCtrl.h:#define TVM_HITTEST             (TV_FIRST + 17)
                CommCtrl.h:#define TVM_CREATEDRAGIMAGE     (TV_FIRST + 18)
                CommCtrl.h:#define TVM_SORTCHILDREN        (TV_FIRST + 19)
                CommCtrl.h:#define TVM_ENSUREVISIBLE       (TV_FIRST + 20)
                CommCtrl.h:#define TVM_SORTCHILDRENCB      (TV_FIRST + 21)
                CommCtrl.h:#define TVM_ENDEDITLABELNOW     (TV_FIRST + 22)
                CommCtrl.h:#define TVM_GETISEARCHSTRINGA   (TV_FIRST + 23)
                CommCtrl.h:#define TVM_GETISEARCHSTRINGW   (TV_FIRST + 64)
                CommCtrl.h:#define TVM_GETISEARCHSTRING    TVM_GETISEARCHSTRINGW
                CommCtrl.h:#define TVM_GETISEARCHSTRING    TVM_GETISEARCHSTRINGA
                CommCtrl.h:#define TVM_SETTOOLTIPS         (TV_FIRST + 24)
                CommCtrl.h:#define TVM_GETTOOLTIPS         (TV_FIRST + 25)
                CommCtrl.h:#define TVM_SETINSERTMARK       (TV_FIRST + 26)
                CommCtrl.h:#define TVM_SETUNICODEFORMAT    CCM_SETUNICODEFORMAT
                CommCtrl.h:#define TVM_GETUNICODEFORMAT    CCM_GETUNICODEFORMAT
                CommCtrl.h:#define TVM_SETITEMHEIGHT       (TV_FIRST + 27)
                CommCtrl.h:#define TVM_GETITEMHEIGHT       (TV_FIRST + 28)
                CommCtrl.h:#define TVM_SETBKCOLOR          (TV_FIRST + 29)
                CommCtrl.h:#define TVM_SETTEXTCOLOR        (TV_FIRST + 30)
                CommCtrl.h:#define TVM_GETBKCOLOR          (TV_FIRST + 31)
                CommCtrl.h:#define TVM_GETTEXTCOLOR        (TV_FIRST + 32)
                CommCtrl.h:#define TVM_SETSCROLLTIME       (TV_FIRST + 33)
                CommCtrl.h:#define TVM_GETSCROLLTIME       (TV_FIRST + 34)
                CommCtrl.h:#define TVM_SETINSERTMARKCOLOR  (TV_FIRST + 37)
                CommCtrl.h:#define TVM_GETINSERTMARKCOLOR  (TV_FIRST + 38)
                CommCtrl.h:#define TVM_GETITEMSTATE        (TV_FIRST + 39)
                CommCtrl.h:#define TVM_SETLINECOLOR        (TV_FIRST + 40)
                CommCtrl.h:#define TVM_GETLINECOLOR        (TV_FIRST + 41)
                CommCtrl.h:#define TVM_MAPACCIDTOHTREEITEM (TV_FIRST + 42)
                CommCtrl.h:#define TVM_MAPHTREEITEMTOACCID (TV_FIRST + 43)
         */
        // from CommCtrl.h
        //====== WM_NOTIFY codes (NMHDR.code values) ==================================
        NM_FIRST                = unchecked(0U-  0U),     // generic to all controls
        NM_LAST                 = unchecked(0U- 99U),
            NM_OUTOFMEMORY          = unchecked(NM_FIRST-1),
            NM_CLICK                = unchecked(NM_FIRST-2),   // uses NMCLICK struct
            NM_DBLCLK               = unchecked(NM_FIRST-3),
            NM_RETURN               = unchecked(NM_FIRST-4),
            NM_RCLICK               = unchecked(NM_FIRST-5),   // uses NMCLICK struct
            NM_RDBLCLK              = unchecked(NM_FIRST-6),
            NM_SETFOCUS             = unchecked(NM_FIRST-7),
            NM_KILLFOCUS            = unchecked(NM_FIRST-8),
            NM_CUSTOMDRAW           = unchecked(NM_FIRST-12),
            NM_HOVER                = unchecked(NM_FIRST-13),
            NM_NCHITTEST            = unchecked(NM_FIRST-14),  // uses NMMOUSE struct
            NM_KEYDOWN              = unchecked(NM_FIRST-15),  // uses NMKEY struct
            NM_RELEASEDCAPTURE      = unchecked(NM_FIRST-16),
            NM_SETCURSOR            = unchecked(NM_FIRST-17),  // uses NMMOUSE struct
            NM_CHAR                 = unchecked(NM_FIRST-18),  // uses NMCHAR struct
            NM_TOOLTIPSCREATED      = unchecked(NM_FIRST-19),  // notify of when the tooltips window is create
            NM_LDOWN                = unchecked(NM_FIRST-20),
            NM_RDOWN                = unchecked(NM_FIRST-21),
            NM_THEMECHANGED         = unchecked(NM_FIRST-22),
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        LVN_FIRST               = unchecked(0U-100U),     // listview
        LVN_LAST                = unchecked(0U-199U),
        HDN_FIRST               = unchecked(0U-300U),      // header
        HDN_LAST                = unchecked(0U-399U),
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        TVN_FIRST               = unchecked(0U-400U),      // treeview
        TVN_LAST                = unchecked(0U-499U),
            TVN_SELCHANGINGA        = unchecked(TVN_FIRST-1),
            TVN_SELCHANGINGW        = unchecked(TVN_FIRST-50),
            TVN_SELCHANGEDA         = unchecked(TVN_FIRST-2),
            TVN_SELCHANGEDW         = unchecked(TVN_FIRST-51),
            TVN_GETDISPINFOA        = unchecked(TVN_FIRST-3),
            TVN_GETDISPINFOW        = unchecked(TVN_FIRST-52),
            TVN_SETDISPINFOA        = unchecked(TVN_FIRST-4),
            TVN_SETDISPINFOW        = unchecked(TVN_FIRST-53),
            TVN_ITEMEXPANDINGA      = unchecked(TVN_FIRST-5),
            TVN_ITEMEXPANDINGW      = unchecked(TVN_FIRST-54),
            TVN_ITEMEXPANDEDA       = unchecked(TVN_FIRST-6),
            TVN_ITEMEXPANDEDW       = unchecked(TVN_FIRST-55),
            TVN_BEGINDRAGA          = unchecked(TVN_FIRST-7),
            TVN_BEGINDRAGW          = unchecked(TVN_FIRST-56),
            TVN_BEGINRDRAGA         = unchecked(TVN_FIRST-8),
            TVN_BEGINRDRAGW         = unchecked(TVN_FIRST-57),
            TVN_DELETEITEMA         = unchecked(TVN_FIRST-9),
            TVN_DELETEITEMW         = unchecked(TVN_FIRST-58),
            TVN_BEGINLABELEDITA     = unchecked(TVN_FIRST-10),
            TVN_BEGINLABELEDITW     = unchecked(TVN_FIRST-59),
            TVN_ENDLABELEDITA       = unchecked(TVN_FIRST-11),
            TVN_ENDLABELEDITW       = unchecked(TVN_FIRST-60),
            TVN_KEYDOWN             = unchecked(TVN_FIRST-12),
            TVN_GETINFOTIPA         = unchecked(TVN_FIRST-13),
            TVN_GETINFOTIPW         = unchecked(TVN_FIRST-14),
            TVN_SINGLEEXPAND        = unchecked(TVN_FIRST-15),
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        TTN_FIRST               = unchecked(0U-520U),      // tooltips
        TTN_LAST                = unchecked(0U-549U),
        TCN_FIRST               = unchecked(0U-550U),      // tab control
        TCN_LAST                = unchecked(0U-580U),
        CDN_FIRST               = unchecked(0U-601U),      // common dialog (new)
        CDN_LAST                = unchecked(0U-699U),
        TBN_FIRST               = unchecked(0U-700U),      // toolbar
        TBN_LAST                = unchecked(0U-720U),
        UDN_FIRST               = unchecked(0U-721),       // updown
        UDN_LAST                = unchecked(0U-740),
        MCN_FIRST               = unchecked(0U-750U),      // monthcal
        MCN_LAST                = unchecked(0U-759U),
        DTN_FIRST               = unchecked(0U-760U),      // datetimepick
        DTN_LAST                = unchecked(0U-799U),
        CBEN_FIRST              = unchecked(0U-800U),      // combo box ex
        CBEN_LAST               = unchecked(0U-830U),
        RBN_FIRST               = unchecked(0U-831U),      // rebar
        RBN_LAST                = unchecked(0U-859U),
    };

    /// <summary>
    /// PInvoke
    /// </summary>
    public class PInvoke
    {
        [DllImport("User32.dll",CharSet = CharSet.Auto,SetLastError=true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
    }
}
