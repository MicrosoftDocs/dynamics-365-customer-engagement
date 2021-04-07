---
title: "App making and customization overview for Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn about app making and customization with Dynamics 365 for Customer Engagement"
ms.custom: 
ms.date: 05/20/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.assetid: e9810433-224b-4bde-851a-e581cf5fb8a4
caps.latest.revision: 21
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---

# App making and customization overview for Dynamics 365 Customer Engagement (on-premises), version 9.x

Dynamics 365 Customer Engagement (on-premises) gives you powerful customization and app making capabilities that don't require you to write a single line of code. With a comprehensive set of WSYSIWYG designer and editor tools, most anyone can fully customize Dynamics 365 Customer Engagement (on-premises) or create their own custom apps.

For documentation of earlier versions (8.x and earlier), visit [https://docs.microsoft.com/previous-versions/dynamics/](/previous-versions/dynamics/).
  
 
## App making and customization components
A well designed app consists of several components that you select using the available designers and editors to build the appearance and functionality of the finished app. The components and component properties that you use to make up an app become the metadata.

To understand how each of these components relates to app design, they're separated here into data, UI, logic, and visualization categories.

### Data
These components determine what data the app will be based upon.

|Component  |Description  |Designer  |
|---------|---------|---------|
|Entity     | An item with properties that you track, such as a contact or account. Many standard entities are available. You can customize a non-system standard entity (production entity) or create a custom entity from scratch.        |  Entity designer       |
|Field     | A property that is associated with an entity. A field is defined by a data type, which determines the type of data that can be entered or selected. Examples include text, number, date and time, currency, or lookup (creates a relationship with another entity). Fields typically are used with forms, views, and searches.        | Entity designer        |
|Relationship     | Entity relationships define how entities can be related to each other. There are 1:N (one-to-many), N:1 (many-to-one), and N:N (many-to-many) types of relationships . For example, adding a lookup field to an entity creates a new 1:N relationship between the two entities and lets you put that lookup field on a form.        | Entity designer        |
|Option set field     |  This is a special type of field, which provides the user a set of predetermined options. Each option has a number value and label. When added to a form, this field displays a control for the user to select an option. There are two kinds of option sets; option sets, where the user can only select one option, and multi-select options sets, which allow more than one selection.       |  Option set designer       |

More information: [Create or edit entities (record types)](create-edit-entities.md)

### UI
These components determine how users interact with the app.


|Component  |Description  |Designer  |
|---------|---------|---------|
|App     | Determines the application fundamentals such as components, properties, client type, and URL for your app.        |  App designer       |
|Site map     |  Specifies the navigation for your app.       | Site map designer        |
|Form     | A set of data-entry fields for a given entity that matches the items that your organization tracks for the entity. For example, a set of data-entry fields that where user's input relevant information to track a customer's previous orders along with specific requested reorder dates.        |  Form designer       |
|View     | Views define how a list of records for a specific entity is displayed in your application. A view defines the columns to display, width of each column, sort behavior, and the default filters.        | View designer        |

More information: [Create or edit an app by using the app designer](create-edit-app.md)

### Logic
This component determines the business processes, rules, and automation the app will have. App makers use a designer that is specific to the type of process or rule.


|Type of logic  |Description  |Designer  |
|---------|---------|---------|
|Business process flow     | An online process that walks users through a standard business process. For example, use a business process flow if you want everyone to handle customer service requests the same way, or to require staff to gain approval for an invoice before submitting an order.        | Business process flow designer        |
|Workflow     |  Workflows automate business processes without a user interface. Designers use workflows to initiate automation that doesn't require any user interaction.       | Workflow designer        |
|Actions     |  Actions are a type of process that let you manually invoke actions, including custom actions, directly from a workflow.       |  Process designer       |
|Business rule     | Used to apply rule or recommendation logic to a form, such as to set field requirements, hide fields, or validate data. App designers use a simple interface to implement and maintain fast-changing and commonly used rules.     | Business rule designer        |

More information: [Create custom business logic through processes](guide-staff-through-common-tasks-processes.md)

### Visualizations

Determines what type of data visualizations and reporting the app will have available.

|Component  |Description  |Designer  |
|---------|---------|---------|
|Chart     | A single graphic visualization that can be displayed within a view, on a form, or be added to a dashboard.        | Chart designer        |
|Dashboard     |  Functions as a palate for one or more graphic visualizations that provide an overview of actionable business data.       |  Dashboard designer       |
|Reports     | Several standard reports that provide useful business information to the user are available. These reports are based on SQL Server Reporting Services, and provide the same set of features that are available for the SQL Server Reporting Services reports.        | Report wizard        |

More information: [Create or edit a system chart](create-edit-system-chart.md) and [Overview of reports](/dynamics365/customer-engagement/analytics/get-started-writing-reports)

## Extensibilty
Dynamics 365 Customer Engagement (on-premises) provides a set of web services and APIs that allow developers to write code. When code is written using supported methods you can expect that it will continue to work when you upgrade your organization. 

More information: [Developer Guide for Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customer-engagement/developer/developer-guide)

## Portability
Solutions exist so that a Dynamics 365 Customer Engagement (on-premises) can be purchased, shared, or otherwise transported from one organization to another. You can create your own solutions or get solutions from [AppSource](https://appsource.microsoft.com/) or from an independent software vendor (ISV). A solution is a file that you can import in to an environment as an app or to apply a set of customizations to an existing app.

More information: [Solutions overview](solutions-overview.md)
  
<a name="BKMK_SupportedCust"></a>   
## What kinds of customizations are supported with Dynamics 365 Customer Engagement (on-premises)?  
 We expect that you can do most of your customization with the tools in the application. Everything you do by using those tools is supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] because they apply changes to the metadata or data that depends on the metadata.  
  
 If the customization tools don't meet your needs, you can install a solution provided by a third party or hire a developer to code your customizations. Either way, it's good for you to understand supported customizations. If you need to invest in a solution that requires code, you should make sure that the code is written using only supported APIs. This helps you protect your investment in both [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps and any solutions you get.  
 
 More information: [Supported and unsupported customization](customizations-supported.md)
 
<a name="BKMK_changesinperformance"></a>   
## Changes that affect [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps organization performance  
 App makers and customizers should know that importing solutions and applying customizations that change metadata can affect Dynamics 365 Customer Engagement (on-premises) organization performance. Actions that can interfere with normal system operation include:  
  
-   Add, remove, or change entities, alternate keys, attributes, or relationships.   
  
-   Import solutions
  
-   Publishing customizations 
  
If you're applying these changes to a production system, we recommend that you schedule these operations when it is least disruptive to users.   
  
  
### See also  
[Get started with app making and customization](getting-started-customization.md) <br />





[!INCLUDE[footer-include](../../../includes/footer-banner.md)]