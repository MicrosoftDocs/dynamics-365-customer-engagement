---
title: "How hierarchical security can be used to control access to entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Provides an additional, more granular security model for accessing records in a hierarchical organizational structure."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 61ec481c-c128-498b-a784-16fe11af424b
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# How hierarchical security can be used to control access to entities

Hierarchy security offers a more granular access to records for an organization and helps to bring the maintenance costs down. For example, in complex scenarios, you can start with creating several business units and then add the hierarchy security. This will achieve a more granular access to data with far less maintenance costs that a large number of business units may require. The hierarchy security model is an extension to the earlier security models that use business units, security roles, sharing, and teams. It can be used in conjunction with all other existing security models.  
  
 Previously, implementing this kind of security often required developers to mimic this behavior using custom plug-ins. Now, with the hierarchy security model, that type of security is built into the  product. This removes the need to create and update custom plug-ins.  
  
 For a detailed description of the hierarchy security model, see [Security concepts for Microsoft Dynamics 365 Customer Engagment apps](https://technet.microsoft.com/library/hh699698.aspx) in the [!INCLUDE[pn_crm_2015_ig](../../includes/pn-crm-2015-ig.md)] Customer Engagement (on-premises) documentation.  
  
 [Video: Hierarchical Security Modelling in Microsoft Dynamics CRM 2015](https://youtu.be/kx5So32DrCo)  
  
## Position hierarchy  
 Administrators can define various job positions in the organization and arrange them in the position hierarchy. You can add users to any given position or “tag” a user with a particular position. A user can be tagged only with one position in a given hierarchy; however, a position can be used for multiple users. Users at the higher positions in the hierarchy have access to the data of the users at the lower positions, in the direct ancestor path. The direct higher positions have Read, Write, Update, Append, and AppendTo access to the lower positions’ data in the direct ancestor path. The non-direct higher positions have read-only access to the lower positions’ data in the direct ancestor path.  
  
 With the position hierarchy security, a user at a higher position has access to the records owned by a lower position user or by the team that a user is a member of, and to the records that are directly shared to the user or the team that a user is a member of. In addition to the position hierarchy security model, the users at a higher level must have at least the user level Read privilege on an entity to see the records that the users at the lower positions have access to. For example, if a user at a higher level doesn’t have the Read access to the `Case` entity, that user won’t be able to see the cases that the users at a lower positions have access to.  
  
 As a developer, you can implement a position hierarchy by using the **Position** entity.  
  
 Two new privileges have been added that are related to the position hierarchy feature as shown in the table below.  
  
|Privilege|Description|  
|---------------|-----------------|  
|prvAssignPosition|Assign a position to a system user.|  
|prvWriteHierarchicalSecurityConfiguration|Change hierarchy security settings.|  
  
 For more information about the `Position` entity and its messages, see [Position Entity](../entities/position.md).  
  
### See also  
 [Video: Hierarchical Security Modelling in Microsoft Dynamics CRM 2015](https://youtu.be/kx5So32DrCo)   
 [The Security Model of Microsoft Dynamics 365 Customer Engagement (on-premises)](security-model.md)   
 [Security concepts for Microsoft Dynamics 365 Customer Engagement (on-premises)](https://technet.microsoft.com/library/hh699698.aspx)
 [Position Entity](../entities/position.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]