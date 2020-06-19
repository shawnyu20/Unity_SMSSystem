# Unity_SMSSystem

## Unity發送SMS推送簡訊    

* 建立 `SMSSystem.cs` 新增以下資訊          
* 新增變數手機號碼與訊息:    
```
public InputField MobileNo
public InputField Message
```    
* 獲取變數內容:       
```
string numbers = MobileNo.text;
string message = MainMessage.text;
```
* 新增簡訊發送:     
```
Application.OpenURL(string.Format("sms:" + numbers + "&body=" + message));    
```



