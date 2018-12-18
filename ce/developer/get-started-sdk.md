---
title: "Get started (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic contains information about some specific key tasks and how you can accomplish them. You’ll get guidance at a high level with directions to where you can find the details you need."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3a50694d-df1e-4da6-92f9-7a84364386d9
caps.latest.revision: 16
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
tags: 
  - "aug2017"
  - "MigrationHO"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Get started with the SDK for Dynamics 365 Customer Engagement

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)] provide many options to achieve the results you need. But how can you jump in and get started? This topic contains information about some specific key tasks and how you can accomplish them. You’ll get guidance at a high level with directions to where you can find the details you need.

<a name="bkmk_environment"></a>

## Try out an environment

 If you just want to get an environment to start learning with, the easiest approach is to sign up for a [30-day free trial on Dynamics 365](http://go.microsoft.com/fwlink/p/?LinkId=708412).

 If you’re looking for something more long term, or you specifically want to use the on-premises version, you can [download the on-premises Microsoft Dynamics CRM Server 2016](http://go.microsoft.com/fwlink/p/?LinkId=708414). During Setup, you have the option to supply a commercial key, or you can use one of the product keys listed on the download page for a 90 day free trial.

 If you have an [MSDN subscription](https://msdn.microsoft.com/subscriptions), you can download [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)] server software and access static activation keys that can be used for any number of installations.

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

<a name="bkmk_findTraining"></a>

## Find training

 In the [Tutorials and resources for learning about development for Dynamics 365](tutorials-resources-sdk.md) topic you can find information about several “quick start” samples included in the [!INCLUDE [pn-sdk](../includes/pn-sdk.md)] as well as links to other resources to help you learn to program with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].

<a name="bkmk_createCustomEntities"></a>

## Create custom tables and fields

 In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you create *entities* that include the database tables. You create *attributes* in those entities that correspond to fields in the application. These entities and attributes are core parts of the platform metadata. You don’t need to write code to do this. You can find instructions about how to create entities and attributes at [Create and edit metadata](../customize/create-edit-metadata.md). If you need to create entities and attributes programmatically, you can find information in [The Metadata and Data Models in Dynamics 365](metadata-data-models.md). Another place to look is [Introduction to Entities in Dynamics 365](introduction-entities.md).

<a name="bkmk_automation"></a>

## Automate business processes

 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] applications are all about improving efficiency by automating business processes. Understanding the different ways to do this can help you choose the right option for your requirement. The following are options available to you:

 **Processes**<br />
 There are several different types of processes that you can configure in the application without writing code. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Guide staff through common tasks with processes](../customize/guide-staff-through-common-tasks-processes.md)

 If you find that you need to create processes programmatically or want to extend what processes can do, be aware that developers refer to processes as *workflows* because the entity that they use is the Workflow entity and the workflows are based on the [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] programming model. Learn more about what you can do with workflows at [Write Workflows to Automate Business Processes](automate-business-processes-customer-engagement.md).

**Business rules**<br />
 If you’re looking for an easy declarative way to consistently evaluate the business logic on both client and server, without the need to write code, you’ll want to explore business rules. The client-side logic evaluation is more immediate because it’is performed when you open and update the record form, while the server-side provides consistent logic evaluation on the server. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create business rules and recommendations to apply logic in a form](../customize/create-business-rules-recommendations-apply-logic-form.md)

 One of the great things about business rules is that they can be evaluated on the client and provide a very responsive experience. But business rules have some limitations. If you can’t achieve what you need with business rules, you can write [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] that will respond to events in forms. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Write scripts for forms](get-started-sdk.md#bkmk_writeFormScripts.)

 **Plug-ins**<br />
 A *plug-in* is custom business logic that you can integrate with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to modify or augment the standard behavior of the platform. Plug-ins are event handlers since they are registered to execute in response to a particular event being fired by the platform. They provide a way to examine and transform the data passed through the platform operations and initiate additional operations. Plug-ins operate at the deepest level and provide the most robust way to automate business processes regardless of whether they originate from one of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] applications, a custom client, data migration, or integration with another system. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)

<a name="bkmk_writeFormScripts."></a>

## Write scripts for forms

 Form scripts provide a way to automate business processes, ensure data entered is valid, or just improve people’s experience when working in forms. Form scripts are written in [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] and are added to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] as *web resources*. You can learn more about how to create web resources in the application at [Create and edit web resources](../customize/create-edit-web-resources.md). For more detailed information, see [Web Resources for Dynamics 365](web-resources.md).

<!-- ../customize/use-the-form-editor.md#BKMK_EventHandlers not available using https://technet.microsoft.com/library/dn531185.aspx#BKMK_EventHandlers until-->
 Form scripts respond to events in the form. You can configure event handlers for many form events in the application using the form editor. To learn how to do that see [Use the form editor : Configure event handlers](https://technet.microsoft.com/library/dn531185.aspx#BKMK_EventHandlers). Detailed information for form script developers is in [Client scripting in Customer Engagement using JavaScript](clientapi/client-scripting.md). For information about the events and the object model used when writing forms, see the [Client API Reference](clientapi/reference.md).

<a name="bkmk_mobileApps"></a>

## Create a mobile application that uses data in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement

 [Write mobile and modern apps](write-mobile-modern-apps.md) contains information to get you started and links to additional content for mobile app development on the [Mobile SDK](https://msdn.microsoft.com/dynamics/crm/mobilesdk).

<a name="bkmk_windowsClient"></a>

## Create a Windows client application that uses data in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement

 XRM tooling is a set of APIs built on top of the .Net assembly APIs (Organization service and Discovery Service) that provide support for building [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] client applications for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build Windows client applications using the XRM tools](build-windows-client-applications-xrm-tools.md)

<a name="bkmk_USD"></a>

## Build call center applications

 [!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)] provides a configurable framework for quickly building applications for call centers so that customer service representatives can get a unified view of the customer data stored in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. You can aggregate customer information from different areas in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] into an integrated desktop that provides a 360° view of the customer interactions. This gives your customer service reps immediate access to business critical information so they can quickly engage with customers and address queries and issues. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk.md)

### See also
[Developer Guide for Dynamics 365 Customer Engagement](developer-guide.md)<br />
[Choose your development style for Dynamics 365](choose-development-style.md)<br />
[Connect to Dynamics 365 Customer Engagement](connect-customer-engagement.md)<br />
[Security model of Customer Engagement](security-dev/security-model.md)<br />
[Extend Dynamics 365 Customer Engagement](extend-customer-engagement.md)<br />
[Model your business data in Dynamics 365 Customer Engagement](model-business-data.md)<br />
[Manage your data in Customer Engagement](manage-data.md)<br />
[Manage your deployment of Customer Engagement](manage-deployment.md)<br />
[Sample code directory for the Customer Engagement SDK](sample-code-directory.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](programming-reference.md)<br />
[Connected Field Service Developer Guide](connected-field-service-developer-guide.md)<br />
