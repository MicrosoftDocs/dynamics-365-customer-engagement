---
title: Overview of the Customer Service Workspace application for Dynamics 365 Customer Service | Microsoft Docs
description: Overview of the Customer Service Workspace application for Dynamics 365 Customer Service
author: lalexms
ms.author: lalexms
manager: shujoshi
ms.date: 08/03/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
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

# Customer Service workspace - Overview

Welcome to the Customer Service workspace app module where we're increasing agent productivity for core customer service with the ability to work on multiple sessions at a time in a single workspace experience. And in the future should your business chose to expand your customer service offering to provide chat and channels, the Customer Service workspace seamlessly adjusts to support managing conversations as well (Early Release 09/01/2020). 

If you have used Customer Service Hub or Omnichannel for Customer Service before, much of the behavior for managing cases and activities in the Customer Service workspace app module works the same way with some exceptions to accomodate the multisession and conversation capabilities. In this article we will walk through the Customer Service workspace experience and explain how to navigate. 

Before we dive in, a quick note about administration of Customer Service workspace. There is not currently a dedicated Administrator experience for Customer Service workspace. As such, configuring and managing core customer service capabilities, such as queues and routing rules, is done in the Customer Service Hub -> Service Management experience. Chat and channel configuration is done in Omnichannel Administration. Because all of these apps are on the Common Data Service (CDS), the data created through these experiences is accessible. 

## Introduction to Customer Service workspace
You can access Customer Service workspace through the app selector where you find all of your other Dynamics 365 apps by choosing the Customer Service workspace app tile. You can also access the app in the Dynamics 365 dropdown navigation in the upper left corner of Dynamics 365.

:::image type="content" source="media/appSelectorAndNavigation.png" alt-text="Open Customer Service workspace" border="false":::

As an agent with the Customer Service Representative security role, when you open Customer Service workspace you start on the Customer Service Agent Dashboard unless your Administrator has changed the default view. This dashboard shows you your active cases, cases you can work in queues you are assigned to, and your open activities. You can open existing cases and activities or begin working new cases from the queues you are assigned to and create new activities. 

Let's explore the elements of the Customer Service workspace and how to navigate between them: 
1. The session pane lists all of the sessions you are actively working on. Click on the tabs to navigate between sessions. 
2. The Home session returns you to the Customer Service Agent Dashboard view. 
3. Each session has a tab in the session panel. Select a tab to navigate to the session you want to work on. 
4. Hold shift + click to open a new session for a case. A single click on a case replaces your view with the case form. Click the back arrow in the upper left corner of the form to get back to your previous view.
5. Choose the dropdown selector to filter cases in queues you can choose to work on. 
6. Click on the tabs to navigate to your open activities, cases, forms and views. 
7. Click the + icon to expand the menu to view a list of forms, views, and activities. Select the one you want to open in a new tab. 
8. Hold shift + click to open a new session for an activity. A single click replaces your view with the activity form. Click the back arrow in the upper left corner of the form to get back to your previous view.

:::image type="content" source="media/csw-overview.png" alt-text="Customer Service workspace overview" border="false":::

### Viewing and editing records

There are new navigation behaviors to be aware of in Customer Service workspace. All other basic model driven app functionality behaves the same way as in the Customer Service Hub and Omnichannel for Customer Service apps.

- Hold shift + click to open a new session tab for the record you want to open. 
- Clicking on the record replaces your view with the form for the record you opened. 
- Click the back arrow in the upper left corner of the form to get back to your previous view. 
- Hold CTRL + click to open items in a new tab. 

### Work with cases

From the Customer Service Agent Dashboard in Customer Service workspace, you can:

1. Select multiple cases to work with. Click the top check mark to select all or individual check boxes next to each case to select a specific group of cases.
2. Associate child cases with selected cases. 
3. Merge cases together. 
4. Edit selected cases. 
5. Delete selected cases. 
6. Apply a routing rule to route cases to a queue. 
7. Open the menu for additional actions including Assign, Add to Queue, Run Report, Email a Link, Share, Follow, or Unfollow cases. 

:::image type="content" source="media/bulkEditCases.png" alt-text="Customer Service workspace overview" border="false":::

### Work with activities

From the Customer Service Agent Dashboard in Customer Service workspace, you can:

1. Select multiple activities to work with. Click the top check mark to select all or individual check boxes next to each activity to select a specific group of activities.
2. Edit selected activities. 
3. Delete selected cases. 
4. Open the menu for aditional actions including Mark Complete, Cancel, Set Regarding, Assign, Email a Link, Add to Queue, Run Report. 

:::image type="content" source="media/bulkEditActivities.png" alt-text="Customer Service workspace overview" border="false":::


### See also  
[Work with cases](customer-service-hub-user-guide-create-a-case.md)    </br>
[Work with activities](customer-service-hub-user-guide-manage-timeline-activities.md)


