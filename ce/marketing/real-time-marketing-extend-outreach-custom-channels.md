---
title: "Preview: Manually add a custom channel (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to extend your outreach by manually adding a custom channel in Dynamics 365 Marketing."
ms.date: 11/03/2022
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

# Preview: Manually add a custom channel

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

This article explains how to manually add a custom channel to real-time marketing.

## Custom channel structure

Custom channels can be implemented as part of a Dataverse solution. A custom channel implementation consists of the following:

1. Channel definition (solution-aware component)
1. Message parts (solution-aware component)
1. Channel instance entity and the relevant form
1. Channel instance account entity and the relevant form (for custom SMS channels only)
1. Message template (editor) and the relevant form (optional)
1. Custom APIs

### 1. Channel definition

To define your channel, you need to add a solution component to the solution. To do this, add an XML element with a collection of entities of type **msdyn\_channeldefinition** entity attributes to the root element **ImportExportXml** in the **customizations.xml** file.

Channel definitions should be added into the **msdyn\_channeldefinitions** element under **ImportExportXml** in the **customizations.xml** file. Each channel definition should include its own unique ID in the form of a GUID as the XML attribute **msdyn\_channeldefinitionid** on the channel definition element.

#### Example of customizations.xml including channel definition

The exact values for each attribute are described in the contracts section.
```
<ImportExportXml xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <msdyn_channeldefinitions>
    <msdyn_channeldefinition msdyn_channeldefinitionid="af0c2a3c-85a5-43b3-84be-2a4a171249f3">
      <msdyn_channeldefinitionaccountexternalentity>cr65f_samplechannelinstanceaccount</msdyn_channeldefinitionaccountexternalentity>
      <msdyn_channeldefinitionaccountexternalformid>3071133f-1208-4dc1-8eba-4d4724961029</msdyn_channeldefinitionaccountexternalformid>
      <msdyn_channeldefinitionexternalentity>cr65f_samplechannelinstance</msdyn_channeldefinitionexternalentity>
      <msdyn_channeldefinitionexternalformid>7d2b885a-80eb-479d-b0c3-600bc41e9789</msdyn_channeldefinitionexternalformid>
      <msdyn_channeltype>Custom</msdyn_channeltype>
      <msdyn_description>Metadata definition for sample custom channel</msdyn_description>
      <msdyn_displayname>Sample custom channel</msdyn_displayname>
      <msdyn_hasdeliveryreceipt>0</msdyn_hasdeliveryreceipt>
      <msdyn_hasinbound>0</msdyn_hasinbound>
      <msdyn_messageformid>69723cfe-3835-4126-ab9a-a82a5b88c21d</msdyn_messageformid>
      <msdyn_outboundendpointurltemplate>/cr65f_OutboundCustomApi</msdyn_outboundendpointurltemplate>
      <msdyn_specialconsentrequired>0</msdyn_specialconsentrequired>
      <msdyn_supportsaccount>0</msdyn_supportsaccount>
      <msdyn_supportsattachment>0</msdyn_supportsattachment>
      <msdyn_supportsbinary>0</msdyn_supportsbinary>
      <statecode>0</statecode>
      <statuscode>1</statuscode>
    </msdyn_channeldefinition>
  </msdyn_channeldefinitions>
</ImportExportXml>

```
### 2. Message parts

Custom channels can accept message parts. At least one message part is required for a custom channel. Message parts are also defined in **customizations.xml** as solution components.

Message parts should be added into the **msdyn\_channelmessageparts** element under **ImportExportXml** in the **customizations.xml** file. Each message part element **msdyn\_channelmessagepart** must include its own unique ID in the form of a GUID as XML attribute **msdyn\_channelmessagepartid**.

#### Example of customizations.xml including channel definition
 
The exact values for each attribute are described in the contracts section.
```
<ImportExportXml xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <msdyn_channelmessageparts>
    <msdyn_channelmessagepart msdyn_channelmessagepartid="15d57b1a-ddcd-4bb1-9af6-c691567ab9ef">
      <msdyn_channeldefinitionid>
        <msdyn_channeldefinitionid>b1b25a46-6da0-4c08-9cf3-505e613c8e30</msdyn_channeldefinitionid>
      </msdyn_channeldefinitionid>
      <msdyn_description>Text</msdyn_description>
      <msdyn_displayname>Text</msdyn_displayname>
      <msdyn_isrequired>1</msdyn_isrequired>
      <msdyn_maxlength>1000</msdyn_maxlength>
      <msdyn_name>text</msdyn_name>
      <msdyn_type>192350000</msdyn_type>
```

