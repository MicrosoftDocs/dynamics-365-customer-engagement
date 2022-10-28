---
title: "Extend your outreach with custom channels (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to extend your outreach with custom channels in Dynamics 365 Marketing."
ms.date: 10/27/2022
ms.custom: 
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

# Preview: Extend your outreach with custom channels

## Custom channel structure

Custom channels can be implemented as part of the Dataverse solution.
A custom channel implementation consists of the following:
1.	Channel definition (solution aware component) 
2.	Message parts (solution aware component)
3.	Channel instance entity and the relevant form
4.	Channel instance account entity (for custom SMS channels only)
5.	Message template (editor) and the relevant form
6.	Custom APIs

### 1. Channel definition
In order to define your channel, you should add a solution component to the solution. You need to add an XML element with a collection of entities of type **msdyn_channeldefinition** entity attributes to the root element **ImportExportXml** of **customizations.xml** file.

Channel definitions should be added into the **msdyn_channeldefinitions** element under **ImportExportXml** of **customizations.xml** file. Each channel definition should include its own unique id in the form of GUID as XML attribute **msdyn_channeldefinitionid** on channel definition element.

##### Example of customizations.xml including channel definition
The exact values for each attribute are described in the contracts section.
<image>
<image>

### 2. Message parts
Custom channels can accept message parts. At least one message part is required for a custom channel.

Message parts are also defined in the **customizations.xml** as solution components. 

Message parts should be added into the **msdyn_channelmessageparts** element under **ImportExportXml** of the customizations.xml file. Each message part element **msdyn_channelmessagepart** must include its own unique id in the form of GUID as XML attribute **msdyn_channelmessagepartid**.

#### Example of customizations.xml including channel definition
The exact values for each attribute are described in the contracts section.
<image>

### 3. Channel instance entity and the relevant form
Each custom channel may need to have multiple senders - like phone numbers in SMS. To allow users to configure more than one sender, Channel Instances were introduced. Channel instance is an entity defined in base **D365ChannelDefinitions** solution. Each custom channel is supposed to extend this entity by creating its own extended channel instance entity and adding a relationship to the base Channel Instance entity on **msdyn_extendedentityId** attribute. This attribute is a polymorphic lookup.

The custom channel solution should include all the metadata for the extended channel instance entity.

The channel definition should also include the **msdyn_channeldefinitionexternalentity** attribute with the name of the extended entity introduced by the custom channel solution.

#### Relationship example
<image>
<image>

#### Channel instance entity main form
Dynamics Marketing has a generic wizard form   for creating channel instances in Settings. For that functionality to work, the custom channel solution should include a main form on the extended channel instance entity that is referenced in the channel definition in the msdyn_channeldefinitionexternalformid attribute.

This form should include all the required attributes for the custom channel to function and will be filled in by the user creating a new custom channel and saved in the UI.

### 4. Channel instance account entity (for custom SMS channels only)
If you're implementing a custom SMS channel, it must also have a channel instance account extended entity, and a relationship with the Channel Instance Account entity the same way as the channel instance does. The channel instance account has a 1:N relationship with the channel instances it serves as a data normalization for SMS accounts. Typically, you'll have one account with the service provider, under which you can create multiple phone numbers.

It also must have a form that will be used in Marketing SMS setup wizard.

#### Example of the relationship
<image>
<image>

The channel definition described before should also include the **msdyn_channeldefinitionaccountexternalentity** attribute with the name of the extended entity introduced by the custom channel solution.

#### Channel instance account main form
Dynamics Marketing has a generic wizard form   for creating channel SMS channels in settings. For that functionality to work, custom channel solution should include a main form on the extended channel instance account entity that is referenced in channel definition in **msdyn_channeldefinitionaccountexternalformid** attribute.

This form should include all the required attributes for the channel to function. They'll be filled in by the user creating a new custom channel and saved in the UI.

### 5. Message template (editor) and the relevant form  
This entity is required for the channel type **Custom**. Channels that are of an SMS type are using the native SMS editor.

