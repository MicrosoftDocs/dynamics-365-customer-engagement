---
title: "createSession method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager createSession API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: createSession (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

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

These examples use the `createSession` method to launch a new session passing an entity record identifier and a session template.

### Basic session creation

Launches a new session passing the incident as entity name, incident Id as entityId, and unique name of the session template as templateName.

> [!Note]
> The user invoking these methods requires to be assigned to an app profile that contains the session template.

```JavaScript
x=new Map();
x.set("parametersStr", '[["entityName", "incident"], ["entityId", "fac04293-1ab0-eb11-8236-000d3a5c49ed"]]');
Microsoft.Apm.createSession({templateName: "case_entity_session_default_template", sessionContext: x});
```

### Session creation but without focusing

```JavaScript
x=new Map(); 
x.set("parametersStr", '[["entityName", "incident"], ["entityId", "0e0e6c4f-cbb6-eb11-8236-000d3a5ab8b9"]]'); 
Microsoft.Apm.createSession({templateName: "case_entity_session_default_template", sessionContext: x, isFocused: false}); 
```



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
