---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to uninstall Dynamics 365 Field Service 
ms.date: 11/22/2022
ms.topic: article
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
| 3     | msdyn_FieldServiceMobileNative                   |                                                           |
| 4     | msdyn_FieldServiceCopilot               |                                                           |
| 5     | msdyn_FieldServiceCollabSolution      |                                                           |
| 6    | msdyn_OneFSSCM                        | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 7     | msdyn_InsightsAnalyticsFSConfiguration|                                                           |
| 8     | msdyn_DataInsightsAndAnalyticsForFS  |                                                           |
| 9     | msdyn_DataInsightsAndAnalytics       |     Required for Sales or Customer Service.                                                       |
| 10     | msdyn_FieldServiceAdminExp           |                                                           |
| 11     | msdyn_FieldServiceGuides             |                                                           |
| 12    | msdyn_GeofenceAlerts                  |                                                           |
| 13   | msdyn_FSMNotifications_Patch_xx       |    Patch name or number may vary                                                       |
| 14    | msdyn_FSMNotifications               |                                                           |
| 15    | msdyn_FieldServiceGeofencing         |                                                           |
| 16    | msdyn_Geofencing_Patch_xx            |     Patch name or number may vary                                                          |
| 17    | msdyn_Geofencing                     |                                                           |
| 18    | msdyn_CFS_Patch_xx                    |   Patch name or number may vary                                                            |
| 19    | msdyn_FieldServiceGeolocation        |                                                           |
| 20   | msdyn_Geolocation                    |                                                           |
| 21   | msdyn_IoTConfigurationData                   |                                                           |
| 22    | msdyn_IoTHealth                   |                                                           |
| 23   | IoTProviders                    |                                                           |
| 24   | msdyn_FieldServiceDisablePricingComponents                    |                                                           |
| 25    | IoTConnector                    |                                                           |
| 26    | ConnectedFieldService                |                                                           |
| 27    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 28    | msdynce_FieldServiceHealth           |                                                           |
| 29    | msdyn_FieldServiceExperienceComponents         |                                                           |
| 30    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 31    | FieldService                         |                                                           |
| 32   | msdyn_FieldServiceExperienceControls                        |                                                           |
| 33    | msdyn_Inspections                    |                                                           |
| 34    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 35    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 36    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 37    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 38    | msdyn_TESA                           | Required for Project Service Automation       |
| 39    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 40    | msdyn_FieldServiceSurveys            |                                                           |
| 41    | MicrosoftDynamicsScheduling_Anchor   | Required for Project Service Automation                   |
| 42    | MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Service Automation           |
| 43    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 44    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 45   | msdynce_3DViewer                     |                                                           |

[!INCLUDE[footer-include](../includes/footer-banner.md)]
