---
title: "Introduction to migration of entity records (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to migrate entity records from the legacy Service Scheduling to the Unified Interface Service Scheduling in Dynamics 365 Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/11/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Introduction to migration of legacy Service scheduling data

Using the new scheduling experience in Customer Service Hub, you can schedule all your resources optimally and efficiently to plan service activities for your customers. You can now migrate your data to the new scheduling experience using the data migration wizard in the Customer Service Hub app.

To learn more, see [Understand the new scheduling experience](basics-service-service-scheduling.md).

Consider the following scenarios before you begin migration:

- If you haven’t been using the legacy scheduling experience and you are setting it up for the first time in the Customer Service Hub app, see [Set up the new scheduling experience](basics-service-service-scheduling.md#set-up-the-service-scheduling-experience).

    > [!Note]
    > As an admin, you should configure all your entity records in the new experience manually from the user interface. You must follow the order as given in the [Scheduling scenario](basics-service-service-scheduling.md#scheduling-scenario) while configuring entity records in the new scheduling experience.

- If you've been using the legacy scheduling experience and plan to migrate to the new scheduling experience in the Customer Service Hub app, use the migration solution. The new migration package lets you migrate scheduling entity records. To learn more, see [Migrate entity records](migrate-entity-records.md) and [Install Scheduling solution](#install-scheduling-solution).

## Install Scheduling solution

1. Go to [Microsoft 365 Admin center](https://admin.microsoft.com/AdminPortal/Home).

2. Select **... Show all** > **Admin centers** > **Dynamics 365**. Dynamics 365 opens in a new tab.

    ![Microsoft Admin Center](media/microsoft-365-admin-center-dynamics-csh.png "Microsoft Admin Center")

3. In the **Dynamics 365 Administration Center**, under the **Instances** tab, select an instance type from the drop-down.

4. Select the edit icon next to solutions. The **Manage your solutions** page appears.

5. In the **Manage your solutions** page, select **Service Scheduling Migration**. The status column shows **Not installed**.

6. Select the install icon next on the **Service Scheduling Migration** card. The **Terms of service** page appears.

7. In the **Terms of service** page, read the terms and conditions and then select **Install**. The installation may take few minutes.

After successful installation, you can access scheduling in the Customer Service Hub sitemap.

## See also

[Plan your migration](plan-migration.md)

[Migrate entity records](migrate-entity-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]