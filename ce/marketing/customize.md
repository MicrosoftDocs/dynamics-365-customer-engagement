---
title: "Customize Dynamics 365 Marketing | Microsoft Docs "
description: "How to customize lists, forms, workflows, business processes, validations, and more in Dynamics 365 Marketing"
keywords: customize;workflow;business process;validation
ms.date: 06/07/2019
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

# Customizing Dynamics 365 Marketing

## Basic customizations
Dynamics 365 Marketing is built on the standard Dynamics 365 for Customer Engagement infrastructure, which provides rich possibilities for customization without coding. Customizers can add new fields to existing entities, add or hide fields in list or form views, design custom business processes and workflows, and much more—all while working in their web browser. Other types of customization include installing custom solutions from Microsoft AppSource, such as a third-party SMS solution for Marketing. The system also provides APIs that enable developers to write code that implements even more advanced custom functionality and third-party integration.

> [!WARNING]
> Do not include sensitive information in your customized schema and display names. Schema and display names for fields, entities, relations, attributes, and other elements are displayed in various interfaces throughout the Marketing application. They may also be referenced by other object definitions and get shared through various other channels. They may also appear in telemetry.

The techniques for customizing the Marketing application are like those for customizing other Dynamics 365 for Customer Engagement applications—especially [!INCLUDEDynamics 365 Sales. You can make many of the most common types of customizations while working directly in the **Settings** work area of Dynamics 365 Marketing, but even more types of customization settings are available in the Dynamics 365 for Customer Engagement advanced-settings area.

The Dynamics 365 for Customer Engagement advanced-settings area provides settings that are common for all Dynamics 365 for Customer Engagement apps on your tenant, including user, security, and customization settings.

To go to the customization settings in the Dynamics 365 for Customer Engagement advanced-settings area:

1. Open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The Dynamics 365 for Customer Engagement advanced-settings area then opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator.
1. Navigate to **Settings** > **Customizations** > **Customizations**.

For complete details about how to customize Dynamics 365 for Customer Engagement, see the [Customization Guide for Dynamics 365 Customer Engagement](../customize/overview.md). That guide describes the interface as you see it in the Dynamics 365 for Customer Engagement advanced-settings area, but the customization features that are also provided in the **Settings** work area of Dynamics 365 Marketing implement similar concepts, operate on the same database, and work similarly. 

For details about customizations that apply only to the Marketing app (but not other Dynamics 365 apps), see the following topic:

- [Create and customize marketing calendars](customize-marketing-calendars.md)

## Create a custom app that includes Marketing solutions

Customizers and developers can create custom app modules that include any number of existing solutions, plus other custom elements, as needed. You can include 
Dynamics 365 Marketing solutions in custom apps such as these, but the *Marketing email test send* entity won't be included automatically when you add the Marketing solution. As a result, your custom app won't support test sends of marketing emails by default. If you'd like to include this feature in your custom app, then you must add the *Marketing email test send* entity manually to your app after you add the Marketing solution.

More information: [Design custom business apps by using the app designer](../customize/design-custom-business-apps-using-app-designer.md)

## Advanced customization through coding

Advanced customization and integration with external systems is possible through code-based interactions with the system's various APIs. For details about writing code and developing for Dynamics 365 for Customer Engagement, see the [Developer Guide for Dynamics 365 Customer Engagement](../developer/developer-guide.md).
