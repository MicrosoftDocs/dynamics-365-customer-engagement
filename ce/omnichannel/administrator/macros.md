---
title: "Agent scripts in the Omnichannel Administrator app | MicrosoftDocs"
description: "Learn about what is agent scripts and how to configure in the Omnichannel Administrator app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 5CC1D385-5E05-4366-BFE9-4772F1E044A5
ms.custom: 
---

# Preview: Automate tasks with macros

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview of macros

In the customer service industry, agents do too many clicks to perform actions (Open a form, fill the form, save the form, and so on), lot of repetitive and monotonous tasks (Greet a customer, Verify a customer, Send acknowledgment mail, Take notes, and so on). These clicks and repetitive tasks could lead to human errors while agents copy and paste the data across different operations.

Macros helps address these challenges aiding users to perform day-to-day operations in a faster, efficient, and process compliant manner.

## Value propositions

- Automate repetitive and monotonous tasks with a single click

- Minimization of human errors

- Adherence to business processes

- Lower Average Handling Time

- Improved customer satisfaction

## Prerequisites

- Install Dynamics 365 Productivity Tools solutions

## Pass macro context data parameters

Macros are a set of configured actions that are executed on-demand by user. As an administrator, you need to configure the actions that a macro must perform. To configure the actions, you need to provide certain data parameters. When the agent runs the macro, these data parameters are replaced by the contextual values.

For example, to create a case, you need to tell the macro to open an incident entity form and GUID of the form (optional).

