---
title: "Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity reference

Stores data about what folders for a mailbox are auto tracked

> [!NOTE]
> The Microsoft Dynamics 365 Sales Mailbox Auto Tracking Folder (MailboxTrackingFolder) table extends the [Microsoft Dataverse Mailbox Auto Tracking Folder (MailboxTrackingFolder) table](/power-apps/developer/data-platform/reference/entities/mailboxtrackingfolder).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/mailboxtrackingfolder#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_MailboxTrackingFolders"></a> sample_bankaccount_MailboxTrackingFolders

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_MailboxTrackingFolders](sample_bankaccount.md#BKMK_sample_bankaccount_MailboxTrackingFolders)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mailboxtrackingfolder?displayProperty=fullName>
