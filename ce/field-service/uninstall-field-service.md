---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to uninstall Dynamics 365 Field Service 
ms.date: 05/23/2022
ms.reviewer: krbjoran

ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
# Uninstall Dynamics 365 Field Service

To uninstall Field Service, administrators can go to **Settings** > **Solutions** to remove solutions in the order listed in the following table.


> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 admin settings, with attention to Solutions.](./media/admin-settings-solutions.png)

>[!Note]
> Some solutions are shared with other apps like Project Service Automation, and should not be removed unless you intend to uninstall those apps too. Skip those solutions.

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
| 10    | msdyn_GeofenceAlert                  |                                                           |
| 11    | msdyn_FSMNotifications_Patch_1       |                                                           |
| 12    | msdyn_FSMNotifications               |                                                           |
| 13    | msdyn_FieldServiceGeofencing         |                                                           |
| 14    | msdyn_Geofencing_Patch_1             |                                                           |
| 15    | msdyn_Geofencing                     |                                                           |
| 16    | msdyn_CFS_Patch_1                    |                                                           |
| 17    | msdyn_FieldServiceGeolocation        |                                                           |
| 18    | msdyn_Geolocation                    |                                                           |
| 19    | ConnectedFieldService                |                                                           |
| 20    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 21    | msdynce_FieldServiceHealth           |                                                           |
| 22    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 23    | FieldService                         |                                                           |
| 24    | msdyn_Inspections                    |                                                           |
| 25    | msdyn_FieldServiceSurveys            |                                                           |
| 26    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 27    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 28    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 29    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 30    | msdyn_TESA                           | Required for Project Service Automation       |
| 31    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 32    | msdyn_FieldServiceSurveys            |                                                           |
| 33    | MicrosoftDynamicsScheduling_Anchor   | Required for Project Service Automation                   |
| 34    |	MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Service Automation           |
| 35    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 36    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 37    | msdynce_3DViewer                     |                                                           |


[!INCLUDE[footer-include](../includes/footer-banner.md)]
