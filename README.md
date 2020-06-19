### Unity 發送 SMS推送簡訊    

* 建立 `SMSSystem.cs` 新增以下資訊          
* 新增變數手機號碼與訊息:    
```
public InputField MobileNo
public InputField Message
```    
* 獲取變數內容:       
```
string numbers = MobileNo.text; // this is your number
string message = MainMessage.text;  // this is your message
```
* 新增簡訊發送:     
```
Application.OpenURL(string.Format("sms:" + numbers + "&body=" + message));    
Application.OpenURL(string.Format("sms:" + numbers + "?body=" + message));
```
* 判斷來源裝置:       
```
if (Application.platform == RuntimePlatform.Android)
{
  Debug.Log("Android");
}
else if(Application.platform == RuntimePlatform.IPhonePlayer)
{
  Debug.Log("IOS");
}
else if(Application.platform == RuntimePlatform.OSXEditor)
{
  Debug.Log("OSXEditor");
}
else
{
  Debug.Log(Application.platform);
}
```
* 來源裝置會影響新增簡訊的調用方式    



