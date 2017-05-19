---
title: "Connect Dynamics 365 and Social Engagement | MicrosoftDocs"
description: 
ms.custom: ""
ms.date: "2017-02-16"
ms.reviewer: ""
ms.service: "mse"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: "Social Engagement"
ms.assetid: f8acc707-064a-47e3-9392-85396b9dda2c
caps.latest.revision: 64
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Connect Dynamics 365 and Social Engagement
Learn how to set up the connection between [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] so you can link social posts to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Linking posts to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] lets you automatically create [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records from social posts that were found in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] by using the **Automatic Record Creation and Update Rules** feature in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
<a name="Prerequisites"></a>   
## Prerequisites to establish a connection with Dynamics 365  
 The following prerequisites apply to both [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] and [!INCLUDE[pn_dyn_365_op](../includes/pn-dyn-365-op.md)]. Prerequisites specific to [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] or [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)] are listed later in this topic.  
  
-   You have a license assigned for both [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)].  
  
-   You have a System Administrator security role in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
     Contact your system administrator if you need an upgrade to your licensed products or an update to your permissions. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find your CRM administrator or support person](http://go.microsoft.com/fwlink/p/?LinkID=513070), [CRM Help & Training: View your user profile](http://go.microsoft.com/fwlink/p/?LinkId=619557)  
  
-   You have an Administrator user role in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)].  
  
To find out your user role in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], go to **Settings** > **Personal Settings** > **Your Preferences**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](../social-engagement/user-roles.md)  
  
> [!TIP]
>  Your browser is likely to block any pop-ups opened by [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] when authenticating to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], or [!INCLUDE[tn_facebook](../includes/tn-facebook.md)]. Learn more about the recommended browser settings to manage authentication pop-ups: [Optimize browser settings for Social Engagement](../social-engagement/system-browser-settings.md)  
  
<a name="additionalPrerequisitesOnline"></a>   
### Additional prerequisites to connect with Dynamics 365 (online)  
  
-   Your organization’s [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] instance is upgraded to [!INCLUDE[pn_crm_online_2015_update_1](../includes/pn-crm-online-2015-update-1.md)] or a later release.  
  
-   Your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] instance is ready to receive social data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [TechNet: Control social data](http://go.microsoft.com/fwlink/p/?LinkId=723352)  
  
<a name="additionalPrerequisitesOnPremises"></a>   
### Additional prerequisites to connect with Dynamics 365 (on-premises) (IFD enabled)  
  
-   You have upgraded to at least [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)] (on-premises) and the deployment is IFD enabled.  
  
-   Your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] (on-premises) instance is an [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] with a public IP address. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [TechNet: Installing on-premises CRM 2016](http://go.microsoft.com/fwlink/p/?LinkId=723353), [TechNet: Configure IFD for Microsoft Dynamics CRM](http://go.microsoft.com/fwlink/p/?LinkId=723354)  
  
-   Follow [post-installation and configuration guidelines for Microsoft Dynamics CRM](http://go.microsoft.com/fwlink/p/?LinkID=723355) to enable OAuth support.  
  
-   Register your [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] solution so that it can connect to and authenticate with the Microsoft Dynamics 365 server, and access the web services. Each solution that you want to connect with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] (on-premises) (IFD enabled) should be registered as a RedirectUri. Use the following command to register the desktop client.  
  
     `Add-AdfsClient -Name MSE -ClientId e8ab36af-d4be-4833-a38b-4d6cf1cfd525 -RedirectUri @("https://listening-prod.dynamics.com/api/connect/version/1.0/solutions/<solution id>/crm/oauthRedirect ", "https://listening-prod.dynamics.com/api/connect/version/1.0/solutions/<solutionid>/crm/oauthRedirect") -Description "OAuth 2.0 client for MSE".`  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [TechNet: Walkthrough: Register a CRM app with Active Directory](http://go.microsoft.com/fwlink/p/?LinkId=723356)  
  
<a name="ConnectCRM"></a>   
## Establish a connection between Social Engagement and Dynamics 365  
To connect [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] and [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], both services must be part of the same organization’s [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] subscription. If you have licenses assigned to both [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], you will find both products in the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] app launcher. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Meet the Office 365 app launcher](http://go.microsoft.com/fwlink/p/?LinkID=401421)  
  
If you're a [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] administrator interested in exploring [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] services and how to integrate them with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] or to connect [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to other domains, see [Integrate Social Engagement with Office 365](../social-engagement/manage-licenses.md).  
  
<a name="connectToCRM"></a>   
#### Connect Social Engagement and Dynamics 365  
  
1.  In [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)], go to **Settings** > **Connections** > **Microsoft Dynamics 365**.  
  
