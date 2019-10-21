---
title: "Pass parameters values in the Omnichannel Administrator app | MicrosoftDocs"
description: "Learn about the supported formats to pass parameters values in the Omnichannel Administrator app for Templates and Macros."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: B769EF6D-A837-4BCF-B827-FD5F319AD9BC
ms.custom: 
---

# Preview: Use automation dictionary to pass data parameter keys

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

Automation Dictionary maintains the contextual data for the sessions. You can use the keys in the automation dictionary to pass the parameters to the action in macros.​

While creating templates and macros in the Omnichannel Administrator app, you can pass parameter keys such as Title of a session, notification, application tab template, custom parameter values for application tab types. These keys are replaced based on the contextual details available at the time of execution.

## Pass data parameters in templates

Let us take a scenario for templates with the notifications.

The notification shows certain fields and values, which are called **Field header** and **Value** respectively.

Kenny Smith, a customer, initiated a conversation and when the agent sees the notification, it displays **Customer Name** as **Kenny Smith**.

Here, **Field header** is **Customer Name** and the **Value** is **Kenny Smith**.

For templates to identify the name of the customer as **Kenny Smith**, as an administrator, you must configure pass the parameter as keys.

Similarly, for session and notification title, you can pass the data parameters in the support formats. To learn more, see [Automation dictionary formats to data parameter keys](#automation-dictionary-formats-to-data-parameter-keys).

The omnichannel system replaces these parameter values with the actual values based on the context of the session, channel provider, Common Data Service, and user actions.

To learn more, see [Types context data parameters](#types-context-data-parameters).

## Pass data parameters in macros

Macros are a set of configured actions that are executed on-demand by user. As an administrator, you need to configure the actions that a macro must perform. To configure the actions, you need to pass the data parameters in the support formats. To learn more, see [Automation dictionary formats to data parameter keys](#automation-dictionary-formats-to-data-parameter-keys).

When the agent runs the macro, the system replaces these parameter keys with the actual values based on the context of the session, channel provider, Common Data Service, and user actions. 

When the context is a session, the marco is executed based on the context for a current session with an Anchor tab or current tab in focus.

For example, to create a case, you need to define the actions to open an incident entity form and GUID of the form (optional).

To learn more, see [Types context data parameters](#types-context-data-parameters).

## Types context data parameters

The automation dictionary uses the context data parameters that are available from the following sources:

- [Context data from the channel provider](#context-data-from-the-channel-provider)
- [Context data from the user actions](#context-data-from-the-user-actions)
- [Context data from Common Data Service](#context-data-from-common-data-service)
- [Context data from other macro actions](#context-data-from-other-macro-actions)

> [!div class=mx-imgBorder] 
> ![Automation dictionary](../media/automation-dictionary.png "Automation dictionary")

#### Context data from the channel provider 

This context data is with the first-party channel provider such as Omnichannel for Customer Service or third-party channel provider that uses the widget exposed by Channel Integration Framework. The context data from the Omnichannel for Customer Service app are pre-chat survey, visitor portal navigation, and so on.

#### Context data from the user actions 

This data is populated as and when agents perform some activities on the session. An example is opening a new customer record, case etc.

#### Context data from Common Data Service 

The organizational data is stored in Common Data Service, and you can fetch the data with the use of OData queries.

#### Context data from other macro actions 

An action in a macro generates context data that is consumed by other actions in that macro.

For example, there two action steps in the following order:

1. Open a new form to create a record
2. Open an email form with predefined template

While creating the **Open an email form with predefined template** action, you can get the context data parameter keys from the **Open a new form to create a record** macro action step.

The context data parameter from the first macro step are as follows:
- Entity Logical Name
- Page Type
- Tab Id

    > [!NOTE]
    > The context data parameter form other macro actions are specific to Macros, and it is not applicable to templates.

## Automation dictionary formats to data parameter keys

These list of supported formats are:

- [Slugs](#slugs)
- [OData queries](#odata-queries)
- [Static values](#static-values)

The system replaces these parameter keys with the actual value based on the context of the session, channel provider, Common Data Service, and user actions.

### Slugs

Slug is a replacement parameter that system populates at the runtime based on the context.

The list of supported slugs are:

| Slug | Description |
|------------|-----------------------------------|
| `{customerName}` | Name of the customer who initiated the conversation. |
| `{caseId}` | Unique Id of a case. The system displays the case Id only if a cased linked to the conversation. |
| `{caseTitle}` | Title of the case. The system displays the title of the case only if a cased linked to the conversation. |
| `{queueId}` | Unique Id of a queue. |
| `{visitorLanguage}` | The language of the customer who initiated the conversation. |
| `{visitorDevice}` | The device of the customer who initiated the conversation. |
| `{entityRoutingLogicalName}` | Name of the entity if the notification is for a entity records. |
| `{entityRoutingRecordId}` | Unique Id of the entity record if the notification is for a entity records. To learn more, see [Entity records routing](../../omnichannel/administrator/entity-channel.md). |
| `{customerEntityName}` | Name of the entity (contact or account entity) if the customer is authenticated. |
| `{customerRecordId}` | Unique Id of t.he entity (contact or account entity) if the customer is authenticated. |
| `{<name of the pre-chat survey questions>}` | All the pre-chat survey questions that are configured for a workstream will have the slug name as the name of the question. |

#### Format

There are two types of format:

- The `{ChannelProvider.<Slug>}` or `{Slug}` parameter format is used to retrieve the context from the channel provider, where `ChannelProvider` is a standard construct to get the value from the provider context of the current session. 

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

    > [!NOTE]
    > The `Session.CurrentTab.<Attribute>` and `Session.AnchorTab.<Attribute>` parameter is only applicable to macros, and it is not applicable to templates.

### OData queries

You can use the OData queries to get the context that are available from the Common Data Service platform.

The OData query format:

`{$Odata.<entityName>.<entityAttributeName>.<?options>} like {$Odata.account.name.?$filter=id eq <GUID>`

Example:

### Static values

These are hardcoded values that you update as your business requirement. For every hardcoded attribute you chose, follow the format type for the particular attribute.

**For example (Macro):**

You want to create a case with the case title being always appended with **Contoso -**. In this case, you use the create **Open a new form to create a record** action with following fields.

   | Parameter | Value |
   |----------------------|----------------------------|
   | Entity Logical Name | incident | 
   | Attribute Name | Case title |
   | Attribute value | `Contoso - {caseTitle}` |

**For example (Templates):**

For an incoming chat request, you want provide the static title to session and notification that agents see at the run time.

Notification title = `New chat request`

Session title = `Chat conversation`

## See also

- [Manage session templates](session-templates.md)
- [Manage application tab templates](application-tab-templates.md)
- [Manage notification templates](notification-templates.md)
- [Associate templates with workstreams](associate-templates.md)