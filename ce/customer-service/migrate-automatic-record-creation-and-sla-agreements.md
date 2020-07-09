---
title: Migrate Automatic Record Creation and Service Level Agreements (SLAs)
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

# Migrate Automatic Record Creation and Service Level Agreements (SLAs)

[Public Preview]

The Customer Service Hub app has several features and functionality that replace the items in the legacy Customer Service app. The rules for automatic record creation and Service Level Agreements (SLAs) are now supported by Power Automate based flows to make the transition to the new platform easier to manage.

The following topic provides an overview on the migration tool that allows legacy rules for automatic record creation and SLAs to be transferred to Customer Service Hub app for easier access.

Based on feedback, we have made a number of improvements to the migration tool. The tool is designed to provide a seamless experience from workflows to Power Automate based flows that are created for the existing legacy rules for automatic record creation and SLAs that provide Admin with the ability to plan your migration and:
- Choose which legacy rules need to be migrated with the ability to activate rules post migration.
- Decide when to switch to the new rule (legacy rules are not modified).
- Flexibility to decide when to activate new rules and deactivate the legacy rules so you are not forced to activate all or none. 
- Ability to run the migration tool multiple times and see what your status looks like at any point in time.
- Receive error insights with recommended resolution steps.

> [!NOTE]
> Legacy rules continue to run on existing cases until the rules are deactivated. 

## Prerequisites
- Customer Service Licensing
- Customer Service version 9.0.20034.20XX or higher environment
- Admin permissions

## Working with Tenets

Before accessing the migration tool, it is important to understand how the tool works with the tenets/rules first. When performing your migration, you will only receive detailed results on tenet/rules which have: 
- Failed (no create)
- Failed the pre-migration checkup step (incomplete) 
- Has not been previously migrated before 

> [!NOTE]
> You will not receive updates on rules that successfully completed migration, unless it is explicitly deleted in the Unified Customer Interface (UCI).

### Editing Rules

The migration tool will only rerun an edited rule which has been: 
- edited prior to the actual rule migration in the web client
- edited on migrated rules with errors and/or failed rules prior to rerunning migration in the web client

The following edits to a rule will not be considered if:
- the rule is edited on the web client after it was successfully migrated to UCI
- any edits were done to migrated rules in the UCI client after running the migration tool

## Accessing the Migration Tool

There are multiple ways an Admin can access the Migration Tool in the Customer Service Hub app. Starting from the left navigation pane, Admins can access the Migration Tool from the following locations: 

- **Option 1:** Under Data management, select Migration Tool.
- **Option 2:** Under Case Settings, select Automatic record creation. In yellow message bar, select migration tool.  
- **Option 3:** Under Service Terms, select Service-level agreement. In yellow message bar, select migration tool. 

> ![Access Migration Tool](media\migration-tool-access-location-1.png "Migration tool access locations")
> ![Access Migration Tool](media\migration-tool-access-location-2.png "Migration tool access locations")

> [!NOTE]
> Only Admins can view and use these options.

## Migration Process

The migration process is broken out into the following six steps:

- **Step 1: Category to migrate.**  Allows you to pick and choose which items you wish to migrate.
- **Step 2: Pre-migration checkup.** This enhancement to the migration process which provides insights into any potential migration failures you may incur prior to beginning your migration.    
- **Step 3: Rules and items to migrate.** Allows you to select which rules you want to migrate. 
- **Step 4: Review.** Provides you with the opportunity to go through any rules that have been identified as having errors or issues and fix these prior to migration.
- **Step 5: Migration.** Once migration is complete, you can review which rules successfully completed the migration process and which ones failed. 
- **Step 6: Finish.** Provides you with a summary / status page of rules which have successfully migrated, those that are pending, and failed migration.

## Using the Migration Tool 

Once you have successfully accessed the migration tool, choose from one of the two options based on your experience working with the tool: 

- **Option 1:** First time migration tool user. Follow the steps in this option if you are accessing and using the migration tool for the first time. 
- **Option 2:** Experienced migration tool user. Follow the steps in this option if you have accessed and used the Migration Tool in the past.

## Migration Tool for First time Users

The migration landing page shown below is what will display for first time users and provides the following: 
1.	View of both automatic record creation and service level agreements (SLAs).
2.	Total displays the number of legacy rules you have currently that can be migrated.
3.	Migrated displays the number items you have migrated.
4.	Pending displays the number of items you have pending migration.
5.	Migration status displays whether migration has started or not.
6.	Refresh allows you update migration status.
7.	Start allows you to being migration process.

