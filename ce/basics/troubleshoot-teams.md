---
title: "Preview: Troubleshoot Teams| MicrosoftDocs"
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
# Preview: Troubleshoot Teams

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The following are error messages from Dynamics 365 Teams app and possible resolutions.

### Error: This record is not connected to Dynamics 365. Repin the tab and try again.

To repin, delete the connection and then re-add:

1. In Microsoft Teams, select the channel with the error.
2. Select the Dynamics 365 tab with the error.
3. Select the down arrow next to the tab, and then select remove.

   > [!div class="mx-imgBorder"] 
   > ![](media/teams-remove-tab.png "Remove a Dynamics 365 tab")

4. Select the **Add** button (![Add button](media/plus-2.png "Add button")).

   ![Select Add button](media/teams-add-tab.png "Select Add button")

5. Continue through the steps as in [Use the team app](use-team-app.md).

### Error: Sorry, the org you selected is not up-to-date. Please select another org.
The Dynamics 365 (online) organization you are trying to connect does not support Microsoft Teams integration. You can contact support and request an update or pick a different org that has been updated to support Teams integration.


### Error: Sorry! Your Dynamics 365 org is not the latest version and is not supported for this feature. Please select a different org or contact your Dynamics 365 admin to do an update.


### Error: You cannot enable Microsoft Teams integration since the org is integrated with SharePoint on-premises.


### Error: File sharing is not set up. Go to [URL] to connect a Microsoft Teams channel to this record.


### Error: You don't have permissions to view files in the selected location. Contact your Microsoft Teams owner or SharePoint administrator for access.


### Error: Shared files exist in multiple locations. Select "Document Location" to see files in other locations.




