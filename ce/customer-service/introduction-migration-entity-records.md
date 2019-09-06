---
title: "Introduction to migration of entity records (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to migrate entity records from the legacy Service Scheduling to the Unified Interface Service Scheduling in Dynamics 365 Customer Service"
author: kabala123
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.author: kabala
manager: shujoshi
ms.date: 08/07/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 2DCAB60C-A152-49CB-B1E2-0E6CE41821DD
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Introduction to migration of legacy Service scheduling data

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)

Using the new scheduling experience in Customer Service Hub, you can schedule all your resources optimally and efficiently to plan service activities for your customers. You can now migrate your data to the new scheduling experience using the migration solution in the Customer Service Hub app.

To learn more, see [Understand the new scheduling experience](basics-service-service-scheduling.md).

Consider the following scenarios before you begin migration:

- If you haven’t been using the legacy scheduling experience and you are setting it up for the first time in the Customer Service Hub app, see [Set up the new scheduling experience](basics-service-service-scheduling.md#set-up-the-new-service-scheduling-experience).

    > [!Note]
    > As an admin, you should configure all your entity records in the new experience manually from the user interface. You must follow the order as given in the [Scheduling scenario](basics-service-service-scheduling.md#scheduling-scenario) while configuring entity records in the new scheduling experience.

- If you've been using the legacy scheduling experience and plan to migrate to the new scheduling experience in the Customer Service Hub app, you can do the following.

    - Manually configure entity records in the new experience. For more information, see [Configure entity records in the new scheduling experience](basics-service-service-scheduling.md#configure-entity-records-in-the-new-scheduling-experience).

        Or

    - Migrate using the migration solution. The new migration package lets you migrate scheduling entity records. To learn more, see [Get migration solution](#get-migration-solution) and [Migrate entity records]().

## Get migration solution

You can opt in and get the migration solution package from the Dynamics Admin center. Follow the below steps to get the migration solution package.

1. Go to the [Dynamics 365 Service Scheduling - Migration](https://experience.dynamics.com/insider/campaign/?id=0365026c-e797-e911-a962-000d3a4f3883) program.

    > [!Note]
    > Use your insider portal credentials to sign in. If you don’t have an account, sign up to create an account.

2. Select **Join Now**.

3. Select **Fill the form** on the program page.

4. Specify the details in the form and submit.

As we receive your details, we will enable the Service Scheduling migration solution on your Dynamics 365 for Customer Engagement instance, and you will receive a confirmation email from Microsoft.

Once you receive the email, you need to install the solution from the Microsoft 365 Admin center. To learn more, see [Install Scheduling solution](#install-scheduling-solution).

## Install Scheduling solution

1. Go to [Microsoft 365 Admin center](https://admin.microsoft.com/AdminPortal/Home).

2. Select **... Show all** > **Admin centers** > **Dynamics 365**. Dynamics 365 opens in a new tab.

    ![Microsoft Admin Center](media/microsoft-365-admin-center-dynamics-csh.png "Microsoft Admin Center")

3. In the **Dynamics 365 Administration Center**, under the **Instances** tab, select an instance type from the drop-down.

4. select the edit icon next to solutions. Manage your solutions page appears.

5. In the **Manage your solutions** page, select **Service Scheduling Migration**. The status column shows Not installed.

6. Select the install icon next on the **Service Scheduling Migration** card. The Terms of service page appears.

7. In the **Terms of service** page, read the terms and conditions and then select **Install**. The installation may take few minutes.

After successful installation, you can access scheduling in the Customer Service Hub sitemap.

## Considerations for migration

- **Role privileges:** To perform the migration, you must have administrator or system customizer roles. The list of privileges that are required if you want to assign to any other roles are as follows:
    - msdyn_ursmigrationlogs
    - msdyn_ursmigrationinfo
    - msdyn_ursmigratedentitiesinfo

- **Order of migration:** Migration of the entity records follow an order. That is, when the migration of one entity record completes, then the next entity will be processed for migration.

    The order of the migration is as stated:
    1. Site
    2. User
    3. Facility/Equipment
    4. Team
    5. Resource Group
    6. Service
    7. Service Activity

- **Understand migration status:** The records that are marked as Ignore won’t be migrated by the tool. The status of migration that are displayed are as follows:

    | Status | Description |
    |----------------|----------------------------------------------|
    | Failed | The entity records that failed in the migration process. |
    | Ignore | The entity records that are ignored in the migration process. |
    | In Progress | The entity records that are in progress in the migration process. |
    | Migrated | The entity records that are migrated in the migration process. |
    | Not Started | The entity records that are not yet started for migration. |

- **Migration start date and end date:** Start date and end date helps you to migrate the service activities that are scheduled to happen between the date range you’ve specified (both dates are inclusive).

    Scenario example: You’ve specified the migration end date field as **07/22/2019**.

    | Migration End date | Activity scheduled date | Activity end date | Entity record migration | Reason |
    |----------|----------|----------|---------|------------------------------------|
    | **07/22/2019** | **07/23/2019** | **07/23/2019**| No | The service activity won’t be migrated as the scheduled date is beyond the end date. |
    | **07/22/2019** | **07/22/2019** at **2300** hours | **07/23/2019** at **0500** hours | No | The service activity won’t be migrated as the scheduled activity ends at a date later than the specified migration end date. |
    | **07/22/2019** | **07/22/2019** at **2359** hours | **07/22/2019** at **0500** hours | Yes | The service activity will be migrated as the activity ends before the specified migration end date. |

- **Recommendation:** For best migration experience, it is recommended not to use Service Scheduling until the migration is completed.

- **Successful migration for all records:** When the tool migrates all the entity records successfully, you can’t use the tool again in the environment.

- **Failed Migration for certain records:** When the migration of an entity record fails, then you can retry migration. For the retry scenario, the number of records that are displayed in the screen are the records that didn’t migrate in the first run of the migration.

- **New entity record:** If you create any records after you start the migration, the newly created entity records will not be reflected in the migration summary.

- **Custom plugins and workflows:** After the migration, if you’ve custom plugins and workflows, examine them for compatibility with the new scheduling experience.

- **Updating records during migration:** After you’ve migrated an entity record, if you update the record in the legacy service scheduling, the difference of update can’t be migrated using the tool. You must manually update the changes in the new service scheduling experience.

## See also

[Migrate entity records](migrate-entity-records.md)