---
title: canCreateSession method (app profile manager) JavaScript API Reference 
description: Learn about the canCreateSession API of app profile manager in Customer Service workspace.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# canCreateSession (app profile manager)

Allows you to check whether a new session can be created.

> [!Note]
> Customer Service workspace lets you open up to 10 sessions simultaneously. If you open more than 10 sessions, then the following message is displayed: "Maximum sessions reached. Close a session before opening another."

## Syntax

`Microsoft.Apm.canCreateSession();`


## Return value

A Boolean value of true if a new session can be created; otherwise, false.


## Example

```JavaScript
if  (Microsoft.Apm.canCreateSession()) {
//checks if maximum allowed of sessions has been reached
x=new Map();
x.set("parametersStr", '[["entityName", "incident"], ["entityId", "11bb11bb-cc22-dd33-ee44-55ff55ff55ff"]]');
Microsoft.Apm.createSession({templateName: "case_entity_session_default_template", sessionContext: x});
}
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
