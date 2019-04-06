<p><span style="font-size: 16px;">[原创]K8 Cscan 3.2大型内网渗透自定义扫描器</span><br /><span style="font-size: 16px;"><a href="https://www.cnblogs.com/k8gege/p/10519321.html" target="_blank">https://www.cnblogs.com/k8gege/p/10519321.html</a></span></p>
<p><span style="font-size: 15px;">Cscan分为检测存活主机、非检测存活主机两个版本 程序采用多线程批量扫描大型内网IP段C段存活主机(支持上万个C段)</span><br /><span style="font-size: 15px;">插件含C段旁注扫描、子域名扫描、Ftp密码爆破、Mysql密码爆、系统密码爆破、存活主机扫描、Web信息探测、端口扫描</span><br /><span style="font-size: 15px;">支持调用任意外部程序或脚本，支持自定义模块，当然<span class="flex-auto mb-2"><span class="text-gray-dark mr-2">也可用于外网扫描（如子域名、C段旁注、FTP破、MYSQL爆破等）</span></span></span></p>
<p><span style="font-size: 18px;"><strong>主程序功能：</strong><br /><span style="font-size: 15px;">1.支持批量IP段C段扫描(成千上万C段没问题)<br /><span style="font-size: 15px;">2.支持指定范围IP段C段扫描、支持指定IP扫描<br /><span style="font-size: 15px;">3.支持调用自定义程序(系统命令或第三方程序)<br /><span style="font-size: 15px;">4.支持自定义模块(功能基于模块源码修改即可)</span></span></span></span></span></p>
<p><span style="font-size: 18px;"><strong>程序&amp;插件:</strong></span><br /><span style="font-size: 15px;">[+] 主程序&nbsp;&nbsp; K8Cscan 3.2.rar 大型内网渗透扫描器</span><br /><span style="font-size: 15px;">[+] 模块插件 K8Cscan Moudle FtpScan.rar Ftp密码扫描插件</span><br /><span style="font-size: 15px;">[+] 模块插件 K8Cscan Moudle MysqlScan.rar Mysql密码扫描插件</span><br /><span style="font-size: 15px;">[+] 模块插件 K8Cscan Moudle OnlinePC.rar 存活主机扫描插件</span><br /><span style="font-size: 15px;">[+] 模块插件 K8Cscan Moudle WebBanner.rar WebBanner标题扫描插件</span><br /><span style="font-size: 15px;">[+] 模块插件 K8Cscan Moudle WmiScan.rar Wmi扫描Win系统密码插件</span><br /><span style="font-size: 15px;">[+] 独立工具 K8Cscan for SameWeb.rar C段旁站扫描工具</span><br /><span style="font-size: 15px;">[+] 独立工具 K8Cscan for SubDomain.rar 子域名扫描工具</span><br /><span style="font-size: 15px;">[+] Demo源码 支持自定义插件、EXE、脚本等（附C#/VC/Delphi/Python源码)</span><br /><span style="font-size: 15px;">[+] 插件源码 K8Cscan Moudle PortScan.cs&nbsp; 端口扫描插件源码(自行编译)</span><br /><span style="font-size: 15px;">[+] 插件源码 c# netscan 存活主机 &amp; Web信息插件源码(以上已发布成品)</span></p>
<p>&nbsp;</p>
<p><span style="font-size: 16px;"><strong>例子: 3.2以上版本独立EXE默认扫描机器所处内网C段存活机器</strong></span></p>
<p><span style="font-size: 15px;">直接cmd下启动cscan</span></p>
<p><strong><span style="font-size: 15px;"><img src="https://img2018.cnblogs.com/blog/1463611/201904/1463611-20190407010530040-1494779713.png" alt="" /></span></strong></p>
<p><span style="font-size: 16px;"><strong>例子1: 配置Cscan.ini 调用外部程序S扫描器扫描C段主机开放端口</strong></span></p>
<p><span style="font-size: 15px;">配置Cscan.ini<br />[Cscan]<br />exe=s.exe<br />arg=TCP $ip$ 21,80,3306,3389,1521<br /><br />命令行下执行cscan</span></p>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201903/1463611-20190312200210710-22698312.png" alt="" /></p>
<p><strong><span style="font-size: 16px;">例子2: 调用c#编写的DLL扫描内网WEB主机Banner以及标题</span></strong></p>
<p>DLL源码 <a href="https://www.cnblogs.com/k8gege/p/10519512.html" target="_blank">https://www.cnblogs.com/k8gege/p/10519512.html</a></p>
<p>已编译：<a href="https://www.cnblogs.com/k8gege/p/10650610.html" target="_blank">https://www.cnblogs.com/k8gege/p/10650610.html</a></p>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201903/1463611-20190312200408983-358773201.jpg" alt="" /></p>
<p><span style="font-size: 16px;"><strong>例子3: K8Cscan新增C段旁站扫描插件\子域名扫描插件</strong></span></p>
<p><span style="font-size: 16px;">&nbsp;<a href="https://www.cnblogs.com/k8gege/p/10626465.html" target="_blank">https://www.cnblogs.com/k8gege/p/10626465.html</a></span></p>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201903/1463611-20190330123634041-483117211.png" alt="" /></p>
<p><strong><span style="font-size: 16px;">例子4: K8Cscan插件之FTP密码爆破</span></strong></p>
<div><strong><span style="font-size: 16px;"><a href="https://www.cnblogs.com/k8gege/p/10650630.html%20" target="_blank">https://www.cnblogs.com/k8gege/p/10650630.html
</a></span></strong></div>
<div><img src="https://img2018.cnblogs.com/blog/1463611/201904/1463611-20190403183627098-963540691.png" alt="" /></div>
<div>
<div><span style="font-size: 16px;"><strong> 例子5:&nbsp; K8Cscan插件之Mysql密码爆破</strong></span><br /><a href="https://www.cnblogs.com/k8gege/p/10650642.html%20" target="_blank"><span style="font-size: 16px;"><strong>https://www.cnblogs.com/k8gege/p/10650642.html
</strong></span></a></div>















