---
title: "Preview: Define your extended configuration entity for Channel Instance (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your extended configuration entity for channel instance in Dynamics 365 Marketing."
ms.date: 12/08/2022
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
# Define your extended configuration entity for Channel Instance

## Applicable channels: SMS, Custom

### Why you need it:

**Channel Instance** is the representation of a channel in Marketing, after an admin uses an installed custom channel package to create and set up the new custom channel.

When creating a new custom channel, you need to set up a sender for example, the sender of the WhatsApp message. It means, each **Channel Instance** for channels of **Custom type** represents a single sender

### How to define it:

For each custom channel solution, you need to:

a. [Create your own custom entity](/learn.microsoft.com/dynamics365/customerengagement/on-premises/customize/create-entities?view=op-9-1) that will represent the extended configuration of the **Channel Instance** entity (**msdyn_channelinstance**), defined in the base solution. The name of the entity will be assigned to the attribute **msdyn_channeldefinitionexternalentity** at Channel Definition Step<ADD LINK to STEP 7>.

b. [Add a relationship](/learn.microsoft.com/dynamics365/customerengagement/on-premises/customize/create-and-edit-1n-relationships?view=op-9-1) to the base **Channel Instance** entity on **msdyn_extendedentityId** attribute. This attribute is a [polymorphic lookup](/learn.microsoft.com/power-apps/developer/data-platform/webapi/multitable-lookup?branch=pr-en-us-4448). Example of the relationship in xml:

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
c. Create a form to expose the configuration fields. The form will be loaded at the Marketing setup wizard. The form ID will be assigned to attribute **msdyn_channeldefinitionexternalformid** at Channel Definition Step<ADD LINK to STEP 6>.

For example, 

i. in **SMS**

> [!div class="mx-imgBorder"]
> ![sms](media/real-time-marketing-sms1.png "sms")

ii. in **Custom** (The form doesn’t have to contain attributes like name or description since they come from Marketing Custom controls.)

> [!div class="mx-imgBorder"]
> ![custom channel](media/real-time-marketing-select-custom-channel1.png "custom channel")