### 3. Channel instance entity and the relevant form

Each custom channel may need to have multiple senders, like phone numbers in SMS. To allow users to configure more than one sender, channel instances were introduced. The Channel instance entity is defined in the base **D365ChannelDefinitions** solution. Each custom channel extends this entity by creating its own extended channel instance entity and adding a relationship to the base Channel instance entity on the **msdyn\_extendedentityId** attribute. This attribute is a [polymorphic](/power-apps/developer/data-platform/webapi/multitable-lookup) lookup.

The custom channel solution should include all the metadata for the [extended channel instance](/dynamics365/customerengagement/on-premises/customize/create-entities) entity.

The channel definition should also include the **msdyn\_channeldefinitionexternalentity** attribute with the name of the extended entity introduced by the custom channel solution.

#### Relationship example
```
<EntityRelationship Name="msdyn_ChannelInstance_extendedentityid_cr65f_samplechannelinstance">
    <EntityRelationshipType>OneToMany</EntityRelationshipType>
    <IsCustomizable>0</IsCustomizable>
    <IntroducedVersion>1.0.0.0</IntroducedVersion>
    <IsHierarchical>0</IsHierarchical>
    <ReferencingEntityName>msdyn_ChannelInstance</ReferencingEntityName>
    <ReferencedEntityName>cr65f_samplechannelinstance</ReferencedEntityName>
    <CascadeAssign>NoCascade</CascadeAssign>
    <CascadeDelete>RemoveLink</CascadeDelete>
    <CascadeReparent>NoCascade</CascadeReparent>
    <CascadeShare>NoCascade</CascadeShare>
    <CascadeUnshare>NoCascade</CascadeUnshare>
    <CascadeRollupView>NoCascade</CascadeRollupView>
    <IsValidForAdvancedFind>1</IsValidForAdvancedFind>
    <ReferencingAttributeName>msdyn_extendedentityId</ReferencingAttributeName>
    <RelationshipDescription>
      <Descriptions>
        <Description description="" languagecode="1033" />
      </Descriptions>
    </RelationshipDescription>
    <EntityRelationshipRoles>
      <EntityRelationshipRole>
        <NavPaneDisplayOption>UseCollectionName</NavPaneDisplayOption>
        <NavPaneArea>Details</NavPaneArea>
        <NavPaneOrder>10000</NavPaneOrder>
        <NavigationPropertyName>msdyn_extendedentityid_cr65f_samplechannelinstance</NavigationPropertyName>
        <RelationshipRoleType>1</RelationshipRoleType>
      </EntityRelationshipRole>
      <EntityRelationshipRole>
<NavigationPropertyName>msdyn_ChannelInstance_extendedentityid_cr65f_samplechannelinstance</NavigationPropertyName>
        <RelationshipRoleType>0</RelationshipRoleType>
      </EntityRelationshipRole>
    </EntityRelationshipRoles>
  </EntityRelationship>
```

#### *Channel instance entity main form*

Dynamics 365 Marketing has a generic wizard form for creating channel instances in **Settings**. For the form to work, the custom channel solution should include a main form on the extended channel instance entity that is referenced in the channel definition in the **msdyn\_channeldefinitionexternalformid** attribute.

This form should include all the required attributes for the custom channel to function. It will be filled in by the user creating a new custom channel and saved in the user interface.

### 4. Channel instance account entity and the relevant form (for custom SMS channels only)

If you're implementing a custom SMS channel, it must also have a channel instance account extended entity and a relationship with the Channel Instance Account entity the same way the channel instance does. The channel instance account has a 1:N relationship with the channel instances it serves as a data normalization for SMS accounts. Typically, you'll have one account with the service provider under which you can create multiple phone numbers.

It also must have a form that will be used in the Marketing SMS setup wizard.

