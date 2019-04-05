#K8 C
[原创]K8 Cscan 3.1 大型内网渗透自定义扫描器（附C#/VC/Delphi/Python插件Demo源码)
链接:   https://www.cnblogs.com/k8gege/p/10519321.html

Cscan 主程序分为检测存活主机、非检测存活主机版本  程序采用Cping原理多线程批量扫描大型内网多个IP段C段主机，

目前插件包含: C段旁注扫描、子域名扫描、Ftp密码爆破、Mysql密码爆、系统密码爆破、存活主机扫描、Web信息探测等，

其实也支持调用任意外部程序或脚本的

 

功能：

1.支持批量IP段C段扫描(两年前实战扫过内网几万IP段)

2.支持指定范围IP段C段扫描、支持指定IP扫描

3.自带模块1(获取内网存活机器IP、主机名、MAC)

4.自带模块2(获取内网Web机器IP、主机名、Banner、网页标题)

5.支持调用自定义程序(当然系统自带命令也可以)

6.支持自定义模块(功能基于模块源码修改即可)

7.主程序分为检测存活主机、非检测存活主机版本

程序模块

[+] 主程序 K8Cscan 3.1.rar 大型内网渗透扫描器<br>
[+] 扫描插件 K8Cscan Moudle FtpScan.rar Ftp密码扫描插件<br>
[+] 扫描插件 K8Cscan Moudle MysqlScan.rar Mysql密码扫描插件<br>
[+] 扫描插件 K8Cscan Moudle OnlinePC.rar 存活主机扫描插件<br>
[+] 扫描插件 K8Cscan Moudle WebBanner.rar WebBanner标题扫描插件<br>
[+] 扫描插件 K8Cscan Moudle WmiScan.rar Wmi扫描Win系统密码插件<br>
[+] 扫描工具 K8Cscan for SameWeb.rar C段旁站扫描工具<br>
[+] 扫描工具 K8Cscan for SubDomain.rar 子域名扫描工具<br>
[+] 扫描插件 支持自定义插件、EXE、脚本等（附C#/VC/Delphi/Python源码)<br>

原理：
采用Cping原理多线程批量执行外部exe或DLL，适用于大型内网，扫描速度和被调用工具或模块有关
为了提高效率Cscan自动探测存活主机，只有主机在线时才会执行DLL或EXE。

通俗的说Cping自定义功能版，插件可自行开发，不懂开发也可直接调用外部程序。

比方说我获取了内网一些FTP帐密，需要扫描内网几百个C段中,有哪些机器存在相同密码

我只需要开发一个Cscan插件即可(当然现成EXE也行),不用完全重新开发一个CftpScan了

 

PS:代理或转发不支持ICMP协议,所以会导致无法探测存活主机（系统ping命令或其它通过ICMP探测的工具都会失效）

     内网代理出来扫描使用非检测存活主机版本,然后你所调用的程序或模块就不要用那些基于ICMP协议的了。

     是你的代理工具不支持ICMP协议，我也没办法使用ICMP协议去探测存活主机，不是说用这版本就可以扫。

     比方说你可以调用那些TCP协议的工具啊，比如S扫开放端口,445漏洞利用等等，工具帮你快速完成批量。

 

例子1: 配置Cscan.ini 调用S扫描器扫描C段主机开放端口

例子2: 调用c#编写的DLL扫描内网WEB主机Banner以及标题

DLL源码 https://www.cnblogs.com/k8gege/p/10519512.html

已编译：https://www.cnblogs.com/k8gege/p/10650610.html

 

例子3: K8Cscan新增C段旁站扫描插件\子域名扫描插件

 https://www.cnblogs.com/k8gege/p/10626465.html

例子4: K8Cscan插件之FTP密码爆破
https://www.cnblogs.com/k8gege/p/10650630.html
例子5:  K8Cscan插件之Mysql密码爆破
https://www.cnblogs.com/k8gege/p/10650642.html

例子6:  K8Cscan插件之Wmi爆破Windows密码
https://www.cnblogs.com/k8gege/p/10650659.html

 

