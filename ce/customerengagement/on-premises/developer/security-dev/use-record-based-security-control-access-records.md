---
title: "Use record-based security to control access to records (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Provides record-based security to manage access rights to individual Customer Engagement records."
ms.custom: 
ms.date: 08/18/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: f2b7ddcc-6678-492f-8b4b-478e00049362
caps.latest.revision: 39
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Use record-based security to control access to records

Record-based security in Dynamics 365 Customer Engagement (on-premises) applies to individual records. It is provided by using access rights.  
  
 The relationship between an access right and a privilege is that access rights apply only after privileges have taken effect. For example, if a user does not have the privilege to read accounts, that user is unable to read any account, regardless of the access rights another user might grant to a specific account through sharing.  
  
<a name="BKMK_AccessRights"></a>   
## Access rights  
 An access right is granted to a user for a particular record. The following table lists the descriptions for these access rights.  
  
|Access right|<xref:Microsoft.Crm.Sdk.Messages.AccessRights> enumeration value|Description|  
|------------------|---------------------------------------------------------------------------------------------------------------------|-----------------|  
|Read|ReadAccess|Controls whether the user can read a record.|  
|Write|WriteAccess|Controls whether the user can update a record.|  
|Assign|AssignAccess|Controls whether the user can assign a record to another user.|  
|Append|AppendAccess|Controls whether the user can attach another record to the specified record.<br /><br /> The Append and Append To access rights work in combination. Every time that a user attaches one record to another, the user must have both rights. For example, when you attach a note to a case, you must have the Append access right on the note and the Append To access right on the case for the operation to work.|  
|Append To|AppendToAccess|Controls whether the user can append the record in question to another record.<br /><br /> The Append and Append To access rights work in combination. For more information, see the description for Append.|  
|Share|ShareAccess|Controls whether the user can share a record with another user or team. Sharing gives another user access to a record. For more information, see [Sharing Records](use-record-based-security-control-access-records.md#BKMK_SharingInstances).|  
|Delete|DeleteAccess|Controls whether the user can delete a record.|  
  
### Create access  
 The right to create a record for an entity type is not included in the previous table because this right does not apply to an individual record, but instead to a class of entities. Create is handled as a privilege instead of as an access right. The user who creates a record has all rights on that record, unless his or her other privileges forbid a specific right.  
  
 The Create privilege controls whether you can create a record. If you have the Create privilege with Local, Deep, or Global access, you can create records for other users. If you have Create and Read privileges with Basic access, you can create records for yourself.  
  
 For more information about dependencies that relate to create privileges, see [Dependencies between access rights](use-record-based-security-control-access-records.md#dependencies).  
  
<a name="BKMK_SharingInstances"></a>   
## Sharing records  
 Sharing lets users give other users or teams access to specific customer information. This is useful for sharing information with users in roles that have only the Basic access level. For example, in an organization that gives salespeople Basic read and write access to accounts, a salesperson can share an opportunity with another salesperson so that they can both track the progress of an important sale.  
  
 For security reasons, develop the practice of sharing only the necessary records with the smallest set of users possible. Only grant the minimum access required for users to do their jobs.  
  
 Dynamics 365 Customer Engagement (on-premises) provides the following sharing capabilities:  
  
- **Share**. Any user who has share privileges on a given entity type can share records of that type with any other user or team in Dynamics 365 Customer Engagement (on-premises). To share a record, use <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>.  
  
     When you share a record with another user, indicate what access rights (Read, Write, Delete, Append, Assign, and Share) you want to grant to the other user. Access rights on a shared record can be different for each user with whom the record is shared. However, you cannot give a user any rights that he or she would not have for that type of entity, based on the role assigned to that user. For example, if a user does not have Read privileges on accounts and you share an account with that user, the user will be unable to see that account.  
  
- **Modify share**. You can modify the rights granted to a shared record after it has been shared. To modify sharing for a record, use the <xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>.  
  
- **Remove share**. If you share a record with another user or team, you can stop sharing the record. After you remove sharing for a record, the other user or team loses access rights to the record. To remove sharing for a record, use the <xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>.  
  
> [!TIP]
>  Use <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>, <xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>, and <xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest> for sharing.  
  
 A user might have access to the same record in more than one context. For example, a user might share a record directly with specific access rights, and he or she might also be on a team in which the same record is shared with different access rights. In this case, the access rights that this user has on the record are the union of all the rights.  
  
 For a list of entities that support sharing, see the <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>.  
  
<a name="BKMK_SharingAndInheritance"></a>   
### Sharing and inheritance  
 If a record is created and the parent record has certain sharing properties, the new record inherits those properties. For example, Joe and Mike are working on a high priority lead. Joe creates a new lead and two activities, shares the lead with Mike, and selects cascade sharing. Mike makes a telephone call and sends an email regarding the new lead. Joe sees that Mike has contacted the company two times, so he does not make another call.  
  
 Sharing is maintained on individual records. A record inherits the sharing properties from its parent and also maintains its own sharing properties. Therefore, a record can have two sets of sharing properties—one that it has on its own and one that it inherits from its parent.  
  
 Removing the share of a parent record removes the sharing properties of objects (records) that it inherited from the parent. That is, all users who previously had visibility into this record no longer have visibility. Child objects still could be shared to some of these users if they were shared individually, not from the parent record.  
  
<a name="BKMK_AssigningRecords"></a>   
## Assigning records  
 Anyone with Assign privileges on a record can assign that record to another user. When a record is assigned, the new user or team becomes the owner of the record and its related records. The original user or team loses ownership of the record, but automatically shares it with the new owner.  
  
 In [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], the system administrator can decide for an organization whether records should be shared with previous owners or not after the assign operation. If **Share with previous owner** is selected, then the previous owner shares the record with all access rights after the assign operation. Otherwise, the previous owner does not share the record and may not have access to the record, depending on his or her privileges. The `Organization.ShareRoPreviousOwnerOnAssign` attribute controls this setting.  
  
 For a list of entities that support Assign, see the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>.  
  
<a name="bkmk_retrievingaccess"></a>   
## Retrieving the access rights for a record  
 Use the <xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest> message to retrieve the access rights the specified security principal (user or team) has to a record.  
  
 Use the <xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest> message to retrieves all the security principals (users or teams) that have access to a record, together with their access rights to that record.  
  
<a name="dependencies"></a>   
## Dependencies between access rights  
 Sometimes, security dependencies exist because it is necessary to have more than one access right to perform a given action. For example, if you have the **create** access right for accounts, you can create a record of the account entity type. However, unless you also have **read** access for accounts, you cannot create an account record and be the owner of that new record.  
  
 The following table lists the access right dependencies for the actions specified.  
  
|Action|Access rights required|  
|------------|----------------------------|  
|To **Create** a record and be the record owner|CREATE<br /><br /> READ|  
|To **Share** a record|SHARE. This right is required by the person doing the share operation.<br /><br /> READ. This right is required by the person doing the share operation and also by the person with whom the record is being shared.|  
|To **Assign** a record|ASSIGN<br /><br /> WRITE<br /><br /> READ|  
|To **Append To** a record|WRITE<br /><br />READ<br /><br /> APPENDTO|  
|To **Append** a record|WRITE<br /><br />READ<br /><br /> APPEND|  
  
 Another type of dependency exists when objects are subordinate to another object. For example, the opportunity object cannot exist on its own. Each opportunity is always attached to an account or contact. To create an opportunity, you must have the access right **appendto** on accounts and the access right **append** on opportunities.  
  
### See also  
 [The Security Model of Microsoft Dynamics 365 Customer Engagement (on-premises)](Security-model.md)   
 [How role-based security can be used to control access to entities in Microsoft Dynamics 365 Customer Engagement (on-premises)](how-role-based-security-control-access-entities.md)  [How field security can be used to control access to field values in Microsoft Dynamics 365 Customer Engagement (on-premises)](use-field-security-control-access-field-values.md)   
 [Introduction to Entities in Microsoft Dynamics 365 Customer Engagement (on-premises)](../introduction-entities.md)   
 [Entity Relationship Behavior](../entity-relationship-behavior.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AccessRights>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]