---
title: "Delete Teams data | MicrosoftDocs"
ms.custom: 
description: "Delete Teams data."
ms.date: 04/30/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
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
# Delete Teams data 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]



## Delete user data
Your privacy is important to us. You can remove Dynamics 365 for Customer Engagement apps personal data from Microsoft Teams.

The following data is stored with Dynamics 365 for Customer Engagement apps integration with Microsoft Teams.

|     Data |  Description  | Data classification    |  Example   |
|----|-----|-------|--------|
|    User ID    |      The user's Azure Active Directory object ID       |  EndUsePseudonymousIdentifiers (EUPI) —<br/>An identifier created by Microsoft tied to the user of a Microsoft service. When EUPI is combined with other information, such as a mapping table, it identifies the end user. EUPI does not contain information uploaded or created by the customer.      |                                      <ul><li>User GUIDs, PUIDs, or SIDs</li><li>Session IDs</li><ul>                                      |
|   Tenant ID   |     The Azure Active Directory ID of the user's tenant     |  OrganizationIdentifiableInformation (OII) —<br/>Data that can be used to identify a tenant, generally config or usage data. This data is not linkable to a user and does not contain customer content.   | <ul><li>Tenant ID (non-GUID)</li><li>Domain name in email address (xxx@contoso.com) or other tenant-specific domain information</li><ul> |
|    Environment URL    |   The URL of the Dynamics 365 for Customer Engagement app    |   OrganizationIdentifiableInformation (OII) —<br/>Data that can be used to identify a tenant, generally config or usage data. This data is not linkable to a user and does not contain customer content.  | <ul><li>Tenant ID (non-GUID)</li><li>Domain name in email address (xxx@contoso.com) or other tenant-specific domain information</li><ul> |
| App module ID | The ID of app module selected to show in the dashboard | EndUsePseudonymousIdentifiers (EUPI) —<br/>An identifier created by Microsoft tied to the user of a Microsoft service. When EUPI is combined with other information, such as a mapping table, it identifies the end user. EUPI does not contain information uploaded or created by the customer. | <ul><li>User GUIDs, PUIDs, or SIDs</li><li>Session IDs</li><ul>   |

You can [contact support](../admin/contact-technical-support.md) to request data deletion. Run the following Windows PowerShell commands to gather the information needed by Dynamics 365 for Customer Engagement apps support.

|Command  |Comment  |
|---------|---------|
|``` Connect-MsolService  ```      |Enter your credentials in the pop-up window         |
|``` (Get-MsolUser -UserPrincipalName "<user email>").ObjectId  ```       |Replace <user email> with the user’s email         |
|``` (Get-MsolCompanyInformation).ObjectId ```        |         |

Record this information to provide to Dynamics 365 for Customer Engagement apps support.