> ![Migration Tool First Time User Overview](media\migration-tool-first-time-users-1.png "Migration Tool First Time User Overview")

Once you select **Start**, the migration tool will begin taking you through the migration process which consists of the following six steps: 

- **Step 1:** Category to migrate
- **Step 2:** Pre-migration checkup
- **Step 3:** Rules and items to migrate 
- **Step 4:** Review
- **Step 5:** Migration 
- **Step 6:** Finish

## Step 1: Category to migrate

The **Step 1** screen provides:

1.	A tracker will be displayed on the left, showing you where you are in the migration process at all times.
2.	Category options that allows you to select which items you want to migrate by clicking a box.  You can elect to migrate automatic record creations and SLAs separately, or migrate both at the same time. 
3.	You must select a category for migration before you can proceed.   

> ![Migration Tool for first time user - Step 1](media\migration-tool-step-1-first-time-users-1.png "Migration Tool for first time user - Step 1")

4.	Once you select the category you want to migrate it will be confirmed by a check mark.
5.	The **Next** button at the bottom will turn blue once you select a category. 

> ![Migration Tool for first time user - Step 1](media\migration-tool-step-1-first-time-users-2.png "Migration Tool for first time user - Step 1")

## Step 2: Pre-migration checkup

The **Step 2** screen is an enhancement to the migration process to mitigate potential migration failures before you begin.  The Pre-migration Checkup can be performed on the Automatic Record Creation or SLA rules separately or together.       

As a first time user, you will not have any insights until you complete the Pre-migration Checkup.  Once the Pre-migration Checkup review is complete, the following overview will be displayed showing:

1.	The number of rules which will successfully complete migration broken out by category.
2.	The number of rules which will fail if migrated broken out by category.
3.	To view which rules passed and which rules failed, select **Next** to continue to Step 3.

> ![Migration Tool for first time user - Step 2](media\migration-tool-step-2-first-time-users-1.png "Migration Tool for first time user - Step 2")

## Step 3: Rules and items to migrate

In **Step 3** the rules which successfully passed are automatically selected to move forward for migration.  However, you can control which rules you want to migrate by selecting/de-selecting any rules you want to migrate.  

Rules that fail can still be migrated, however the data will not migrate over completely. You even have the option to fix the error prior to migration or fix the rule in the Customer Service Hub app upon completing your migration.  If you want to migrate both pass and failed rules, use the **Migrate all rules** to override any selected rules to migrate everything.

In an effort to mitigate confusion, Step 3 of the migration process is broken out into two sub-sections that support:

- **Step 3.1:** Automatic record creation and update rules
- **Step 3.2:** Service-level agreements

### Step 3.1: Automatic record creation and update rules

Details covered in Step 3.1 are only related to Automatic Record Creation migration and will display the following:  

