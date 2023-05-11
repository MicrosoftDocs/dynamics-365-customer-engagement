---
title: Deprecations in Dynamics 365 Customer Service
description: Use this topic to get information about features that are deprecated in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms-service: dynamics-365
ms.topic: conceptual
ms.date: 05/11/2023
ms.custom: bap-template
---

# Deprecations in Customer Service

The features that have been deprecated in Customer Service are listed in this article.

Administrators and IT professionals can use this information to prepare for future releases.

> [!IMPORTANT]
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and will be fully supported until it is officially removed. This deprecation notification might span a few years. After removal, the feature or capability will no longer work. We are notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.

## Some admin apps are deprecated

With the release of the Customer Service admin center app that consolidates admin experiences across the Customer Service suite, we announce that the following admin experiences are deprecated and no longer supported after April 2023.

- Service Management area in the Customer Service Hub app
- Omnichannel admin center
- **App profile manager:** Is removed in April 2023.

Also, as of October 2022, the Omnichannel admin center and the service management area in Customer Service Hub are hidden by default in newly created organizations and environments. You can bring them back, but we recommend that you start using the Customer Service admin center app to perform tasks like manage cases, and configure unified routing, channels, and agent experience profiles. More information: [Get started with Customer Service admin center](cs-admin-center.md)

## Omnichannel Administration app is deprecated and will be removed in July 2023

Support for the Omnichannel Administration app ended on April 30, 2022. The app will be removed in July 2023. We recommend that you use the Customer Service admin center app to configure the latest features, such as unified routing and voice channel. More information: [Get started with Customer Service admin center](cs-admin-center.md)

## Omnichannel for Customer Service agent-facing app to be deprecated

The Omnichannel for Customer Service agent-facing app will be deprecated as of April 1, 2023. After the app is deprecated, support will be available until June 2024. We recommend that you migrate your omnichannel configuration to Customer Service workspace. More information: [Migrate from Omnichannel for Customer Service to Customer Service workspace](migrate-oc-to-csw.md)

## setContextProvider method for authenticated chat is deprecated

The setContextProvider method for authenticated chat has been deprecated and isn't supported as of October 1, 2021. We recommend that you use the JWT token for authenticated chat. More information: [Send authentication tokens](send-auth-token-starting-chat.md)

## Support for some knowledge management entities is deprecated <a name="deprecatedkmentities"></a>

The KbArticle, KbArticleComment, and KbArticleTemplate knowledge management entities that were deprecated earlier aren't supported as of October 1, 2021. We recommend that you use the newer KnowledgeArticle entity (introduced in CRM Online 2016 Update and Dynamics 365) for knowledge management in Dynamics 365. More information: [Work with knowledge articles](work-knowledge-articles.md)

## Internet Explorer 11 support for Dynamics 365 and Microsoft Power Platform is deprecated
 
Effective October 31, 2022, Dynamics 365 Customer Service and Power Platform are blocked in Internet Explorer. As of early October 2022, users are redirected to Microsoft Edge if it's installed on their device. Otherwise, they'll receive a non-dismissible message informing them why they're blocked and to use Customer Service on [Microsoft Edge](https://www.microsoft.com/edge). More information: [Support end for Internet Explorer](/power-platform/admin/support-end-internet-explorer) <br>

For any questions, contact your Microsoft Customer Service representative or Microsoft Partner.

## Automatic record creation rules in web client are deprecated

