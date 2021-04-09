---
title: "Field security entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about using field security entities to apply field-level security, which restricts field access to specified users and teams."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - field-level security, scope of
  - applying field-level security
  - secured fields, sharing
  - restricting field access
  - field security profile records, creating
  - securing fields vs. securing records
  - field permission attributes
  - field-level security, setting up and using
  - creating field security profile records
  - field access, restricting
  - sharing secured fields
ms.assetid: 3fa8b175-a73e-4b38-b73d-e385a7c6ced5
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Field security entities

You use field security entities to apply field-level security, which restricts field access to specified users and teams. The scope of field-level security is global, which means that it applies to all records within the organization, regardless of the business unit hierarchical level to which the record or the user belongs. Field security works in all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] clients, including the Web client, [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)], and [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)]. It applies to all components, such as the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)], reports, search, offline, filtered views, auditing, and duplicate detection. For this release, field security can be applied to both custom fields and many out-of-box (OOB) fields.  
  
 For more information about how secured fields change the behavior of methods, see [How Field Security Can Be Used to Control Access to Field Values in Dynamics 365 Customer Engagement (on-premises)](security-dev/use-field-security-control-access-field-values.md).  
  
> [!IMPORTANT]
>  Field-level security profiles prevent unintended users from getting access to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data based on the profile definitions. If the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] ACLs are misconfigured, or if there is a SQL injection issue, adversaries can get direct access to data in [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] thereby bypassing field level security restrictions. For more information, see [Overview of Web Application Security Threats](/previous-versions/f13d73y6(v=vs.140)).  
  
<a name="bkmk_setup"></a>   
## Set up and use field security  
 To use field security you must do the following:  
  
1. Create a field security profile record  
  
2. Add users or teams to the profile  
  
3. Find an attribute that can be secured at the field level  
  
4. Secure the attribute, either when you create the attribute or by updating the attribute metadata  
  
5. Publish the attribute customizations  
  
6. Create a field permission record that defines what access (create, update, read) the profile will have for the custom attribute  
  
   For sample code about how to perform these steps, see [Sample: Enable Field Security For An Entity](sample-enable-field-security-entity.md).  
  
   Use the following field permission attributes to set whether the specified field security profile can create, read, or update an attribute. 
   You can set or compare the value for these attributes by using the `field_security_permission_type` global option set:  
  
-   `FieldPermission`.`CanCreate`  
  
-   `FieldPermission`.`CanRead`  
  
-   `FieldPermission`.`CanUpdate`  
  
> [!IMPORTANT]
>  If low privilege users are given Read access to the field security profile entity, they can see what profiles other users have and find other users with access to secured attributes they are interested in. They can then use social engineering techniques to get assigned a profile with access to those secured attributes.  
  
<a name="bkmk_whichattributes"></a>   
## Which attributes can be secured?  
 To see which attributes can be secured, you can query the entity metadata for the following properties:  
  
- <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.CanBeSecuredForCreate>  
  
- <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.CanBeSecuredForRead>  
  
- <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.CanBeSecuredForUpdate>  
  
  There are a few additional rules that apply to certain attribute data types:  
  
- Boolean attributes can be secured for create and update operations but not for read.  
  
- Option set attributes can be secured for create, update, and read when a default value is unspecified.  
  
  There are thousands of attributes that can be secured, so there are two easier ways to look for this information. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  
  
<a name="bkmk_sharing"></a>   
## Share secured fields  
 You can share secured fields much as you can share records. To do this, you create, update, or delete a `PrincipalObjectAttributeAccess` (field sharing) record, where you specify the user or team, the entity, and the permissions.  
  
 The following table lists the corresponding methods for securing a field compared to securing a record.  
  
|Record sharing|Field access sharing|  
|--------------------|--------------------------|  
|Use the <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest> message to grant record access for a user or team.|Use the <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message or the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method to grant secured field access for a user or team.|  
|Use the <xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest> message to update record access for a user or team.|Use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message or the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method to update secured field access for a user or team.|  
|Use the <xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest> message to remove record access for a user or team.|Use the <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> message or the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method to remove secured field access for a user or team.|  
  
### See also  
 [The Security Model of Dynamics 365 Customer Engagement (on-premises)](security-dev/security-model.md)   
 [Administration and security entities](administration-security-entities.md)   
 [FieldSecurityProfile Entity](entities/fieldsecurityprofile.md)   
 [FieldPermission Entity](entities/fieldpermission.md)   
 [PrincipalObjectAttributeAccess Entity](entities/principalobjectattributeaccess.md)   
 [Field-level data encryption](field-level-data-encryption.md)   
 [Sample: Retrieve Field Permissions](sample-retrieve-field-permissions.md)   
 [Sample: Enable Field Security For An Entity](sample-enable-field-security-entity.md)   
 [Sample: Retrieve Field Sharing Records](sample-retrieve-field-sharing-records.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]