---
title: Migrate Automatic Record Creation (ARC) and Service Level Agreements (SLAs) rules.
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 08/03/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - migration
search.app: 
  - D365CE
  - D365CS
---

# Migrate Automatic Record Creation (ARC) and Service Level Agreements (SLAs)

[Public Preview]

The Customer Service Hub app has several features and functionalities that replace the rules in the legacy Customer Service app. The rules for Automatic Record Creation (ARC) and Service Level Agreements (SLAs) are now supported by Power Automate based flows to make the transition to the new platform easier to manage.

The following topic provides an overview on the migration tool that allows legacy rules for ARC and SLAs to be transferred to the Customer Service Hub app for easier access.

Based on feedback, we have made a number of improvements to the migration tool. The migration tool is designed to migrate the existing legacy rules to Unified Customer Interface (UCI) ensuring all the rules, items, and actions get converted accordingly to suit the UCI format. This includes conversion of workflow to Power Automate based flow as well.

The migration tool provides the following:
- Ability to run the migration tool multiple times and see what your status looks like at any point in time.
- Flexibility to pick and choose which legacy rules need to be migrated. 
- Flexibility to decide when to activate new rules and deactivate the legacy rules so you are not forced to activate all or none.
- Existing legacy rules are not modified or deactivated automatically. 
- Messages on potential issues on why a ruled failed the migration process.

> [!NOTE]
> Legacy rules continue to run on existing cases until the rules are deactivated. 

## Prerequisites
- Customer Service Licensing 
- ARC must have a Customer Service version of 9.0.20034.20XX or higher environment to opt-in for migration
- SLA must have a Customer Service version of 9.0.20053.1030 or higher enironment to opt-in for migration
- Admin permissions 

### Working with Rules 

Before running the migration tool, it is important to understand and familiarize yourself with how the modern ARC and SLA rules work in the Customer Service Hub app before you start migration.

When performing your migration, you will only receive detailed results on rules which have failed the pre-migration checkup, creation or was partially migrated (incomplete).  

To learn more about how to create rules in the Customer Service Hub app, see [Automatically create or update records in Customer Service Hub](automatically-create-update-records.md) and [Define service-level agreements](define-service-level-agreements.md) for more information.

> [!Note]
> Once you have successfully migrated a rule, any edits made to that rule on the web client will not be visible in UCI. It must be explicitly deleted in UCI and migrated again for those edits to be visable in UCI.

### Editing Rules

The migration tool will pick up any updates or edits in the web client during a rerun if the rule has been: 
- edited prior to the actual migration in the web client
- edited to resolve errors in the web client that failed during a previous migration attempt

The following updates or edits to a rule will not be considered if:
- the rule is edited on the web client after it was successfully migrated to UCI
- any edits were made to migrated rules in the UCI client after running the migration tool

## Accessing the Migration Tool

Admins can access the migration tool using the following steps:

**Step 1:** Go to **Service**<br>
**Step 2:** Select **Service Management**<BR>
**Step 3:** Under **Data Management** section, select **ARC & SLA Migration Tool (Preview)**

![Access Migration Tool](media\migration-tool-access-location-1.png "Migration tool access locations")

![Access Migration Tool](media\migration-tool-access-location-2.png "Migration tool access locations")

> [!NOTE]
> Only Admins can view and use this option.

## Migration Process

The migration process is broken out into the following six steps:

**Step 1: Category to migrate.**  Allows you to pick and choose which rules you wish to migrate.

**Step 2: Pre-migration checkup.** This enhancement to the migration process which provides insights into any potential migration failures you may incur prior to beginning your migration.    

**Step 3: Rules and items to migrate.** Allows you to select which rules you want to migrate. 

**Step 4: Review.** Provides you with the opportunity to go through any rules that have been identified as having errors or issues and fix these prior to migration.

**Step 5: Migration.** Once migration is complete, you can review which rules successfully completed the migration process and which ones failed. 

**Step 6: Finish.** Provides you with a summary / status page of rules which have successfully migrated, those that are pending, and failed migration.

## Using the Migration Tool 

Once you have successfully accessed the migration tool, choose from one of the two options based on your experience working with the tool: 

**Option 1:** First time migration tool user. Follow the steps in this option if you are accessing and using the migration tool for the first time. <BR>
**Option 2:** Experienced migration tool user. Follow the steps in this option if you have accessed and used the Migration Tool in the past.

## Migration Tool for First time Users

The migration landing page shown below is what will display for first time users and provides the following: 
1.	An overview of both ARC and SLAs rules
2.	**Total** displays the number of legacy rules available overall
3.	**Migrated** displays the number of rules you have completely migrated
4.	**Pending** displays the number of rules you have pending migration (includes failed rules, partially/incomplete migrated rules, and rules which have not been attempted)
5.	**Migration status** displays whether migration has started or not
6.	**Refresh** allows you update migration status
7.	**Start migration** allows you to being migration process

