## Welcome to GitHub Pages

C# Connect Mycat By Two ways

## first way
 Connect Mycat By  Pomelo.Mycat.dll 
 
 connectionString :   key="ConnectionString" value="server=192.168.195.164;database=mydb;uid=mycatroot;pwd=123456;Pooling=true;Connection Lifetime=120;Connection Timeout=120;Port=8066" 
 
## second way
 Connect Mycat By mysql.data.dll ,just like connect mysql , change connectionString to 
 
 key="ConnectionString" value="server=192.168.195.164;database=mydb;uid=mycatroot;pwd=123456;Pooling=true;Connection Lifetime=120;Connection Timeout=120;Port=8066" 
 
 Note: Add Port=8066 8066 is  mycat  service port
 
 
