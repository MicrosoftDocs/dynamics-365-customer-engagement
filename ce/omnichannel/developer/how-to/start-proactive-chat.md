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

### Scenario 1

Amy has accidentally damaged her Surface Book and is on the product knowledge base trying to seek answers for about 20 seconds. She is then offered a proactive chat.

A chat pop-up is triggered based on the product page that Amy is browsing and the time spent on the page.

Here is the chat invitation message that is sent.

```
Hi! Just checking in to see if I can help answer any questions you may have. 
```

Amy can accept the chat offer and continue a conversation with the bot to sort out her issue 

#### Sample code

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
