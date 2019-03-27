---
title: "Customize Dynamics 365 for Marketing | Microsoft Docs "
description: "How to customize lists, forms, workflows, business processes, validations, and more in Dynamics 365 for Marketing"
keywords: customize;workflow;business process;validation
ms.date: 02/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-cust
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: a615251f-ce0e-45cf-8e73-3dc74657982a
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Customizing [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

## Basic customizations
[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is built on the standard [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] infrastructure, which provides rich possibilities for customization without coding. Customizers can add new fields to existing entities, add or hide fields in list or form views, design custom business processes and workflows, and much more—all while working in their web browser. Other types of customization include installing custom solutions from [!INCLUDE[pn-microsoft-appsource](../includes/pn-microsoft-appsource.md)], such as a third-party SMS solution for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. The system also provides APIs that enable developers to write code that implements even more advanced custom functionality and third-party integration.

The techniques for customizing the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] application are like those for customizing other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] applications—especially [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. You can make many of the most common types of customizations while working directly in the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but even more types of customization settings are available in the [!include[](../includes/pn-custom-app-module.md)] app.

The [!include[pn-custom-app-module](../includes/pn-custom-app-module.md)] app is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. It combines features from many of the various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps you have licensed into a single navigation structure (but most [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] end-user features aren’t included here). The custom app operates on the same database as [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so settings made in the custom app (including for customization, user administration, events, LinkedIn Lead Gen, [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)], and more) can affect the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app.

To go to the customization settings in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], go to the **Settings** work area, choose **Advanced Settings**, and then work in the **Customization** section, where you can edit views and business and process flows. To go to the custom app, which provides access to these customization settings and more, choose **[!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)]** from the app-selector menu, and then go to **Settings** > **Customization**. The following image shows how to use the app-selector menu to switch between the Marketing and custom apps.

![The app-selector menu](media/nav-apps-custom-ill.png "The app-selector menu")

For complete details about how to customize [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], see the [Customization Guide for Dynamics 365 Customer Engagement](../customize/overview.md). That guide describes the interface as you see it in the [!include[](../includes/pn-custom-app-module.md)] app, but the customization features that are also provided in the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] implement similar concepts, operate on the same database, and work similarly. 

For details about customizations that apply only to the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app (but not other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps), see the following topic:

- [Create and customize marketing calendars](customize-marketing-calendars.md)

## Create a custom app that includes Marketing solutions

Customizers and developers can create custom app modules that include any number of existing solutions, plus other custom elements, as needed. You can include 
[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] solutions in custom apps such as these, but the *Marketing email test send* entity won't be included automatically when you add the Marketing solution. As a result, your custom app won't support test sends of marketing emails by default. If you'd like to include this feature in your custom app, then you must add the *Marketing email test send* entity manually to your app after you add the Marketing solution.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design custom business apps by using the app designer](../customize/design-custom-business-apps-using-app-designer.md)

## Advanced customization through coding

Advanced customization and integration with external systems is possible through code-based interactions with the system's various APIs. For details about writing code and developing for [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], see the [Developer Guide for Dynamics 365 Customer Engagement](../developer/developer-guide.md).
