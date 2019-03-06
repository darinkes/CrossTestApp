CrossTestApp
============

Research how hard it is to build an Application with AvaloniaUI based on existing MVVM WPF Code.

ToDos:
------
- [ ] Properties
- [ ] Dispatcher
- [ ] ...

Build single file exe:
----------------------
See: https://github.com/dgiagio/warp#windows-1

```bash
$ [Net.ServicePointManager]::SecurityProtocol = "tls12, tls11, tls" ; Invoke-WebRequest https://github.com/dgiagio/warp/releases/download/v0.3.0/windows-x64.warp-packer.exe -OutFile warp-packer.exe
$ cd CrossTestAppAvalonia
$ dotnet publish -c Release -r win10-x64 -f netcoreapp2.0
$ .\warp-packer --arch windows-x64 --input_dir bin/Release/netcoreapp2.0/win10-x64/publish/ --exec CrossTestAppAvalonia.exe --output CrossTestAppAvalonia.exe
```
