---
title: "Export, import, or remove a Dynamics 365 Customer Engagement app | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e82e7f64-37ad-41e5-acd7-16309881c6a2
ms.author: udag
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 9
topic-status: Drafting
---

# Export, import, or remove an app

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Apps are available as solution components in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Once you have created an app, you can make it available for other organization to use it by packaging the app into a solution and then exporting it into a zip file. Once the solution (.zip file) is successfully imported by the organization, the packaged app is available for use.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Solutions overview](../customize/solutions-overview.md).
  
## Export an app  
 Export an app into a solution when you want other organizations to use it. The process of exporting a solution includes:  

1. [Create a solution](../customize/create-solution.md).
2. [Add apps to the solution](../customize/import-update-export-solutions.md).
3. [Export solution to a zip file](../customize/import-update-export-solutions.md).

	> [!NOTE]
	> When you export an app using a solution, the app URL is not exported.

Now you can share the created solution zip file with other organization to import and use the apps.
  
## Import an app  
When you receive the solution zip file which contains the app that you want to import. Open the solutions component page and import the solution. On successful import, your organization is ready to use the app.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Import, update, and export solutions](../customize/import-update-export-solutions.md).  
  
## Remove (Delete) an app  
Remove app that are obsolete in your organization.

1. In your Dynamics 365 instance, go to **Settings** > **Customizations** > **Customize the system**.
2. On the solutions window, under **Components**, select **Apps**.
3. Select the app that you want to delete and from the command bar, choose **Delete**.

    ![Delete an app](media/app-module-solution-window.png "Delete an app")

4. A confirmation message displays. select **Delete**.

   The app is deleted from your organization.
  
If the component has dependencies such as relationships, you must remove the dependencies before you can delete the app. To see the dependencies of an app, select the app and then select **Show Dependencies** on the command bar.

> [!NOTE]
> When you delete the app, we recommend that you delete the associated sitemap. If you do not delete the associated sitemap, the sitemap designer displays an error the first time when you create another app with the same name. However, you may ignore the error and the error will not display on the subsequent attempts.<br />

### See also  
 [Design custom business apps by using the app designer](design-custom-business-apps-using-app-designer.md)
