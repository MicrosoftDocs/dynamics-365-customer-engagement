---
title: "Include filtering attributes with plugin registration | MicrosoftDocs"
description: "If no filtering attributes are set for a plug-in registration step, then the plug-in will execute every time an update message occurs for that event"
ms.date: 06/28/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4667c52a-a9d5-4b56-b1ed-e62437eccbe5
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---
# Include filtering attributes with plugin registration

**Category**: Performance

**Impact potential**: Medium

<a name='symptoms'></a>

## Symptoms

If no filtering attributes are set for a plug-in registration step, then the plug-in will execute every time an update message occurs for that event.

<a name='guidance'></a>

## Guidance

Most plug-ins registered for an entity's update message do not need to execute on all updates. Usually, there is only a need to process certain logic when a specific attribute or attributes have changed. In order to prevent extra processing in the environment, minimize the logic needed in a plug-in and all the update to complete as quickly as possible, it is highly recommended that plug-in step registrations also include filtering attributes for update messages.

![Plug-in Registration Step with Filtering Attributes](../media/plugin-registration-step-with-filtering-attributes.png)

### Upgrade Warning

Starting with Dynamics CRM 2013, an auto-save feature was added to the application. After an upgrade, you may find performance degradation due to this feature, if there are no filtering attributes specified.

<a name='additional'></a>

## Additional information

Filtering attributes are a list of entity attributes that, when changed, cause the plug-in to execute.  These attributes can be set when registering the plug-in using the Plug-in Registration tool. If no attributes are set, then the plug-in will execute every time an update message occurs. Updates can occur in Dynamics 365 for a variety of reasons. When auto-save is turned on in the environment, it can occur multiple times during the session of user when on an entity form. If filtering attributes are not specified, then the plug-in will execute for any attribute change to the designed entity.

<a name='seealso'></a>

### See also

[Plug-in design](../../developer/write-plugin.md#plug-in-design)<br />
[Walkthrough: Register a plug-in using the plug-in registration tool](https://msdn.microsoft.com/library/gg309580.aspx)<br />