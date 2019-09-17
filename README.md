Wiki: https://github.com/k8gege/K8CScan/wiki<br>

K8Cscan一款专用于大型内网渗透的高并发插件化扫描器，支持批量A段/B段/C段以及跨网段扫描。5.0版本内置11种方式快速获取目标网络所有存活主机IP、计算机名、工作组、网卡物理地址、操作系统版本、网站域名、Web中间件、路由器（Cisco）、数据库(MSSQL\MySQL)等网络资产信息,内置MS17-010、Weblogic漏洞检测，内置Mysql、Ftp密码爆破。插件化支持加载.net程序集、DLL(C#/Delphi/vc)、PowerShell编写以及通过INI加载任意程序或命令(如调用wmiexec.vbs批量内网密码爆破以及批量上控、调用sshcmd进行SSH密码爆破、调用python写的exp快速批量利用等)。支持Cobalt Strike 3.x,直接命令行下扫描目标内网或跳板扫描外网目标

PS：小中型内网明显也是支持的，大家不要慌而且速度非常快，扫你的办公室就只是嗖的一下<br>
程序通过ICMP、DNS、SMB、HTTP、netbios协议、端口、Banner、Web等方式探测存活主机