#### Example of the relationship
```
<?xml version="1.0" encoding="utf-8"?>
<EntityRelationships xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <EntityRelationship Name="msdyn_ChannelInstanceAccount_extendedentityid_cr65f_samplechannelinstanceaccount">
    <EntityRelationshipType>OneToMany</EntityRelationshipType>
    <IsCustomizable>0</IsCustomizable>
    <IntroducedVersion>1.0.0.0</IntroducedVersion>
    <IsHierarchical>0</IsHierarchical>
    <ReferencingEntityName>msdyn_ChannelInstanceAccount</ReferencingEntityName>
    <ReferencedEntityName>cr65f_samplechannelinstanceaccount</ReferencedEntityName>
    <CascadeAssign>NoCascade</CascadeAssign>
    <CascadeDelete>RemoveLink</CascadeDelete>
    <CascadeReparent>NoCascade</CascadeReparent>
    <CascadeShare>NoCascade</CascadeShare>
    <CascadeUnshare>NoCascade</CascadeUnshare>
    <CascadeRollupView>NoCascade</CascadeRollupView>
    <IsValidForAdvancedFind>1</IsValidForAdvancedFind>
    <ReferencingAttributeName>msdyn_extendedentityId</ReferencingAttributeName>
    <RelationshipDescription>
      <Descriptions>
        <Description description="" languagecode="1033" />
      </Descriptions>
    </RelationshipDescription>
    <EntityRelationshipRoles>
      <EntityRelationshipRole>
        <NavPaneDisplayOption>UseCollectionName</NavPaneDisplayOption>
        <NavPaneArea>Details</NavPaneArea>
        <NavPaneOrder>10000</NavPaneOrder>
        <NavigationPropertyName>msdyn_extendedentityid_cr65f_samplechannelinstanceaccount</NavigationPropertyName>
        <RelationshipRoleType>1</RelationshipRoleType>
      </EntityRelationshipRole>
      <EntityRelationshipRole>
        <NavigationPropertyName>msdyn_ChannelInstanceAccount_extendedentityid_cr65f_samplechannelinstanceaccount</NavigationPropertyName>
        <RelationshipRoleType>0</RelationshipRoleType>
      </EntityRelationshipRole>
    </EntityRelationshipRoles>
  </EntityRelationship>
</EntityRelationships>
```

The channel definition should also include the **msdyn_channeldefinitionaccountexternalentity** attribute with the name of the extended entity introduced by the custom channel solution.

#### *Channel instance account main form*

Dynamics 365 Marketing has a generic wizard form for creating SMS channels in **Settings**. For the form functionality to work, the custom channel solution should include a main form on the extended channel instance account entity that is referenced in the channel definition in the **msdyn\_channeldefinitionaccountexternalformid** attribute.

This form should include all the required attributes for the channel to function. The attributes will be filled in by the user creating a new custom channel and saved in the user interface.

### 5. Message template (editor) and the relevant form (optional)

This optional entity can be defined for the channel type **Custom**. Channels that are of an SMS type use the native SMS editor.

#### *Entity definition*

Dynamics 365 Marketing supports a generic user interface for message templates (editor) used by custom channels, in case the optional message template (editor) is not configured. To use the editor, an entity needs to be defined that will hold a form with the message parts you've defined in your channel. This entity won't store anything; it's only used as metadata to define your message contract.

The entity must include all the message parts defined in your channel with the exact same names but including the publisher prefix. For example, **cr65f\_text** for the **text** message part.

On top of that, the entity must include the **placeholders** attribute that is used for personalization in Marketing. The **placeholders** attribute should also have the publisher prefix.

#### *Main form for the message template (editor)*

The main form is used in the Marketing content editor, accessed through the "More channels" area.

The form must include all the required attributes of the entity and the **placeholders** attribute. You can use custom controls on the form or use the out of the box Marketing controls such as the **MsdynmktControls.RichTextControl.RichTextControl** that supports personalization.

### 6. Custom APIs

#### *Outbound custom API*

A [custom API](/power-apps/developer/data-platform/custom-api) needs to be defined that will be called during the journey runtime in Marketing.

The custom API is the entry point for custom code execution. When the journey reaches a custom channel step, it will execute the API defined in the Channel Definition **msdyn\_outboundendpointurltemplate**. This API must accept the contract defined by the Marketing journey and return the response.

#### *Delivery report custom API*

If your channel has delivery reports or statuses for messages, such as "Delivered", you need to proxy the reports or statuses back to Dataverse. One way to send the information to Dataverse is to have an external application that accepts such traffic, process it, and then notifies Dataverse by executing the custom API **msdyn\_D365ChannelsNotification.**

There are multiple ways of achieving reporting back to Dataverse. One way could be having a webhook in the service provider that will call a Power Automate flow. Basic validation and data transformation can be completed there. Then your own custom API can be executed which will do the final steps and execute the **msdyn\_D365ChannelsNotification** API.

## **Contracts**

### **Channel definition**

