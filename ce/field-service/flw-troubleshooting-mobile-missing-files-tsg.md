---
title: App shows error on start due to missing files in the solution
description: FSM App (preview) shows error on start due to missing files in the solution
ms.date: 09/14/2023
ms.topic: troubleshooting
author: andrea-orimoto
ms.author: andreo
ms.reviewer: 
ms.custom: bap-template
---

Michael the content for [this page is here](https://dynamicscrm.visualstudio.com/OneCRM/_wiki/wikis/FieldService.NativeExperience/64652/Native-UI-boot-error)

1. summarize as needed
2. clean up screenshots (names, etc.)

## Check if mobile sources are deployed successfully

1. Go to [maker portal](https://make.powerapps.com/) and select the envrionment to check
1. Select 'Tables' and 'All' and search for table 'mobilesource'

   ![image.png](/.attachments/image-8193bd40-105a-48a8-b381-df70993b2434.png)
1. Select the table and check it has the following entries in the table

   ![image.png](/.attachments/image-6f0f83d3-2605-4bad-bd09-f32d595f520f.png)

If the table is empty, then the Field Service Solution update didn't apply successfully. 

## Re-apply Field Service Solution update

1. Go to [maker portal](https://make.powerapps.com/) and select the envrionment to re-apply the soluton update
1. Select 'Solutions' and search for 'fieldservice_anchor' solution
   ![image.png](/.attachments/image-aeaf4359-2d81-4397-b5f5-821e8d43a501.png)

1. Delete the 'FieldService_Anchor' solution

   ![image.png](/.attachments/image-0400cd59-bdae-4e1f-99ce-71d8468cec23.png)

1. After the solution is deleted, goto [PowerApps Admin center](https://admin.powerplatform.microsoft.com/environments) and select the envrionment to reapply solution update

   ![image.png](/.attachments/image-62247103-4536-4dbd-9205-572459918128.png)

1. Select the envrionment to manage its Dynamics 365 applications

   ![image.png](/.attachments/image-d74cff77-871a-4816-8c26-68e0dd5103d4.png)

1. Select install app and select 'Dynamics 365 for Field Service' to install

   ![image.png](/.attachments/image-23eed6ea-e0f4-45b0-8255-42a2d73e9d61.png)

1. Check term of service and click install

   ![image.png](/.attachments/image-81e820be-aef3-4701-afe3-05c96fc12eba.png)

After the solution install is re-applied, go back to [first section](https://make.powerapps.com/) and verify that mobilesource table is populated as [described above](#check-if-mobile-sources-are-deployed-successfully)
