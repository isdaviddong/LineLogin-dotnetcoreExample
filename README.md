# LineLogin-dotnetcoreExample
This example shows how to implement LINE login SSO in the .net core Razor PageModel

## how to use it?
1. clone this repo
2. replace the following parameter which in the file 'appsettings.json' with your LINE Login channel ID/Secret
```
 "LINE-Login-Setting": {
    "Channel_ID": "_____replace_with_channel_id________",
    "Channel_Secret": "____replace_with_channel_secret______",
    "CallbackURL": "http://localhost:50416/callback"  
  }
```
3. update the Callback url in the LINE developer portal
<img src='https://i.imgur.com/rDmURwy.png' />
4. go to the folder which included the file 'LineLogin.csproj'
5. Run this app with following command  (of couse, dotnet core 2.2 need to installed):
```
dotnet run
```
6. OR, you can simply use visual studio 2019 to open and run this project

<img src='https://i.imgur.com/1grmNo9.png' />

# resources:
LineBotSDK：https://www.nuget.org/packages/LineBotSDK  
相關課程：http://www.studyhost.tw/NewCourses/LineBot  
線上課程：https://www.udemy.com/line-bot/  
更多內容，請參考電子書：https://www.pubu.com.tw/ebook/103305  
LINE Bot 實體書籍：https://www.tenlong.com.tw/products/9789865020354