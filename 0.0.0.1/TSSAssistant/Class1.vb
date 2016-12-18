
'Copyright (c) 2011 Josip Medved <jmedved@jmedved.com>  http://www.jmedved.com


Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Friend Class OpenFolderDialog
    Implements IDisposable

    ''' <summary>
    ''' Gets/sets folder in which dialog will be open.
    ''' </summary>
    Public Property InitialFolder() As String
        Get
            Return m_InitialFolder
        End Get
        Set
            m_InitialFolder = Value
        End Set
    End Property
    Private m_InitialFolder As String

    ''' <summary>
    ''' Gets/sets directory in which dialog will be open if there is no recent directory available.
    ''' </summary>
    Public Property DefaultFolder() As String
        Get
            Return m_DefaultFolder
        End Get
        Set
            m_DefaultFolder = Value
        End Set
    End Property
    Private m_DefaultFolder As String

    ''' <summary>
    ''' Gets selected folder.
    ''' </summary>
    Public Property Folder() As String
        Get
            Return m_Folder
        End Get
        Private Set
            m_Folder = Value
        End Set
    End Property
    Private m_Folder As String


    Friend Function ShowDialog(owner As IWin32Window) As DialogResult
        If Environment.OSVersion.Version.Major >= 6 Then
            Return ShowVistaDialog(owner)
        Else
            Return ShowLegacyDialog(owner)
        End If
    End Function

    Private Function ShowVistaDialog(owner As IWin32Window) As DialogResult
        Dim frm = DirectCast(New NativeMethods.FileOpenDialogRCW(), NativeMethods.IFileDialog)
        Dim options As UInteger
        frm.GetOptions(options)
        options = options Or NativeMethods.FOS_PICKFOLDERS Or NativeMethods.FOS_FORCEFILESYSTEM Or NativeMethods.FOS_NOVALIDATE Or NativeMethods.FOS_NOTESTFILECREATE Or NativeMethods.FOS_DONTADDTORECENT
        frm.SetOptions(options)
        If Me.InitialFolder IsNot Nothing Then
            Dim directoryShellItem As NativeMethods.IShellItem
            Dim riid = New Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")
            'IShellItem
            If NativeMethods.SHCreateItemFromParsingName(Me.InitialFolder, IntPtr.Zero, riid, directoryShellItem) = NativeMethods.S_OK Then
                frm.SetFolder(directoryShellItem)
            End If
        End If
        If Me.DefaultFolder IsNot Nothing Then
            Dim directoryShellItem As NativeMethods.IShellItem
            Dim riid = New Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")
            'IShellItem
            If NativeMethods.SHCreateItemFromParsingName(Me.DefaultFolder, IntPtr.Zero, riid, directoryShellItem) = NativeMethods.S_OK Then
                frm.SetDefaultFolder(directoryShellItem)
            End If
        End If

        If frm.Show(owner.Handle) = NativeMethods.S_OK Then
            Dim shellItem As NativeMethods.IShellItem
            If frm.GetResult(shellItem) = NativeMethods.S_OK Then
                Dim pszString As IntPtr
                If shellItem.GetDisplayName(NativeMethods.SIGDN_FILESYSPATH, pszString) = NativeMethods.S_OK Then
                    If pszString <> IntPtr.Zero Then
                        Try
                            Me.Folder = Marshal.PtrToStringAuto(pszString)
                            Return DialogResult.OK
                        Finally
                            Marshal.FreeCoTaskMem(pszString)
                        End Try
                    End If
                End If
            End If
        End If
        Return DialogResult.Cancel
    End Function

    Private Function ShowLegacyDialog(owner As IWin32Window) As DialogResult
        Using frm = New SaveFileDialog()
            frm.CheckFileExists = False
            frm.CheckPathExists = True
            frm.CreatePrompt = False
            frm.Filter = "|" + Guid.Empty.ToString()
            frm.FileName = "any"
            If Me.InitialFolder IsNot Nothing Then
                frm.InitialDirectory = Me.InitialFolder
            End If
            frm.OverwritePrompt = False
            frm.Title = "Select Folder"
            frm.ValidateNames = False
            If frm.ShowDialog(owner) = DialogResult.OK Then
                Me.Folder = Path.GetDirectoryName(frm.FileName)
                Return DialogResult.OK
            Else
                Return DialogResult.Cancel
            End If
        End Using
    End Function


    Public Sub Dispose()
    End Sub

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        Throw New NotImplementedException()
    End Sub
    'just to have possibility of Using statement.
End Class

Friend NotInheritable Class NativeMethods
    Private Sub New()
    End Sub

#Region "Constants"

    Public Const FOS_PICKFOLDERS As UInteger = &H20
    Public Const FOS_FORCEFILESYSTEM As UInteger = &H40
    Public Const FOS_NOVALIDATE As UInteger = &H100
    Public Const FOS_NOTESTFILECREATE As UInteger = &H10000
    Public Const FOS_DONTADDTORECENT As UInteger = &H2000000

    Public Const S_OK As UInteger = &H0

    Public Const SIGDN_FILESYSPATH As UInteger = &H80058000UI

#End Region


#Region "COM"

    <ComImport, ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FCanCreate), Guid("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7")>
    Friend Class FileOpenDialogRCW
    End Class


    <ComImport, Guid("42F85136-DB7E-439C-85F1-E4075D135FC8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Friend Interface IFileDialog
        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        <PreserveSig>
        Function Show(<[In], [Optional]> hwndOwner As IntPtr) As UInteger
        'IModalWindow 

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetFileTypes(<[In]> cFileTypes As UInteger, <[In], MarshalAs(UnmanagedType.LPArray)> rgFilterSpec As IntPtr) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetFileTypeIndex(<[In]> iFileType As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetFileTypeIndex(ByRef piFileType As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function Advise(<[In], MarshalAs(UnmanagedType.[Interface])> pfde As IntPtr, ByRef pdwCookie As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function Unadvise(<[In]> dwCookie As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetOptions(<[In]> fos As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetOptions(ByRef fos As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Sub SetDefaultFolder(<[In], MarshalAs(UnmanagedType.[Interface])> psi As IShellItem)

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetFolder(<[In], MarshalAs(UnmanagedType.[Interface])> psi As IShellItem) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetFolder(<MarshalAs(UnmanagedType.[Interface])> ByRef ppsi As IShellItem) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetCurrentSelection(<MarshalAs(UnmanagedType.[Interface])> ByRef ppsi As IShellItem) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetFileName(<[In], MarshalAs(UnmanagedType.LPWStr)> pszName As String) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetFileName(<MarshalAs(UnmanagedType.LPWStr)> ByRef pszName As String) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetTitle(<[In], MarshalAs(UnmanagedType.LPWStr)> pszTitle As String) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetOkButtonLabel(<[In], MarshalAs(UnmanagedType.LPWStr)> pszText As String) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetFileNameLabel(<[In], MarshalAs(UnmanagedType.LPWStr)> pszLabel As String) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetResult(<MarshalAs(UnmanagedType.[Interface])> ByRef ppsi As IShellItem) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function AddPlace(<[In], MarshalAs(UnmanagedType.[Interface])> psi As IShellItem, fdap As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetDefaultExtension(<[In], MarshalAs(UnmanagedType.LPWStr)> pszDefaultExtension As String) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function Close(<MarshalAs(UnmanagedType.[Error])> hr As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetClientGuid(<[In]> ByRef guid As Guid) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function ClearClientData() As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function SetFilter(<MarshalAs(UnmanagedType.[Interface])> pFilter As IntPtr) As UInteger
    End Interface


    <ComImport, Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Friend Interface IShellItem
        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function BindToHandler(<[In]> pbc As IntPtr, <[In]> ByRef rbhid As Guid, <[In]> ByRef riid As Guid, <Out, MarshalAs(UnmanagedType.[Interface])> ByRef ppvOut As IntPtr) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetParent(<MarshalAs(UnmanagedType.[Interface])> ByRef ppsi As IShellItem) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetDisplayName(<[In]> sigdnName As UInteger, ByRef ppszName As IntPtr) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function GetAttributes(<[In]> sfgaoMask As UInteger, ByRef psfgaoAttribs As UInteger) As UInteger

        <MethodImpl(MethodImplOptions.InternalCall, MethodCodeType:=MethodCodeType.Runtime)>
        Function Compare(<[In], MarshalAs(UnmanagedType.[Interface])> psi As IShellItem, <[In]> hint As UInteger, ByRef piOrder As Integer) As UInteger
    End Interface

#End Region


    <DllImport("shell32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
    Friend Shared Function SHCreateItemFromParsingName(<MarshalAs(UnmanagedType.LPWStr)> pszPath As String, pbc As IntPtr, ByRef riid As Guid, <MarshalAs(UnmanagedType.[Interface])> ByRef ppv As IShellItem) As Integer
    End Function

End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
