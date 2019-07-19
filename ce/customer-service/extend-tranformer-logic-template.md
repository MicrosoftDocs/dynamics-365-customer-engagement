---
title: Extend transformer logic on templates (Dynamics 365 for Customer Service) | MicrosoftDocs
description: ""
keywords: Customer Service Hub; Customer Service;  Microsoft Dynamics 365 for Customer Engagement;
author: susikka
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.author: susikka
manager: shujoshi
ms.date: 07/30/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 3BEFC582-E967-4310-8744-60639EF56200
ms.custom: dyn365-customerservice
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365CS
---
# Extend transformer logic on templates

Customers can overwrite the out-of-the-box transformer logic by creating a plug-in and registering it as `msdyn_GetKAObjectFromTemplate` message.

Follow the procedure given below to extend the transformer logic for your knowledge article templates.

1. Create a plug-in by following the steps mentioned in [Create a plug-in project](/powerapps/developer/common-data-service/tutorial-write-plug-in#BKMK_create).
2. You can write your own mapping logic with the transformed `kaobject` using `context.OutputParameters["Result"]` as Entity. In this example, we will show how you can pre-populated the knowledge article content section with "Hello World".

In the plug-in that you created, replace the comment `// Plug-in business logic goes here` with the sample code given below.

```csharp
Entity kaobject = new Entity();
kaobject = context.OutputParameters["Result"] as Entity;
// Changing the content of knowledge article object to "Hello World"
kaobject["content"] = "Hello World";
```

2. Follow the steps mentioned in [Register a plug-in](/powerapps/developer/common-data-service/tutorial-write-plug-in#BKMK_register) to register your plug-in using the plug-in registration tool.
3. Now, when you create a new knowledge article from the existing template, you will be able to see the content section pre-populated with "Hello World".

## See also

[Create a knowledge article using template](create-knowledge-article-using-template.md)