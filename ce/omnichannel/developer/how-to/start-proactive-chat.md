---
title: "Start chat proactively | Microsoft Docs"
description: "Read how you can start chat proactively to see if customers need help and thereby improve customer experience"
keywords: ""
ms.date: 10/11/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: B8E99BB8-302D-4197-96FA-C8963A9560AB
author: susikka
ms.author: susikka
manager: shujoshi
---
# Start chat proactively

Anticipating areas where customers need help and then engaging them through chat when they have been browsing your website for some time helps improve customer satisfaction.

Consider the scenarios given below for initiating chat proactively.

## Scenario 1: Customer wait time

Amy has accidentally damaged her Surface Book and is on the product knowledge base trying to seek answers for about 20 seconds. She is then offered a proactive chat.

A chat pop-up is triggered based on the product page that Amy is browsing and the time spent on the page.

Here is the chat invitation message that is sent.

```
Hi! Just checking in to see if I can help answer any questions you may have. 
```

Amy can accept the chat offer and have a conversation with the bot to sort out her issue. 

### Sample code

```html
<script id="Microsoft_Omnichannel_LCWidget" src="https://oc-cdn-ocint5m.azureedge.net/livechatwidget/scripts/LiveChatBootstrapper.js" data-app-id="67be3444-1901-49de-8ba1-b1a24d34c398" data-org-id="d9631307-003e-4e5d-9ef8-5d49c8f08fbf" data-org-url="https://org77fb4aa4-crm.oc.crmlivetie.com"></script><script id="Proactivechattrigger"> 

   window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){ 
   
   Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){ 
   
   return { 
       'Time On Page':{'value':'30sec','isDisplayable':true}, 
       'Page URL':{'value':'int5.microsoftcrmportals.com/support/','isDisplayable':true}, 
        }; 
   }); 
    
    setTimeout(function(){ 
           Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(true, null) },20000); 
});    
</script>
```

If the bot fails to address the issue, it can escalate the conversation to a human agent.

## Scenario 2: Customer browsing multiple webpages

Thomas is browsing through the Microsoft Surface community webpage. He is looking for answers of his question on Microsoft Surface device. He has browsed through multiple pages but is not able to find the answers he is looking for.

Realizing this scenario, the organization offers a chat request to the customer with the message given below.

```
Hi! Do you have a question on Surface device ? I am here to help.
```
### Sample code

```html
<script id="Proactivechattrigger"> 
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){ 
Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){ 
return { 
'No. of visits':{'value':'2','isDisplayable':true}, 
'Current Page URL':{'value':'Surface Laptop','isDisplayable':true}, 
   }; 
}); 
setTimeout(function(){ 
var visits = GetCookie("counter"); 

if (visits == 2) { 
    Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(true, {message: "Hi! How are you doing today? Do you have any questions? I am here to help."}); 
    DeleteCookie("counter"); 
} 
},5000); 
}); 
</script> 

function VisitCounter(){ 
    var visits = GetCookie("counter"); 

    if (!visits) { 
                    visits = 1;  
                    document.write("."); 
                 }  

else {  

    visits = parseInt(visits) + 1; document.write("..");} 
    setCookie("counter", visits,expdate); 
     }

VisitCounter() 
```

## Scenario 3: Checking status for support case

Jacob is browsing through the support page for Microsoft Surface devices to find some more information regarding his open support case.

On realizing that Jacob has visited the support page seeking more information regarding his open case, he is offered proactive chat with the message given below.

```
Hi! How are you doing today? The status of the case: <Case No> is "In Progress". Would you like to get more details? 
```

### Sample code

```html
<script id="Microsoft_Omnichannel_LCWidget" src="https://oc-cdn-ocint5m.azureedge.net/livechatwidget/scripts/LiveChatBootstrapper.js" data-app-id="67be3444-1901-49de-8ba1-b1a24d34c398" data-org-id="d9631307-003e-4e5d-9ef8-5d49c8f08fbf" data-org-url="https://org77fb4aa4-crm.oc.crmlivetie.com"></script> 
<script id="Proactivechattrigger"> 
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){ 
    Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){ 
    return { 
        'Case Id':{'value':'CAS-01000-C7D0Q6','isDisplayable':true}, 
        'Case Status':{'value':'InProgress','isDisplayable':true}, 
           }; 
}); 
 
setTimeout(function(){ 
    Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(false, {message: "Hi! How are you doing today? The status of the case:CAS-01000-C7D0Q6 is in progress. Would you like to get more details?"}) 
        },10000); 
    }); 
</script> 
```

## See also

[Manage custom context](send-context-starting-chat.md)<br />
[Initiate a chat](initiate-chat-wait-time.md)<br />
[Display custom context](display-custom-context.md)<br />
[Live chat JavaScript API reference](../omnichannel-reference.md)