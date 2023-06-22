---
title: Define an extended configuration entity for the SMS instance
description: Learn how to define an extended configuration entity for the SMS instance in Dynamics 365 Sales. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define an extended configuration entity for the channel instance

A *Custom instance* is the representation of a provider in Dynamics 365 Sales. When you create the channel, you need to configure a sender&mdash;for example, the sender of a text message. Each instance of a channel&mdash;that is, the entity **Channel Instance**&mdash;represents a single sender.

For each channel solution, you need to:

1. [Create a custom table](/power-apps/maker/data-platform/data-platform-create-entity) to represent the extended configuration of the **Channel Instance** table (**msdyn_channelinstance**) defined in the base solution.

    The name of the table is assigned to the attribute **msdyn_channeldefinitionexternalentity** at the [channel definition step](custom-define-sms-definition.md).

1. [Create and edit One-to-many or Many-to-one table relationships](/power-apps/maker/data-platform/create-edit-1n-relationships-portal) to the base **Channel Instance** table in the `msdyn_extendedentityid` attribute.

    This attribute is a [polymorphic lookup](/power-apps/developer/data-platform/webapi/multitable-lookup). Here's an example of the relationship in XML:

    ```XML
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

    The form is loaded in the Sales setup wizard. The form ID is assigned to the attribute **msdyn_channeldefinitionexternalformid** at the [channel definition step](custom-define-sms-definition.md).

    :::image type="content" source="media/sms-custom-form.png" alt-text="Screenshot of a form for an SMS channel.":::

## Next steps

[Define an extended configuration entity for the SMS instance account](custom-define-sms-account.md)