Entity logical name: **msdyn\_channeldefinition**  
Entity set name: **msdyn\_channeldefinitions**  
  
Primary ID attribute name: **msdyn\_channeldefinitionid**

- **msdyn\_displayname:** string - Optional. Display name of the channel.
- **msdyn\_description:** string - Optional. Description of the channel.
- **msdyn\_channeltype:** string - Supported values: Custom, SMS.
- **msdyn\_outboundendpointurltemplate:** string – Name of the Custom API for the outbound flow
- **msdyn\_hasinbound:** bit - Required. Boolean value indicating whether the channel supports inbound messages.
- **msdyn\_hasdeliveryreceipt:** bit - Required. Boolean value indicating whether the channel supports delivery receipt.
- **msdyn\_supportsaccount:** bit - Required. Boolean value indicating whether the channel supports account level configuration.
- **msdyn\_channeldefinitionexternalentity:** string - Required. Name of the CDS entity, representing an extended configuration of the channel instance.
- **msdyn\_channeldefinitionexternalformid:** GUID - Required. ID of the form to be rendered to display configuration of the extended channel instance table.
- **msdyn\_channeldefinitionaccountexternalentity:** string - Optional. Name of the CDS entity, representing an extended configuration of the channel instance account.
- **msdyn\_channeldefinitionaccountexternalformid:** string - Optional. ID of the form to be rendered to display configuration of the extended channel instance account table.
- **msdyn\_messageformid:** GUID - Optional. Defines a form representing the message editor for the channel.

### **Message parts**

Entity logical name: **msdyn\_channelmessagepart**  
Entity set name: **msdyn\_channelmessageparts**

Primary ID attribute name: **msdyn\_channelmessagepartid  
**

- **msdyn\_name:** string – Name for the message part, used as key for message parts in the outbound flow.
- **msdyn\_displayname:** string – Display name.
- **msdyn\_description:** string – Description.
- **msdyn\_channeldefinitionid:** GUID – Channel definition ID, must match the channel definition ID of the channel.
- **msdyn\_type:** OptionSet – Channel type, currently supported values:
    - 192350000 plaintext

More types will be introduced in further releases.

- **msdyn\_isrequired:** bit - Indicates whether the part is required.
- **msdyn\_maxlength: in** bit - Max length for the part.

### **Outbound custom API**

The Outbound custom API must implement the following contract:  
  
It must have one input parameter: **payload** and one output attribute: **response**

**payload** is a serialized JSON with the following contract:
```
{

    "ChannelDefinitionId": GUID,

    "RequestId": string,

    "From": string,

    "To": string,

    "Message": Dictionary&lt;string, string&gt;

}
```
where "**Message**" contains all the message parts for a channel.

**response** is a serialized JSON with the following contract  
```
{

    "ChannelDefinitionId": GUID,

    "MessageId": string,

    "RequestId": string,

    "Status": string,

    "StatusDetails": Dictionary&lt;string, object&gt;

}
```
Possible values for **Status:**

- **SendingAborted** – The internal validation from the channel side blocked the submission without a possibility to retry.
- **NotSent** – There was an attempt to execute the submission to the provider, but it was rejected without a possibility to retry.
- **SendingFailed** – An internal issue (500 on channel implementation side or provider side) occurred for all submission retries.
- **Sent** – The submission request was successfully accepted by the provider.
- **Delivered** – The accepted message was successfully delivered to the target.
- **NotDelivered** – The accepted message wasn't successfully delivered to the target.

### Delivery report custom API

API Name: **msdyn\_D365ChannelsNotification**

Input parameter: notificationPayLoad – Serialized JSON with the following contract:
```
{

  "ChannelDefinitionId": GUID

  "From": string

  "MessageId": string

  "RequestId": string

  "Status": string

  "OrganizationId": string

  "StatusDetails": Dictionary&lt;string, object&gt;

}
```

## Sample solutions

The samples below include unpacked solutions for Dataverse and plugins projects.

To pack and import these solutions, first build the plugin project. The project will then copy the assembly to the solution project. Then, pack the solution using the [Solution Packager tool](/power-platform/alm/solution-packager-tool).

[SampleSmsChannel.zip](https://download.microsoft.com/download/c/c/6/cc6fed59-f95a-4577-aed5-49daa62b1f66/SampleSmsChannel.zip)

[SampleCustomChannel.zip](https://download.microsoft.com/download/5/8/6/586e2d47-ac82-48e9-9cc4-066c141e0649/SampleCustomChannel.zip)