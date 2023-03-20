---
title: "canCreateSession method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the canCreateSession API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/01/2021
ms.topic: reference
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
x.set("parametersStr", '[["entityName", "incident"], ["entityId", "fac04293-1ab0-eb11-8236-000d3a5c49ed"]]');
Microsoft.Apm.createSession({templateName: "case_entity_session_default_template", sessionContext: x});
}
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
