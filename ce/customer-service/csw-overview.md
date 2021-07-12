---
title: Overview of the Customer Service Workspace application for Dynamics 365 Customer Service | Microsoft Docs
description: Overview of the Customer Service Workspace application for Dynamics 365 Customer Service
ms.date: 07/01/2021
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Customer Service workspace

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Welcome to the Customer Service workspace app module, where we're increasing agent productivity for core customer service with the ability to work on multiple sessions at a time in a single workspace experience. If you choose to expand your customer service offering to provide chat and channels, the Customer Service workspace seamlessly adjusts to support managing conversations as well.

If you've used Customer Service Hub or Omnichannel for Customer Service before, much of the behavior for managing cases and activities in the Customer Service workspace app module works the same way, with some exceptions to accommodate the multisession and conversation capabilities. This article walks you through the Customer Service workspace experience and explains how to navigate the app.

Before we begin, a quick note about administration of Customer Service workspace: Currently, there isn't a dedicated administrator experience for Customer Service workspace. As such, configuring and managing core customer service capabilities, such as queues and routing rules, is done in the [Customer Service Hub](customer-service-hub-user-guide-basics.md) > Service Management experience. Channel configuration is done in [app profile manager](../app-profile-manager/overview.md). Because all of these apps are on [Microsoft Dataverse](/powerapps/maker/common-data-service/data-platform-intro), the data created through these experiences is accessible.

## Introduction to Customer Service workspace

You can access Customer Service workspace through the app selector (where you find all of your other Dynamics 365 apps) by choosing the Customer Service workspace app tile. You can also access the app in the Dynamics 365 drop-down navigation in the upper-left corner of Dynamics 365.

As an agent with the Customer Service Representative security role, when you open Customer Service workspace, you start on the Customer Service Agent Dashboard unless your administrator has changed the default view. This dashboard shows you your active cases, cases you can work in queues you are assigned to, and your open activities. You can open existing cases and activities or begin working new cases from the queues you are assigned to and create activities. 

The following table displays the elements of the Customer Service workspace.


| Label | Description|
| ------------ | ------------- |
| 1 | The session pane lists all the sessions that you are actively working on. Select the tabs to navigate among sessions.  |
| 2 | The Home session returns you to the Customer Service Agent Dashboard view.|
| 3 | Each session has a tab in the session panel. Select a tab to navigate to the session you want to work on. |
| 4 | Select a case to open a new session. A single click on a case replaces your view with the case form. Select the back arrow in the upper-left corner of the form to get back to your previous view.|
| 5 | Select the + icon to expand the menu to view a list of forms, views, and activities. Select the one you want to open in a new tab. |
| 6 | Select the tabs to navigate to your open activities, cases, forms and views. |
| 7 | Select the drop-down selector to filter cases in queues you can choose to work on. |
| 8 | Select Shift + mouse click to open a new session for an activity. A single click replaces your view with the activity form. Select the back arrow in the upper-left corner of the form to go back to your previous view. |
|||

## Navigate and view records

By default, you can use the following navigation options to open and view cases, accounts, and other details on the Customer Service Agent Dashboard:

- Select Shift while clicking to open a new session tab for the record you want to open. 
- Select the record to replace your view with the form for the record you opened. 
- Select the back arrow in the upper-left corner of the form to get back to your previous view. 
- Select Ctrl while clicking to open items on a new tab. 

However, an administrator can configure settings that allow for simpler navigation options that don't require you to use complex keyboard selections. The administrator can perform the steps in the following section to enable these settings. 

### Use simplified navigation

When an administrator enables simplified navigation, the navigation options will have the following characteristics.