更新历史

3.1 支持单个IP扫描
例子：Cscan.exe 192.11.22.8


3.0 DLL调用（支持C# DLL \ VC DLL \Delphi DLL）

Demo
C# DLL 名称必须为netscan.dll      （源码例子为获取IP对应机器名，其它功能自己写）
VC DLL 名称必须为vcscan.dll       （源码例子为打印在线主机IP，其它功能自己写）
Delphi DLL 名称必须为descan.dll  （源码例子为打印在线主机IP，其它功能自己写）

EXE (非scan.exe或多参数需配置cscan.ini)
scan.py   使用pyinstaller打包成exe（源码例子为打印在线主机IP，其它功能自己写）
scan.cs  （源码例子为打印在线主机IP，其它功能自己写）
scan.cpp （源码例子为打印在线主机IP，其它功能自己写）

调用优先级
为 netscan.dll >> vcscan.dll >> descan.dll >> Cscan.ini >> scan.exe 同目录下同时含以下多个文件时，仅会调用一个。
Cscan.ini 支持exe自定义参数，其它均只支持IP。

注意：

      调用EXE可能会在运行机器上产生30个exe进程,所以建议将功能写成DLL比较好。
      不懂代码的或实在无法实现功能的可使用exe或配置cscan.ini文件（如批量ping，WMI批量种马等）

      
其它：

     由于python编译后的DLL还是需要python相关依赖实在太大，就不提供DLL例子了,不会以上3种语言就exe吧。
      Python、Perl或其它类似脚本可配置Cscan.ini当成EXE来调用,如python.exe scan.py 192.168.1.1
      但你并不能保证目标一定安装有对应python依赖包，所以还是得编译成EXE比较好，
      如果不编译也会产生30个Python.exe进程，因为py脚本是靠python.exe来执行的。

      Bat也会产生一堆被执行系统命令的EXE进程，最佳方案把相关命令写成一个EXE。
      最主要是多线程不好同时监视BAT调用的命令是否执行完成，无法准确获取回显。
      
      
build 20190312 by K8哥哥

=======================================================================
2.0 用法：

2.0已支持调用自定义参数程序,默认用法与1.0一致

把需要调用的程序改名为scan.exe (程序用法必须为: scan.exe ip)
ip.txt填上需要扫描的IP或IP段，程序自动转换为IP段。

自定义参数例子

0x001 批量获取C段Web主机标题
程序用法 LanWebScan.exe gettitle 192.168.1.1

配置Cscan.ini
[Cscan]
exe=LanWebScan.exe
arg=gettitle ip


命令行下执行cscan

0x002 调用S扫描C段主机开放端口

程序用法s.exe TCP 12.12.12.12 21,3389 8

配置Cscan.ini
[Cscan]
exe=s.exe
arg=TCP ip

21,80,3306,3389,1521

命令行下执行cscan

build 20190308 by K8哥哥


=======================================================================

1.0 用法：

把需要调用的程序改名为scan.exe (程序用法必须为: scan.exe ip)
ip.txt填上需要扫描的IP或IP段，程序自动转换为IP段。

PS：kscan支持自定义参数，cscan暂不支持自定义参数。

build 20180531 by K8哥哥


1.0 例子
 
0x001 批量扫描多个C段SMB漏洞
========================================================
单个：使用checker.exe检测单个IP 用法：checker.exe ip

批量扫描C段
把checker.exe改为scan.exe放置于程序根目录
在ip.txt里填上需要扫描的IP段，运行cscan即可


0x002 批量ping多个C段在线主机(调用系统ping)
========================================================
单个：系统ping命令大家都会用，就是ping ip

批量多个C段
复制系统自带ping.exe改为scan.exe放置于程序根目录
在ip.txt里填上需要扫描的IP段,运行cscan即可

下载:
主程序：https://github.com/k8gege/K8tools/blob/master/K8Cscan%203.1.rar

模块源码：https://github.com/k8gege/K8CScan
