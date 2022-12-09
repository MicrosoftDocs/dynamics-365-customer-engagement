---
title: "Define your extended configuration entity for the Channel Instance account (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your extended configuration entity for the channel instance account in the real-time marketing area of Dynamics 365 Marketing."
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
# Define your extended configuration entity for the Channel Instance account

## Applicable channels: SMS only

### Why you need it:

If you're creating a custom SMS channel, you must define an entity representing extended configuration for **Channel Instance Account** (**msdyn_channelinstanceaccount**). For example, you could have a MessageBird   account and have enabled multiple numbers for it. The **Channel Instance Account** has a 1:N relationship with the **Channel Instances** (for example, phone numbers) that we’ll examine in Step 2 <ADD LINK to STEP 6>.

### How to define it:

For each custom channel solution, you need to:

a. Create your own custom entity that will represent the extended configuration of the **Channel Instance Account** entity, defined in the base solution. The name of the entity will be assigned to the attribute **msdyn_channeldefinitionaccountexternalentity** at Channel Definition Step<ADD LINK to STEP 7>.

b. Add a relationship to the base **Channel Instance Account** entity on **msdyn_extendedentityId** attribute. This attribute is a polymorphic lookup.   Example of the new relationship in xml:

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
c. Create a form to expose configuration fields. The form doesn’t have to contain attributes like name or description since they come from Marketing Custom controls. The form will be loaded at the Marketing SMS setup wizard (Settings step). The form ID will be assigned to the attribute **msdyn_channeldefinitionaccountexternalformid** at Channel Definition Step<ADD LINK to STEP 7>.  

For example, in SMS, the form will look as follows:

> [!div class="mx-imgBorder"]
> ![sms channel](media/real-time-marketing-sms-channel.png "sms channel")