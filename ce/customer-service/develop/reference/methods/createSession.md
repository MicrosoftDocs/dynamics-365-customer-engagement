---
title: "createSession method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the createSession API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# createSession (app profile manager)

Creates a session based on a session template and returns the unique identifier of the session.

## Syntax

`Microsoft.Apm.createSession(SessionInput);`

## Parameters

| Name         | Type           | Required     | Description            |
|-----------   |----------------|--------------|--------------------    |
| SessionInput |    String      |      Yes     | JSON input properties of the session to be created.         |


The structure of the JSON `SessionInput` parameter is as follows:

```json
{
        /**
         * Returns the name of the template used in the session
         */
        templateName: string;
        /**
         * additional information for session creation
         */
        sessionContext: Map<string, string>;
        /**
         * will focus after session is created
         */
        isFocused?: boolean;
    }
```

## Return value

Session identifier as String.


## Examples

These examples use the `createSession` method to create a new session passing an entity record identifier and a session template as parameters.

### Create a basic session

Creates a new session passing the incident as entity name, incident Id as entityId, and unique name of the session template as templateName.

> [!Note]
> The user invoking these methods must be assigned to an app profile that contains the session template.

```JavaScript
x=new Map();
x.set("parametersStr", '[["entityName", "incident"], ["entityId", "11bb11bb-cc22-dd33-ee44-55ff55ff55ff"]]');
Microsoft.Apm.createSession({templateName: "case_entity_session_default_template", sessionContext: x});
```

### Create a session that is not in focus

```JavaScript
x=new Map(); 
x.set("parametersStr", '[["entityName", "incident"], ["entityId", "22cc22cc-dd33-ee44-ff55-66aa66aa66aa"]]'); 
Microsoft.Apm.createSession({templateName: "case_entity_session_default_template", sessionContext: x, isFocused: false}); 
```



[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
