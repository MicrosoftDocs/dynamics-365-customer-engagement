---
title: Deprecations in Dynamics 365 Customer Service | MicrosoftDocs
description: Visit this page to see what's recently deprecated in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 02/02/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Deprecations in Customer Service

The features that have been deprecated in Customer Service are listed in this article.

Administrators and IT professionals can use this information to prepare for future releases.

> [!Important]
>
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and is fully supported until it is officially removed. This deprecation notification might span a few years. After removal, the feature or capability will no longer work. We are notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.

## Internet Explorer 11 support for Dynamics 365 and Microsoft Power Platform is deprecated <a name="internetexplorer11"></a>

Effective December 2020, Microsoft Internet Explorer 11 support for Microsoft Dynamics 365 and Microsoft Power Platform is deprecated, and Internet Explorer 11 won’t be supported after August, 2021.

This will impact customers who use Dynamics 365 and Microsoft Power Platform products that are designed to be used through an Internet Explorer 11 interface. After August 2021, Internet Explorer 11 won't be supported for such Dynamics 365 and Microsoft Power Platform products. We recommend that customers transition to Microsoft Edge.

For the complete list of products impacted by this change and transitioning from Internet Explorer 11 to a supported browser, see FAQ: [Internet Explorer 11 deprecation for Dynamics 365 and Microsoft Power Platform Products](https://aka.ms/IEsupportDeprecationBAG). If you have additional questions, contact your Microsoft Customer Service representative or Microsoft Partner.

## Automatic record creation rules in web client are deprecated

Effective from October 01, 2020, the automatic record creation and update rules are deprecated in the web client. You are encouraged to migrate your automatic record creation rules that were created in the web client to the new Unified Interface experience. For information on how to migrate the rules, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md). Microsoft will continue to provide support and critical security updates for these features in the web client till the end of life that is applicable from October 01, 2021.

> [!NOTE]
> The deprecation and end of life is not applicable to the feature in Dynamics 365 Customer Engagement (on-premises).

## SLA items in web client are deprecated

Effective from October 01, 2020, the service-level agreements (SLAs) are deprecated in the web client. You are encouraged to migrate your SLA items that were created in the web client to the new Unified Interface experience. For information on how to migrate the items, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md). Microsoft will continue to provide support and critical security updates for these features in the web client till the end of life that is applicable from October 01, 2021.

> [!NOTE]
> The deprecation and end of life is not applicable to the feature in Dynamics 365 Customer Engagement (on-premises).

## Service scheduling in Dynamics 365 Customer Service is deprecated

The existing service scheduling functionality is deprecated, and will no longer be available on December 1, 2020. The new scheduling experience, built on Universal Resource Scheduling, is now available in Unified Interface.

Existing service scheduling users will be provided advance notice for a time bound migration to the new scheduling capabilities.

There are two approaches to migrate to the scheduling experience:

Follow the guidance in the [Service Scheduling Guide](basics-service-service-scheduling.md) to set up the new scheduling experience for an existing Dynamics 365 Customer Service organization.

If your organization requires features that rely on legacy APIs, the product team is offering an incremental migration option and will update your organization to the Unified Interface experience while continuing to allow the use of the legacy APIs. This approach is available in 2020 release wave 2 with Early Access in August, 2020.

## Contracts, Contract Line Items, and Contract Templates entities are deprecated

The Contracts, Contract Line Items, and Contract Templates entities are deprecated in the web client. This functionality has been replaced by [entitlements](create-entitlement-define-support-terms-customer.md) in Unified Interface. The [web client](https://docs.microsoft.com/power-platform/important-changes-coming#legacy-web-client-is-deprecated) will not be available after Tuesday, December 01, 2020, and you must migrate to Unified Interface by this date. We recommend that you migrate your contracts to entitlements at the earliest to avoid any loss in functionality. For information on the migration strategy, see [Strategy for migrating from contracts to entitlements](contract-to-entitlement-migration.md).

## Standard SLAs in Dynamics 365 Customer Service are deprecated

Standard service level agreements (SLA Type field is set to Standard) are deprecated and will be removed in a future major release. Standard SLAs are replaced by enhanced SLAs. More information: [Enhanced service level agreements](https://technet.microsoft.com/library/dn887187.aspx).

## Customer Service Insights standalone app is deprecated

The Customer Service Insights standalone app is deprecated. If you are a customer who uses this app, your current working environment(s) will be terminated and inaccessible by December 8, 2021. You won't be able to use the standalone service after this date, but the embedded Customer Service Insights features in the core applications will continue to be available and supported. For users with Customer Service Enterprise licenses, you won't be able to create new workspaces, but you'll retain access to existing ones. We recommend that you migrate to the [embedded experience](introduction-customer-service-analytics.md) within the core Dynamics 365 Customer Service applications. In the interim, the [standalone app guide](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/quickstart) contains documentation for the standalone web application.


### See also

[Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)  
[Define service-level agreements](define-service-level-agreements.md)  
[Important changes (deprecations) coming in Power Apps, Power Automate](https://go.microsoft.com/fwlink/p/?linkid=2126541)  
