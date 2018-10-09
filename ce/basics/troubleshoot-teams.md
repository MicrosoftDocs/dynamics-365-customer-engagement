---
title: "Troubleshoot Teams integration| MicrosoftDocs"
ms.custom: ""
description: Troubleshoot Teams.
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

The following are error messages from Dynamics 365 Teams app and possible resolutions.

### Error: This record is not connected to Dynamics 365. Repin the tab and try again.
If retrying the connection doesn't work, try repinning the Dynamics 365 tab. To repin, delete the connection and then re-add:

1. In Microsoft Teams, select the channel with the error.
2. Select the Dynamics 365 tab with the error.
3. Select the down arrow next to the tab, and then select remove.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-remove-tab.png "Remove a Dynamics 365 tab")

4. Select the **Add** button (![Add button](media/plus-2.png "Add button")).

   ![Select Add button](media/teams-add-tab.png "Select Add button")

5. Continue through the steps as in [Use the team app](use-team-app.md).

### Error: Sorry, the org you selected is not up-to-date. Please select another org.
### Error: Sorry! Your Dynamics 365 org is not the latest version and is not supported for this feature. Please select a different org or contact your Dynamics 365 admin to do an update.
The Dynamics 365 (online) organization you are trying to connect does not support Microsoft Teams integration. You can contact support and request an update or pick a different org that has been updated to support Teams integration.

### Error: You cannot enable Microsoft Teams integration since the org is integrated with SharePoint on-premises.
You need to set up document management in Dynamics 365 (online) to use SharePoint Online. See: [Set up Dynamics 365 (online) to use SharePoint Online](https://docs.microsoft.com/dynamics365/customer-engagement/admin/set-up-dynamics-365-online-to-use-sharepoint-online).

### Error: File sharing is not set up. Go to [URL] to connect a Microsoft Teams channel to this record.
This record has not been connected to a Teams channel. Select the URL to go to the Dynamics 365 Teams app and pin the record to a channel as documented in: [Use the team app](use-team-app.md).

If document management has not been set up in Dynamics 369 (online), see: [Configure server-based authentication with Dynamics 365 (online) and SharePoint Online](https://docs.microsoft.com/dynamics365/customer-engagement/admin/configure-server-based-authentication-sharepoint-online).

### Error: You don't have permissions to view files in the selected location. Contact your Microsoft Teams owner or SharePoint administrator for access.
You need to be a member of the team to view files. Contact the Teams owner or your SharePoint admin and request to be added as a member.

### Error: Shared files exist in multiple locations. Select "Document Location" to see files in other locations.
The record has been pinned to multiple Teams channels. In Dynamics 365 (online), select **Document Location** to specify the location of the file.

> [!div class="mx-imgBorder"] 
> ![](media/teams-change-document-location.png "Change document location")

