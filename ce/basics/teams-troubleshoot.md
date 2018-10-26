---
title: "Troubleshoot Teams integration| MicrosoftDocs"
ms.custom: ""
description: "Troubleshoot issues with Teams integration."
ms.date: 10/30/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 17
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Troubleshoot Teams integration

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The following are error messages and possible resolutions.

## Error messages in the Teams app

### Error: This record is not connected to Dynamics 365. Repin the tab and try again.
A failed connection means file synchronization is not set up between Microsoft Teams and Dynamics 365 (online). However, changes made to the record in Teams will update in Dynamics 365 (online).

This is the connection error notification bar:

> [!div class="mx-imgBorder"] 
> ![](media/teams-error-connection-failed.png "Connection to Dynamics 365 (online) failed")

Try repinning the Dynamics 365 tab. To repin, remove the tab and then re-add:

1. In Microsoft Teams, select the channel with the error.
2. Select the Dynamics 365 tab with the error.
3. Select the down arrow next to the tab, and then select **Remove**.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-remove-tab.png "Remove a Dynamics 365 tab")

4. On the same channel, select the **Add** button (![Add button](media/plus-2.png "Add button")).

   ![Select Add button](media/teams-add-tab.png "Select Add button")

5. Continue through the steps as in [Use the team app](teams-collaboration.md).

### Error: Sorry, the org you selected is not up-to-date. Please select another org.
> [!div class="mx-imgBorder"] 
> ![](media/teams-error-org-not-up-to-date.png "Org is not up-to-date")

and

### Error: Sorry! Your Dynamics 365 org is not the latest version and is not supported for this feature. Please select a different org or contact your Dynamics 365 admin to do an update.
> [!div class="mx-imgBorder"] 
> ![](media/teams-error-org-not-latest.png "Org is not up-to-date")

The Dynamics 365 (online) organization you are trying to connect does not support Microsoft Teams integration. You can wait for the org to be updated or pick a different org that has been updated to support Teams integration.

## Error messages in Dynamics 365 (online)

### Error: You cannot enable Microsoft Teams integration since the org is integrated with SharePoint on-premises.
You are currently configured to use SharePoint on-premises for document management. You need to set up document management in Dynamics 365 (online) to use SharePoint Online. See: [Set up Dynamics 365 (online) to use SharePoint Online](https://docs.microsoft.com/dynamics365/customer-engagement/admin/set-up-dynamics-365-online-to-use-sharepoint-online).

### Error: You don't have permissions to view files in the selected location. Contact your Microsoft Teams owner or SharePoint administrator for access.
> [!div class="mx-imgBorder"] 
> ![](media/teams-error-permissions.png "You don't have permissions to view files")

You need to be a member of the connected channel team to view files. Contact the connected channel team owner and request to be added as a member. You need to determine the document location to which request membership.

1. In Dynamics 365 (online), open the record with the permissions error message.
2. Select **Related** > **Documents**.  
  
   > [!div class="mx-imgBorder"] 
   > ![](media/teams-select-documents.png "Select Documents")

3. Select **Document Location**. The first item in the list shows the team you need membership. Request access from the channel team owner.
  
   > [!div class="mx-imgBorder"] 
   > ![](media/teams-select-document-location.png "Select Document Location")

### Error: File sharing is not set up. Go to [URL] to connect a Microsoft Teams channel to this record.

> [!div class="mx-imgBorder"] 
> ![](media/teams-error-file-sharing.png "File sharing not set up")

This record has not been connected to a Teams channel. Select the URL to go to the Dynamics 365 Teams app and pin the record to a channel as documented in: [Use the team app](teams-collaboration.md).