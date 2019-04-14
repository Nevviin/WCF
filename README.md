# WCF
This repository has projects related various type of wcf services


1, SimpleWcf -- Solution 

This solution comprises of a simple wcf service and a client

1, SimpleWcf.Service --> this serivice will return the integer value you passed to the GetData method with a text prefixed
2, SimpleWcf.Service  --> This is a client which access the SimpleWcf.Service which is hosted in IIS using the proxy


How to test this application once you download

1, Download or pull the complete wcf solution to you local machine
2, Try to build the entire solution 
3, Host the SimpleWcf.Service in your iis to create a url , here I hosted it in the IIS
   with the url name as www.simplewcf.com
   Please refer the screenshot inthe folder "Hosting In IIS" in this solution 
4, Hostfile update 
   Navigate to the host file in the location C:\Windows\System32\drivers\etc\hosts
   Make and entry for the local ip "127.0.0.1 www.simplewcf.com"
   Once you update the host file this , you can browse the www.simplewcf.com and it will list the directories and files in the fodler 
   refer the screenshot in the file Service_In_Browser.jpg" for how it looks like in browser
   
 5, Then select the service1.svc link and it will show the wsdl ursl in the page " http://www.simplewcf.com/Service1.svc"
 
 6, once you are able to setup the url, then you can generate the proxy class and proxy config for the client
 which I have already created in this and added 
 
 Incse if you are generating the proxy.cs and proxy config you can use the command line utility to do that 
 
 svcutil http://www.simplewcf.com/Service1.svc  /Language=c#  /t:Code  /out:D:\DotNetCode\WCF_Works\simplewcfProxy.cs /config:D:\DotNetCode\WCF_Works\simplewcfProxy.config

