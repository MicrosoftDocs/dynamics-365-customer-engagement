---
title: "Customize Dynamics 365 for Marketing | Microsoft Docs "
description: "How to customize lists, forms, workflows, business processes, validations, and more in Dynamics 365 for Marketing"
keywords: "customize;workflow;business process;validation"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a615251f-ce0e-45cf-8e73-3dc74657982a
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Customize [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

## Customize [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is built on the standard [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] infrastructure, which provides rich possibilities for customization without coding. Customizers can add new fields to existing entities, add or hide fields in list or form views, design custom business processes and workflows, and much more—all while working in their web browser. Other types of customization include installing custom solutions from [!INCLUDE[pn-microsoft-appsource](../includes/pn-microsoft-appsource.md)], such as a third-party SMS solution for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. The system also provides APIs that enable developers to write code that implements even more advanced custom functionality and third-party integration.

The techniques for customizing the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] application are like those for customizing other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] customer engagement applications—especially [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. You can make many of the most common types of customizations while working directly in the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but even more types of customization settings are available in the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]—Custom app.

The [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]—Custom app is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. It combines features from many of the various [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps you have licensed into a single navigation structure (but most [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] end-user features aren’t included here). The Custom app operates on the same database as [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so settings made in the Custom app (including for customization, user administration, events, LinkedIn Lead Gen, [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)], and more) can affect the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app.

To go to the customization settings in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], go to the **Settings** work area, choose **Advanced Settings** and then work in the **Customization** section, where you can edit the **Views** and **Business & process flows**. To go to the **Custom** app, which provides access to these customization settings and more, choose **[!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]—Custom** from the app-selector menu and then go to **Settings > Customization**. The following image shows how to use the app-selector menu to switch between the **Marketing** and **Custom** apps.


[comment]: <> (add screenshot)

 
For complete details about how to customize [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], see the [Customization Guide for Dynamics 365 Customer Engagement](../customize/overview.md). That guide describes the interface as you see it in the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]—Custom app, but those customization features also provided in the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] implement similar concepts, operate on the same database, and work similarly. For details about customizations that apply only to the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app (but not other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps), see the other sections in this topic.

For more information about writing code and developing for [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], see the [Dynamics 365 Developer’s Center](https://msdn.microsoft.com/en-us/dynamics365).

## Add custom validation rules to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]


A standard feature of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]
 is its ability to check published content for errors before going live. You’ve probably seen this feature at work when designing email messages, customer journeys, forms, lead-scoring models, and other features that use the content designer interface. The validation (check for errors) feature works by checking for missing content (such as a required setting or a subscription-center link in a marketing email) and errors (such as illogical settings, syntax errors or messages that won’t compile). After the error check, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] displays the results right on the page, including error messages that should help the user solve the issue.

The validation feature works by implementing a validation pipeline with a series of rules that the content must pass. For each violation, an error or warning is added to the response and the content won’t be allowed to go live. Customizers can extend the pipeline by adding a custom validation stage that implements the required custom checks. You might use this capability to, for example, scrub email text content for obscenities or to ensure that a required disclaimer is always present.

Unlike most customization features in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], custom validation rules do require some coding to create the actual validation logic. This is simply a matter of parsing the incoming text and generating messages as needed, but details of how to do this are beyond the scope of this topic. This topic describes the requirements that your custom code must fulfil (such as keeping errors generated by previous stages, adding new ones, and passing the combined result to the next stage) and explains how to set up the system to use your custom code.