> ![Migration Tool First Time User Overview](media\migration-tool-first-time-users-1.png  "Migration Tool First Time User Overview")

Once you select **Start migration**, the migration tool will begin taking you through the migration process which consists of the following six steps: 

**Step 1:** [Category to migrate](migrate-automatic-record-creation-and-sla-agreements.md#step-2-pre-migration-checkup)  <br>
**Step 2:** [Pre-migration checkup](migrate-automatic-record-creation-and-sla-agreements.md#step-1-category-to-migrate) <br>
**Step 3:** [Rules and items to migrate](migrate-automatic-record-creation-and-sla-agreements.md#step-3-rules-and-items-to-migrate)<br> 
**Step 4:** [Review](migrate-automatic-record-creation-and-sla-agreements.md#step-4-review)<br>
**Step 5:** [Migration](migrate-automatic-record-creation-and-sla-agreements.md#step-5-migration)<br> 
**Step 6:** [Finish](migrate-automatic-record-creation-and-sla-agreements.md#step-6-finish)

## Step 1: Category to migrate

**Step 1** screen provides:

1.	A tracker will be displayed on the left, showing you where you are in the migration process at all times.
2.	Category options that allows you to select which rules you want to migrate by clicking a box.  You can elect to migrate ARC and SLAs separately, or migrate both at the same time. 
3.	You must select a category for migration before you can proceed.   

> ![Migration Tool for first time user - Step 1](media\migration-tool-step-1-first-time-users-1.png "Migration Tool for first time user - Step 1")

4.	Once you select the category you want to migrate it will be confirmed by a check mark.
5.	The **Next** button at the bottom will turn blue once you select a category. 

> ![Migration Tool for first time user - Step 1](media\migration-tool-step-1-first-time-users-2.png "Migration Tool for first time user - Step 1")

## Step 2: Pre-migration checkup

**Step 2** screen provides a pre-migration check that displays what the actual migration results will look like so you can mitigate potential migration failures before you begin.  

The **Pre-migration checkup** can be performed on ARC or SLA or both depending on your selection from the previous screen.       

As a first time user, you will not have any insights until you complete the Pre-migration Checkup.  Once the Pre-migration Checkup review is complete, the following overview will be displayed showing:

1.	The number of rules which may successfully complete migration broken out by category.
2.	The number of rules which may fail if migrated broken out by category.
3.	To view which rules passed and which rules failed, select **Next** to continue to **Step 3**.

> ![Migration Tool for first time user - Step 2](media\migration-tool-step-2-first-time-users-1.png "Migration Tool for first time user - Step 2")

## Step 3: Rules and items to migrate

**Step 3** shows the rules which successfully passed are automatically selected to move forward for migration.  However, you can control which rules you want to migrate by selecting or de-selecting any rules you want to migrate.  

Rules that fail can still be migrated, however the data will not migrate over completely. You have the option to fix the error prior to migration or fix the rule in the Customer Service Hub app upon completing your migration.  If you want to migrate both passed and failed rules, use the **Migrate all rules** option to override any current selection and migrate all rules.

### Step 3: Automatic record creation and update rules

Use the following to complete Step 3:   

1.	The tracker displays which set of rules you are working on for migration to ensure clarity.
2.	Rules that pass are automatically selected for migration. You have control to uncheck these.
3.	Rules that failed are not selected for migration, however you can select rules that failed the pre-migration check. Please note that these failed rules may not migrate completely.  To understand why a rule failed, you can click on the rule and view the details around the failure.  You can use the information to fix the failure prior to migration or after migration. See [View Details for Rule Failure](#view-details-for-rule-failure) for more details. 
4.	**Migrate all rules** provides you the ability to override the current selection in order to select all rules, regardless of their pre-migration checkup result.
5.	Allows you to **download all logs** which failed for review and troubleshooting purposes.  
6.	This alert notifies you that while you can migrate rules that failed the Pre-migration Checkup, the data on failed rules will not migrate completely and provides the option to **unselect rules** that failed.
7.	When you have selected / deselected all the rules you want to migrate, select **Next** to continue to Step 4.

> ![Migration Tool for first time user](media\migration-tool-step-3-first-time-users-1.png "Migration Tool for first time user")

## View Details for Rule Failure

When you click on a rule that failed the Pre-migration Checkup you have a choice of **Basic** and **Advance** views to better understand why a rule failed. You can use this information to either troubleshoot and fix the ruled that failed, or choose to migrate the rule and fix it in the Customer Service Hub after migration is complete.

### Basic View

The Basic view provides the following overview for each individual rule that failed, including:

1.	**Basic** provides high level details on rules that fail.
2.	**Pre-migration checkup** shows results along with details why a rule failed.

> ![Migration Tool for first time user - Basic detail screen for failed rules](media\migration-tool-step-3-basic-screen-first-time-users-1.png "Migration Tool for first time user - Basic detail screen for failed rules")

### Advanced View

The **Advanced** view provides the following overview on rules that failed, including:

1.	Provides a deeper dive into the details as to why the rule may have failed migration and gives details as to why a rule failed which you can use to troubleshoot and resolve prior to migration.
2.	**Download log** a list of failed rules to  review and troubleshoot.  

> ![Migration Tool for first time user - Advanced detail screen for failed rules](media\migration-tool-step-3-advanced-screen-first-time-users-1.png "Migration Tool for first time user - Advanced detail screen for failed rules")

## Step 4: Review

Once you have selected the rules you want to migrate for ARC and/or SLAs a list will be displayed for your review.  This review section allows you to:  

1.	View a list of all the rules you have selected for migration. 
2.	Select **Back** to return to the previous step to make additional changes.
3.	Select **Start migration** to kick off migration.

> ![Migration Tool for first time user - Step 4](media\migration-tool-step-4-first-time-users-1.png "Migration Tool for first time user - Step 4")

## Step 5: Migration

Once you begin your migration, the following screen will appear that displays:

1. The message that your migration is in progress.
2. The **Next** button is disabled during the migration process.	Once migration is completed you will be taking to the next step automatically.

> ![Migration Tool for first time user - Step 5](media\migration-tool-step-5-first-time-users-1.png
 "Migration Tool for first time user - Step 5")

Once migration is complete the following screen will appear that includes:

1.	**Selected** displays the total number of rules that were selected for the current migration run.
2.	**Migrated** displays the total number of rules that successfully completed migration.
3.	**Incomplete** displays the total number of rules that encountered errors which did not complete the migration process successfully. See [Incomplete Migration Details](#incomplete-migration-details) for more information.
4.	**Migration Status** displays either green check mark ![green check mark](media\migration-tool-step-5-green-check-first-time-users-3.png "green check mark")  which represents rules successfully migrated or a red exclamation mark ![red exclamation mark](media\migration-tool-step-5-red-check-first-time-users-3.png "red exclamation mark")   which represents some or all rules did not successfully complete migration.
5.	**Finish** completes the migration process when completed.

> ![Migration Tool for first time user - Step 5](media\migration-tool-step-5-first-time-users-2.png "Migration Tool for first time user - Step 5")

### Incomplete migration details

To view ARC and/or SLAs rules that did not successfully complete migration, you can click on **Incomplete** in the **Migration status** section and a list will be displayed of all the rules that did not pass, including:  

1.	**Name** displays each individual rule that failed.
2.	**Migration Status** displays whether rule successfully Migrated or was unsuccessful and therefore Incomplete.
3.	**Problem Details** displays why the rule failed and has a **Download log** option which provides more details.
4.	**Download all logs** allows you to download a list of all the rules that failed migration for review and troubleshooting.  

> ![Migration Tool for first time user - Step 5 Incomplete migration details](media\migration-tool-step-5-first-time-users-3.png "Migration Tool for first time user - Step 5 Incomplete migration details")

## Step 6: Finish

Now that you have completed your first run, and select **Finish**, a migration **Summary** page will appear:

1.	**Total** displays the number of legacy rules present overall.
2.	**Migrated** displays the number of rules you have completely migrated to date.
3.	**Pending** displays the number of rules you have pending migration (includes failed rules, partially/incomplete migrated rules, and rules which have not been attempted)
4.	**Refresh** allows you view your update migration status.
5.	**Next Step** section provides you with links to all the ARC and SLA rules where you can review the migrated rules and choose to activate them. See [Activate New Rules](#activate-new-rules) for more information. 

> ![Migration Tool for first time user - Step 6](media\migration-tool-step-6-first-time-users-1.png "Migration Tool for first time user - Step 6")

## Review and activate migrated rules

Once you activate new rules for either ARC or SLA you are taken to the following screen:

1.	**Rule name** displays migrated rules with an underscore (_), for example: **_migrated** for easy identification of migrated rules.

> ![Migration Tool for first time user - Step 6 Activate New Rules](media\migration-tool-step-6-first-time-users-2.png "Migration Tool for first time user - Step 6 Activate New Rules")

### Migration detail section

#### Working with partially migrated rules

When you click on a **Rule name** ending in **_migrated** a screen will appear:

1.  Go to the **Migration details** tab 
2.	**Mark as complete**. This field contains a toggle feature.  The toggle is used to identify whether a rule has either completed migration (**Yes**), or has not completed and/or has only paritally completed migration (**No**).  <BR><BR> The Admin can review the incomplete rule and choose to resolve the issue and move the toggle to **Yes**, which then updates the migration status to **Migrated**. 

    > [!Note]
    > - When an Admin moves the toggle to **Yes** this serves as a confirmation that the rule has been successfully migrated and therefore will not be picked up in subsequent migration runs.
    > - If the Admin does not take any action on an incomplete rule, the rule will continue to be picked up in subsequent migration runs. Also, the rule will be replaced when chosen to migrate again. 
3. **Migration status**. This displays the status of the rule as either **Migrated** or **Incomplete**.
4. **Problem details**. This provides a high level detail on the error(s) encountered on the rule during migration. 

> ![Migration Tool for first time user - Step 6 Migration Status](media\migration-tool-step-6-first-time-users-3.png "Migration Tool for first time user - Step 6 Migration Status")

#### Working with successfully migrated rules

1. **Mark as complete**. The toggle is set to **Yes** by default.
2. **Migration status**. This displays the status of the rule as either **Migrated** or **Incomplete**.

> ![Migration Tool for first time user - Step 6 Migration Status](media\migration-tool-step-6-first-time-users-3a.png "Migration Tool for first time user - Step 6 Migration Status")

## Migration Tool for Experienced Users

If you have already been through the migration process, your experience will be very similar to that of the first time user, with a few exceptions.   

1.	**ARC and SLA Migration tool.** Access the migration tool as before under the Data management section.
2.	**Previous migration data.**  Since you have been through the migration process before, your **Summary page** will have updated data based on previous migration. 
3.	**Start migration.** To begin the migration process select Start to continue. 

> ![Migration Tool for experienced users](media\migration-tool-step-1-experienced-users-1.png "Migration Tool for experienced users")

## Step 1: Category to migrate.  (Experienced User)

This step allows you to pick and choose which rules you wish to migrate.

## Step 2: Pre-migration checkup. (Experienced User)

When preparing to rerun the **Pre-migration checkup** process step it will only review the rules that did not pass before. You can download the details provided to troubleshoot errors and make updates in the Unified Interface or legacy system before you rerun your migration.

1.	**Yellow notification message** reminds you that rules that were successfully migrated previously will automatically be skipped in a rerun of the pre-migration checkup process.  This includes rules that were confirmed by the Admin as well.
2.	**Total** shows the number of rules that are available for migration. The pre-migration checkup process will only focus on running rules that have not been migrated completely, not attempted previously, or failed to create which is reflected in the total count.

> ![Migration Tool for experienced users - step 2](media\migration-tool-step-2-experienced-users-1.png "Migration Tool for experienced users - step 2")

## Step 3: Rules and items to migrate. (Experienced User)

This step allows you to select which rules you want to migrate on the following screen, which includes:
 
1.	**Migrate all rules** allows you to override all previous selections.
2.	**Checkup Results** displays if your rule passed or failed the pre-migration.
3.	**Failed** rules can be reviewed by selecting the rules which failed.
4.	**Download all logs** to see each individual problem detail.

> ![Migration Tool for experienced users - step 3](media\migration-tool-step-3-experienced-users-1.png "Migration Tool for experienced users - step 3")

Only rules that were either not attempted, did not completely migrate, or failed to migrate will appear in **Step 3**. If you want to attempt migration of a successfully migrated rule again, delete the corresponding one from UCI and re-run the migration tool for it to appear in the list again. 

## Step 4: Review. (Experienced User)

This step provides you with the opportunity to go through any rules that have been identified as having errors or issues and fix these prior to migration.

## Step 5: Migration.  (Experienced User)

This step confirms when migration is complete and provides a summary of the number of rules that successfully completed migration and number of rules that failed migration.

1.	**Selected**, **Migrated**, and **Incomplete** sections provides the migration results for the current migration run.
2.	**Migration status** shows you the status of your current migration run and allows you to view the details on the **Incomplete** rules that could not be migrated.

> ![Migration Tool for experienced users - step 5](media\migration-tool-step-5-experienced-users-1.png "Migration Tool for experienced users - step 5")

## Step 6: Finish (Experienced User)

When you finish your migration, an updated **Summary** page will be displayed that includes:

1.	**Summary**. Provides the overall summary of all the migration details to date. 
2.	**Start**. Select to rerun the migration process again.

> ![Migration Tool for experienced users - step 6](media\migration-tool-step-6-experienced-users-1.png "Migration Tool for experienced users - step 6")

This feature will available for public preview as part of August Early access. So if you opt-in for early access, this the migration tool will be available to you as well. This will be automatically available post GA for everyone.

### See Also

[Migration Tool FAQs](migrate-tool-faqs.md)

[Set up rules to automatically create or update records](set-up-rules-to-automatically-create-or-update-records.md)

[Define service-level agreements](define-service-level-agreements.md)

[Important changes (deprecations) coming](https://docs.microsoft.com/power-platform/important-changes-coming) 

































