---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to uninstall Dynamics 365 Field Service 
ms.date: 05/12/2025
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---
# Uninstall Dynamics 365 Field Service

Uninstalling Dynamics 365 Field Service removes all the customizations and the data such as work orders, resources, and accounts. This action can't be undone and we can't recover the data after deletion.

To uninstall Field Service, administrators can go to the Power Platform Environment Settings app. Under **Customizations** select **Solutions** and remove solutions in the order listed in the following table. Depending on the version of Field Service that is installed for your organization, some solutions might not show in the list and you can skip them.

> [!CAUTION]
> Some solutions are shared with other Dynamics 365 apps and have dependencies to solutions these apps introduce. Don't remove them unless you intend to uninstall the other apps too.

| Order | Solution name                         | Note                                                      |
|-------|---------------------------------------|-----------------------------------------------------------|
| 1     | FieldServiceUpgradeScripts            |                                                           |
| 2     | FieldService_Anchor                   |                                                           |
| 3     | msdyn_SchedulingExchangeIntegration   |                                                           |
| 4     | msdyn_FieldServiceMobileNative        |                                                           |
| 5     | msdyn_FieldServiceCopilot             |                                                           |
| 6     | msdyn_FieldServiceDefaultComponents   |                                                           |
| 7     | msdyn_FieldServiceCollabSolution      |                                                           |
| 8     | msdyn_OneFSSCM                        | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 9     | msdyn_InsightsAnalyticsFSConfiguration|                                                           |
| 10    | msdyn_DataInsightsAndAnalyticsForFS   |                                                           |
| 11    | msdyn_DataInsightsAndAnalytics        | Required for Sales or Customer Service if analytics feature is enabled. |
| 12    | msdyn_FieldServiceAdminExp            |                                                           |
| 13    | msdyn_FieldServiceGuides              |                                                           |
| 14    | msdyn_GeofenceAlerts                  |                                                           |
| 15    | msdyn_FSMNotifications_Patch_xx       | Patch name or number may vary |
| 16    | msdyn_FSMNotifications                |                                                           |
| 17    | msdyn_FieldServiceGeofencing          |                                                           |
| 18    | msdyn_Geofencing_Patch_xx             | Patch name or number may vary |
| 19    | msdyn_Geofencing                      |                                                           |
| 20    | msdyn_CFS_Patch_xx                    | Patch name or number may vary |
| 21    | msdyn_FieldServiceGeolocation         |                                                           |
| 22    | msdyn_Geolocation                     |                                                           |
| 23    | msdyn_IoTConfigurationData            |                                                           |
| 24    | msdyn_IoTHealth                       |                                                           |
| 25    | IoTProviders                          |                                                           |
| 26    | msdyn_FieldServiceDisablePricingComponents |                                                   |
| 27    | IoTConnector                    |                                                           |
| 28    | ConnectedFieldService                |                                                           |
| 29    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 30    | msdynce_FieldServiceHealth           |                                                           |
| 31    | msdyn_FieldServiceExperienceComponents         |                                                           |
| 32    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 33    | FieldService                         |                                                           |
| 34   | msdyn_FieldServiceExperienceControls                        |                                                           |
| 35    | msdyn_Inspections                    |                                                           |
| 36    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 37    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 38    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 39    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 40    | msdyn_TESA                           | Required for Project Service Automation       |
| 41    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 42    | msdyn_FieldServiceSurveys            |                                                           |
| 43    | MicrosoftDynamicsScheduling_Anchor   | Required for Project Service Automation                   |
| 44    | MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Service Automation           |
| 45    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 46    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 47   | msdynce_3DViewer                     |                                                           |

[!INCLUDE[footer-include](../includes/footer-banner.md)]
