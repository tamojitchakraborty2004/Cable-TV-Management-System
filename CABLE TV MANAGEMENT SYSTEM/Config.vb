Module Config
    Public dbFilePath As String = "E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\App_Data\CABLE_TV_DB.accdb"
    Public invoicepath As String = ("Invoices\")
    Public img_path As String = ("E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\Assets\mail_bg.jpg")
    Public logo_path As String = ("C:\Users\ctamo\Desktop\1.png")
    Public seal_path As String = ("E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\Assets\SEAL.png")
    Public log_path As String = ("E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\log.txt")
    Public app_name_text As String = "CABLE TV MANAGEMENT SYSTEM"
    Public ErrorAlert As New System.Media.SoundPlayer("E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\Assets\Error.wav")
    Public SuccessAlert As New System.Media.SoundPlayer("E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\Assets\Gpay.wav")
    Public FileNotFound As String = "E:\CABLE-TV-MANAGEMENT-SYSTEM\CABLE TV MANAGEMENT SYSTEM\Assets\FileNotFound.html"
    Public smtpID As String = "Email_ID"
    Public smtpPass As String = "App Password"
End Module
