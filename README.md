Cscan 3.2 大型内网渗透自定义扫描器
Author: K8gege
https://github.com/k8gege/K8CScan
https://www.cnblogs.com/k8gege/p/10519321.html

主程序分为检测存活主机、非检测存活主机两个版本 程序采用多线程批量扫描大型内网IP段C段存活主机(支持上万个C段)
插件含C段旁注扫描、子域名扫描、Ftp密码爆破、Mysql密码爆、系统密码爆破、存活主机扫描、Web信息探测、端口扫描
支持调用任意外部程序或脚本，支持自定义模块(功能基于公开模块源码修改即可)

功能：
1.主程序分为检测存活主机、非检测存活主机版本
2.支持批量IP段C段扫描(成千上万C段没问题)
3.支持指定范围IP段C段扫描、支持指定IP扫描
4.支持调用自定义程序(系统命令或第三方程序)
5.支持自定义模块(功能基于模块源码修改即可)


程序&插件:
[+] 主程序   K8Cscan 3.2.rar 大型内网渗透扫描器
[+] 模块插件 K8Cscan Moudle FtpScan.rar Ftp密码扫描插件
[+] 模块插件 K8Cscan Moudle MysqlScan.rar Mysql密码扫描插件
[+] 模块插件 K8Cscan Moudle OnlinePC.rar 存活主机扫描插件
[+] 模块插件 K8Cscan Moudle WebBanner.rar WebBanner标题扫描插件
[+] 模块插件 K8Cscan Moudle WmiScan.rar Wmi扫描Win系统密码插件
[+] 独立工具 K8Cscan for SameWeb.rar C段旁站扫描工具
[+] 独立工具 K8Cscan for SubDomain.rar 子域名扫描工具
[+] Demo源码 支持自定义插件、EXE、脚本等（附C#/VC/Delphi/Python源码)
[+] 插件源码 K8Cscan Moudle PortScan.cs  端口扫描插件源码(自行编译)
[+] 插件源码 c# netscan 存活主机 & Web信息插件源码(以上已发布成品)

更新历史：
3.2 独立EXE时扫描C段存活主机
即无cscan.ini或相关DLL时，程序相当于Cping，自动扫描当前机器所处C段存活主机。
端口扫描插件例子源码

3.1 支持单个IP扫描
例子：Cscan.exe 192.11.22.8

3.0 DLL调用（支持C# DLL \ VC DLL \Delphi DLL）

Demo
C# DLL 名称必须为netscan.dll 	 （源码例子为获取IP对应机器名，其它功能自己写）
VC DLL 名称必须为vcscan.dll  	 （源码例子为打印在线主机IP，其它功能自己写）
Delphi DLL 名称必须为descan.dll  （源码例子为打印在线主机IP，其它功能自己写）

EXE (非scan.exe或多参数需配置cscan.ini)
scan.py   使用pyinstaller打包成exe（源码例子为打印在线主机IP，其它功能自己写）
scan.cs  （源码例子为打印在线主机IP，其它功能自己写）
scan.cpp （源码例子为打印在线主机IP，其它功能自己写）

调用优先级
为 netscan.dll >> vcscan.dll >> descan.dll >> Cscan.ini >> scan.exe 同目录下同时含以下多个文件时，仅会调用一个。

Cscan.ini 支持exe自定义参数，其它均只支持IP。

注意：调用EXE可能会在运行机器上产生30个exe进程,所以建议将功能写成DLL比较好。
	  不懂代码的或实在无法实现功能的可使用exe或配置cscan.ini文件（如批量ping，WMI批量种马等）

	  
其它：由于python编译后的DLL还是需要python相关依赖实在太大，就不提供DLL例子了,不会以上3种语言就exe吧。
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
arg=gettitle $ip$

命令行下执行cscan

0x001 调用S扫描C段主机开放端口

程序用法s.exe TCP 12.12.12.12 21,3389 8

配置Cscan.ini
[Cscan]
exe=s.exe
arg=TCP $ip$ 21,80,3306,3389,1521

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

PS: (工具自带scan.exe为XP系统ping.exe,WIN7复制到其它目录改名的ping竟然用不了)
