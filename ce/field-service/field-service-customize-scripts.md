---
title: "How to write scripts to implement complex business logic in Field Service | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/12/2022
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Write scripts to implement complex business logic in Field Service

In some Field Service implementations, there are functionalities and complex business logic requested by the stakeholders which go beyond the processes offered by the default "out-of-the-box" Field Service app and even beyond the platform options like workflow and business rules. For these requirements developers may write custom code to execute complex requirements.

Implementing complex business logic typically involves writing [plugins](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/plug-ins) on the server side and [JavaScript web resources](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/clientapi/client-scripting?view=op-9-1) on the client side.  


**Plugins** allow you to write your own custom functionality on top of Microsoft’s event-driven dynamics platform for just about any process you can imagine.

A plug-in is a custom business logic that integrates with Microsoft Dynamics 365 to modify or extend the standard behavior of the platform. Plug-ins act as event handlers and are registered to execute on a particular event in CRM. Plugins are written in either C# or VB and can run either in synchronous or asynchronous mode.

Some scenarios where you would write a plugin are −

- You want to execute some business logic such as updating certain fields of a record or updating related records, etc. when you create or update a Dynamics 365 record.
- You want to call an external web service on certain events such as saving or updating a record.
- You want to dynamically calculate the field values when any record is opened.
- You want to automate processes such as sending e-mails to your customers on certain events in CRM.

**JavaScript** is one of the ways to apply custom business process logic for displaying data on a form in Dynamics 365. In the context of Field Service, developers may add JavaScript to the work order and booking forms to enforce business logic. They may also add JavaScript to the Schedule Board to create [booking rules](set-up-booking-rules) that perform validations when a booking



## Understand the risks

- performance issues
- errors
- supportability
- time and cost

## Check if Field Service or Dynamics 365 can accomplish the requirement 



## Try using platform

Make sure you have leveraged the built-in platform options first

In many cases, a simple workflow, business logic could have been used to solve the use case.

[When to use plugins, advantages and disadvantages comapred to workflows](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/plug-ins#when-to-use-plug-ins)

## Review best practices before writings plugins or scripts

References
- [Best practices and guidance regarding plug-in and workflow development for the Microsoft Dataverse](https://docs.microsoft.com/powerapps/developer/data-platform/best-practices/business-logic/)
- [Best practices and guidance of client side scripting for model-driven apps](https://docs.microsoft.com/en-us/powerapps/developer/model-driven-apps/best-practices/business-logic/)
- [Make intelligent customizations when you use JavaScript on forms](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/design-performant-forms#javascript-customization)
- [Scalable Customization Design in Microsoft Dataverse](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/scalable-customization-design/overview)

## Use tools to test your scripts

[Use solution checker to validate your model-driven apps in Power Apps](https://docs.microsoft.com/powerapps/maker/data-platform/use-powerapps-checker)

Use the built-in CRM Plugin Trace Functionality and plugin profiler - For Online Dynamics 365, we can use the Plugin Registration Tool. Install Plugin Profiler in PRT using Install Profiler to get started. 

[Analyze plug-in performance](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/analyze-performance)



## Summary of recommended best practices

- Avoid writing scripts when possible
- Try using workflows and flows before writing scripts
- Run solution checker on scripts
- Run scripts asynchrnously instead of synchronously
- create a custom model driven app or canvas app (powerapp)
- do not edit or delete existing form libraries 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customization-form-libraries.png)

## JavaScript on the Schedule board 

It is recommended to not create more than 1 booking rule. Instead think about using booking alerts. 

### See also

- [Create or edit model-driven app web resources to extend an app](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-edit-web-resources)
- [Client scripting in Customer Engagement using JavaScript](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/clientapi/client-scripting?view=op-9-1)
- [Script (JScript) web resources](https://docs.microsoft.com/en-us/powerapps/developer/model-driven-apps/script-jscript-web-resources)
- [Use plug-ins to extend business processes](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/plug-ins)
- [Access external web services](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/access-web-services)