</div>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201904/1463611-20190403183709383-1787739211.png" alt="" /></p>
<p><span style="font-size: 16px;"><strong>例子6:&nbsp; K8Cscan插件之Wmi爆破Windows密码</strong></span></p>
<div><span style="font-size: 16px;"><strong><a href="https://www.cnblogs.com/k8gege/p/10650659.html%20" target="_blank">https://www.cnblogs.com/k8gege/p/10650659.html
</a></strong></span></div>
<div><img src="https://img2018.cnblogs.com/blog/1463611/201904/1463611-20190403183752920-1000441903.png" alt="" /></div>
<p>&nbsp;</p>
<p><strong><span style="font-size: 18px;">更新历史</span> </strong></p>
<p><strong><span style="font-size: 16px;">3.2 独立EXE默认扫描C段存活主机<br /></span></strong><span style="font-size: 16px;"><span style="font-size: 15px;">即无cscan.ini或相关DLL时，程序相当于Cping，自动扫描当前机器所处C段存活主机。</span></span><span style="font-size: 16px;"><br /><span style="font-size: 15px;">端口扫描插件例子源码</span></span></p>
<p><strong><span style="font-size: 16px;">3.1 支持单个IP扫描</span></strong><br />例子：Cscan.exe 192.11.22.8</p>
<p><br /><span style="font-size: 16px;"><strong>3.0 DLL调用（支持C# DLL \ VC DLL \Delphi DLL）</strong></span><br /><br />Demo<br />C# DLL 名称必须为netscan.dll &nbsp;&nbsp; &nbsp; （源码例子为获取IP对应机器名，其它功能自己写）<br />VC DLL 名称必须为vcscan.dll &nbsp;&nbsp;&nbsp; &nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br />Delphi DLL 名称必须为descan.dll&nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br /><br />EXE (非scan.exe或多参数需配置cscan.ini)<br />scan.py&nbsp;&nbsp; 使用pyinstaller打包成exe（源码例子为打印在线主机IP，其它功能自己写）<br />scan.cs&nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br />scan.cpp （源码例子为打印在线主机IP，其它功能自己写）<br /><br /><span style="font-size: 16px;">调用优先级</span><br /><span style="font-size: 16px;">为 netscan.dll &gt;&gt; vcscan.dll &gt;&gt; descan.dll &gt;&gt; Cscan.ini &gt;&gt; scan.exe 同目录下同时含以下多个文件时，仅会调用一个。</span><br /><span style="font-size: 16px;">Cscan.ini 支持exe自定义参数，其它均只支持IP。</span><br /><br /><span style="font-size: 16px;"><strong>注意：</strong></span></p>
<p><span style="font-size: 16px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>调用EXE可能会在运行机器上产生30个exe进程,所以建议将功能写成DLL比较好。</span><br /><span style="font-size: 16px;">&nbsp;&nbsp; &nbsp;&nbsp; 不懂代码的或实在无法实现功能的可使用exe或配置cscan.ini文件（如批量ping，WMI批量种马等）</span><br /><br />&nbsp;&nbsp; &nbsp; &nbsp;<br /><span style="font-size: 16px;"><strong>其它：</strong></span></p>
<p><span style="font-size: 16px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp; </strong></span>由于python编译后的DLL还是需要python相关依赖实在太大，就不提供DLL例子了,不会以上3种语言就exe吧。<br />&nbsp;&nbsp; &nbsp;&nbsp; Python、Perl或其它类似脚本可配置Cscan.ini当成EXE来调用,如python.exe scan.py 192.168.1.1<br />&nbsp;&nbsp; &nbsp;&nbsp; 但你并不能保证目标一定安装有对应python依赖包，所以还是得编译成EXE比较好，<br />&nbsp;&nbsp; &nbsp;&nbsp; 如果不编译也会产生30个Python.exe进程，因为py脚本是靠python.exe来执行的。<br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bat也会产生一堆被执行系统命令的EXE进程，最佳方案把相关命令写成一个EXE。<br />&nbsp;&nbsp; &nbsp;&nbsp; 最主要是多线程不好同时监视BAT调用的命令是否执行完成，无法准确获取回显。<br />&nbsp;&nbsp; &nbsp; &nbsp;<br />&nbsp;&nbsp; &nbsp; &nbsp;<br />build 20190312 by K8哥哥<br /><br />=======================================================================<br /><br /></p>
<p><span style="font-size: 16px;"><strong>下载:</strong></span><br />主程序：<a href="https://github.com/k8gege/K8tools/blob/master/K8Cscan%203.2.rar" target="_blank">https://github.com/k8gege/K8tools/blob/master/K8Cscan%203.2.rar</a></p>
<p>模块源码：<a href="https://github.com/k8gege/K8CScan" target="_blank">https://github.com/k8gege/K8CScan</a></p>








