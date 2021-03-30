---
title: "Delete Microsoft Teams data | MicrosoftDocs"
ms.custom: 
description: "Delete Microsoft Teams data."
ms.date: 8/27/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 17
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Delete Microsoft Teams data 

## Delete user data
Your privacy is important to us. You can remove the personal data for customer engagement apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation) from Microsoft Teams.

The following data is stored with Dynamics 365 app integration with Microsoft Teams.

|     Data |  Description  | Data classification    |  Example   |
|----|-----|-------|--------|
|    User ID    |      The user's Azure Active Directory object ID       |  EndUsePseudonymousIdentifiers (EUPI) —<br/>An identifier created by Microsoft tied to the user of a Microsoft service. When EUPI is combined with other information, such as a mapping table, it identifies the end user. EUPI does not contain information uploaded or created by the customer.      |                                      <ul><li>User GUIDs, PUIDs, or SIDs</li><li>Session IDs</li><ul>                                      |
|   Tenant ID   |     The Azure Active Directory ID of the user's tenant     |  OrganizationIdentifiableInformation (OII) —<br/>Data that can be used to identify a tenant, generally config or usage data. This data is not linkable to a user and does not contain customer content.   | <ul><li>Tenant ID (non-GUID)</li><li>Domain name in email address (xxx@contoso.com) or other tenant-specific domain information</li><ul> |
|    Environment URL    |   The URL of the customer engagement app (such as Dynamics 365 Sales and Dynamics 365 Customer Service)    |   OrganizationIdentifiableInformation (OII) —<br/>Data that can be used to identify a tenant, generally config or usage data. This data is not linkable to a user and does not contain customer content.  | <ul><li>Tenant ID (non-GUID)</li><li>Domain name in email address (xxx@contoso.com) or other tenant-specific domain information</li><ul> |
| App module ID | The ID of app module selected to show in the dashboard | EndUsePseudonymousIdentifiers (EUPI) —<br/>An identifier created by Microsoft tied to the user of a Microsoft service. When EUPI is combined with other information, such as a mapping table, it identifies the end user. EUPI does not contain information uploaded or created by the customer. | <ul><li>User GUIDs, PUIDs, or SIDs</li><li>Session IDs</li><ul>   |

You can contact support to request data deletion. Run the following Windows PowerShell commands to gather the information needed by the support team.

For more information on how to install Windows PowerShell, see [Azure ActiveDirectory](/powershell/azure/active-directory/overview?view=azureadps-1.0&preserve-view=true).

|Command  |Comment  |
|---------|---------|
|``` Connect-MsolService  ```      |Enter your credentials in the pop-up window         |
|``` (Get-MsolUser -UserPrincipalName "<user email>").ObjectId  ```       |Replace <user email> with the user’s email         |
|``` (Get-MsolCompanyInformation).ObjectId ```        |         |

Record this information to provide to the support team.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
