---
title: Define an extended configuration entity for the channel instance
description: Learn how to define an extended configuration entity for a custom channel instance in Dynamics 365 Marketing.
ms.date: 01/30/2023
ms.custom: 
  - dyn365-marketing
  - bap-template
ms.topic: how-to
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Define an extended configuration entity for the channel instance

Applicable channels: SMS, custom

A *channel instance* is the representation of a custom channel in Dynamics 365 Marketing. When you create a custom channel, you need to configure a sender&mdash;for example, the sender of a WhatsApp message. Each instance of a custom channel&mdash;that is, the entity **Channel Instance**&mdash;represents a single sender.

> [!IMPORTANT]
> To allow Marketing to access the extended configuration entity during submission, you need to add **Read** privileges for the extended configuration entity to the "Cxp Channel Definitions Services User" role.

For each custom channel solution, you need to:

1. [Create a custom entity](/dynamics365/customerengagement/on-premises/customize/create-entities) to represent the extended configuration of the **Channel Instance** entity (**msdyn_channelinstance**) defined in the base solution.

    The name of the entity is assigned to the attribute **msdyn_channeldefinitionexternalentity** at the [channel definition step](real-time-marketing-define-channel-definition.md).

1. [Add a relationship](/dynamics365/customerengagement/on-premises/customize/create-and-edit-1n-relationships) to the base **Channel Instance** entity in the **msdyn_extendedentityid** attribute.\

    This attribute is a [polymorphic lookup](/power-apps/developer/data-platform/webapi/multitable-lookup). Here's an example of the relationship in XML:

```xml
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

1. Create a form to expose the configuration fields.

    [!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

    The form is loaded in the Marketing setup wizard. The form ID is assigned to the attribute **msdyn_channeldefinitionexternalformid** at the [channel definition step](real-time-marketing-define-channel-definition.md).

    - SMS example:

      :::image type="content" source="media/real-time-marketing-sms1.png" alt-text="Screenshot of a form for an SMS channel." lightbox="media/real-time-marketing-sms1.png":::
    <!-- EDITOR'S NOTE: Please crop the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

    - Custom example (the form doesn't have to contain attributes like name or description since they come from Marketing Custom controls):

      :::image type="content" source="media/real-time-marketing-select-custom-channel1.png" alt-text="Screenshot of a form for a custom channel." lightbox="media/real-time-marketing-select-custom-channel1.png":::
    <!-- EDITOR'S NOTE: Please crop the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

[!INCLUDE [footer-include](../includes/footer-banner.md)]
