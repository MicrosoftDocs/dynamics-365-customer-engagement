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

| Order | Solution name                        | Note                                                      |
|-------|--------------------------------------|-----------------------------------------------------------|
| 1     | FieldServiceUpgradeScripts           |                                                           |
| 2     | FieldService_Anchor                  |                                                           |
| 3     | msdyn_DataInsightsAndAnalyticsForFS  |                                                           |
| 4     | msdyn_DataInsightsAndAnalytics       |                                                           |
| 5     | msdyn_FieldServiceGuides             |                                                           |
| 6     | msdyn_GeofenceAlert                  |                                                           |
| 7     | msdyn_FSMNotifications_Patch_1       |                                                           |
| 8     | msdyn_FSMNotifications               |                                                           |
| 9     | msdyn_FieldServiceGeofencing         |                                                           |
| 10    | msdyn_Geofencing_Patch_1             |                                                           |
| 11    | msdyn_Geofencing                     |                                                           |
| 12    | msdyn_CFS_Patch_1                    |                                                           |
| 13    | ConnectedFieldService                |                                                           |
| 14    | msdynce_FieldServiceHealth_Patch     |                                                           |
| 15    | msdynce_FieldServiceHealth           |                                                           |
| 16    | msdyn_FieldService_patch_xx          | Patch name or number may vary                             |
| 17    | msdyn_FieldService                   |                                                           |
| 18    | FieldServiceCommon                   | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)  |
| 19    | msdyn_AssetCommon                    | Required for DualWrite (with Dynamics 365 Finance or Dynamics 365 Supply Chain Management)              |
| 20    | msdyn_TESA_Anchor                    | Required for Project Service Automation       |
| 21    | msdyn_TESA_Patch                     | Required for Project Service Automation       |
| 22    | msdyn_TESA                           | Required for Project Service Automation       |
| 23    | ResourceSchedulingControls           | Required for Project Service Automation                   |
| 24    | MicrosoftDynamicsScheduling_Patch_xx | Required for Project Service Automation                   |
| 25    | MicrosoftDynamicsScheduling          | Required for Project Service Automation                   |
| 26    | msdynce_3DViewer                     |                                                           |


[!INCLUDE[footer-include](../includes/footer-banner.md)]