1.	The tracker displays which set of rules you are working on for migration to ensure clarity.
2.	Rules that pass are automatically selected for migration. You have control to uncheck these.
3.	Rules that fail are not selected for migration, however you can select rules that failed for migration, but please note that data on failed rules will not migrate completely.  To understand why a rule failed, you can click on the rule and view the details around the failure.  You can use the information to fix the failure prior to migration or after migration. See [View Details for Rule Failure](#view-details-for-rule-failure) for more details. 
4.	**Migrate all rules** provides you the ability to override any previously selected rules that have passed and failed and migrate everything.
5.	Allows you to **download all logs** which failed for review and troubleshooting purposes.  
6.	This alert notifies you that while you can migrate rules that failed the Pre-migration Checkup, the data on failed rules will not migrate completely and provides the option to **unselect rules** that failed.
7.	When you have selected / deselected all the rules you want to migrate, select **Next** to continue to Step 4.

> ![Migration Tool for first time user - Step 3.1](media\migration-tool-step-3-first-time-users-1.png "Migration Tool for first time user - Step 3.1")

## View Details for Rule Failure

When you click on a rule that failed the Pre-migration Checkup you have a choice of **Basic** and **Advance** views to better understand why a rule failed. You can use this information to either troubleshoot and fix the ruled that failed, or choose to migrate the rule and fix it in the Customer Service Hub after migration is complete.

### Basic View

The Basic view provides the following overview for each individual rule that failed, including:

1.	**Basic** provides high level details on rules that fail.
2.	**Pre-migration checkup** details provides the conditions that didn’t pass the checkup to better understand why a rule failed.

> ![Migration Tool for first time user - Basic detail screen for failed rules](media\migration-tool-step-3-basic-screen-first-time-users-1.png "Migration Tool for first time user - Basic detail screen for failed rules")

### Advanced View

The **Advanced** view provides the following overview on rules that failed, including:

1.	A deep dive into the details as to why a rule will fail migration. 
2.	A break down and detailed explanation why a rule failed which you can use to troubleshoot and resolve prior to migration.
3.	The ability to **download log** of failed rule for review and troubleshooting.  

> ![Migration Tool for first time user - Advanced detail screen for failed rules](media\migration-tool-step-3-advanced-screen-first-time-users-1.png "Migration Tool for first time user - Advanced detail screen for failed rules")

### Step 3.2: Service-level agreements

<Need screenshot for Step 3.2:SLA>

## Step 4: Review

Once you have selected the rules you want to migrate for Automatic Record Creation and/or Service Level Agreements a list will be displayed for your review.  This review section allows you to:  

1.	View a list of all the rules you have selected for migration. 
2.	Select **Back** to return to the previous step to make additional changes.
3.	Select **Start migration** to kick off migration.

> ![Migration Tool for first time user - Step 4](media\migration-tool-step-4-first-time-users-1.png "Migration Tool for first time user - Step 4")

## Step 5: Migration

Once you begin your migration, the following screen will appear that displays:

1.	The message that your migration is in progress.
2.	A blue **Next** button once migration is complete. 

> ![Migration Tool for first time user - Step 5](media\migration-tool-step-5-first-time-users-1.png "Migration Tool for first time user - Step 5")

Once migration is complete the following screen will appear that includes:

1.	**Selected** displays the total number of rules migrated
2.	**Migrated** displays the total number of rules that successfully completed migration process.
3.	**Incomplete** displays the total number of rules that encountered errors which did not complete the migration process successfully. See [Incomplete Migration Details](#incomplete-migration-details) for more information.
4.	**Migration Status** displays either green check mark ![green check mark](media\migration-tool-step-5-green-check-first-time-users-3.png "green check mark")  which represents rules successfully migrated or a red exclamation mark ![red exclamation mark](media\migration-tool-step-5-red-check-first-time-users-3.png "red exclamation mark")   which represents some or all rules did not successfully complete migration.
5.	**Refresh** allows you to update results.
6.	**Finish** completes the migration process when completed.

> ![Migration Tool for first time user - Step 5](media\migration-tool-step-5-first-time-users-2.png "Migration Tool for first time user - Step 5")

### Incomplete Migration Details

To view Automatic Record Creation and/or Service Level Agreement rules that did not successfully complete migration, you can click on **Incomplete** in the **Migration status** section and a list will be displayed of all the rules that did not pass, including:  

1.	**Name** displays each individual rule that failed.
2.	**Migration Status** displays whether rule successfully Migrated or was unsuccessful and therefore Incomplete.
3.	**Problem Details** displays why rule failed migration and provides a UCI and legacy rule ID. 
4.	**Download log** allows you to download and save a detailed copy of each rule that failed for review and troubleshooting.  

> ![Migration Tool for first time user - Step 5 Incomplete migration details](media\migration-tool-step-5-first-time-users-3.png "Migration Tool for first time user - Step 5 Incomplete migration details")

## Step 6: Finish

Now that you have completed your first run, and select **Finish**, a migration **Summary** page will appear:

1.	**Total** displays the number or rules.
2.	**Migrated** displays the number of rules that were successfully migrated.
3.	**Pending** displays the number of rules that were not successfully migrated.
4.	**Refresh** allows you to update your status view.
5.	**Activate** you new rules and items allows you activate migrated rules. See [Activate New Rules](#activate-new-rules) for more information. 

> ![Migration Tool for first time user - Step 6](media\migration-tool-step-6-first-time-users-1.png "Migration Tool for first time user - Step 6")

## Activate New Rules

When you activate new rules for either Automatic Record Creation or Service Level Agreement you are taken to the following screen that includes:

1.	**Rule name** displays listing of all your rules.
2.	**Migration status** displays whether the rule has not started migration, completed migration as identified as **Migrated**, or did not complete migration as indicated by **Incomplete**.

> ![Migration Tool for first time user - Step 6 Activate New Rules](media\migration-tool-step-6-first-time-users-2.png "Migration Tool for first time user - Step 6 Activate New Rules")

If you have any rules listed as **Incomplete** in the **Migration** status, they will need to be reviewed. When you click on the *Rule** name go to **Advanced** section to the **Migration detail** section:

1.	**Mark as complete** appears after migration in the **Migration details** section. Once you review the rule allows you to confirm the rule is good to go and run the rule through migration again in an attempt to complete the migration successfully. This serves as a confirmation that the Admin has reviewed this rule and it is ready to be migrated.    
2.	After moving **Mark as complete** to **Yes**, your rule **Migration status** will display as **Migrated**.

> ![Migration Tool for first time user - Step 6 Migration Status](media\migration-tool-step-6-first-time-users-3.png "Migration Tool for first time user - Step 6 Migration Status")

> [!NOTE]
> The same functionality is provided for SLA, only the Migration details are displayed under the Basic section since SLA does not have an Advanced section.  

## Migration Tool for Experienced Users

If you have already been through the migration process, your experience will be very similar to that of the first time user, with a few exceptions.   

1.	**Migration tool.** Access the migration tool as before under the Data management section.
2.	**Previous migration data.**  Since you have been through the migration process before, your Summary page will already have data displayed. 
3.	**Start.** To begin the migration process select Start to continue. 

> ![Migration Tool for experienced users](media\migration-tool-step-1-experienced-users-1.png "Migration Tool for experienced users")

## Step 1: Category to migrate.  (Experienced User)

This step allows you to pick and choose which items you wish to migrate.

## Step 2: Pre-migration checkup. (Experienced User)

When preparing to rerun the **Pre-migration checkup** process step it will only review the rules that did not pass before. You can download the details provided to troubleshoot errors and make updates in the Unified Interface or legacy system before you rerun your migration.

1.	**Yellow notification message** reminds you that rules that were successfully migrated previously will automatically be skipped in a rerun of the pre-migration checkup process.  This includes rules that were confirmed by the Admin as well.
2.	**Failed.** The pre-migration checkup process will only focus on running rules that have not been migrated, were not selected previously, or did not complete the migration process due to errors.

> ![Migration Tool for experienced users - step 2](media\migration-tool-step-2-experienced-users-1.png "Migration Tool for experienced users - step 2")

## Step 3: Rules and items to migrate. (Experienced User)

This step allows you to select which rules you want to migrate on the following screen, which includes:
 
1.	**Migrate all rules** allows you to override all previous selections.
2.	**Checkup Results** displays if your rule passed or failed migration.
3.	**Failed** rules can be reviewed by selecting the rule which failed to troubleshoot the issue.
4.	**Download all logs** to see each individual problem detail.

> ![Migration Tool for experienced users - step 3](media\migration-tool-step-3-experienced-users-1.png "Migration Tool for experienced users - step 3")

If you have a migrated rule that has failed you are unable to fix or do not want to repair, it can be deleted.  Also, if a rule has successfully passed the pre-migration checkup, but you want to run it again, you can delete in the Unified Interface them and run it again so it displays in the screen above so the rule can be rerun for validation.   

## Step 4: Review. (Experienced User)

This step provides you with the opportunity to go through any rules that have been identified as having errors or issues and fix these prior to migration.

## Step 5: Migration.  (Experienced User)

This step confirms when migration is complete and provides a summary of the number of rules that successfully completed migrations and number of rules that failed migration.

1.	Provides that migration results for the current migration run.
2.	Migration status allows you to view the details on the Incomplete rules that could not be migrated.

> ![Migration Tool for experienced users - step 5](media\migration-tool-step-5-experienced-users-1.png "Migration Tool for experienced users - step 5")

## Step 6: Finish (Experienced User)

When you finish you will receive an updated **Summary** page that includes:

1.	**Summary** provides the overall summary of all migration results to date.
2.	**Start** to rerun the migration process again.

> ![Migration Tool for experienced users - step 6](media\migration-tool-step-6-experienced-users-1.png "Migration Tool for experienced users - step 6")

Once migration is complete you can uninstall the migration tool.  After General Availability in October 2020 this feature will have auto-install functionality.

### See Also
[Plan your migration](https://docs.microsoft.com/en-us/dynamics365/customer-service/plan-migration)

[Important changes (deprecations) coming](https://docs.microsoft.com/en-us/power-platform/important-changes-coming) 
































