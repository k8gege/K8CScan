<h3>K8Cscan5.0 Update 20190924</h3>
<h5>Wiki: https://github.com/k8gege/K8CScan/wiki</h5>

K8Cscan一款专用于大型内网渗透的高并发插件化扫描器，支持批量A段/B段/C段以及跨网段扫描。5.2版本内置24个功能模块,通过各种协议以及方法快速获取目标网络存活主机IP、计算机名、工作组、网络共享、网卡物理地址、操作系统版本、网站域名、Web中间件、路由器（Cisco）、数据库等网络资产信息,内置MS17-010(SMB漏洞)、Weblogic漏洞检测，内置6种密码认证爆破3种数据库(Mysql、Oracle、MSSQL)、FTP密码爆破(文件服务器)、SSH密码爆破(Linux主机)、IPC/WMI两种方式爆破Windows主机密码，Web指纹识别模块可识别33种国内外主流CMS。高度自定义插件支持.NET程序集、DLL(C#/Delphi/VC)、PowerShell等语言编写的插件以及无编程功底通过配置INI加载任意程序命令(如调用wmiexec.vbs批量内网密码爆破以及批量上控、调用sshcmd对Linux机器批量上控、调用python写的exp快速批量利用等)。支持Cobalt Strike命令行下扫描目标内网或跳板扫描外网目标

PS：小中型内网明显也是支持的，大家不要慌而且速度非常快，扫你的办公室网络就只是嗖的一下<br>
通过ICMP、DNS、SMB、HTTP、netbios、Port、Banner、Web、Sql、WMI、Wnet等方式探测主机
