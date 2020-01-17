---
title: "Use automation dictionary  to pass parameter keys in the Omnichannel Administration app | MicrosoftDocs"
description: "Learn about the supported formats to pass parameter values in the Omnichannel Administration app for Templates and Macros."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Use automation dictionary to pass data parameter keys

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

Automation Dictionary maintains the contextual data for the sessions. You can use the keys from the automation dictionary to pass the parameter in a action.​

While creating templates and macros in the Omnichannel Administration app, you can pass parameter keys such as title of a session, title of notification, title of an application tab template, and custom parameter values for application tab types. These keys are replaced based on the contextual information available at the time of execution.

### Pass data parameter in templates

Let us take a scenario for templates with the notifications.

The notification shows certain fields and values, which are called **Field header** and **Value** respectively.

Kenny Smith, a customer, initiated a conversation and when the agent sees the notification, it displays **Customer Name** as **Kenny Smith**.

Here, **Field header** is **Customer Name** and the **Value** is **Kenny Smith**.

For templates to identify the name of the customer as **Kenny Smith**, as an administrator, you must pass the parameter as keys.

Similarly, for session and notification title, you can pass the data parameters. To learn more, see [Automation dictionary formats to data parameter keys](#automation-dictionary-formats-to-pass-data-parameter-keys).

The system replaces these parameter keys with the actual values based on the context of the session, channel provider, Common Data Service, and user actions.

To learn more, see [Types of context data parameters](#types-of-context-data-parameters).

### Pass data parameter in macros

Macros are a set of configured sequential actions that are executed on-demand by user. As an administrator, you need to configure the actions that a macro must perform. To configure the actions, you need to pass the data parameters. To learn more, see [Automation dictionary formats to pass data parameter keys](#automation-dictionary-formats-to-pass-data-parameter-keys).

When the agent runs the macro, the system replaces these parameter keys with the actual values based on the context of the session, channel provider, Common Data Service, and user actions. 

When the context is from a session, the marco action is executed based on the information for a current session, where the information is obtained from an Anchor tab or current tab that is in focus.

For example, to create a case, you need to define the actions that contains incident entity form and the GUID of the form (optional).

To learn more, see [Types of context data parameter](#types-of-context-data-parameters).

## Types of context data parameters

The automation dictionary uses the context data parameters that are available from the following sources:

- [Context data from the channel provider](#context-data-from-the-channel-provider)
- [Context data from the user actions](#context-data-from-the-user-actions)
- [Context data from Common Data Service](#context-data-from-common-data-service)
- [Context data from other macro actions](#context-data-from-other-macro-actions)

> [!div class=mx-imgBorder] 
> ![Automation dictionary](../media/automation-dictionary.png "Automation dictionary")

#### Context data from the channel provider 

This context data is from the first-party channel provider such as Omnichannel for Customer Service or third-party channel provider that uses the widget exposed by Channel Integration Framework. The context data from Omnichannel for Customer Service are pre-chat survey, visitor portal navigation, and so on.

#### Context data from the user actions 

This data is populated as and when agents perform some activities in the session. An example is opening a new customer record, case, and so on.

#### Context data from Common Data Service 

The organizational data is stored in Common Data Service, and you can fetch the data with the use of OData queries. To learn more, see [OData queries](#odata-queries).

#### Context data from other macro actions 

An action in a macro generates context data that is consumed by other actions in that macro.

For example, there two action steps in the following order:

1. Open a new form to create a record
2. Open an email form with predefined template

While creating the **Open an email form with predefined template** action, you can get the context data parameter keys from the **Open a new form to create a record** macro action step.

The context data parameter from the first macro action are as follows:
- Entity Logical Name
- Page Type
- Tab Id

    > [!NOTE]
    > The context data parameter form other macro actions are specific to Macros, and it is not applicable to templates.

## Automation dictionary formats to pass data parameter keys

Automation Dictionary maintains the contextual data for the sessions. The keys in the automation dictionary can be passed as parameters to the action in macros. The system replaces these parameter keys with the actual value based on the context of the session, channel provider, Common Data Service, and user actions.

The automation dictionary supports the following formats:

- [Slugs](#slugs)
- [OData queries](#odata-queries)
- [Static values](#static-values)

### Slugs

#### Slugs for productivity tools (macros and agent scripts)

Slug is a replacement parameter that system populates at the runtime based on the context. Use the following list of slugs only for Macros, Agent Scripts, and to set an agent script as default using the expression builder.

The list of supported slugs are:

| Slug | Description |
|------------|-----------------------------------|
| `${customerName}` | Name of the customer who initiated the conversation. |
| `${caseId}` | Unique Id of a case. The system displays the case Id only if a cased linked to the conversation. |
| `${caseTitle}` | Title of the case. The system displays the title of the case only if a cased linked to the conversation. |
| `${queueId}` | Unique Id of a queue. |
| `${visitorLanguage}` | The language of the customer who initiated the conversation. |
| `${visitorDevice}` | The device of the customer who initiated the conversation. |
| `${entityRoutingLogicalName}` | Name of the entity if the notification is for a entity records. |
| `${entityRoutingRecordId}` | Unique Id of the entity record if the notification is for a entity records. To learn more, see [Entity records routing](../../omnichannel/administrator/entity-channel.md). |
| `${customerEntityName}` | Name of the entity (contact or account entity) if the customer is authenticated. |
| `${customerRecordId}` | Unique Id of t.he entity (contact or account entity) if the customer is authenticated. |
| `${<name of the pre-chat survey questions>}` | All the pre-chat survey questions that are configured for a workstream will have the slug name as the name of the question. |

#### Format

The `${Slug}` parameter format that retrieves the context from the channel provider, current user session, output of other macro actions, and/or the Common Data Service platform.

**Productivity automation context**

When you want to execute a slug in the productivity automation context which is used to perform operations related to a Dynamics 365 model-driven apps, then use the ${<slug>} format.

   For example: `${customerName}`

**Session connector context**

When you want to execute a slug in the session context, then you must use the `${$session.<slug>}` format.

For example: `${$session.customerName}`

Some of the slugs that are available for session context are:

- `${$session.visitorDevice}`
- `${$session.visitorDevice}`
- `${$session.entityRoutingLogicalName}`
- `${$session.entityRoutingRecordId}`
- `${$session.<name of the pre-chat survey questions>` - Pre-chat survey questions

**Omnichannel connector context**

When you want to execute a slug in the Omnichannel context, then you must use the `${$oc.<slug>}` format.

For example: `${$oc.customerName}`

> [!Note]
> The `Session.CurrentTab.<Attribute>` and `Session.AnchorTab.<Attribute>` parameter provides context data based on the current session and the anchor tab or the current tab in focus.
> The following are the supported attribute types:
>
>   - EntityName
>   - EntityId
>
>      For example:
>
>      `Session.CurrentTab.<EntityName>`
>
>      `Session.CurrentTab.<EntityId>`
>
>      `Session.AnchorTab.<EntityName>`
>
>      `Session.AnchorTab.<EntityId>`

   > [!NOTE]
   > The `Session.CurrentTab.<Attribute>` and `Session.AnchorTab.<Attribute>` parameter is only applicable to macros, and it is not applicable to templates.

#### Slugs for templates

Slug is a replacement parameter that system populates at the runtime based on the context. The list of supported slugs are:

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

The `{Slug}` parameter format that retrieves the template context from the channel provider, current user session, and/or the Common Data Service platform.

   For example: `{caseId}` 

### OData queries

You can use the OData queries to get the context that are available from the Common Data Service platform.

The OData query format:

`{$Odata.<entityName>.<entityAttributeName>.<?options>}`

Example:

- `{$Odata.account.name.?$filter=id eq '{accountid}'}`

- `{$odata.incident.prioritycode.?$filter=incidentid eq '{caseId}'&$select=prioritycode}`

- `{$odata.incident.title.?$filter=incidentid eq '{caseId}'&$select=title}`

### Static values

These are hardcoded values that you update as your business requirement. For every hardcoded attribute you chose, follow the format type for the particular attribute.

**For example (Macro):**

You want to create a case with the case title being always appended with **Contoso -**. In this case, you use the create **Open a new form to create a record** action with following fields.

   | Parameter | Value |
   |----------------------|----------------------------|
   | Entity Logical Name | incident | 
   | Attribute Name | Case title |
   | Attribute value | `Contoso - {caseTitle}` |

   Here **Contoso -** is the hardcoded static value.

**For example (Templates):**

For an incoming chat request, you want provide the static title to the session and notification template that agents see at the runtime.

Notification title = `New chat request`

Session title = `Chat conversation`

## See also

- [Manage session templates](session-templates.md)
- [Manage application tab templates](application-tab-templates.md)
- [Manage notification templates](notification-templates.md)
- [Associate templates with workstreams](associate-templates.md)
