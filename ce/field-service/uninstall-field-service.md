---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to uninstall Dynamics 365 Field Service 
ms.date: 03/19/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---
# Uninstall Dynamics 365 Field Service

Uninstalling Dynamics 365 Field Service will remove all the customizations and the data such as work orders, resources, and accounts. This action can't be undone and we can't recover the data after deletion.

To uninstall Field Service, administrators can go to **Advanced Settings** > **Settings** > **Customizations** > **Solutions** to remove solutions in the order listed in the following table. Depending on the version of Field Service that is installed for your organization, some solutions may not show in the list and you can skip them.

:::image type="content" source="./media/admin-settings-solutions.png" alt-text="Screenshot of Dynamics 365 admin settings, with attention to Solutions.":::

> [!CAUTION]
> Some solutions are shared with other Dynamics 365 apps and have dependencies to solutions these apps introduce. Don't remove them unless you intend to uninstall the other apps too.

| Order | Solution name                         | Note                                                      |
|-------|---------------------------------------|-----------------------------------------------------------|
| 1     | FieldServiceUpgradeScripts            |                                                           |
| 2     | FieldService_Anchor                   |                                                           |
| 3     | msdyn_FieldServiceMobileNative        |                                                           |
| 4     | msdyn_FieldServiceCopilot             |                                                           |
| 5     | msdyn_FieldServiceDefaultComponents   |                                                           |
| 6     | msdyn_FieldServiceCollabSolution      |                                                           |
| 7     | msdyn_OneFSSCM                        | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 8     | msdyn_InsightsAnalyticsFSConfiguration|                                                           |
| 9     | msdyn_DataInsightsAndAnalyticsForFS   |                                                           |
| 10    | msdyn_DataInsightsAndAnalytics        | Required for Sales or Customer Service if analytics feature is enabled. |
| 11    | msdyn_FieldServiceAdminExp            |                                                           |
| 12    | msdyn_FieldServiceGuides              |                                                           |
| 13    | msdyn_GeofenceAlerts                  |                                                           |
| 14    | msdyn_FSMNotifications_Patch_xx       | Patch name or number may vary |
| 15    | msdyn_FSMNotifications                |                                                           |
| 16    | msdyn_FieldServiceGeofencing          |                                                           |
| 17    | msdyn_Geofencing_Patch_xx             | Patch name or number may vary |
| 18    | msdyn_Geofencing                      |                                                           |
| 19    | msdyn_CFS_Patch_xx                    | Patch name or number may vary |
| 20    | msdyn_FieldServiceGeolocation         |                                                           |
| 21    | msdyn_Geolocation                     |                                                           |
| 22    | msdyn_IoTConfigurationData            |                                                           |
| 23    | msdyn_IoTHealth                       |                                                           |
| 24    | IoTProviders                          |                                                           |
| 25    | msdyn_FieldServiceDisablePricingComponents |                                                   |
| 26    | IoTConnector                    |                                                           |
| 27    | ConnectedFieldService                |                                                           |
| 28    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 29    | msdynce_FieldServiceHealth           |                                                           |
| 30    | msdyn_FieldServiceExperienceComponents         |                                                           |
| 31    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 32    | FieldService                         |                                                           |
| 33   | msdyn_FieldServiceExperienceControls                        |                                                           |
| 34    | msdyn_Inspections                    |                                                           |
| 35    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 36    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 37    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 38    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 39    | msdyn_TESA                           | Required for Project Service Automation       |
| 40    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 41    | msdyn_FieldServiceSurveys            |                                                           |
| 42    | MicrosoftDynamicsScheduling_Anchor   | Required for Project Service Automation                   |
| 43    | MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Service Automation           |
| 44    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 45    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 46   | msdynce_3DViewer                     |                                                           |

[!INCLUDE[footer-include](../includes/footer-banner.md)]
