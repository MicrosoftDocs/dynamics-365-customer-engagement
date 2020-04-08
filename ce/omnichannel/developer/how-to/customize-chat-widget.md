---
title: "Customize a chat widget | Microsoft Docs"
description: "Read how you can customize chat widgets by using data tags on the chat widget script"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 04/08/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Customize a chat widget

Chat widgets can be customized by using data tags on the chat widget script.

|Attribute name|Description|Example|
|----|-----|-----|
|`data-hide-chat-button`| When the HTML snippet is added to a website, a widget shows up on that website by default. In some cases, customers may want to implement the chat widget using their own button so this attribute allows customers to hide the chat button. | Add this tag to the chat widget script that you got from the Omnichannel Administration page.<br /><br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-chat-button="true"></script>`|

## See also

[Start proactive chat](start-proactive-chat.md)<br />
[JavaScript API reference for Live chat SDK](../omnichannel-reference.md)