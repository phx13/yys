; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "����ʦ����"
#define MyAppVersion "1.0"
#define MyAppPublisher "phx"
#define MyAppExeName "����ʦ����.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{6720454D-9E5E-4157-9FDC-CCCF631ABE7B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
InfoBeforeFile=D:\Visual Studio 2017\projects\����ʦ����\����ʦ����\bin\Release\ReadMe.txt
OutputDir=D:\Visual Studio 2017\projects\����ʦ����
OutputBaseFilename=����ʦ����setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Visual Studio 2017\projects\����ʦ����\����ʦ����\bin\Release\����ʦ����.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Visual Studio 2017\projects\����ʦ����\����ʦ����\bin\Release\Microsoft.NET.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Visual Studio 2017\projects\����ʦ����\����ʦ����\bin\Release\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Visual Studio 2017\projects\����ʦ����\����ʦ����\bin\Release\YYS_db"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Visual Studio 2017\projects\����ʦ����\����ʦ����\bin\Release\Images\*"; DestDir: "{app}\\Images"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

