# K8CScan 3.1 20190403
[+] 主程序 K8Cscan 3.1.rar 高效内网渗透扫描工具<br>
[+] 扫描插件 K8Cscan Moudle FtpScan.rar Ftp密码扫描插件<br>
[+] 扫描插件 K8Cscan Moudle MysqlScan.rar Mysql密码扫描插件<br>
[+] 扫描插件 K8Cscan Moudle OnlinePC.rar 存活主机扫描插件<br>
[+] 扫描插件 K8Cscan Moudle WebBanner.rar WebBanner标题扫描插件<br>
[+] 扫描插件 K8Cscan Moudle WmiScan.rar Wmi扫描Win系统密码插件<br>
[+] 扫描工具 K8Cscan for SameWeb.rar C段旁站扫描工具<br>
[+] 扫描工具 K8Cscan for SubDomain.rar 子域名扫描工具<br>


<p><span style="font-size: 16px;">[原创]K8 Cscan 3.0 高效内网渗透自定义扫描器（附C#/VC/Delphi/Python源码) </span><br /><span style="font-size: 16px;">链接:&nbsp;&nbsp; <a href="https://www.cnblogs.com/k8gege/p/10519321.html" target="_blank">https://www.cnblogs.com/k8gege/p/10519321.html</a></span></p>
<p><br /><strong><span style="font-size: 16px;">功能：</span></strong></p>
<p>1.支持批量C段扫描(几千几万IP段都可以)</p>
<p>2.支持指定范围C段扫描</p>
<p>3.自带模块1(获取内网存活机器IP、主机名、MAC)</p>
<p>4.自带模块2(获取内网Web机器IP、主机名、Banner、网页标题)</p>
<p>5.支持调用自定义程序(当然系统自带命令也可以)</p>
<p>6.支持自定义模块(功能基于模块源码修改即可)</p>
<p>7.主程序分为检测存活主机、非检测存活主机版本</p>
<p>&nbsp;</p>
<p><span style="font-size: 16px;"><strong>原理：</strong></span><br />采用Cping原理多线程批量执行外部exe或DLL，适用于大型内网，扫描速度和被调用工具或模块有关<br />为了提高效率Cscan自动探测存活主机，只有主机在线时才会执行DLL或EXE。</p>
<p>通俗的说Cping自定义功能版，插件可自行开发，不懂开发也可直接调用外部程序。</p>
<p>&nbsp;</p>
<p>PS:代理或转发不支持ICMP协议,所以会导致无法探测存活主机（系统ping命令或其它通过ICMP探测的工具都会失效）</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; 内网代理出来扫描使用非检测存活主机版本,然后你所调用的程序或模块就不要用那些基于ICMP协议的了。</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; 是你的代理工具不支持ICMP协议，我也没办法使用ICMP协议去探测存活主机，不是说用这版本就可以扫。</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; 比方说你可以调用那些TCP协议的工具啊，比如S扫开放端口,445漏洞利用等等，工具帮你快速完成批量。</p>
<p>&nbsp;</p>
<p><span style="font-size: 16px;"><strong>例子1: 配置Cscan.ini 调用S扫描器扫描C段主机开放端口</strong></span></p>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201903/1463611-20190312200210710-22698312.png" alt="" /></p>
<p><strong><span style="font-size: 16px;">例子2: 调用c#编写的DLL扫描内网WEB主机Banner以及标题</span></strong></p>
<p>DLL源码 <a href="https://www.cnblogs.com/k8gege/p/10519512.html" target="_blank">https://www.cnblogs.com/k8gege/p/10519512.html</a></p>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201903/1463611-20190312200408983-358773201.jpg" alt="" /></p>
<p><br /><span style="font-size: 16px;"><strong>3.0 DLL调用（支持C# DLL \ VC DLL \Delphi DLL）</strong></span><br /><br />Demo<br />C# DLL 名称必须为netscan.dll &nbsp;&nbsp; &nbsp; （源码例子为获取IP对应机器名，其它功能自己写）<br />VC DLL 名称必须为vcscan.dll &nbsp;&nbsp;&nbsp; &nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br />Delphi DLL 名称必须为descan.dll&nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br /><br />EXE (非scan.exe或多参数需配置cscan.ini)<br />scan.py&nbsp;&nbsp; 使用pyinstaller打包成exe（源码例子为打印在线主机IP，其它功能自己写）<br />scan.cs&nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br />scan.cpp （源码例子为打印在线主机IP，其它功能自己写）<br /><br /><span style="font-size: 16px;">调用优先级</span><br /><span style="font-size: 16px;">为 netscan.dll &gt;&gt; vcscan.dll &gt;&gt; descan.dll &gt;&gt; Cscan.ini &gt;&gt; scan.exe 同目录下同时含以下多个文件时，仅会调用一个。</span><br /><span style="font-size: 16px;">Cscan.ini 支持exe自定义参数，其它均只支持IP。</span><br /><br /><span style="font-size: 16px;"><strong>注意：</strong></span></p>
<p><span style="font-size: 16px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>调用EXE可能会在运行机器上产生30个exe进程,所以建议将功能写成DLL比较好。</span><br /><span style="font-size: 16px;">&nbsp;&nbsp; &nbsp;&nbsp; 不懂代码的或实在无法实现功能的可使用exe或配置cscan.ini文件（如批量ping，WMI批量种马等）</span><br /><br />&nbsp;&nbsp; &nbsp; &nbsp;<br /><span style="font-size: 16px;"><strong>其它：</strong></span></p>
<p><span style="font-size: 16px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp; </strong></span>由于python编译后的DLL还是需要python相关依赖实在太大，就不提供DLL例子了,不会以上3种语言就exe吧。<br />&nbsp;&nbsp; &nbsp;&nbsp; Python、Perl或其它类似脚本可配置Cscan.ini当成EXE来调用,如python.exe scan.py 192.168.1.1<br />&nbsp;&nbsp; &nbsp;&nbsp; 但你并不能保证目标一定安装有对应python依赖包，所以还是得编译成EXE比较好，<br />&nbsp;&nbsp; &nbsp;&nbsp; 如果不编译也会产生30个Python.exe进程，因为py脚本是靠python.exe来执行的。<br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bat也会产生一堆被执行系统命令的EXE进程，最佳方案把相关命令写成一个EXE。<br />&nbsp;&nbsp; &nbsp;&nbsp; 最主要是多线程不好同时监视BAT调用的命令是否执行完成，无法准确获取回显。<br />&nbsp;&nbsp; &nbsp; &nbsp;<br />&nbsp;&nbsp; &nbsp; &nbsp;<br />build 20190312 by K8哥哥<br /><br />=======================================================================<br /><span style="font-size: 16px;"><strong>2.0 用法：</strong></span><br /><br />2.0已支持调用自定义参数程序,默认用法与1.0一致<br /><br />把需要调用的程序改名为scan.exe (程序用法必须为: scan.exe ip)<br />ip.txt填上需要扫描的IP或IP段，程序自动转换为IP段。<br /><br />自定义参数例子<br /><br /><strong><span style="font-size: 16px;">0x001 批量获取C段Web主机标题</span></strong><br />程序用法 LanWebScan.exe gettitle 192.168.1.1<br /><br />配置Cscan.ini<br />[Cscan]<br />exe=LanWebScan.exe<br />arg=gettitle $ip$<br /><br />命令行下执行cscan<br /><br /><strong><span style="font-size: 16px;">0x002 调用S扫描C段主机开放端口</span></strong><br /><br />程序用法s.exe TCP 12.12.12.12 21,3389 8<br /><br />配置Cscan.ini<br />[Cscan]<br />exe=s.exe<br />arg=TCP $ip$ 21,80,3306,3389,1521<br /><br />命令行下执行cscan<br /><br />build 20190308 by K8哥哥<br /><br /><br />=======================================================================<br /><br /><span style="font-size: 16px;"><strong>1.0 用法：</strong></span><br /><br />把需要调用的程序改名为scan.exe (程序用法必须为: scan.exe ip)<br />ip.txt填上需要扫描的IP或IP段，程序自动转换为IP段。<br /><br />PS：kscan支持自定义参数，cscan暂不支持自定义参数。<br /><br />build 20180531 by K8哥哥<br /><br /><br /><span style="font-size: 16px;"><strong>1.0 例子</strong> </span><br />&nbsp;<br /><span style="font-size: 16px;"><strong>0x001 批量扫描多个C段SMB漏洞</strong></span><br />========================================================<br />单个：使用checker.exe检测单个IP 用法：checker.exe ip<br /><br />批量扫描C段<br />把checker.exe改为scan.exe放置于程序根目录<br />在ip.txt里填上需要扫描的IP段，运行cscan即可<br /><br /><br /><strong><span style="font-size: 16px;">0x002 批量ping多个C段在线主机(调用系统ping)</span></strong><br />========================================================<br />单个：系统ping命令大家都会用，就是ping ip<br /><br />批量多个C段<br />复制系统自带ping.exe改为scan.exe放置于程序根目录<br />在ip.txt里填上需要扫描的IP段,运行cscan即可</p>
<p><span style="font-size: 16px;"><strong>下载:</strong></span><br />主程序：&nbsp;&nbsp; <a href="https://github.com/k8gege/K8tools/blob/master/K8%20Cscan%203.0.rar" target="_blank">https://github.com/k8gege/K8tools/blob/master/K8%20Cscan%203.0.rar</a></p>
<p>模块源码：<a href="https://github.com/k8gege/K8CScan" target="_blank">https://github.com/k8gege/K8CScan</a></p>
