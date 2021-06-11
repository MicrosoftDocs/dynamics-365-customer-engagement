---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to uninstall Dynamics 365 Field Service 
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/11/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
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
| 3     | msdyn_OneFSSCM                        | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 4     | msdyn_InsightsAnalyticsFSConfiguration|                                                           |
| 5     | msdyn_DataInsightsAndAnalyticsForFS  |                                                           |
| 6     | msdyn_DataInsightsAndAnalytics       |                                                           |
| 7     | msdyn_FieldServiceGuides             |                                                           |
| 8     | msdyn_GeofenceAlert                  |                                                           |
| 9     | msdyn_FSMNotifications_Patch_1       |                                                           |
| 10    | msdyn_FSMNotifications               |                                                           |
| 11    | msdyn_FieldServiceGeofencing         |                                                           |
| 12    | msdyn_Geofencing_Patch_1             |                                                           |
| 13    | msdyn_Geofencing                     |                                                           |
| 14    | msdyn_CFS_Patch_1                    |                                                           |
| 15    | msdyn_FieldServiceGeolocation        |                                                           |
| 16    | msdyn_Geolocation                    |                                                           |
| 17    | ConnectedFieldService                |                                                           |
| 18    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 19    | msdynce_FieldServiceHealth           |                                                           |
| 20    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 21    | FieldService                         |                                                           |
| 22    | msdyn_Inspections                    |                                                           |
| 23    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 24    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 25    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 26    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 27    | msdyn_TESA                           | Required for Project Service Automation       |
| 28    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 29    |	MicrosoftDynamicsScheduling3_CumulativePatch | Required for Project Service Automation           |
| 30    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 31    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 32    | msdynce_3DViewer                     |                                                           |


[!INCLUDE[footer-include](../includes/footer-banner.md)]
