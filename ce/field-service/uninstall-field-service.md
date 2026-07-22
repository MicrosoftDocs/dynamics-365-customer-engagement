---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to uninstall Dynamics 365 Field Service 
ms.date: 03/30/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---
# Uninstall Dynamics 365 Field Service

Uninstalling Dynamics 365 Field Service removes all the customizations and the data such as work orders, resources, and accounts. This action can't be undone and we can't recover the data after deletion. Only administrators can uninstall Field Service.

1. Go to the Power Platform Environment Settings app.

1. Under **Customizations** select **Solutions**.

1. Remove solutions in the order listed in the following table. Depending on the version of Field Service that is installed for your organization, some solutions might not show in the list and you can skip them.

> [!CAUTION]
> Some solutions are shared with other Dynamics 365 apps and have dependencies to solutions these apps introduce. Don't remove them unless you intend to uninstall the other apps too.

| Order | Solution name                         | Note                                                      |
|-------|---------------------------------------|-----------------------------------------------------------|
| 1     | FieldServiceUpgradeScripts            |                                                           |
| 2     | FieldService_Anchor                   | Required for Project Operations      |
| 3     | msdyn_SchedulingExchangeIntegration   |                                                           |
| 4     | msdyn_FieldServiceMobileNative        |                                                           |
| 5     | msdyn_FieldServiceCopilot             |                                                           |
| 6     | msdyn_FieldServiceDefaultComponents   |                                                           |
| 7     | msdyn_FieldServiceCollabSolution      |                                                           |
| 8     | msdyn_OneFSSCM                        | Required for Project Operations  |
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
| 34    | msdyn_FieldServiceExperienceControls |                                                           |
| 35    | msdyn_Inspections                    |                                                           |
| 36    | FieldServiceCommon                   | Required for Project Operations                           |
| 37    | msdyn_AssetCommon                    | Required for Project Operations                     |
| 38    | msdyn_TESA_Anchor                    | Required for Project Operations       |
| 39    | msdyn_TESA_Patch                     | Required for Project Operations       |
| 40    | msdyn_TESA                           | Required for Project Operations       |
| 41    | ResourceSchedulingControls           | Required for Project Operationsn                   |
| 42    | msdyn_FieldServiceSurveys            |                                                           |
| 43    | MicrosoftDynamicsScheduling_Anchor   | Required for Project Operations                   |
| 44    | MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Operations           |
| 45    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Operations                   |
| 46    | MicrosoftDynamicsScheduling          | Required for Project Operations                   |
| 47    | msdynce_3DViewer                     |                                                           |

If you receive a dependency error when removing a solution:

1. Verify you are removing solutions in the **exact order** shown in the table.

1. Check for custom components (workflows, plugins, or entities) that reference the solution. Remove or update those custom components first.

1. If other Dynamics 365 apps such as Project Operations or Sales are installed, don't remove them unless you intend to uninstall the other apps too.

1. Use the [**Solution Layers** view in Power Apps](/power-apps/maker/data-platform/solution-layers#view-the-solution-layers-for-a-component) to identify which components are creating the dependency. Remove the dependencies.

1. For persistent dependency errors, [export the solution as unmanaged](/power-apps/maker/data-platform/export-solutions#export-from-power-apps), remove the blocking components, [reimport](/power-apps/maker/data-platform/import-update-export-solutions), then retry the uninstall.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
