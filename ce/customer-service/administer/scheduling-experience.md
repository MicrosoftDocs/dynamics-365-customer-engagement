---
title: Set up the Service Scheduling experience
description: Learn about how to set up the Service Scheduling experience in Dynamics 365 Customer Service
author: lalexms 
ms.author: laalexan
ms.reviewer: shujoshi
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 12/05/2023
ms.custom: bap-template 
---

# Set up the Service Scheduling experience

How you set up service scheduling differs, based on the following scenarios:

- For new or existing organizations, where the Core Service Scheduling solution isn't installed, [install Service Scheduling from the Power Platform admin center](install-service-scheduling-from-power-platform.md).

- For existing organizations, where the Core Service Scheduling solution is already installed, install the available updates by [checking your app status](/power-platform/admin/manage-apps#environment-level-view-of-apps) from the Power Platform admin center.

### Prerequisites

- Make sure that you have the required security role or equivalent permissions. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

- Ensure your organization has Universal Resource Scheduling 3.2.0.405 or a later version. If your organization has a version prior to 3.2.0.405, then Universal Resource Scheduling installation fails. To check the Unified Resource Scheduling version on your instance, go to **Settings** > **Solutions**.

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule anything with Universal Resource Scheduling (Sales, Customer Service, Field Service, Project Service Automation)](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

   > [!NOTE]
   > - If your organization doesn't have Universal Resource Scheduling, the **Core Service Scheduling** solution installs the latest version of Universal Resource Scheduling.
   > - If Field Service or Project Service is already installed on your organization with Universal Resource Scheduling 3.2.0.405 or later version, then Universal Resource Scheduling will also be upgraded to the latest version. Otherwise, the installation fails.
   > - The latest version of Universal Resource Scheduling might not be compatible with the older versions of Field Service or Project Service.
- Ensure your organization has Customer Service Hub application.

### Install the scheduling solutions

1. Go to [Microsoft 365 admin center](https://admin.microsoft.com/AdminPortal/Home).

2. Select **... Show all** > **Admin centers** > **Dynamics 365**. Dynamics 365 opens in a new tab.

   > [!div class=mx-imgBorder]
   > ![Go to Dynamics 365 in Microsoft 365 admin center.](media/microsoft-365-admin-center-dynamics-csh.png)
3. In the **Dynamics 365 Administration Center**, under the **Instances** tab, select an instance type from the drop-down. 

4. select the edit icon next to solutions. Manage your solutions page appears.

   > [!div class=mx-imgBorder]
   > ![Edit the solutions.](media/dynamics-365-admin-instance-edit-csh.png)
5. In the **Manage your solutions** page, select **Core Service Scheduling**. The status column shows **Not installed**.

6. Select the install icon next on the **Core Service Scheduling** card. The **Terms of service** page appears.

   > [!div class=mx-imgBorder]
   > ![Install the solutions.](media/core-service-scheduling-install-csh.png)
7. In the **Terms of service** page, read the terms and conditions and then select **install**. The installation may take few minutes.

After successful installation, you can access scheduling in the Customer Service Hub sitemap.


### See also    

[Overview of Service Scheduling](basics-service-service-scheduling.md)
[Service Scheduling FAQ](service-scheduling-faq.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
