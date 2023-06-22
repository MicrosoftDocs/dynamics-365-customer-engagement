---
title: Define an extended configuration entity for the channel instance account
description: Learn how to define an extended configuration entity for the custom SMS channel instance account in Dynamics 365 Sales. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define an extended configuration entity for the channel instance account

When you create a custom SMS channel, you need to define an entity to represent the extended configuration for the *channel instance account* (**msdyn_channelinstanceaccount**). For example, you might have a **MessageBird** account for which you've enabled multiple phone numbers. The channel instance account has a 1:N relationship with the [channel instances you created](custom-define-sms-instance.md) (in this example, the **MessageBird** phone numbers).

For each custom SMS channel solution, you need to:

1. Create a custom entity to represent the extended configuration of the **Channel Instance Account** entity defined in the base solution.

    The name of the entity is assigned to the attribute `msdyn_channeldefinitionaccountexternalentity` at the [channel definition step](custom-define-sms-definition.md).

1. Add a relationship to the base **Channel Instance Account** entity in the `msdyn_extendedentityid` attribute.

    This attribute is a [polymorphic lookup](/power-apps/developer/data-platform/webapi/multitable-lookup). Here's an example of the relationship in XML:

    ```XML
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

1. Create a form to expose the configuration fields.

    The form doesn't have to contain attributes like name or description since they come from Sales Custom controls. The form is loaded in the Sales SMS setup wizard (settings step). The form ID is assigned to the attribute **msdyn_channeldefinitionaccountexternalformid** at the [channel definition step](custom-define-sms-definition.md).  

    :::image type="content" source="media/sms-custom-form-account.png" alt-text="Screenshot of a form for an SMS channel with account details.":::

## Next step

[Define the message parts](custom-sms-message-parts.md)
