---
title: "Connect LinkedIn to Dynamics 365 Connector for LinkedIn Lead Gen Forms | Microsoft Docs"
description: " Learn how to connect Dynamics 365 Connector for LinkedIn Lead Gen Forms with the LinkedIn service to sync lead gen data to Dynamics 365 (online)."
keywords: "LinkedIn Lead Gen Connector, connection, Dynamics 365, Customer Engagement"
ms.date: 03/13/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 4140669d-2155-4f43-a4fc-253b67e42f7d
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Establish a connection between [!include[Dynamics 365 Connector for LinkedIn Lead Gen Forms](../includes/cc-linkedin-solution.md)] and LinkedIn

[!include[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Before we can sync leads from [!include[LinkedIn](../includes/pn-linkedin.md)] campaign accounts to a [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)] organization, a [!include[LinkedIn](../includes/pn-linkedin.md)] member with access to [!include[LinkedIn](../includes/pn-linkedin.md)] Campaign Manager is required to authorize their [!include[LinkedIn](../includes/pn-linkedin.md)] accounts in [!include[Dynamics 365 (online)](../includes/pn-crm-online-shortest.md)]. In [!include[Dynamics 365 (online)](../includes/pn-crm-online-shortest.md)], this user requires at least a **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen Forms Connector Salesperson** security role.  
More information about assigning security roles to users: [TechNet: Create users and assign Microsoft Dynamics 365 (online) security roles](https://technet.microsoft.com/library/jj191623.aspx).

## Authorize [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)] to sync data from [!include[LinkedIn](../includes/pn-linkedin.md)] Campaign Manager

1. In [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)], go to **Sales** > **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen Forms** > **[!include[LinkedIn](../includes/pn-linkedin.md)] User Profile**.

2. To add a new [!include[LinkedIn](../includes/pn-linkedin.md)] user profile record, select **New**, enter a **Name**, and then select **Save**.

3. To add [!include[LinkedIn](../includes/pn-linkedin.md)] accounts to this user profile, select **Authorize**.

4. Enter the credentials for your [!include[LinkedIn](../includes/pn-linkedin.md)] profile, and then select **Sign In**.  
![Sign In](media/Add-credentials-to-linked-profile.png "Enter credentials for your LinkedIn profile")  

5. In the permissions dialog box, select **Allow**.  
![Allow permissions](media/LinkedIn-permission-popup-dialog.png "LinkedIn permissions dialog box")  

6. Check and confirm the [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)] organization you want to sync your LinkedIn data to.  
![LinkedIn permission popup dialogs](media/Confirm-dynamics-365-organization-to-sync-linkedin-data.png "Confirm the name of your Dynamics 365 organization")

After successful authorization, the [!include[LinkedIn](../includes/pn-linkedin.md)] accounts appear on the **[!include[LinkedIn](../includes/pn-linkedin.md)] User Profile** record. You can review the details of the [!include[LinkedIn](../includes/pn-linkedin.md)] accounts in the form. It might take a few seconds to get the accounts; try refreshing the view if you don’t see them.

[!include[LinkedIn](../includes/pn-linkedin.md)] form submissions are now synced automatically to [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)]. You’ll be able to see the data in [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)] as soon as the sync is complete, which might take a few minutes. 

![User profile in the LinkedIn Lead Gen Connector](media/LinkedIn-user-profile-information.png "User profile in the LinkedIn Lead Gen Connector")

## See the sync status for LinkedIn data

When you go to **Sales** > **LinkedIn Lead Gen** > **Sync Status**, you'll find an aggregated overview about the data that was pulled from all LinkedIn user profiles to Dynamics 365. At a glance, you can see when the most recent synchronization took place and find out how many leads were created or updated in total.

If you want synchronize the LinkedIn data retroactively after migrating to a to a newly created Dynamics 365 organization, you can trigger an optional, on-demand sync of all data from [!include[LinkedIn](../includes/pn-linkedin.md)] by selecting **Reset Synchronization**. This will pull all lead data from LinkedIn again. We don't recommend this action if you already have a working synchronization set up because the matching will fail for all leads that were matched earlier. Additionally, it can take a long time to complete as it's syncing all leads again and thus shouldn't be used frequently.  

### See also

[How to sync LinkedIn leads by using Dynamics 365 Connector for LinkedIn Lead Gen Forms](sync-linkedin-leads.md)  
[Install Dynamics 365 Connector for LinkedIn Lead Gen Forms from AppSource](install-linkedin-connector.md)