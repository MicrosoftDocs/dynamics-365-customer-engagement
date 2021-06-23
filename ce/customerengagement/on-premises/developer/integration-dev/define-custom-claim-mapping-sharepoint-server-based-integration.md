---
title: "Define custom claim mapping for SharePoint server-based integration (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: f926277d-6820-4ea3-9512-3643da16b94b
caps.latest.revision: 15
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
<!-- jdaly bug 700711 determines whether this page should be removed  -->

# Define custom claim mapping for SharePoint server-based integration

For server-based integration with [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)], [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]  uses claims to authenticate and authorize [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] users to access the documents stored in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]. For more information about claims-based authentication, see [Claims-based identity in SharePoint 2013](https://msdn.microsoft.com/library/office/ee535242.aspx).  

 By default, [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] uses the following claims  to integrate with [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]:  


|                                                                              Scenario                                                                               |                                                                                                                                              Claims                                                                                                                                              |
|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|      [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)]      |                                                   `NameId (PUID)`<br /><br /> Both Dynamics 365 Customer Engagement (on-premises) and SharePoint share [!INCLUDE[pn_microsoft_azure_active_directory](../../includes/pn-microsoft-azure-active-directory.md)] for user identity.                                                   |
| [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] on-premises | `SMTP (email)`<br /><br /> No shared active directory infrastructure for user identity; claims sent as SMTP address. The claims is picked from WindowsLiveID field in Dynamics 365 Customer Engagement (on-premises) and mapped to work email address from [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]. |
|                                Dynamics 365 Customer Engagement (on-premises) and [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)]                                |                            `SMTP (email)`<br /><br /> No shared active directory infrastructure for user identity; claims sent as SMTP address. The claims is picked from PrimaryEmailAddess field in Dynamics 365 Customer Engagement (on-premises) and mapped to work email address from SharePoint.                             |
|                           Dynamics 365 Customer Engagement (on-premises) and [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] on-premises                           |                                                                           `Security Identifier (SID)`<br /><br /> Both Dynamics 365 Customer Engagement (on-premises)  and SharePoint share Microsoft Windows Server Active Directory for user identity.                                                                            |

 You can use the `UserMapping` entity to specify custom claim mappings in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to use a value other than the default value used by [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to authenticate and authorize [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] users in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]. For example, you can use the “last name” and “first name” of the user instead of “email” to authenticate [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] users in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]. Custom claim mappings override the default claim mappings used by [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. You can define multiple custom claim mappings in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. By default, only users having the System Administrator role have access to the `UserMapping` entity.  

 To define a custom claim mapping in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], create a `UserMapping` entity record, and specify the attribute values listed in the following table.  


|               Attribute               |                                                                     Value                                                                      |                                                                                                                                                                                                                                                                                Description                                                                                                                                                                                                                                                                                |
|---------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `UserMapping.PartnerApplicationType`  | -   `0`: [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]<br />-   `1`: [!INCLUDE[internal](../../includes/internal.md)] |                                                                                                                                                                                     The partner application type for which this claim mapping is to be used. In the current release, only `0` ([!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]) is supported.                                                                                                                                                                                      |
| `UserMapping.SystemUserAttributeName` |                                                                  String value                                                                  | The logical name of the attribute in the `SystemUser` (user) entity from where the value for the claims will be used. **Note:**  If the attribute used for custom claim mapping doesn’t contain a value, the default claim mapping is used by [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. For example, if you want to use the first name of the user as the attribute for custom claim mapping and a user’s first name is missing, [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] will use the default claim mapping (PUID or email). |
|        `UserMapping.ClaimType`        |                                                                  String value                                                                  |                     Specify the claim type to be sent to SharePoint. For a list of claim types, see [ClaimTypes Members](https://msdn.microsoft.com/library/microsoft.identitymodel.claims.claimtypes_members.aspx). **Note:**  The referred claim type list is just for reference. All the claim types listed there might not be supported by [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)], or might not contain all the claim types supported by [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)].                      |

 The following sample code shows how to define a custom claim mapping using the `UserMapping` entity.  

```csharp
UserMapping customMapping = new UserMapping  
{  
   PartnerApplicationType = new OptionSetValue(0),  
   SystemUserAttributeName = "personalemailaddress",  
   ClaimType = "smtp"  
};  
_serviceProxy.Create(customMapping);  
```  

> [!NOTE]
>  Any instance of the `UserMapping` entity with valid values will override the default claim mappings used by [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  

 By default, [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] supports the following claim types: NameId (PUID), SMTP (email), and UPN (user principal name). If you’re passing a claim of any other type, you must also create corresponding claim type mappings in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)][New-SPClaimTypeMapping](https://technet.microsoft.com/library/ff607650.aspx)  

### See Also
 [UserMapping Entity](../entities/usermapping.md)   
 [Integrate Microsoft Dynamics 365 Customer Engagement (on-premises) with SharePoint](integrate-sharepoint.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]