</div>
<p><img src="https://img2018.cnblogs.com/blog/1463611/201904/1463611-20190403183709383-1787739211.png" alt="" /></p>
<p><span style="font-size: 16px;"><strong>例子6:&nbsp; K8Cscan插件之Wmi爆破Windows密码</strong></span></p>
<div><span style="font-size: 16px;"><strong><a href="https://www.cnblogs.com/k8gege/p/10650659.html%20" target="_blank">https://www.cnblogs.com/k8gege/p/10650659.html
</a></strong></span></div>
<div><img src="https://img2018.cnblogs.com/blog/1463611/201904/1463611-20190403183752920-1000441903.png" alt="" /></div>
<p>&nbsp;</p>
<p><strong><span style="font-size: 18px;">更新历史</span> </strong></p>
<p><strong><span style="font-size: 16px;">3.2 独立EXE默认扫描C段存活主机<br /></span></strong><span style="font-size: 16px;"><span style="font-size: 15px;">即无cscan.ini或相关DLL时，程序相当于Cping，自动扫描当前机器所处C段存活主机。</span></span><span style="font-size: 16px;"><br /><span style="font-size: 15px;">端口扫描插件例子源码</span></span></p>
<p><strong><span style="font-size: 16px;">3.1 支持单个IP扫描</span></strong><br />例子：Cscan.exe 192.11.22.8</p>
<p><br /><span style="font-size: 16px;"><strong>3.0 DLL调用（支持C# DLL \ VC DLL \Delphi DLL）</strong></span><br /><br />Demo<br />C# DLL 名称必须为netscan.dll &nbsp;&nbsp; &nbsp; （源码例子为获取IP对应机器名，其它功能自己写）<br />VC DLL 名称必须为vcscan.dll &nbsp;&nbsp;&nbsp; &nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br />Delphi DLL 名称必须为descan.dll&nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br /><br />EXE (非scan.exe或多参数需配置cscan.ini)<br />scan.py&nbsp;&nbsp; 使用pyinstaller打包成exe（源码例子为打印在线主机IP，其它功能自己写）<br />scan.cs&nbsp; （源码例子为打印在线主机IP，其它功能自己写）<br />scan.cpp （源码例子为打印在线主机IP，其它功能自己写）<br /><br /><span style="font-size: 16px;">调用优先级</span><br /><span style="font-size: 16px;">为 netscan.dll &gt;&gt; vcscan.dll &gt;&gt; descan.dll &gt;&gt; Cscan.ini &gt;&gt; scan.exe 同目录下同时含以下多个文件时，仅会调用一个。</span><br /><span style="font-size: 16px;">Cscan.ini 支持exe自定义参数，其它均只支持IP。</span><br /><br /><span style="font-size: 16px;"><strong>注意：</strong></span></p>
<p><span style="font-size: 16px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>调用EXE可能会在运行机器上产生30个exe进程,所以建议将功能写成DLL比较好。</span><br /><span style="font-size: 16px;">&nbsp;&nbsp; &nbsp;&nbsp; 不懂代码的或实在无法实现功能的可使用exe或配置cscan.ini文件（如批量ping，WMI批量种马等）</span><br /><br />&nbsp;&nbsp; &nbsp; &nbsp;<br /><span style="font-size: 16px;"><strong>其它：</strong></span></p>
<p><span style="font-size: 16px;"><strong>&nbsp;&nbsp;&nbsp;&nbsp; </strong></span>由于python编译后的DLL还是需要python相关依赖实在太大，就不提供DLL例子了,不会以上3种语言就exe吧。<br />&nbsp;&nbsp; &nbsp;&nbsp; Python、Perl或其它类似脚本可配置Cscan.ini当成EXE来调用,如python.exe scan.py 192.168.1.1<br />&nbsp;&nbsp; &nbsp;&nbsp; 但你并不能保证目标一定安装有对应python依赖包，所以还是得编译成EXE比较好，<br />&nbsp;&nbsp; &nbsp;&nbsp; 如果不编译也会产生30个Python.exe进程，因为py脚本是靠python.exe来执行的。<br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bat也会产生一堆被执行系统命令的EXE进程，最佳方案把相关命令写成一个EXE。<br />&nbsp;&nbsp; &nbsp;&nbsp; 最主要是多线程不好同时监视BAT调用的命令是否执行完成，无法准确获取回显。<br />&nbsp;&nbsp; &nbsp; &nbsp;<br />&nbsp;&nbsp; &nbsp; &nbsp;<br />build 20190312 by K8哥哥<br /><br />=======================================================================<br /><span style="font-size: 16px;"><strong>2.0 用法：</strong></span><br /><br />2.0已支持调用自定义参数程序,默认用法与1.0一致<br /><br />把需要调用的程序改名为scan.exe (程序用法必须为: scan.exe ip)<br />ip.txt填上需要扫描的IP或IP段，程序自动转换为IP段。<br /><br />自定义参数例子<br /><br /><strong><span style="font-size: 16px;">0x001 批量获取C段Web主机标题</span></strong><br />程序用法 LanWebScan.exe gettitle 192.168.1.1<br /><br />配置Cscan.ini<br />[Cscan]<br />exe=LanWebScan.exe<br />arg=gettitle $ip$<br /><br />命令行下执行cscan<br /><br /><strong><span style="font-size: 16px;">0x002 调用S扫描C段主机开放端口</span></strong><br /><br />程序用法s.exe TCP 12.12.12.12 21,3389 8<br /><br />配置Cscan.ini<br />[Cscan]<br />exe=s.exe<br />arg=TCP $ip$ 21,80,3306,3389,1521<br /><br />命令行下执行cscan<br /><br />build 20190308 by K8哥哥<br /><br />=======================================================================<br /><br /></p>
<p><span style="font-size: 16px;"><strong>下载:</strong></span><br />主程序：<a href="https://github.com/k8gege/K8tools/blob/master/K8Cscan%203.2.rar" target="_blank">https://github.com/k8gege/K8tools/blob/master/K8Cscan%203.2.rar</a></p>
<p>模块源码：<a href="https://github.com/k8gege/K8CScan" target="_blank">https://github.com/k8gege/K8CScan</a></p>
