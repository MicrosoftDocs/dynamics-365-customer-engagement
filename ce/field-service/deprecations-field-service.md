---
title: Feature deprecations
description: Learn about features that are being deprecated for Dynamics 365 Field Service.
ms.date: 10/28/2025
ms.topic: article
ms.custom: bap-template
ms.author: vhorvath
author: vhorvathms
---

# Feature deprecations

Features that have been deprecated in Dynamics 365 Field Service are listed in this article.

> [!IMPORTANT]
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and is fully supported until it's officially removed. This deprecation notification spans at least six months. After removal, the feature or capability will no longer work. We're notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.

## Dynamics 365 Field Service integration with finance and operations applications -  October 31, 2025

The Dynamics 365 Field Service integration with finance and operations applications will no longer be available after October 30, 2026. Instead, look to a simpler, more integrated Field Service experience. Learn more in [Connect Field Service to finance and operations](/dynamics365/release-plan/2025wave2/service/dynamics365-field-service/connect-field-service-finance-operations) and [Link work orders to projects for unified financials](/dynamics365/release-plan/2025wave2/service/dynamics365-field-service/link-work-orders-projects-unified-financials).

Beginning with the Field Service 9.3 release, the **Install Finance and Operations** toggle will no longer be available in environments where the finance and operations integration isn't already installed or configured. Environments that already have the integration enabled will retain access and can continue until the feature deprecation.

## Dynamics 365 Field Service integrations with Microsoft Outlook, Teams, Viva Connections, and Planner - September 1, 2025

The following Dynamics 365 Field Service integrations are deprecated after October 30, 2025:

- Microsoft Outlook Add-in
- Microsoft Teams app
- Microsoft Viva Connections
- Microsoft Planner

These integrations aren't supported after October 30, 2025. Instead, look to a simpler, more integrated Field Service experience inside Microsoft 365. Learn more in [Field Service release plans](/dynamics365/release-plan/2025wave2/service/dynamics365-field-service/).

## Dynamics 365 Field Service reports - May 25, 2025

The following Dynamics 365 Field Service reports are deprecated after May 25, 2025 and aren't supported after August  2025.

 - Resource and Utilization in Field Service
 - Work order summary in Field Service
 - Admin Report in Resource Scheduling Optimization
 - Optimization Summary in Resource Scheduling Optimization
 - Calls Dashboard in Remote Assist

To make your transition easier, migrate to [Microsoft Fabric](/fabric/fundamentals/microsoft-fabric-overview). Microsoft Fabric lets you recreate and customize reports to fit your organization’s needs. You can tailor dashboards and keep getting insights from your data with more flexibility and power. This move gives you a more dynamic and ready-for-the-future reporting experience.

## Dynamics 365 Field Service Plugin for Microsoft Copilot (Teams app) - January 15, 2025

The Dynamics 365 Field Service Plugin for Microsoft Copilot is no longer available after January 15 for users of the Field Service app in Microsoft Teams. You can use [Copilot in Field Service through the side pane chat](copilot-side-pane.md), which doesn't require extra licenses, to chat about work order information.

## Dynamics 365 Field Service reports and features - September 3, 2024

The following Dynamics 365 Field Service reports and features are no longer available after November 2024.
- Predictive work duration reports (Preview)
- Incident type AI suggestions
- IoT alert suggestions

## Dynamics 365 Field Service (on-premises) - June 30, 2022

For more information about this deprecation, [see this blog post](https://cloudblogs.microsoft.com/dynamics365/it/2021/06/30/dynamics-365-field-service-on-premises-use-rights-to-retire-on-june-30-2022/).

## Field Service Mobile (Xamarin) and related solutions - June 30, 2022

For more information about this deprecation, [see this blog post](https://cloudblogs.microsoft.com/dynamics365/it/2020/05/01/next-generation-field-service-mobile-app-available/).

Solution components related to the Field Service Mobile (Xamarin) application are also deprecated:
- msdyn_GeofenceAlerts
- msdyn_FSMNotifications
- Woodford | Resco MobileCRM Woodford

These solutions can be removed from an organization that is no longer using the Field Service Mobile - Xamarin application. While removing solutions, you might encounter dependencies. The system informs you of these dependencies. Either delete the component or modify it to remove references to the solution you're trying to remove. For more information, see [Removing dependencies](/power-platform/alm/removing-dependencies).

With the deprecation of the Field Service Mobile (Xamarin), drip scheduling is currently not available in the Field Service mobile app. Drip scheduling controlled how many bookings appear on the Field Service mobile app at one time.

## Deprecations in the scheduling solution

[Learn more about deprecations in Universal Resource Scheduling](../common-scheduler/deprecations.md).

## Next steps

- [Dynamics 365 Field Service version history](version-history.md)
- [Submit a feature idea](https://experience.dynamics.com/ideas/categories/?forum=bee3d862-df65-e811-a95d-000d3a1be7ad&forumName=Dynamics%20365%20for%20Field%20Service)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
