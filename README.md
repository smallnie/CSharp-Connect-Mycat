# C# Connect Mycat By Two ways
## first way
 Connect Mycat By  Pomelo.Data.Mycat.dll and Pomelo.Data.Mysql.dll ,you can install Pomelo by nuget

Note:

 connectionString format: key="ConnectionString" value="server=192.168.195.164;database=mydb;uid=mycatroot;pwd=123456;Pooling=true;Connection Lifetime=120;Connection Timeout=120;Port=8066" 
 
## second way
 Connect Mycat By mysql.data.dll ,just like connect mysql , change connectionString  format to 
 
 key="ConnectionString" value="server=192.168.195.164;database=mydb;uid=mycatroot;pwd=123456;Pooling=true;Connection Lifetime=120;Connection Timeout=120;Port=8066" 
 
 Note:
 
 donot forget Add Port=8066 ,8066 is  mycat  service port
 
 
