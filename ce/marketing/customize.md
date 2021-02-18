---
title: "Customize Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to customize lists, forms, workflows, business processes, validations, and more in Dynamics 365 Marketing."
ms.date: 06/07/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-cust
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
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
Model-driven apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation) provide rich possibilities for customization without coding. Customizers can add new fields to existing entities, add or hide fields in list or form views, design custom business processes and workflows, and much more—all while working in their web browser. Other types of customization include installing custom solutions from Microsoft AppSource, such as a third-party SMS solution for Marketing. The system also provides APIs that enable developers to write code that implements even more advanced custom functionality and third-party integration.

> [!WARNING]
> Do not include sensitive information in your customized schema and display names. Schema and display names for fields, entities, relations, attributes, and other elements are displayed in various interfaces throughout the Marketing application. They may also be referenced by other object definitions and get shared through various other channels. They may also appear in telemetry.

The techniques for customizing Dynamics 365 Marketing are the same as those for customizing other model-driven apps in Dynamics 365. You'll make these customizations using the advanced-settings area. The advanced-settings area provides settings that are common for all Dynamics 365 model-driven apps on your tenant, including user, security, and customization settings.

To access the customization settings in the advanced-settings area:

1. Open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The advanced-settings area then opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator.
1. Navigate to **Settings** > **Customizations** > **Customizations**.

For complete details about how to customize model-driven apps in Dynamics 365, see the [Power Apps documentation](https://docs.microsoft.com/powerapps/#pivot=home&panel=getstarted).

For details about customizations that apply only to the Marketing app (but not other Dynamics 365 apps), see the following topics:

- [Create and customize marketing calendars](customize-marketing-calendars.md)
- [Create and customize template labels](customize-template-labels.md)

## Don't remove status-reason values used by go-live functionality

Entities that include [go-live functionality](go-live.md) provide a **Status reason** field that tracks the go-live status of each record. The field is an option set that must include the following values: **Draft**, **Live**, **Stopped**, "**Live, editable**", **Error**, **Going live**, and "**Stopping...**". Be sure not to delete any of these standard values. If you do, the entity will no longer be able to go live.

## Create a custom app that includes Marketing solutions

Customizers and developers can create custom app modules that include any number of existing solutions, plus other custom elements, as needed. You can include 
Dynamics 365 Marketing solutions in custom apps such as these, but the *Marketing email test send* entity won't be included automatically when you add the Marketing solution. As a result, your custom app won't support test sends of marketing emails by default. If you'd like to include this feature in your custom app, then you must add the *Marketing email test send* entity manually to your app after you add the Marketing solution.

More information: [Design model-driven apps by using the app designer](https://docs.microsoft.com/powerapps/maker/model-driven-apps/design-custom-business-apps-using-app-designer)

## Advanced customization through coding

Advanced customization and integration with external systems is possible through code-based interactions with the system's various APIs. For details about writing code and developing for Dynamics 365 Marketing and other model-driven apps in Dynamics 365, see the [developer documentation for Power Apps](https://docs.microsoft.com/powerapps/#pivot=home&panel=developer).


[!INCLUDE[footer-include](../includes/footer-banner.md)]