#### Entity definition
Dynamics Marketing supports a generic UI for message templates (editor)   used by custom channels. For that an entity needs to be defined that will hold a form with the message parts you've defined in your channel. This entity won't store anything - it's only used as metadata to define your message contract.

The entity must include all the message parts defined in your channel with the exact same names but including the publisher prefix. For example, **cr65f_text** for the **text** message part.

On top of it, the entity must include the **placeholders** attribute that is used for personalization in Marketing. The **placeholders** attribute should also have the publisher prefix.

### Main form for the message template (editor)

This form will be used in the Marketing content editor, accessed through the “More channels” area.

The form must include all the required attributes of the entity and the **placeholder's** attribute. You can use custom controls on the form or use Marketing OOB controls such as the **MsdynmktControls.RichTextControl.RichTextControl** that supports personalization.

### 6. Custom APIs

#### Outbound custom API
A custom API needs to be defined that will be called during the Journey runtime in Marketing.

That is the entry point for custom code execution. When the Journey reaches a custom channel step, it will execute the API defined in the Channel Definition **msdyn_outboundendpointurltemplate**. This API must accept the contract defined by the Marketing Journey and return the response.

#### Delivery report custom API
If your channel has delivery reports or statuses for messages, such as for example, “Delivered”, you need to somehow proxy them back to Dataverse. One of the ways is to have an external application that will accept such traffic, process it and then notify Dataverse by executing the Custom API **msdyn_D365ChannelsNotification**.

There are multiple ways of achieving that. One of them could be having a webhook in the service provider that will call a Power Automate flow. Basic validation and data transformation can be completed there. Then your own Custom API can be executed which will do the final steps and execute the **msdyn_D365ChannelsNotification** API.

### Contracts

#### Channel definition

Entity logical name: 
**msdyn_channeldefinition**

Entity set name: **msdyn_channeldefinitions**

Primary Id attribute name: **msdyn_channeldefinitionid**

•	**msdyn_displayname**: string - Optional. Display name of the channel.

•	**msdyn_description**: string - Optional. Description of the channel.

•	**msdyn_channeltype**: string - Supported values: Custom, SMS.

•**msdyn_outboundendpointurltemplate**: string – Name of the Custom API for the outbound flow

•	**msdyn_hasinbound**: bit - Required. Boolean value indicating whether the channel supports inbound messages.

•	**msdyn_hasdeliveryreceipt**: bit - Required. Boolean value indicating whether the channel supports delivery receipt.

•	**msdyn_supportsaccount**: bit - Required. Boolean value indicating whether the channel supports account level configuration.
	
• **msdyn_channeldefinitionexternalentity**: string - Required. Name of the CDS entity, representing an extended configuration of the channel instance.

• **msdyn_channeldefinitionexternalformid**: GUID - Required. ID of the form to be rendered to display configuration of the extended channel instance table.

• **msdyn_channeldefinitionaccountexternalentity**: string - Optional. Name of the CDS entity, representing an extended configuration of the channel instance account.

•	**msdyn_channeldefinitionaccountexternalformid**: string - Optional. ID of the form to be rendered to display configuration of the extended channel instance account table.

•	**msdyn_messageformid**: GUID - Optional. Defines a form representing the message editor for the channel.

#### Message parts

Entity logical name: **msdyn_channelmessagepart**
Entity set name: **msdyn_channelmessageparts**

Primary Id attribute name: **msdyn_channelmessagepartid**

•	**msdyn_name**: string – Name for the message part, used as key for message parts in the outbound flow.

•	**msdyn_displayname**: string – Display name.

•	**msdyn_description**: string – Description.

•	**msdyn_channeldefinitionid**: GUID – Channel definition id, must match the channel definition id of the channel.

•	**msdyn_type**: OptionSet – Channel type, currently supported values:
o	192350000 plain text

More types will be introduced in further releases.

•	**msdyn_isrequired**: bit - Indicates whether the part is required.

•	**msdyn_maxlength**: int - max length for the part



