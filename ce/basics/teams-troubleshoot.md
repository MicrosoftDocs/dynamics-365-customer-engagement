---
title: "Troubleshoot Teams integration| MicrosoftDocs"
ms.custom: 
description: "Troubleshoot issues with Teams integration."
ms.date: 4/30/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 17
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Troubleshoot Teams integration 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The following are error messages with possible resolutions.

## Error messages in the Teams app


### Error: I can't find the Dynamics 365 app in the Teams app store.

This happens when the external app for Microsoft Teams service is not enabled by your Office 365 admin. To fix the issue, do the following:

1. Sign in to [http://portal.office.com](http://portal.office.com).
2. From the list of apps, select **Admin**.

   > [!div class="mx-imgBorder"] 
   > ![Admin portal](media/ts1.png "Admin portal")
   
3. From the menu select **Settings** > **Services & add-ins**.

   > [!div class="mx-imgBorder"] 
   > ![Setting and add-insl](media/ts2.png "Setting and add-ins")
   
4. Find Microsoft Teams and then enable **External Apps**. 

   > [!div class="mx-imgBorder"] 
   > ![Find Microsoft Teams](media/ts3.png "Find Microsoft Teams")
   
5.  Set **Allow external app in Microsoft Teams** to **On**.
   > [!div class="mx-imgBorder"] 
   > ![Enable external apps](media/ts4.png "Enable external apps")
   
6. Restart Microsoft Teams and then try seaching for **Dynamics 365** again in the Teams app store.

### Error: This record is not connected to Dynamics 365. Repin the tab and try again.
A failed connection means file synchronization is not set up between Microsoft Teams and Dynamics 365 for Customer Engagement apps. However, changes made to the record in Teams will update in Dynamics 365 for Customer Engagement apps.

This is the connection error notification bar:

> [!div class="mx-imgBorder"] 
> ![Connection to Dynamics 365 for Customer Engagement appsfailed](media/teams-error-connection-failed.png "Connection to Dynamics 365 for Customer Engagement apps failed")

> [!IMPORTANT]
> When you first create a new team and channel in Microsoft Teams, you might see this error because it takes some time to make the SharePoint file library connection. Wait a few minutes and then refresh your browser to retry the connection.

Try repinning the Dynamics 365 tab. To repin, remove the tab and then re-add, as follows:

1. In Microsoft Teams, select the channel with the error.
2. Select the Dynamics 365 tab with the error.
3. Select the down arrow next to the tab, and then select **Remove**.

   > [!div class="mx-imgBorder"] 
   > ![Remove a Dynamics 365 for Customer Engagement apps tab](media/teams-remove-tab.png "Remove a Dynamics 365 for Customer Engagement apps tab")

4. On the same channel, select the **Add** button (![Add button](media/plus-2.png "Add button")).

   > [!div class="mx-imgBorder"] 
   > ![Select Add button](media/teams-add-tab.png "Select Add button")

5. Continue through the steps as in [Collaborate with Teams](teams-collaboration.md).

### Error: Sorry, the environment you selected is not up-to-date or is not supported. Please select another environment.

> [!div class="mx-imgBorder"] 
> ![environment is not up to date](media/teams-error-org-not-up-to-date.png "environment is not up to date")

and

### Error: Sorry! Your Dynamics 365 environment is not the latest version and is not supported for this feature. Please select a different environment or contact your Dynamics 365 admin to do an update.

> [!div class="mx-imgBorder"] 
> ![environment is not up to date](media/teams-error-org-not-latest.png "environment is not up to date")

The Dynamics 365 for Customer Engagement apps environment that you are trying to connect does not support Microsoft Teams integration. You can wait for the environment to be updated or pick a different environment that has been updated to support Teams integration.

## Error messages in Dynamics 365 for Customer Engagement apps 

### Error: You cannot enable Microsoft Teams integration since the environment is integrated with SharePoint on-premises.
You are currently configured to use SharePoint on-premises for document management. You need to set up document management in Dynamics 365 for Customer Engagement apps to use SharePoint Online. See [Set up Dynamics 365 for Customer Engagement apps to use SharePoint Online](https://docs.microsoft.com/dynamics365/customer-engagement/admin/set-up-dynamics-365-online-to-use-sharepoint-online).

### Error: You don't have permissions to view files in this location. Contact your Microsoft Teams owner or SharePoint administrator for access.

> [!div class="mx-imgBorder"] 
> ![You don't have permissions to view files](media/teams-error-permissions.png "You don't have permissions to view files")

You need to be a member of the connected channel team to view files. Contact the connected channel team owner and request to be added as a member. You need to determine the document location for which to request membership.

1. In Dynamics 365 for Customer Engagement apps, open the record with the permissions error message.
2. Select **Related** > **Documents**.  
  
   > [!div class="mx-imgBorder"] 
   > ![Select Documents](media/teams-select-documents.png "Select Documents")

3. Select **Document Location**. The first item in the list shows the team for which you need membership. Request access from the channel team owner.
  
   > [!div class="mx-imgBorder"] 
   > ![Select Document Location](media/teams-select-document-location.png "Select Document Location")

### Error: File sharing is not set up. Go to [URL] to connect a Microsoft Teams channel to this record.

> [!div class="mx-imgBorder"] 
> ![File sharing not set up](media/teams-error-file-sharing.png "File sharing not set up")

This record has not been connected to a Teams channel. Select the URL to go to the Dynamics 365 Teams app and pin the record to a channel as documented in [Collaborate with Teams](teams-collaboration.md).



