---
title: "Execute scripts using scriptlets in Unified Service Desk | MicrosoftDocs"
description: "Scriptlets are snippets of JavaScript that are executed when using a special syntax for your replacement parameter."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Execute scripts using scriptlets in Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Scriptlets are snippets of JavaScript that are executed when using a special syntax for your replacement parameter. Sometimes the system generated replacement parameters contain the proper data needed for these functions, but might not contain the data in the desired format. For example, in Computer Telephone Integration (CTI), phone numbers typically arrive from phone system as a string of digits such as “3035551212”, without any formatting. However, Microsoft Dataverse stores phone numbers as a string that typically includes formatting characters such as dashes as in (303) 555-1212. If you were to search your entity using the data supplied directly by the phone system, changes are slim that a match would ever be found. You address this using scriptlets in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
<a name="HowTo"></a>   
## How to use scriptlets?  
 You define a scriptlet in the **Scriptlets** area (**Settings** > **Scriptlets**) in Dataverse. After you have defined a scriptlet, you use the scriptlet in the following format as a replacement parameter in your queries or parameters to the action calls.  
  
```  
[[script.<Scriptlet_Name>]]  
```  
  
 When the system sees such a replacement parameter starting with **script.**, it will look for a script with the name matching the text following it in your scriptlet list. If it finds a scriptlet with the specified name, it will first replace parameters within that script, and then execute the script as a JavaScript expression. The value of the expression will be used to replace the value of the replacement above.  
  
> [!WARNING]
>  If your replacement parameters in the scriptlet contain another scriptlet replacement, and so on until it creates a loop, it will cause the system to continuously substitute parameters until the stack overflows. As a result, it is highly recommended that you never use `[[script.ReplacementParameters]]` in your scriptlets.  
  
<a name="RferringToGlobalHC"></a>   
## Referring to global hosted controls from your scriptlets  
 Scriptlets can reference global hosted control methods while executing. All global (non-dynamic) hosted controls are added as scriptable objects to the scriptlet engine at startup. Because JavaScript cannot refer to names with spaces in them, the scriptlet engine automatically replaces spaces in the name of your global hosted control with “_” underscores. You can therefore use the following valid JavaScript.  
  
```  
Connection_Manager.ConfigurationReader.ReadAppSettings(“maxNumberOfSessions”);  
```  
  
 There exists a special case scenario for the Global Manager. It can also be referred to via `CRMGlobalManager`, regardless of what it is named in the configuration.  
  
 If (CRMGlobalManager.SessionCount == 0)  // no customer sessions are loaded. Only a global session is loaded.  
  
> [!NOTE]
>  Only public functions are accessible via this method.  
  
 Consider a situation where you want to display session overview information in your Session Lines component but the information actually resides in an external system that is accessible via web services rather than being available in your Dataverse server. You may create a hosted control that exposes a public function, which calls the external web service. You then configure this hosted control as a global hosted control and place it on the HiddenPanel. This function and web service call is now usable from a scriptlet. You could then create the following scriptlet to call your new function.  
  
```  
My_Global_Application.CallExternalWebService(“[[account.accountnumber]$]”);  
```  
  
 This code passes the account number from the account into your function as the first parameter. If you name your scriptlet **Call Web Service**, you can then use the following Session Line to display the result of the web service call.  
  
```  
<Grid Margin="0"  
  xmlns:x="https://schemas.microsoft.com/winfx/2006/xaml"  
  xmlns:CCA="clr-namespace:Dynamics;assembly=Dynamics">  
<Grid.RowDefinitions>  
 <RowDefinition Height="auto" />  
</Grid.RowDefinitions>  
<Grid.ColumnDefinitions>  
 <ColumnDefinition Width="100"/>  
 <ColumnDefinition Width="*" />  
 <ColumnDefinition Width="auto" />  
</Grid.ColumnDefinitions>  
<Label Margin="3,0,5,3" Content="Web Service Data" Padding="0" Grid.Row="4" HorizontalAlignment="Right" FontFamily="Tohoma" FontSize="12" FontWeight="Bold" />  
<TextBlock Text="[[script.Call Web Service]]" Margin="0" Grid.Column="1" Grid.Row="4" Padding="3,0,0,3" FontFamily="Tohoma" FontSize="12"/>  
</Grid>  
```  
  
### See also  
 [Replacement parameters](../unified-service-desk/replacement-parameters.md)   
 [Global and session-based Unified Service Desk hosted controls](../unified-service-desk/unified-service-desk-hosted-controls.md#Global)


[!INCLUDE[footer-include](../includes/footer-banner.md)]