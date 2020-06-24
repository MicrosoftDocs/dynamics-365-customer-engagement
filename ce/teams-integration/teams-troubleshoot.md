---
title: "Troubleshoot Microsoft Teams integration| MicrosoftDocs"
ms.custom: 
description: "Troubleshoot issues with Microsoft Teams integration."
ms.date: 6/22/20
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
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
# Troubleshoot Microsoft Teams integration 

The following are error messages with possible resolutions.


## Troubleshoot configuration issues with Microsoft Teams integration

Microsoft Teams integration uses SharePoint integration at the backend, so if there is a failure with SharePoint integration or OneDrive configuration, it will also fail when you enable Microsoft Teams integration.

If you get an error while configuring Microsoft Teams Integration from Dynamics 365, it might be because of the following pre-requisites are not met.

- SharePoint Integration is not configured, and OneDrive Integration is enabled. To Fix the issue, disable OneDrive.

- SharePoint Integration is not configured, but there is an active SharePoint site in your organization. To fix the issue, deactivate the SharePoint site.

- SharePoint Integration is not configured, but there is SharePoint document locations created with an absolute URL in your organization. To fix the issue, delete locations with an absolute URL.

- If SharePoint Online admin has enabled control access from unmanaged devices (conditional access policy) to allow/block SharePoint sites from unmanaged devices, then the same restrictions will be applied for Microsoft Teams integration because Microsoft Teams uses SharePoint sites for document management. This might block a user when they try to access a connected team channel file library on a model-driven app page. For more information, see [Control access from unmanaged devices](https://docs.microsoft.com/sharepoint/control-access-from-unmanaged-devices). 

- If you get this error: **You cannot enable Microsoft Teams integration since the environment is integrated with SharePoint on-premises**, this means that you are currently configured to use SharePoint on-premises for document management. You need to set up document management for model-driven apps in Dynamics 365 to use SharePoint Online. For more information, see [Set up model-driven apps in Dynamics 365 to use SharePoint Online](https://docs.microsoft.com/power-platform/admin/set-up-dynamics-365-online-to-use-sharepoint-online).

### Error when you pin a record or view of any model-driven app to a team channel if the enhanced experience is not configured correctly by your Common Data Service admin.

Error: **The admin has not consented to use user sync feature, you can add them manually**.

When you turn on enhanced Microsoft Teams Integration, there are two dialog boxes that you need to accept. On the second dialog box, when you don't check the **Consent on behalf of organization** check box, then users will get this error when they try to pin an entity record or view to Microsoft Teams and share the tab with another user.

   > [!div class="mx-imgBorder"] 
  > ![Microsoft Teams error](media/error1.png "Microsoft Teams error")

To fix the issue, disable the Enhanced Microsoft Teams integration feature.

1. Go to, [https://portal.azure.com](https://portal.azure.com).
2. Select **Azure Active Directory** > **Enterprise**.
3. In the list of apps go to, **Dynamics 365 Microsoft Teams collaboration integration**.
    > [!div class="mx-imgBorder"] 
    > ![Teams error](media/error2.png "Teams error")
4. Delete the app.
    > [!div class="mx-imgBorder"] 
    > ![Teams error](media/error3.png "Teams error")
5. Wait for about five minutes and then enable the [Enhanced Microsoft Teams Integration](teams-install-app.md) feature again. This time make sure that you to check the **Consent on behalf of organization** checkbox.

### Error when you pin a record or view of any model-driven app to a team channel if your user role permission is not configured correctly by your Common Data Service system admin.

Error: **User does not have permissions to create SharePoint Site or Document Location. This record is not connected to Dynamics 365**.

This means the user that is getting this error does not have sufficient permissions such as Create, Read, Write, Append, AppendTo and Delete for the user role to pin an entity to a Microsoft Teams channel; however, changes made to the record in Microsoft Teams will update in model-driven apps in Dynamics 365.

When the user tries to pin an entity to a Microsoft Teams channel, this error will display in the notification bar:

   > [!div class="mx-imgBorder"]
   > ![Microsoft Teams permission error](media/teams_permission_error.png "Microsoft Teams permission error")

To fix the issue, do the following:

1. In Microsoft Teams, select the channel with this error.
2. Select the tab with this error.
3. Select the down arrow next to the tab, then select **Remove**.
4. In your app, identify the Common Data Service role which is assigned to this user:
     1. Sign in as a admin to your Common Data service app.
     2. Navigate to **Settings** > **Security** > **Users**. 
     3. Find and select the user account that got the error message to open it.
     4. Select **Manage Roles**.
     5. Identify the security role assigned to this user.
     6. Select **Close**.
5. Navigate to **Settings** > **Security** > **Security Roles**.
6. Open the security role identified above.
7. Go to the **Core Records** tab.
8. Give Create, Read, Write, Append, AppendTo and Delete permissions to **SharePoint Site** and **Document Location**.
9. Select **Save and Close**.

Now, when the user tries to pin the Common Data Service entity to the required Microsoft Teams channel, it should work.

## Troubleshoot errors in Microsoft Teams

### Error: I can't find the Dynamics 365 app in the Microsoft Teams app store.

This happens when the external app for Microsoft Teams service is not enabled by your Office 365 admin. To fix the issue, do the following:

1. Sign in to [https://portal.office.com](https://portal.office.com).
2. From the list of apps, select **Admin**.

   > [!div class="mx-imgBorder"] 
   > ![Admin portal](media/ts1.png "Admin portal")
   
3. From the menu select **Settings** > **Services & add-ins**.

   > [!div class="mx-imgBorder"] 
   > ![Settings and add-ins](media/ts2.png "Settings and add-ins")
   
4. Find Microsoft Teams and then enable **External Apps**. 

   > [!div class="mx-imgBorder"] 
   > ![Find Microsoft Teams](media/ts3.png "Find Microsoft Teams")
   
5. Set **Allow external app in Microsoft Teams** to **On**.
   > [!div class="mx-imgBorder"] 
   > ![Enable external apps](media/ts4.png "Enable external apps")

6. Restart Microsoft Teams and then try seaching for **Dynamics 365** again in the Microsoft Teams app store.

### Error: Sorry, the environment you selected is not up-to-date or is not supported. Please select another environment.

> [!div class="mx-imgBorder"] 
> ![Environment is not up-to-date](media/teams-error-org-not-up-to-date.png "Environment is not up-to-date")

Or, you may get this error:

### Error: Sorry! Your Dynamics 365 environment is not the latest version and is not supported for this feature. Please select a different environment or contact your Dynamics 365 admin to do an update.

> [!div class="mx-imgBorder"] 
> ![Environment is not up-to-date](media/teams-error-org-not-latest.png "Environment is not up-to-date")

The Common Data Service environment that you are trying to connect does not support Microsoft Teams integration. You can wait for the environment to be updated or pick a different environment that has been updated to support Microsoft Teams integration.

### Error: This record is not connected to Dynamics 365. Repin the tab and try again.

A failed connection means file synchronization is not set up between Microsoft Teams and Dynamics 365 apps; however, changes made to the record in Microsoft Teams will update in the model-driven apps in Dynamics 365.

This is how the error will display on the notification bar:

> [!div class="mx-imgBorder"] 
> ![Connection to Dynamics 365 apps failed](media/teams-error-connection-failed.png "Connection to Dynamics 365 apps failed")

> [!IMPORTANT]
> When you first create a new team and channel in Microsoft Teams, you might see this error because it takes some time for Microsoft Teams to provision a new SharePoint file library for the channel. Wait a few minutes, and then refresh your browser to retry the connection.

Try repinning the Dynamics 365 tab. To repin, remove the tab, and then re-add, as follows:

1. In Microsoft Teams, select the channel with the error.
2. Select the Dynamics 365 tab with the error.
3. Select the down arrow next to the tab, and then select **Remove**.

   > [!div class="mx-imgBorder"] 
   > ![Remove a Dynamics 365 apps tab](media/teams-remove-tab.png "Remove a Dynamics 365 apps tab")

4. On the same channel, select the **Add** button (![Add button](media/plus-2.png "Add button")).

   > [!div class="mx-imgBorder"] 
   > ![Select Add button](media/teams-add-tab.png "Select Add button")

5. Continue through the steps as in [Collaborate with Microsoft Teams](teams-collaboration.md).


## Error messages in model-driven apps in Dynamics 365 


### Error: File sharing is not set up. Go to [URL] to connect a Microsoft Teams channel to this record.

> [!div class="mx-imgBorder"] 
> ![File sharing is not set up](media/teams-error-file-sharing.png "File sharing is not set up")

This record has not been connected to a Microsoft Teams channel. Select the URL to go to the Dynamics 365 Microsoft Teams app and pin the record to a channel as documented in [Collaborate with Microsoft Teams](teams-collaboration.md).


### Error: You don't have permissions to view files in this location. Contact your Microsoft Teams owner or SharePoint administrator for access.

> [!div class="mx-imgBorder"] 
> ![You don't have permissions to view files](media/teams-error-permissions.png "You don't have permissions to view files")

You need to be a member of the connected team channel to view files. Contact the owner of the connected team channel, and request to be added as a member. You need to determine the location of the document to which you need permission.

1. In your app, open the record with the permissions error message.
2. Select **Related** > **Documents**.  
  
   > [!div class="mx-imgBorder"] 
   > ![Select documents](media/teams-select-documents.png "Select documents")

3. Select **Document Location**. The first item in the list shows the team for which you need membership. Request access from the team channel owner.
  
   > [!div class="mx-imgBorder"] 
   > ![Select document location](media/teams-select-document-location.png "Select document location")

## Known issues

### Authentication issue in Teams when you have embedded apps within Dynamics 365

You may get an authentication failure when you open a pinned Dynamics 365 tab in Teams desktop client that has apps, such as PowerBI, LinkedIn Navigation widget, or KnowledgeBase Control enabled. 

To work around this issue, open Teams on the web and close the desktop version. 


### Error while creating a team or channel. The property is missing a required prefix/suffix per your organization's Group naming requirements. 

A user may get this error when they try to connect a record or a view to a team channel using the **Collaborate** button in model-driven apps in Dynamics 365. This happens if your tenant admin has configured group level naming policy from Azure Portal with a prefix and suffix condition 

   > [!div class="mx-imgBorder"] 
   > ![Prefix error](media/azure_portal_error.png "Prefix error")

To work around this issue, your tenant admin will need to remove this policy from Azure Portal.

### Error while creating a team or channel. The displayName cannot contain the blocked word 'blocked' as per company policy.

A user may get this error when they try to connect a record or a view to a team channel using the **Collaborate** button in model-driven apps in Dynamics 365. This happens when your tenant admin creates a custom blocked word list on Azure Portal.

To work around this issue, your tenant admin will need to remove this policy from Azure Portal.






