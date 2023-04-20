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
| 3     | msdyn_FieldServiceCollabSolution      |                                                           |
| 4     | msdyn_OneFSSCM                        | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 5     | msdyn_InsightsAnalyticsFSConfiguration|                                                           |
| 6     | msdyn_DataInsightsAndAnalyticsForFS  |                                                           |
| 7     | msdyn_DataInsightsAndAnalytics       |                                                           |
| 8     | msdyn_FieldServiceAdminExp           |                                                           |
| 9     | msdyn_FieldServiceGuides             |                                                           |
| 10    | msdyn_GeofenceAlerts                  |                                                           |
| 11    | msdyn_FSMNotifications_Patch_xx       |    Patch name or number may vary                                                       |
| 12    | msdyn_FSMNotifications               |                                                           |
| 13    | msdyn_FieldServiceGeofencing         |                                                           |
| 14    | msdyn_Geofencing_Patch_xx            |     Patch name or number may vary                                                          |
| 15    | msdyn_Geofencing                     |                                                           |
| 16    | msdyn_CFS_Patch_xx                    |   Patch name or number may vary                                                            |
| 17    | msdyn_FieldServiceGeolocation        |                                                           |
| 18    | msdyn_Geolocation                    |                                                           |
| 19    | msdyn_IoTConfigurationData                   |                                                           |
| 20    | msdyn_IoTHealth                   |                                                           |
| 21   | IoTProviders                    |                                                           |
| 22   | msdyn_FieldServiceDisablePricingComponents                    |                                                           |
| 23    | IoTConnector                    |                                                           |
| 24    | ConnectedFieldService                |                                                           |
| 25    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 26    | msdynce_FieldServiceHealth           |                                                           |
| 27    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 28    | FieldService                         |                                                           |
| 29    | msdyn_Inspections                    |                                                           |
| 30    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 31    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 32    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 33    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 34    | msdyn_TESA                           | Required for Project Service Automation       |
| 35    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 36    | msdyn_FieldServiceSurveys            |                                                           |
| 37    | MicrosoftDynamicsScheduling_Anchor   | Required for Project Service Automation                   |
| 38    |	MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Service Automation           |
| 39    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 40    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 41    | msdynce_3DViewer                     |                                                           |

[!INCLUDE[footer-include](../includes/footer-banner.md)]