2.  Click the **Add connection** button ![Add button](../social-engagement/media/add-icon.png "Add button").  
  
3.  Select the **Connection type** from the drop-down list.  
  
![Add connection drop&#45;down list in Social Engagement](../social-engagement/media/dynamics-365-connection-drop-down-menu.png "Add connection drop-down list in Social Engagement")  
  
4.  Provide the connection information for your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance.  
  
    1.  For [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], select **Dynamics 365 (online)** and then click **Check Instances**  to automatically discover all available [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instances from around the globe in your [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] tenant.  
  
 ![Add connection dialog box in Social Engagement](../social-engagement/media/add-connection-details-dialog-box.png "Add connection dialog box in Social Engagement")  
  
        1.  Select the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance you want to connect to from the list of discovered [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instances for the selected location. For more information about the discovery process, see [Discover the URL for your organization using the Web API](https://msdn.microsoft.com/library/mt607485.aspx).  
  
        2.  Based on the selected [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance, the value in the **Name** field changes. You can update the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] name if required.  
  
        > [!NOTE]
        >  If the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] discovery service endpoint is unresponsive, or results not returned, add the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance and name manually.  
  
    2.  For [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] (on-premises), select **Dynamics 365 (On-Premises)** and add the details of your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance and provide a unique name to the connection.  
  
 ![Add connection to Dynamics 365 &#40;on&#45;premises&#41;](../social-engagement/media/add-dynamics-365-connection.png "Add connection to Dynamics 365 (on-premises)")  
  
5.  Click **Next** ![Next button](../social-engagement/media/next-icon.png "Next button").  
  
6.  The **Dynamics 365 Instance** pane opens and shows you the details about the connected instance if the connection is successful.  
  
7.  You can set the **Set as default** control to ON to have this instance selected by default when creating new links to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records from social posts.  
  
8.  If you changed a value in the **Dynamics 365 Instance** pane, click **Save** ![Save button](../social-engagement/media/save-icon.png "Save button") to apply your changes.  
  
9. The connected [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance is now listed in the main pane when you go to **Settings** > **Connections** > **Microsoft Dymanics Dynamics 365**.  
  
## Next steps  
Now that you've connected [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], you can define entity details in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to specify information for the Social Activity entity that is created when you link a post to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage the connection between Dynamics 365 and Social Engagement](../social-engagement/manage-connection-dynamics-365-social-engagement.md)  
  
 When you are satisfied with the configuration of the entities, configure the Record Creation Rules in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to automatically create [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records from Social Activity entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 record from a social post](../social-engagement/create-dynamics-365-record-from-social-post.md)  
  
<a name="privacy"></a>   
### Privacy Notice  
[!INCLUDE[cc_privacy_mse_post_and_automation_rules](../includes/cc-privacy-mse-post-and-automation-rules.md)]  
  
### See Also  
 [](../social-engagement/link-posts-to-dynamics-365.md "Link posts from Social Engagement to Dynamics 365")   
 [](../social-engagement/create-dynamics-365-record-from-social-post.md "Create a Dynamics 365 record from a social post")   
 [](../social-engagement/manage-connection-dynamics-365-social-engagement.md "Manage the connection between Dynamics 365 and Social Engagement")   
 [](../social-engagement/administer-microsoft-social-engagement.md "Administer Microsoft Social Engagement")
[!INCLUDE[cc_copy_year_all_rights_reserved_md](../includes/cc-copy-year-all-rights-reserved.md)]
