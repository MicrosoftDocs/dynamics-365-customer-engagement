---
title: "Migrate data from legacy Service Scheduling using migration tool (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to migrate entity records from the legacy Service Scheduling to the Unified Interface Service Scheduling in Dynamics 365 Customer Service"
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/03/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: FB1D8DDE-AADD-4249-A011-1BA02CEE7B0D
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Migrate entity records data from legacy Service scheduling using migration tool

Follow these steps to migrate entity records from legacy scheduling experience to the new scheduling experience.

1. Sign in to the Customer Service Hub app with Administrator or System Customizer role privileges.

2. Select **Scheduling** from **Change area**.

3. Select **Data migration** under **Tools**. The **Migrate to Service scheduling on Unified Interface** page displays the **Last run status**. If you've never run the tool, then the **Date** and **Status** field will be blank.

    ![Data Migration](media/data-migration.png "Data Migration")

4. Review the details and select **Next** in the **Migrate to Service scheduling on Unified Interface** page. The **Step 1/3: Configuration data** page appears that displays the name of the entity records and the total number of records that will be migrated.

    ![Migrate data](media/migration-step1.png "Migrate data")

5. Specify the following in the **Step 2/3: Service Activities** page and select **Migrate**.

    | Field | Description | Value |
    |----------------------------|-------------------------------|---------------------------------------|
    | Migrate Service Activities | Set the toggle to **On** to migrate the service activities. | On |
    | Start date | Select a start date from the date picker. | 6/20/2019. <br> **Note:** This is an example value. |
    | End date | Select a end date from the date picker. | 9/23/2019. <br> **Note:** This is an example value. |

    The tool considers all the Service activities that are scheduled to start and be completed within the date range.

    ![Migrate data](media/migration-step2.png "Migrate data")

    > [!Note]
    > - The migration tool doesn’t consider the records whose status is marked as Ignore. To learn more, see [Understand migration status](#understand-migration-summary-and-troubleshoot).
    >
    > - If you create any records after you start the migration, the newly created entity records will not be fetched and migrated.

6. Review the information in the confirmation dialog and select **Migrate**. Once you migrate, the action cannot be undone.

7. Review the status of the migration. If the migration is successful, select **Done**, and the migration status page is displayed.
 
    ![Migration in progress](media/migration-step3.png "Migration in progress")

    > [!Note]
    > After you’ve migrated an entity record, if you update the record in the legacy service scheduling, the difference of update can’t be migrated using the tool. You must manually update the changes in the new service scheduling experience.

## Understand migration summary and troubleshoot

The status column displays two types migration status for the entity records:

- **Done:** When the migration of the entity records is completed successfully, the tool displays the status as Done. 
- **View Errors:** When the migration of the entity records is failed, the tool displays the status as View Errors.

### View errors

If the migration of one or more entity records has failed, the status column displays for which entity records the error has occurred.

   ![Migration with errors](media/migration-step4.png "Migration with errors")

Select the **View Errors** in the status column to view the details in a new browser tab. The tool navigates to the associated entity view that shows the record name, status (which will be failed all the time), and migration failure reason.

For example, when you select the View Errors option against the **Service Activity**, a new browser tab opens, and the tool displays **Service Activities - Migration Status** page.

   ![Migration status view](media/migration-step5.png "Migration status view")

To learn more, see [Troubleshoot using migration information](#troubleshoot-to-resolve-migration-errors).

### Troubleshoot to resolve migration errors

One of the reasons for the failure of entity record migration is a dependency between the entity records. That is, an entity record **C** has a dependency on the record **B**, which in turn has a dependency on the record **A**. If the migration of entity record **A** fails, then migration of entity record **B** and **C** also fails.

   ![Migration record failure](media/migration-record-failure.png "Migration record failure")

For example, 

In the legacy web client service scheduling experience, the Contoso Bike Center organization the following entity data records.

   | Entity record | Record name |
   |------------------------|---------------------|
   | Sites |<ul> <li>Contoso Bike Center - Bellevue</li> <li>Contoso Bike Center - Redmond</li> <ul> |
   | Facilities/Equipment | <ul> <li> Allen key kit </li> <li>Bike workbench</li> <li>Electronic Control Manager</li> <li>Fork Spring Compressor</li> <li>Paint Spray</li> <li>Special spanner</li> <li>Wheel Balancer</li> <li>Wrench spanners</li></ul>
   | Resource groups | <ul> <li>Bike advisors</li> <li>Bike service managers</li> <li>Bike technicians</li></ul> |
   | Services | <ul> <li>Bike inspection</li> <li>Bike maintenance</li> <li>Bike overhaul</li> <li>Bike repair</li></ul>

Now, in the **Contoso Bike Center - Bellevue** site, to do a **Bike overhaul** service, the **Bike technicians** resource group and the **Allen key kit** facilities/equipment is required.

See the matrix for the dependency.

   | Entity name |Record name|
   |------------------|--------------------|
   | Services | Bike overhaul |
   | Resource groups | Bike technicians |
   | Facilities/Equipment | Allen key kit |
   | Site | Contoso Bike Center - Bellevue |

   ![Migration record failure](media/migration-record-failure-example.png "Migration record failure")

If the migration of the **Contoso Bike Center - Bellevue** site fails, then the migration of the following entity records also fails:

- **Allen key kit**
- **Bike technicians**
- **Bike overhaul**

Let us take the above mentioned example to learn how to resolve the error.

1. Select **View Errors** against the **Service** record in the **Data Migration Wizard** tab. The **Services - Migration Status** page opens in a new browser tab. <br> You can view the migration error message for the **Bike overhaul** record that states **Dependent ResourceGroup not migrated**.

    ![View service errors](media/migration-step8.png "View service errors")

    ![Service entity migration status view](media/migration-step9.png "Service entity migration status view")

2. Select **View Errors** against the **Resource Group** record in the **Data Migration Wizard** tab. The **Resource Groups - Migration Status** page opens in a new browser tab. <br> You can view the migration error message for the **Allen key kit** record that states **Resource(s) in the ResourceGroup not migrated to BookableResource(s)**. <br><br> The resources might be facilities/equipments, sites, users, team or any other entity records. In this example, let us look for facilities/equipments as it has errors.

    ![Resource Group View](media/migration-step10.png "Resource Group View")

3. Select **View Errors** against the **Facility/Equipment** record in the **Data Migration Wizard** tab. The **Facility/Equipment - Migration Status** page opens in a new browser tab. <br> You can view that the dependent site is not migrated with the GUID - `B83FE603-F3DA-E911-A81F-000D3A6D4947`.

4. Open a new browser window and go to `http://<dynamics org url>api/data/v9.0/sites(B83FE603-F3DA-E911-A81F-000D3A6D4947)`, and you find the record name. In our case, it is **Contoso Bike Center - Bellevue**, which is a **Site** entity. 

5. Select **View Errors** against the **Site** record in the **Data Migration Wizard** tab. The **Sites - Migration Status** page opens in a new browser tab. <br> You can view the error the caused the Site entity record failure.

6. Resolve the error that caused the migration failure, and then you can go to the migration step, and select **Retry Migration** to start the migration for the failed entity records.

   > [!Note]
   > In case of retry scenario, the migration tool shows the number of records that need to be migrated in that retry scenario of migration.

7. Review the migration status, if there are any errors, investigate in a similar way as explained in this example.

## See also

[Introduction to migration of entity records](introduction-migration-entity-records.md)

[Plan your migration](plan-migration.md)