To learn more, see [Types context data parameters](#types-context-data-parameters).

### Types context data parameters

The context data parameters are available from the following:

- [Context data from the channel provider](#context-data-from-the-channel-provider)
- [Context data from the user actions](#context-data-from-the-user-actions)
- [Context data from other macro actions](#context-data-from-other-macro-actions)
- [Context data from Common Data Service](#context-data-from-common-data-service)

#### Context data from the channel provider 

This context data is with the first-party channel providers, Omnichannel for Customer Service that uses the widget exposed by Channel Integration Framework. The context data from the Omnichannel for Customer Service app are pre-chat survey, visitor portal navigation, and so on.

#### Context data from the user actions 

This data is populated as and when agents perform some activities on the session. An example is opening a new customer record, case etc. The marco is executed based on the context for a current session with an Anchor tab or current tab in focus.

#### Context data from other macro actions 

An action in a macro generates context data that is consumed by other actions in that macro. 

For example, there two action steps in the following order:

1. Open a new form to create a record
2. Open an email form with predefined template

While creating the **Open an email form with predefined template**, you can get pass the context data parameters from the **Open a new form to create a record** macro step.

The context data parameter from the first macro step are as follows:
- Entity Logical Name
- Page Type
- Tab Id

#### Context data from Common Data Service 

The organizational data is stored in Common Data Service, and you can fetch the data as a part of macros. The context is fetched with the use of OData queries.

## Built-in macros

As an administrator, you can use the built-in macros to automate and perform operations.

The following are the built in macros.

### Open a new form to create a record

This macro is used to open a new form to create a record. This macro contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to open.<br> This is a mandatory field. | incident |
   | Entity Form Id | Specify the form Id.<br> This is an optional field. |
   | Attribute Name | Specify the attribute logical name. You need to provide the attribute name in order to pre-populate the field with a value.| |
   | Attribute Value | Specify the attribute value. You need to provide the attribute value to pre-populate for the attribute field. | |
   

### Open an existing form

This macro is used to open an existing record form. This macro contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to open. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record id. <br>This is a mandatory field.| |
   | Entity Form Id | Specify the form Id. <br>This is an optional field. | |

### Open a record grid

This macro is used to open an record grid. This macro contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity for which you want to open the grid. <br> This is a mandatory field. | incident |
   | View Id| Specify the view Id that you want to open.<br> This is a mandatory field. | |
   | View Type | Specify the view type. <br>This is a mandatory field. | |

### Search knowledge base for the populated phrase

This macro is used for searching knowledge articles based on the populated phrase. This macro contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to search for knowledge articles. You can provide the context data. For example, the context data parameter can be case title. |  |

### Search for a phrase

This macro is used for searching knowledge articles based on the populated phrase. This macro contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to do a relevance search. You can provide the context data. For example, the context data parameter can be case title. <br> This is a mandatory field.  |  |

### Update an existing record

This macro is used to update an existing record. This macro contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record id. <br>This is a mandatory field.| |
   | Attribute Name | Specify the attribute logical name for which you want to update.| |
   | Attribute Value | Specify the attribute value that will be updated for above mentioned attribute. | |

### Open an email form with predefined template

This macro is used to open an email with a predefined template. This macro contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record id. <br>This is a mandatory field.| |
   | Email Recipients | Specify the recipients detail to whom you want the mail to be sent. <br> This is a mandatory field. | |
   | Template Id | Specify the id of the template that must displayed in the email. <br> This is a mandatory field. | |

### Resolve a case

This macro is used to open an email with a predefined template. This macro contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Billable Time |  Specify the time that is billable. <br> This is a mandatory field. | incident |
   | Incidentid| Specify the case id that you want to close. <br>This is a mandatory field.| |
   | Resolution | Specify the reason to resolve the case. <br> This is a mandatory field. | |

## Supported format for context data

As an administrator, you need to pass the context data values for the parameters in the macro steps. The following types are supported formats:

- [Slug for parameter values](#Slug-for-parameter-values)
- [OData queries](#odata-queries-for-parameter-values)
- [Static values](#satitc-values-for-the-parameter-values)

### Slug for parameter values

Slug is the replacement parameter that macros populates at the run time based on the context variables.

Supported list of slugs are:

| Slug | Description |
|------------|-----------------------------------|
| {customerName} | Name of the customer who initiated the conversation. |
| {caseId} | Unique Id of a case. The system displays the case Id only if a cased linked to the conversation. |
| {caseTitle} | Title of the case. The system displays the title of the case only if a cased linked to the conversation. |
| {queueId} | Unique Id of a queue. |
| {visitorLocale} | The language of the customer who initiated the conversation. |
| {visitorDevice} | The device of the customer who initiated the conversation. |
| {entityRoutingLogicalName} | Name of the entity if the notification is for a entity records. |
| {entityRoutingRecordId} | Unique Id of the entity record if the notification is for a entity records. To learn more, see [Entity records routing](entity-channel.md). |
| {customerEntityName} | Name of the entity (contact or account entity) if the customer is authenticated. |
| {customerRecordId} | Unique Id of the entity (contact or account entity) if the customer is authenticated. |
|{\<name of the pre-chat survey questions\>} | All the pre-chat survey questions that are configured for a workstream will have the slug name as the name of the question. |


#### Format

There are two types of parameter format:

- The `{ChannelProvider.<Slug>}` or `{Slug}` parameter format is used to retrieve the context from the channel provider, where `ChannelProvider` is a standard construct to get the value from the context of the provider of the current session. 

   For example: 

   `{ChannelProvider.caseId}`

   or

   `{caseId}` 

- The `Session.CurrentTab.<Attribute>` and `Session.AnchorTab.<Attribute>` parameter provides context data based on the current session and the anchor tab or the current tab in focus.

   The following are the supported attribute types:

- EntityName
- EntityId

   For example: 

   `Session.CurrentTab.<EntityName>`

   `Session.CurrentTab.<EntityId>`

   `Session.AnchorTab.<EntityName>`

   `Session.AnchorTab.<EntityId>` 

### OData queries for parameter values

### Static values for the parameter values

These are hardcoded values that you update as your business requirement. For every hardcoded attribute you chose, follow the format type for the particular attribute.

For example:

You want to create a case with the case title being always appended with **Contoso -**. In this case, you use the create **Open a new form to create a record** action with following fields.

   | Parameter | Value |
   |----------------------|----------------------------|
   | Entity Logical Name | incident | 
   | Attribute Name | Case title |
   | Attribute value | `Contoso - {caseTitle}` |

## Create macro

1. Sign in to the Omnichannel Administrator app.

2. Select **Macros** under **Agent Experience**.

3. Select **+ New**.

4. Specify the following in the **Create macros** page.

    | Field | Description | Example value |
    |-------------|-----------------------------------|------------------------------------|
    | Name | Provide a name to the macro. The name is displayed to the agent at the run time. | Create case |
    | Description | Describe the purpose of the macro. The description is displayed to the agent at the run time. | This macro is used to create a case. |

5. Select **Start macro execution**, and then select **+ New step**.

6. Select an action from a list of built in macro actions. You can add as many as actions as per your business requirements.

    | Purpose | Macro name |
    |-----------------------------|---------------------------------------------|
    | Open a new form to create a record | Create new |
    | Open an existing form | Open form |
    | Open a record grid | Open grid |
    | Search the knowledge base for the populated phrase | Search knowledge articles |
    | Do a relevance search based on the phrase | Search |
    | Update an existing record | Update record |
    | Open an email form with predefined template | Open email |
    | Resolve a case | Resolve case |

    For example, select **Open a new form to create a record**, and the step appears.

7. Specify the values in the fields.

8. Select **Show advanced options** to add required attributes and values. If required, you can select **+ Add new item** to add more attributes.

9. Select **Save and close** to save and close the macro changes.