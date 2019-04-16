---
title: "Monthly updates in portal capabilities for Dynamics 365 for Customer Engagement | MicrosoftDocs"
description: "Learn about what's new in the latest release of portal capabilities for Dynamics 365 for Customer Engagement."
keywords: "portal new features, portal enhancements, portal user guide"
ms.date: 04/17/2019
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-portal
ms.topic: article
ms.assetid: 873dffa1-e598-4548-b494-7b67f2b01bb1
author: sbmjais
ms.author: shjais
manager: shubhadaj
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# What's new in portal capabilities for Dynamics 365 for Customer Engagement apps

Welcome to portal capabilities for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps. Here's a list of recently added features. For more information about portal capability updates for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps to date, see [portal capabilities for Microsoft Dynamics 365 for Customer Engagement Releases](https://support.microsoft.com/en-us/help/3181191).

## Portal capabilities version 9.1.4 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 9.1.4 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps brings these new updates and features:

- **Maintenance mode for portal**: As a portal administrator, you can now configure your portal to display a proper message to the customers whenever a maintenance activity is going on—for example, solution packages are being upgraded. More information: [Maintenance mode for a portal](enable-maintenance-mode.md)

- **Enable Power BI Embedded service**: As a portal customizer, you can now embed dashboards and reports created in the new workspace of Power BI by enabling Power BI Embedded service. The dashboards and reports are embedded on web pages in a portal by using the powerbi Liquid tag. More information: [Set up Power BI integration](set-up-power-bi-integration.md#enable-power-bi-embedded-service)

- **Enable content moderation on ideas**: As a portal administrator, you can now create a content moderation policy to moderate the ideas that are submitted on your portal. More information: [Enable content moderation on ideas](enable-idea-content-moderation.md)

- **OAuth 2.0 implicit grant flow**: As a portal developer, you can now make client-side API calls to external APIs and get them secured by using OAuth 2.0 implicit grant flow. More information: [OAuth 2.0 implicit grant flow](oauth-implicit-grant-flow.md)

- **Common Data Service starter portal (preview)**: As a portal administrator, you can now configure your portal to connect to the Common Data Service environment and allow your users to interact with it. This feature brings in the ability to connect a portal to a Common Data Service environment that does not have any [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps (Sales, Service, or Marketing) preinstalled. More information: [Common Data Service starter portal](cds-portal.md)

## Portal capabilities version 9.1.1 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 9.1.1 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps brings these new updates and features:

- **Portal checker**: You can now use portal checker to identify issues with your portal by looking at various configuration parameters and provide suggestions on how to fix them. More information: [Portal checker](portal-checker.md)

## Portal capabilities version 9.0.10 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 9.0.10 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps brings these new updates and features:

- **Migrate Dynamics 365 for Customer Engagement Portal configuration**: You can now migrate your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal configuration from development to testing or the production environments. Migration involves exporting the existing configuration from the source [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instance, and then importing it into the target [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instance. To migrate configuration data, you need to use the Configuration Migration tool and a portal-specific configuration schema file. More information: [Migrate Dynamics 365 for Customer Engagement Portal configuration](migrate-portal-configuration.md)

- **Add Power BI visualization**: As a portal customizer, you can now embed Power BI visualizations (dashboard, reports, and tiles) on web pages in a portal by using the powerbi Liquid tag. More information: [Set up Power BI integration](set-up-power-bi-integration.md)

- **Restrict portal access by IP address**: As a portal administrator, you can now define a list of IP addresses that are allowed to access your portal. When a request to the portal is generated from any user, their IP address is evaluated against the allow list. If the IP address is not on the list, the portal displays a web page with an HTTP 403 status code. More information: [Restrict portal access by IP address](ip-address-restrict.md)

- **Manage SharePoint documents**: [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal now supports uploading and displaying documents to and from SharePoint directly on an entity form or web form in a portal. This allows portal users to view, download, add, and delete documents from a portal. Portal users can also create folders to organize their documents. More information: [Manage SharePoint documents](manage-sharepoint-documents.md)

- **New portal content editor (preview)**: In this preview, a new and simplified portal editor is available for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal customizers to reduce the learning curve on Dynamics 365 for Customer Engagement Portal customization and increase a customizer's productivity. More information: [Get started with the new portal content editor](portal-new-content-editor.md)

- **Enable voting for status reasons**: By default, an idea is enabled for voting only when the Status Reason is set to New. You can now enable the voting on an idea for different status reasons. To enable voting for different status reasons, you must create the Ideas/EnableVotingForStatusReasons site setting and set its value to the required status reason values. More information: [Enable voting for status reasons](crowdsource-ideas.md#enable-voting-for-status-reasons)

## Portal capabilities version 9.0.6 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 9.0.6 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps has brought the following latest updates and features:

- **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal app**: The [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal app provides a new experience to configure and manage your online platform to communicate and collaborate with customers. When you install [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal version 9.0 and higher, the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Portal app, built on the Unified Interface framework, is created out-of-the-box.

- **Reset a portal**: You can now reset a portal if you plan to move to another geolocation or to another tenant, and don't want to use the portal anymore. When you reset a portal, the hosted resources of the portal are deleted, and the portal URL will not be accessible. More information: [Reset a portal](reset-portal.md)

- **Change the base URL of a portal**: You can now change the base URL of a portal after it is provisioned. For example, if you choose contosocommunity.microsoftcrmportals.com as the base URL while provision the portal, you can later change it to contosocommunityportal.microsoftcrmportals.com as per your requirement. More information: [Change base URL](change-base-url.md)


## Portal capabilities version 8.4.1 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 8.4.1 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps brings in a bunch of bug fixes, as well as performance improvements, along with the following features:

- **Search within attachment content of knowledge articles and web files**: Attachment content of knowledge articles and web files are now searchable to increase the likelihood of relevant search results. More information: [Search within file attachment content](search-file-attachment.md)
- **Accessibility**: The out-of-the-box portals (Community portal, Partner portal, Customer portal, Employee self-service portal) are now accessible. However, customizer should ensure that the portal remains accessible after any customization or changes.


## Portal capabilities version 8.4 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 8.4 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps brings in a bunch of bug fixes, as well as performance improvements, along with the following features:

- **Access portal error logs**: As a portal developer, you can now access detailed error logs for any issues on your portal. This helps you to debug the issues while developing the portal. Once your portal is live, you can configure the portal to send all application errors to an Azure Blob storage account owned by you. This will help you to debug the issues reported by your customers. More information: [Access portal error logs](view-portal-error-log.md)
- **Renew portal authentication key**: A portal connects to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization using Azure active directory application. To do this, it requires an authentication key connected to Azure Active Directory application. This key is added when you provision your portal and it must be renewed every two years. This version of portal brings in the capability for administrators to be notified about key expiration and renew this key from Portal Admin Center. More information: [Renew portal authentication key](connect-with-dynamics.md)
- **Implement General Data Protection Regulation in portals**: As a portal administrator, you can now configure your portal to meet the GDPR standards. You can also provide certain terms and conditions that must be agreed by the portal users to use a portal. You can also setup checks such as, if a portal is accessed by a minor user, the user must have parental consent to access the portal. Implementing GDPR allows obtaining consent from portal users regarding use of their personal data, identifying minor users, and obtaining parental consent for minor users. More information: [Implement GDPR in portals](implement-gdpr.md)

## Portal capabilities version 8.3 for Dynamics 365 for Customer Engagement apps

Portal capabilities version 8.3 for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps has many new updates and features:

- **Ability to include attachments with knowledge articles**: You can display note attachments along with knowledge articles. To enable this feature, you create the site setting KnowledgeManagement/DisplayNotes and set the value to **true**. Portal users can also search for these attachments. More information: [Display attachments with knowledge articles](display-file-attachments-knowledge-article.md)

  > [!Note]
  > Search for attachments can only be performed on the note's description and file attachment name. The content of the attached file is not searchable.
  
- **Administrative wizard to add an entity to the portal**: This feature introduces a new administrative wizard to easily expose data on the portal. The entity created through the wizard takes the data from your organization and makes a subset of it available to your portal customers, based on the security and permission model you choose. More information: [Create and expose portal content easily](create-expose-portal-content.md)

- **Import metadata translation**: Use this feature to import the metadata translation of newly activated languages after you install a portal. More information: [Import metadata translation](manage-portal.md#import-metadata-translation)
- **Source code availability for portals**: A one-time release of portal capabilities code is released to the Microsoft Download Center under MIT license for developers to download. This feature enables portals to be deployed to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] on-premises or online environments, and allows developers to customize the code to suit their specific business needs.

  > [!Note]
  > Source code is offered as a working sample and on an as-needed basis. No direct support will be provided for any modifications to the code.
- **Single sign-on (SSO) configuration improvements and support for Azure Active Directory B2C (Azure AD B2C)**: For portals that require a consumer-based sign-in, this feature now supports the ability to:
  - Configure your portal authentication to use SSO. 
  - Support Azure AD B2C for customer authentication.
  - Manage your portal security in Azure.

  More information: [Azure AD B2C provider settings for portals](azure-ad-b2c.md)
- **Support time zone&ndash;independent date formats in portals forms**: This feature adds support for **Date Only** and **Timezone Independent** behaviors for date/time fields. More information: [Behavior and format of the date and time field](behavior-format-date-time-field.md)
- **Allowing non-global administrators to provision a portal**: You can now provision a portal if you are assigned to the System Administrator role of the CRM organization selected for the portal. You can now also manage an existing portal, if you have any of the following roles:
  - [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Service Administrator
  - System Administrator of the CRM organization selected for the portal
- **Store the custom domain name for a portal**: This feature stores the primary domain name of a portal on the website record. If the domain name is changed in the future, the latest primary domain name will be stored. More information: [View primary domain name](view-primary-domain.md)
- **Tracking cookie for portals**: A persistent cookie, Dynamics365PortalAnalytics, will be set whenever a user  goes to a portal. This cookie has an expiration of 90 days. This cookie does not store any of the user's personal data and is used by Microsoft to collect analytics about portal service. Please read the Microsoft online services privacy statement [here](https://go.microsoft.com/fwlink/p/?linkid=856855).
- **Performance improvement of header and footer on a portal**: Two new site settings, Header/OutputCache/Enabled and Footer/OutputCache/Enabled, are added to enable header/footer output caching when these settings are set to true. For new users, these site settings are set to true by default, thereby enabling header and footer output caching. For existing users who upgrade to a newer version of portal capabilities, output caching is disabled by default. It means that the Header and Footer web templates are parsed and rendered on every page load. To enable output caching, they must update the appropriate web templates and create the required site settings. More information: [Enable header and footer output caching](enable-header-footer-output-caching.md)

## December 2016 updates
The December 2016 update has brought many new features to the portal capabilities of [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] apps. These updates allow for better interactions among companies, partners, and customers, and make the experience of navigating the portal faster and easier. Some of the major updates include:

- **Multiple language support:** Support customers from multiple regions by using a single portal. More information: [Enable multiple-language support](enable-multiple-language-support.md)
- **East Asian language support:** Multiple-byte languages such as Japanese, Chinese, and Korean are now supported.
- **Faceted search:** New filters improve how quickly customers can find the content they are looking for while granting more control over visibility of content. More information: [Faceted search](improve-portal-search-faceted-search.md)
- **Product filtering:** Portal users can trim access to knowledge articles related to their product ownership to avoid information overload.
- **Content access levels:** A new level of ownership associated with a portal contact, account, or web role can be used to control access to knowledge articles, to help target the right article at the right audience and prevent irrelevant articles from surfacing. More information: [Content access levels](manage-knowledge-articles-content-levels.md)
- **Knowledge article reporting enhancement:** The portal tracks where a knowledge article was used in the portal.
- **Project Service Automation integration:** Provide access and visibility for active and closed projects across all stages of a project lifecycle to partners and customers. Team members, reviewers, and customers can view project status, quotes, order forums, and bookable resources on the portal with this solution. More information: [Integrate Project Service Automation](integrate-project-service-automation.md)
- **Field Service integration:** Expose information about active agreements, assets, work orders, invoices, and support cases to partners and customers on the portal with this solution. More information: [Integrate Field Service](integrate-field-service.md)
- **Partner onboarding:** Recruit new partners for better customer sales and service experiences. Potential partners can apply for partner status through the portal.

### Privacy notice

[!INCLUDE[cc-privacy-crm-portals-data-exposed](../includes/cc-privacy-crm-portals-data-exposed.md)]

For more information about additional [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] service offerings, see the [[!INCLUDE[cc_privacy_note_azure_trust_center](../includes/cc_privacy_note_azure_trust_center.md)]](https://azure.microsoft.com/support/trust-center/).  