- From the **Home** session, you can select a record in the following ways and open it as a new session (you'll see the records you opened on the left pane):

  - Select a record in a view to open the record in a new session.
  - Select a record in a dashboard to open the record in a new session.
  - Select a record from a queue to open the record in a new session.
  - Create a new record in a view&mdash;select **New** to open the entity form in a new session.

- When you use global search, you can:

  - Search records and open a list of all the retrieved records on a new tab. 
  - Search for and select a record from the Home session and open the record in a new session. 
  - Search for and select a record from an existing session and open the record on a new tab.

- In a session that's already open, you'll be able to use the following navigation to open records.

  - Select a related record from a form in a session to automatically open the record on a new tab within the same session.
  - Select a related record from the timeline to automatically open the record on a new tab within the same session.
  - Create a record from the timeline to automatically open the entity form on a new tab in the same session.
  - Select **New** to create a new record from a form to open the entity form in a new session.


- Selecting a record or session that's already open sets focus to the open session, instead of opening the session or record multiple times.

- Selecting Shift while clicking overrides the new, simplified navigation  and opens the record in a new session. Selecting Ctrl while clicking overrides the simplified navigation and opens the record on a new tab.

**To explore simplified navigation after it's configured**

1. Open Customer Service workspace.

2. On the Customer Service Agent Dashboard, perform the following actions:

   - Select a case. The case record opens on a session tab.
   - Select the customer in the case. The customer record opens on an application tab.
  


### Admin: Configure the simplified navigation experience

> [!IMPORTANT]
> You must have the System Administrator role to run this utility.

**To copy the code for the utility**

1. Sign in to Dynamics 365.

1. Select **F12** to open the developer tools.

1. Copy the following code, and paste it on the **Console** tab of the developer tools.

```
/**
* Utility to manage app settings
*/
class AppSettingUtility {
    static origin = Xrm.Utility.getGlobalContext().getClientUrl();
    static webApiUrl = `${this.origin}/api/data/v9.0/`;

    /**
     * Updates an app setting to the specified value
     * @param {*} setting the setting to update
     * @param {*} value value to set for the setting
     * @param {*} app (optional) if specified will update for individual app, if omitted then will update for all apps
     */
    static updateAppSetting(setting, value, app) {
        const data = {
            SettingName: setting,
            Value: value.toString(),
        };

        if (app !== undefined) {
            data.AppUniqueName = app;
        }

        // makes a call to SaveSettingValue to update an app setting
        console.log("Attempting update...");
        $.ajax({
            url: this.webApiUrl + "SaveSettingValue()",
            type: 'POST',
            contentType: 'application/json',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json; charset=utf-8',
                'OData-MaxVersion': '4.0',
                'OData-Version': '4.0',
            },
            data: JSON.stringify(data),
            success: function () {
                // update was successful
                console.log(`The app setting '${setting}' was successfully updated to '${value}' for '${app !== undefined ? app : 'all app modules'}'`);
            },
            error: function (error) {
                // update failed
                console.log("An error occurred while trying to update the app setting. Please try again.");
                console.log(error);
            }
        });
    }
}

/**
* App module utility class
*/
class AppModuleUtility {
    static app;

    /**
     * Updates an app setting for the individual app module
     * @param {string} setting the setting to update
     * @param {*} value value to set for the setting
     */
    static updateAppSetting(setting, value) {
        AppSettingUtility.updateAppSetting(setting, value, this.app);
    }

    /**
     * Updates the multisession navigation improvements setting
     * @param {boolean} value value to set for the setting
     */
    static setMultisessionNavigationImprovementsSetting(value = true) {
        const setting = "msdyn_MultisessionNavigationImprovements";
        this.updateAppSetting(setting, value);
    }
}

/**
* App module utility for Customer Service workspace app
*/
class CSWAppUtility extends AppModuleUtility {
    static app = "msdyn_customerserviceworkspace";
}

/**
* App module utility for Omnichannel for Customer Service app
*/
class OCAppUtility extends AppModuleUtility {
    static app = "OmniChannelEngagementHub"; 
}
   ```

**To turn on the simplified navigation settings**

- Run one of the following commands at the console window:

  - For Customer Service workspace:

   `CSWAppUtility.setMultisessionNavigationImprovementsSetting();` 

  - For Omnichannel for Customer Service:

   `OCAppUtility.setMultisessionNavigationImprovementsSetting();`

  - For both the multisession apps:

   `AppSettingUtility.updateAppSetting('msdyn_MultisessionNavigationImprovements', true);`

> [!NOTE]
> To turn off the navigation settings, run the command by using the `false` option.


### Work with cases

From the Customer Service Agent Dashboard in Customer Service workspace, you can perform the following actions.

|Label | Description|
|------------ | -------------|
| 1 | Select multiple cases to work with. Select the top check mark to select all cases, or select individual check boxes next to each case to select a specific group of cases.
| 2 | Associate child cases with selected cases. 
| 3 | Merge cases together. 
| 4 | Edit selected cases. 
| 5 | Delete selected cases. 
| 6 | Apply a routing rule to route cases to a queue. 
| 7 | Open the menu for additional actions including Assign, Add to Queue, Run Report, Email a Link, Share, Follow, or Unfollow cases.
|||


#### Edit case data

Let's explore the fields you can edit on the **Case Summary** tab:

| Label | Description |
| ------------ | ------------- |
| 1 | In Case Details, you can update the Case Title, Customer, Subject, Priority, Case Status, Product, and Description.
| 2 | These are attributes that are set when the case is created by the system including Case Number, Origin, and Created On Date that won't change. You can change the case owner here.
| 3 | Select the plus sign (+) on the timeline to expand the menu of timeline actions. 
|||

Let's explore the fields you can edit on the **Case Additional Details** tab:

| Label | Description |
| ------------ | ------------- |
| 1 | You can set Service Level Agreement (SLA) attributes on the case so that customer support managers can measure the overall success of the support organization against its goals of meeting customer Service Level Agreements.
| 2 | Associate a Parent Case, classify the Type of case, and apply a support Entitlement. 
| 3 | Sort and export the list of Associated Knowledge Articles.
| 4 | View and export the list of Similar Cases.
| 5 | View, add associations, and export Child Cases. 
| 6 | View and export the list of Merged Cases.
|||

### Work with activities

From the Customer Service Agent Dashboard in Customer Service workspace, you can:

| Label | Description|
------------ | -------------
| 1 | Select multiple activities to work with. Select the top check mark to choose all, or select individual check boxes next to each activity to select a specific group of activities.
| 2 | Edit selected activities. 
| 3 | Delete selected cases. 
| 4 | Open the menu for additional actions including Mark Complete, Cancel, Set Regarding, Assign, Email a Link, Add to Queue, Run Report. 
|||

### Create and search knowledge articles

From the Customer Service Agent Dashboard in Customer Service workspace, you can access knowledge search and knowledge articles:

|Label | Description|
|------------ | -------------|
| 1 | Select the plus sign (+) to expand the tab menu.|
| 2 | Select Knowledge Article or Knowledge Search. You can also create and manage knowledge articles in other ways. For more information, see [Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md).|
|||

Intelligent knowledge suggestions are displayed in the productivity pane while you are working on a case.

### Use email templates and signatures

From the Customer Service Agent Dashboard in Customer Service workspace, you can access email templates and signatures as follows:

1. Select the plus sign (+) to expand the tab menu.
2. Select Email Templates or Email Signatures.

### Productivity pane with Smart Assist

While you are working on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help agents better help customers. The productivity pane hosts Smart assist, which suggests related cases and knowledge articles that could be relevant to the current case, and agent scripts to guide agents through a consistent series of steps with potentially automated actions through macros. 

For more information, see [Productivity pane](csw-productivity-pane.md).

### See also

[Work with cases in Customer Service Hub](customer-service-hub-user-guide-create-a-case.md) <br>
[Work with activities in Customer Service Hub](customer-service-hub-user-guide-manage-timeline-activities.md) <br>
[Overview of the productivity pane](csw-productivity-pane.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
