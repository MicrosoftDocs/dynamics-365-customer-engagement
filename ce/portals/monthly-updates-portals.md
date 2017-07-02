---
title: "Monthly updates in portal capabilities for Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 873dffa1-e598-4548-b494-7b67f2b01bb1
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# What’s new in portal capabilities for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

Welcome to portal capabilities for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. Here's a list of features we added recently. For more about the updates that have been made to portal capabilities for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] to date, along with other information pertinent to those updates, see [Portal capabilities for Microsoft Dynamics 365 Releases](https://support.microsoft.com/help/3181191/portal-capabilities-for-microsoft-dynamics-365-releases).

## Portal capabilities version 8.3 for Dynamics 365
The Portal capabilities version 8.3 for Dynamics 365 has brought many new updates and features:
- Ability to include attachments on knowledge articles: This feature allows you to display notes attachments along with the knowledge article in Portals. To enable this feature, you must create a site setting KnowledgeManagement/DisplayNotes and set the value to true. With this feature, Portal users can also search for these attachments. 
>[!Note] Search for attachments is possible only on the Notes description and File Attachment name. The content of attachment file is not searchable.
- Administrative wizard to add an entity to the portal: This feature introduces a new administrative wizard to easily expose data on the portal. The entity created through the wizard takes the data from your organization and make a subset of it available to your Portal customers based on the security and permission model you choose. 
- Portal interaction tracking (Preview): This preview feature allows you to track your customer's interactions with your Portal and funnel it to Dynamics 365 Customer Insights (DCI) to plot a 360-degree view. This will be helpful in knowing the user’s journey on a Portal before and after creating a case. This also help you to understand the real issue, avoid asking the same information again from the user, and enable you to respond with the relevant information.
- Import metadata translation: This feature allows you to import the metadata translation of the newly activated languages post installation of a portal.
- Source code availability for Portals: A one-time release of Portals code is released to the Microsoft Download Center under MIT license for developers to download. This feature enables Portals to be deployed to Dynamics 365 on-premise or online environments, and allows developers to customize the code to suit their specific business needs.
Note: Source code is offered as working sample and on an as-needed basis. No direct support will be provided for any modifications to the code.
- Single Sign-on (SSO) configuration improvements and support for Azure Active Directory B2C: For Portals that require a consumer based login, this feature now supports the ability to:
  - Configure your portal authentication to use a Single Sign-On configuration 
  - Support Azure AD-B2C for customer authentication
  - Manage your Portal security in Azure
- Support timezone independent date formats in Portals forms: This feature adds support for “Date Only” and “Timezone Independent” behaviors for date/time fields to Portals.
- Allowing non-global administrators to provision Portal: You can now provision a portal if you are assigned to the System Administrator role of the CRM organization selected for the portal. You can now also manage an existing portal, if you have any of the following roles:
  - Dynamics 365 Service Administrator
  - System Administrator of the CRM organization selected for the portal
- Store custom domain name for portal: This feature stores the primary domain name of a portal on the website record. If the domain name is changed in future, the latest primary domain name is stored. 
- Tracking cookie for Portals: A persistent cookie Dynamics365PortalAnalytics will be set whenever a user will navigate to a Portal. This cookie has an expiration of 90 days.  This cookie does not store any personal data of the user and is used by Microsoft to collect analytics about portal service. Please read more about Microsoft Online services privacy statement here.


[//]: # (Please verify whether these instances of "December 2016 update" would be better as tokens? I'm not sure which ones to suggest.)
## December 2016 updates
The December 2016 update has brought many new features to the portal capabilities of [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. These updates allow for better interactions among companies, partners, and customers, and make the experience of navigating the portal faster and easier. Some of the major updates include:

- **Multiple language support:** Support customers from multiple regions by using a single portal.
- **East Asian language support:** Multi-byte languages such as Japanese, Chinese, and Korean are now supported.
- **Faceted search:** New filters improve how quickly customers can find the content they are looking for while granting more control over visibility of content.
- **Product filtering:** Portal users can trim access to knowledge articles related to their product ownership to avoid information overload.
- **Content access levels:** A new level of ownership associated with a portal contact, account, or web role can be used to control access to knowledge articles, to help target the right article at the right audience and prevent irrelevant articles from surfacing.
- **Knowledge article reporting enhancement:** The portal tracks where a knowledge article was used in the portal.
- **Project Service Automation integration:** Provide access and visibility for active and closed projects across all stages of a project lifecycle to partners and customers. Team members, reviewers, and customers can view project status, quotes, order forums, and bookable resources on the portal with this solution.
- **Field Service integration:** Expose information about active agreements, assets, work orders, invoices, and support cases to partners and customers on the portal with this solution.
- **Partner onboarding:** Recruit new partners for better customer sales and service experiences. Potential partners can apply for partner status through the portal.

### Privacy notice

[!INCLUDE[cc-privacy-crm-portals-data-exposed](../includes/cc-privacy-crm-portals-data-exposed.md)]

For more information about additional [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] service offerings, see the [[!INCLUDE[cc_privacy_note_azure_trust_center](../includes/cc_privacy_note_azure_trust_center.md)]](https://azure.microsoft.com/support/trust-center/).  
