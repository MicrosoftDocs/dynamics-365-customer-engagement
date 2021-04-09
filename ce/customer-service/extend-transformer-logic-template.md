---
title: Extend transformer logic on templates (Dynamics 365 Customer Service) | MicrosoftDocs
description: 
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365CS
---
# Extend transformer logic on templates

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Customers can overwrite the out-of-the-box transformer logic by creating a plug-in and registering it as `msdyn_GetKAObjectFromTemplate` message.

Follow the procedure given below to extend the transformer logic for your knowledge article templates.

1. Create a plug-in by following the steps mentioned in [Create a plug-in project](/powerapps/developer/common-data-service/tutorial-write-plug-in#BKMK_create).
2. You can write your own mapping logic with the transformed `kaobject` using `context.OutputParameters["Result"]` as Entity. In this example, we will show how you can pre-populate the knowledge article content section with "Hello World". In the plug-in that you created, replace the comment `// Plug-in business logic goes here` with the sample code given below.

```csharp
Entity kaobject = new Entity();
kaobject = context.OutputParameters["Result"] as Entity;
// Changing the content of knowledge article object to "Hello World"
kaobject["content"] = "Hello World";
```
3. Follow the steps mentioned in [Register a plug-in](/powerapps/developer/common-data-service/tutorial-write-plug-in#BKMK_register) to register your plug-in.
4. Now, when you create a new knowledge article from the existing template, you will be able to see the content section pre-populated with "Hello World".

## See also

[Create a knowledge article using template](create-knowledge-article-using-template.md)<br />
[Tutorial: Write and register a plug-in](/powerapps/developer/common-data-service/tutorial-write-plug-in)


[!INCLUDE[footer-include](../includes/footer-banner.md)]