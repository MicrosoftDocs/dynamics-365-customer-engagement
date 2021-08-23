---
title: "canCreateSession (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the canCreateSession API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# canCreateSession

Returns a boolean value indicating whether a new session can be created.

> [!Note]
> Customer Service workspace allows users to open up to 10 sessions including the Home session. If an users tries to launch more than 10 session, then the following message is shown: "Maximum sessions reached. Close a session before opening another."

## Syntax

`Microsoft.Apm.canCreateSession()`


## Returns

A Boolean value of true if a new session can be created; otherwise false.


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
