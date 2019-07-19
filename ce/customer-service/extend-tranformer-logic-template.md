---
title: Extend transformer logic on templates (Dynamics 365 for Customer Service) | MicrosoftDocs
description: ""
keywords:
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

Customers can overwrite the out-of-the-box transformer logic by creating a plugin and registering it as `msdyn_GetKAObjectFromTemplate` message.

Follow the procedure given below to extend the transformer logic for your knowledge article templates.

1. Copy and paste the sample code given below into your plugin code to create a logic where the content section of the knowledge article template is pre-populated with "Hello World".

```csharp
Entity kaobject = new Entity();
kaobject = context.OutputParameters["Result"] as Entity;
// Changing the content of knowledge article object to "Hello World"
kaobject["content"] = "Hello World";
```

2. While registering, select `PostOperation` in **Event Pipeline Stage of Execution**.
3. Once done, select **Register New Step**.

## See also

[Create a knowledge article using template](create-knowledge-article-using-template.md)