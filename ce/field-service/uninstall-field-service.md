---
title: "Uninstall Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/05/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: FieldServiceDave
ms.assetid: e6acfdb3-1580-4052-8895-8efbf98dfae8
caps.latest.revision: 15
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Uninstall Dynamics 365 Field Service

To uninstall Field Service, administrators can go to the list of solutions and remove solutions in the order listed in the following table.

>[!Note]
> Some solutions are shared with other apps like Project Service Automation, so once the base Field Service solution is uninstalled, be sure to carefully review each following solution in this article's table.

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
| 18    | FieldServiceCommon                   | Also used by DualWrite and FinanceAndOperations solutions |
| 19    | msdyn_AssetCommon                    | Also used by FinanceAndOperations solutions               |
| 20    | msdyn_TESA_Anchor                    | TESA is also required by Project Service Automation       |
| 21    | msdyn_TESA_Patch                     | TESA is also required by Project Service Automation       |
| 22    | msdyn_TESA                           | TESA is also required by Project Service Automation       |
| 23    | ResourceSchedulingControls           | Also used by Project Service Automation                   |
| 24    | MicrosoftDynamicsScheduling_Patch_xx | Also used by Project Service Automation                   |
| 25    | MicrosoftDynamicsScheduling          | Also used by Project Service Automation                   |
| 26    | msdynce_3DViewer                     |                                                           |