Effective October 01, 2020, the automatic record creation and update rules are deprecated in the web client. We recommend that you migrate your automatic record creation rules that were created in the web client to the new Unified Interface experience. For information on how to migrate the rules, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md). You can also refer to the migration playbook, which includes all the information you need to work on the migration. More information: [Dynamics 365 SLA and ARC Migration Playbook](https://www.d365implementationguide.com/books/aiij/).

Microsoft will continue to provide support and critical security updates for these features in the web client until April 01, 2023.

> [!NOTE]
> The deprecation isn't applicable to the features in Dynamics 365 Customer Engagement (on-premises).

## SLAs in web client are deprecated

Effective October 1, 2020, the service-level agreements (SLAs) are deprecated in the web client. We recommend that you migrate your SLAs that were created in the web client to the new Unified Interface experience. For information on how to migrate the items, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md). You can also refer to the migration playbook, which includes all the information you need to work on the migration. More information: [Dynamics 365 SLA and ARC Migration Playbook](https://www.d365implementationguide.com/books/aiij/).

Microsoft will continue to provide support and critical security updates for these features in the web client until April 1, 2023.

> [!NOTE]
> The deprecation isn't applicable to the features in Dynamics 365 Customer Engagement (on-premises).

## Service scheduling in Dynamics 365 Customer Service is deprecated

The existing service scheduling functionality is deprecated, and is longer available as of December 1, 2020. The new scheduling experience, built on Universal Resource Scheduling, is now available in Unified Interface.

Existing service scheduling users will be provided advance notice for a time bound migration to the new scheduling capabilities.

There are two approaches to migrate to the scheduling experience:

Follow the guidance in the [Service Scheduling Guide](basics-service-service-scheduling.md) to set up the new scheduling experience for an existing Dynamics 365 Customer Service organization.

If your organization requires features that rely on legacy APIs, the product team is offering an incremental migration option and will update your organization to the Unified Interface experience and continue to allow the use of the legacy APIs. This approach is available as of 2020 release wave 2 with Early Access in August 2020.

## Contracts, Contract Line Items, and Contract Templates entities are deprecated

The Contracts, Contract Line Items, and Contract Templates entities are deprecated and aren't supported as of April 1, 2022. They'll be removed in a future major release of Dynamics 365. This functionality has been replaced by [entitlements](create-entitlement-define-support-terms-customer.md) in Unified Interface. The [web client](/power-platform/important-changes-coming#legacy-web-client-is-deprecated) will not be available after Tuesday, December 1, 2020, and you must migrate to Unified Interface by this date. We recommend that you migrate your contracts to entitlements at the earliest to avoid any loss in functionality. For information on the migration strategy, see [Strategy for migrating from contracts to entitlements](contract-to-entitlement-migration.md).

## Standard SLAs in Dynamics 365 Customer Service are deprecated

Standard service level agreements (SLA Type field is set to Standard) are deprecated and will be removed in a future major release. Standard SLAs are replaced by enhanced SLAs. More information: [Enhanced service level agreements](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn887187(v=crm.8))

## Customer Service Insights standalone app is deprecated

The Customer Service Insights standalone app is deprecated. We recommend that you migrate to the [embedded experience](introduction-customer-service-analytics.md) within the core Dynamics 365 Customer Service applications.

## Customer Service workspace legacy layout is deprecated

The Customer Service workspace legacy layout is deprecated as of April 2023, and won't be supported after October 2023. For more information, see [Deprecated Customer Service workspace layout](csw-overview.md#deprecated-customer-service-workspace-layout)

## Intraday insights for Omnichannel for customer service to be deprecated

The [Omnichannel intraday insights reports](intro-intraday-insights-dashboard.md) will be deprecated as of May 1, 2023. After intraday insights is deprecated, support will be available until October 31, 2023. We won't release any new functionalities for intraday insights.

Effective April 30, 2024, Omnichannel intraday insights reports will no longer be available for existing organizations. Reports won’t be available for new organizations or tenants onboarded after May 01, 2023, and for organizations that haven’t used the reports in the last 30 days. To enable these reports, raise a ticket with [Microsoft Support](/admin.powerplatform.microsoft.com/support).

### See also

[Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)  
[Define service-level agreements](define-service-level-agreements.md)  
[Important changes (deprecations) coming in Power Apps, Power Automate](/power-platform/important-changes-coming)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
