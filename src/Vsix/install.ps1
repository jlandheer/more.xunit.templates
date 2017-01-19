Get-ChildItem -Path  '.\' -Recurse -exclude More.Xunit.Templates.vsix,install.ps1 | Remove-Item -force -recurse

& 'C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\VSIXInstaller.exe' .\More.Xunit.Templates.vsix /q