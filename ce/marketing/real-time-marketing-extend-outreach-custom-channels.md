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

### **1. Channel definition**

In order to define your channel, you should add a solution component to the solution. To do this, you need to add an XML element with a collection of entities of type **msdyn\_channeldefinition** entity attributes to the root element **ImportExportXml** of **customizations.xml** file.

Channel definitions should be added into the **msdyn\_channeldefinitions** element under **ImportExportXml** of **customizations.xml** file. Each channel definition should include its own unique id in the form of GUID as XML attribute **msdyn\_channeldefinitionid** on channel definition element.

**Example of customizations.xml including channel definition**  
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



### **2. Message parts**

Custom channels can accept message parts. At least one message part is required for a custom channel.

Message parts are also defined in the **customizations.xml** as solution components.

Message parts should be added into the **msdyn\_channelmessageparts** element under **ImportExportXml** of the **customizations.xml** file. Each message part element **msdyn\_channelmessagepart** must include its own unique id in the form of GUID as XML attribute **msdyn\_channelmessagepartid**.

**Example of customizations.xml including channel definition**  
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
### **3. Channel instance entity and the relevant form**

Each custom channel may need to have multiple senders - like phone numbers in SMS. To allow users to configure more than one sender, Channel Instances were introduced. Channel instance is an entity defined in base **D365ChannelDefinitions** solution. Each custom channel is supposed to extend this entity by creating its own extended channel instance entity and adding a relationship to the base Channel Instance entity on **msdyn\_extendedentityId** attribute. This attribute is a [polymorphic](https://learn.microsoft.com/en-us/power-apps/developer/data-platform/webapi/multitable-lookup?branch=pr-en-us-4448) lookup.

The custom channel solution should include all the metadata for the [extended channel instance](https://learn.microsoft.com/en-us/dynamics365/customerengagement/on-premises/customize/create-entities?view=op-9-1) entity.

The channel definition should also include the **msdyn\_channeldefinitionexternalentity** attribute with the name of the extended entity introduced by the custom channel solution.

**Relationship example**

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

Dynamics Marketing has a generic wizard form for creating channel instances in Settings. For that functionality to work, the custom channel solution should include a main form on the extended channel instance entity that is referenced in the channel definition in the **msdyn\_channeldefinitionexternalformid** attribute.

This form should include all the required attributes for the custom channel to function. It will be filled in by the user creating a new custom channel and saved in the UI.

### **4. Channel instance account entity (for custom SMS channels only)**

If you're implementing a custom SMS channel, it must also have a channel instance account extended entity, and a relationship with the Channel Instance Account entity the same way as the channel instance does. The channel instance account has a 1:N relationship with the channel instances it serves as a data normalization for SMS accounts. Typically, you'll have one account with the service provider, under which you can create multiple phone numbers.

It also must have a form that will be used in Marketing SMS setup wizard.

***Example of the relationship***

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

The channel definition described before should also include the **msdyn_channeldefinitionaccountexternalentity** attribute with the name of the extended entity introduced by the custom channel solution.

#### *Channel instance account main form*

Dynamics Marketing has a generic wizard form for creating channel SMS channels in settings. For that functionality to work, custom channel solution should include a main form on the extended channel instance account entity that is referenced in channel definition in **msdyn\_channeldefinitionaccountexternalformid** attribute.

This form should include all the required attributes for the channel to function. They'll be filled in by the user creating a new custom channel and saved in the UI.

### **5. Message template (editor) and the relevant form** 

This entity is required for the channel type **Custom**. Channels that are of an SMS type are using the native SMS editor.

#### *Entity definition*

Dynamics Marketing supports a generic UI for message templates (editor) used by custom channels. For that an entity needs to be defined that will hold a form with the message parts you've defined in your channel. This entity won't store anything - it's only used as metadata to define your message contract.

The entity must include all the message parts defined in your channel with the exact same names but including the publisher prefix. For example, **cr65f\_text** for the **text** message part.

On top of that, the entity must include the **placeholders** attribute that is used for personalization in Marketing. Note that the **placeholders** attribute should also have the publisher prefix.

#### *Main form for the message template (editor)*

This form will be used in the Marketing content editor, accessed through the "More channels" area.

The form must include all the required attributes of the entity and the **placeholder's** attribute. You can use custom controls on the form or use Marketing OOB controls such as the **MsdynmktControls.RichTextControl.RichTextControl** that supports personalization.

### **6. Custom APIs**

#### *Outbound custom API*

A [custom API](https://learn.microsoft.com/en-us/power-apps/developer/data-platform/custom-api) needs to be defined that will be called during the Journey runtime in Marketing.

That is the entry point for custom code execution. When the Journey reaches a custom channel step, it will execute the API defined in the Channel Definition **msdyn\_outboundendpointurltemplate**. This API must accept the contract defined by the Marketing Journey and return the response.

#### *Delivery report custom API*

If your channel has delivery reports or statuses for messages, such as for example, "Delivered", you need to somehow proxy them back to Dataverse. One of the ways is to have an external application that will accept such traffic, process it and then notify Dataverse by executing the Custom API **msdyn\_D365ChannelsNotification.**

There are multiple ways of achieving that. One of them could be having a webhook in the service provider that will call a Power Automate flow. Basic validation and data transformation can be completed there. Then your own Custom API can be executed which will do the final steps and execute the **msdyn\_D365ChannelsNotification** API.

## 

## **Contracts**

### **Channel definition**

Entity logical name: **msdyn\_channeldefinition**  
Entity set name: **msdyn\_channeldefinitions**  
  
Primary Id attribute name: **msdyn\_channeldefinitionid**

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

Primary Id attribute name: **msdyn\_channelmessagepartid  
**

- **msdyn\_name:** string – Name for the message part, used as key for message parts in the outbound flow.

- **msdyn\_displayname**: string – Display name.

- **msdyn\_description:** string – Description.

- **msdyn\_channeldefinitionid:** GUID – Channel definition id, must match the channel definition id of the channel.

- **msdyn\_type:** OptionSet – Channel type, currently supported values:

    -   192350000 plaintext

More types will be introduced in further releases.

- **msdyn\_isrequired:** bit - Indicates whether the part is required.

- **msdyn\_maxlength: in**t - max length for the part

### **Outbound custom API**

The Outbound custom API must implement the following contract:  
  
It must have one input parameter: **payload**, and one output attribute: **response**

**payload** is a serialized JSON with the following contract:

{

    "ChannelDefinitionId": GUID,

    "RequestId": string,

    "From": string,

    "To": string,

    "Message": Dictionary&lt;string, string&gt;

}

where "**Message**" contains all the message parts for a channel.

**response** is a serialized JSON with the following contract  
{

{

    "ChannelDefinitionId": GUID,

    "MessageId": string,

    "RequestId": string,

    "Status": string,

    "StatusDetails": Dictionary&lt;string, object&gt;

};

Possible values for **Status:**

- **SendingAborted** – the internal validation from the channel side blocked the submission without a possibility to retry

<!-- -->

- **NotSent** – there was an attempt to execute the submission to the provider, but it was rejected without a possibility to retry

- **SendingFailed** – an internal issue (500 on channel implementation side or provider side) occurred for all submission retries 

- **Sent** – the submission request was successfully accepted by the provider 

- **Delivered** – the accepted message was successfully delivered to the target 

- **NotDelivered** – the accepted message wasn't successfully delivered to the target 

### 

### **Delivery report custom API**

API Name: **msdyn\_D365ChannelsNotification**

Input parameter**: notificationPayLoad -** serialized JSON with the following contract:

{

  "ChannelDefinitionId": GUID

  "From": string

  "MessageId": string

  "RequestId": string

  "Status": string

  "OrganizationId": string

  "StatusDetails": Dictionary&lt;string, object&gt;

}

