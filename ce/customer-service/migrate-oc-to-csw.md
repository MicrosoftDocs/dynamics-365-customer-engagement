---
title: "Omnichannel for Customer Service migration guide | MicrosoftDocs"
description: "Migration guide for Omnichannel for Dynamics 365 Customer Service to Customer Service workspace"
ms.date: 01/11/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.reviewer: nenellim
---

# Migrate Omnichannel for Customer Service to Customer Service workspace

With the planned deprecation of Omnichannel for Customer Service in June 2024, there may be customizations that you want to migrate to the Customer Service sorkspace app.  

This article contains configuration information for moving from the Omnichannel for Customer Service app to the Customer Service Workspace app. If you've configured Omnichannel for Customer Service using the Customer Service admin center, most of those configurations apply to both Omnichannel for Customer Service and Customer Service workspace. For some components, however, you'll need to make some customizations in Customer Service workspace to be able to use them.

The following table lists the missing components in Customer Service workspace that are present in Omnichannel for Customer Service.


|Category                   |Component missing in Customer Service workspace                            |
|---------------------------|----------------------------------------|
|Entities      |<li>Feeback</li> <li>Goal</li><li>Phone to Case process</li> <li>Social activity</li>|                    |
|Views         |<li>Views from the four missing entities</li> <li>Omnichannel for Customer Service has all of the views selected but Customer Service workspace only has selected views. Include all the views from Account, Case, and Contact entity in the Customer Service workspace app.</li>|
|Forms         |<li>Forms from the four missing entities</li><li>Account - Account for Interactive experience (default), TimelineWallControl - Case - Main </li><li> Case: Case for Interactive experience (default), TimelineWallControl - Case - Main</li><li>Contact - Contact for Interactive experience</li>|                       |
|Dashboards    |<li>Omnichannel Agent dashboard</li><li>Omnichannel Ongoing Conversations dashboard</li>| 
|Business Process Flow   |<li>Phone to Case process</li><li>Users</li>                          |
|Sitemap       |<li>Routing diagnostic</li> |

## Customize the Customer Service workspace app 

The following sections walk through the customizations for the Customer Service workspace app to help you migrate from Omnichannel for Customer Service.

### Add entities, forms, views, and chart in Customer Service workspace

1. Open [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Solutions** in the sitemap, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Open the Customer Service workspace app menu, and then select **Edit** to open the modern app designer.
1. Turn on the toggle for the following components:
   - **Entity**: Feedback, Goal, Phone to Case Process, Social Activity
   - **Form**: Account for Interactive experience, Case for Interactive experience, TimelineWallControl - Case - Main, Contact for Interactive experience
   - **View**
   All of the administrator and personalized views that are present in your Omnichannel for Customer Service app configuration will appear on in Customer Service workspace for the entity.
1. Complete the steps in [Add or remove forms, views, or charts](/power-apps/maker/model-driven-apps/create-add-remove-forms-views-dashboards)
1. Select **Publish**. This also saves the Customer Service workspace app if you've made other changes.
1. Select **Play** to run the Customer Service workspace app in a new browser tab.
1. To close the app designer and return to the solution, select **Back**.
